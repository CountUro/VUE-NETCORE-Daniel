using Datos.Contexto;
using Entidades.Modelo;
using Entidades.ViewModels;
using Microsoft.EntityFrameworkCore;
using Negocios.Extensiones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios.Servicios
{
    public interface ISucursalService
    {
        Task<bool> Existe(int id);
        Task<IEnumerable<SucursalVM>> GetAllVM(int IdCia);
        Task<IEnumerable<Sucursal>> GetAll(int IdCia);
        Task<SucursalVM> GetVM(int id);
        Task<Sucursal> Get(int id);
        Task<Boolean> Delete(int id);
        Task<SucursalVM> Update(SucursalUpdateVM model);
        Task<SucursalVM> Add(SucursalCreaVM model);
        Task<IEnumerable<SelectVM2>> Select2(int Cia);
        Task<IEnumerable<SelectVM>> Select(int Cia);

    }
    public class SucursalService : ISucursalService
    {
        // Base de datos
        private readonly DbContextHd _context;

        // Constructor
        public SucursalService(DbContextHd context)
        {
            _context = context;
        }

        //----------------------------------------------------------------------

        public async Task<SucursalVM> Add(SucursalCreaVM model)
        {
            var agregar = await _context.Sucursales.FirstOrDefaultAsync(f =>
                                f.nombre == model.nombre &&
                                f.cia_id == model.cia_id 
                                );

            if (agregar != null)
            {
                throw new Exception("La sucursal ya existe");
            }

            Sucursal sucursal = new Sucursal
            {
                nombre = model.nombre,
                cia_id = model.cia_id,
                pais_id = model.pais_id,
                estado_id = model.estado_id,
                municipio_id = (model.municipio_id.HasValue)?model.municipio_id:null,
                ciudad_id = model.ciudad_id,
            };

            _context.Sucursales.Add(sucursal);
            await _context.SaveChangesAsync();

            SucursalVM sucursalVm = await GetSucursalVM(sucursal.sucursal_id);

            return sucursalVm;
        }

        //----------------------------------------------------------------------

        public async Task<bool> Delete(int id)
        {
            if (id < 1)
            {
                throw new Exception("La ID insertada no es valida");
            }
            var borrar = await _context.Sucursales.FindAsync(id);
            if (borrar == null)
            {
                throw new Exception("No se ha podido borrar el registro");
                return false;
            }

            _context.Sucursales.Remove(borrar);
            await _context.SaveChangesAsync();

            return true;
        }

        //----------------------------------------------------------------------

        public async Task<bool> Existe(int id)
        {
            var existe = await _context.Sucursales.FindAsync(id);
            return (existe != null) ? true : false;
        }

        //----------------------------------------------------------------------

        public async Task<Sucursal> Get(int id)
        {
            var tomar = await _context.Sucursales.FindAsync(id);
            if (tomar == null)
            {
                throw new Exception("Registro no encontrado");
            }

            return tomar;
        }

        //----------------------------------------------------------------------

        public async Task<IEnumerable<Sucursal>> GetAll(int IdCia)
        {
            var todos = await _context.Sucursales
                .Where(w => w.cia_id == IdCia)
                .OrderBy(o=>o.nombre)
                .ToListAsync();

            return todos;
        }

        //----------------------------------------------------------------------

        public async Task<IEnumerable<SucursalVM>> GetAllVM(int IdCia)
        {
            var todos = await _context.Sucursales
                .Where(w => w.cia_id == IdCia)
                .Include(i => i.municipio)
                .Include(i => i.ciudad)
                .Include(t => t.estado)
                .Include(t => t.pais)
                .Select(s => new SucursalVM
                {
                    sucursal_id = s.sucursal_id,

                    nombre = s.nombre,

                    cia_id = s.cia_id,
                    cia = s.cia.nombre,

                    pais_id = s.pais_id,
                    pais = s.pais.nombre,

                    estado_id = s.estado_id,
                    estado = s.estado.nombre,

                    ciudad_id = s.ciudad.ciudad_id,
                    ciudad = s.ciudad.nombre,

                    municipio_id = s.municipio_id,
                    municipio = s.municipio.nombre
                })
                .OrderBy(t=>t.nombre)
                .ToListAsync();

            return todos;
        }

        //----------------------------------------------------------------------

        public async Task<SucursalVM> GetVM(int id)
        {
            
            SucursalVM regresar = await GetSucursalVM(id);
            if (regresar == null)
            {
                throw new Exception("Registro no encontrado");
            }
            return regresar;
        }

        //----------------------------------------------------------------------

        public async Task<IEnumerable<SelectVM>> Select(int Cia)
        {
            var vms = await _context.Sucursales
                .Where(w => w.cia_id == Cia)
                .Select(s => new SelectVM
                {
                    value = s.sucursal_id,
                    text = s.nombre

                }).ToListAsync();

            return vms;
        }

        //----------------------------------------------------------------------

        public async Task<IEnumerable<SelectVM2>> Select2(int Cia)
        {
            var vms = await _context.Sucursales
                .Where(w => w.cia_id == Cia)
                .Select(s => new SelectVM2
                {
                    value = s.sucursal_id.ToString(),
                    label = s.nombre

                }).ToListAsync();

            return vms;
        }

        //----------------------------------------------------------------------

        public async Task<SucursalVM> Update(SucursalUpdateVM model)
        {
            var actualizar = await _context.Sucursales.FindAsync(model.sucursal_id);
            if (actualizar == null)
            {
                throw new Exception("Registro no encontrado");
            }

            actualizar.nombre = model.nombre;
            actualizar.cia_id = model.cia_id;
            actualizar.pais_id = model.pais_id;
            actualizar.estado_id = model.estado_id;
            actualizar.municipio_id = (int)model.municipio_id;
            actualizar.ciudad_id = model.ciudad_id;

            _context.Sucursales.Update(actualizar);
            await _context.SaveChangesAsync();

            SucursalVM regresar = await GetSucursalVM(actualizar.sucursal_id);

            return regresar;
        }

        //----------------------------------------------------------------------
        //----------------------------------------------------------------------
        //----------------------------------------------------------------------

        private async Task<SucursalVM> GetSucursalVM(int id)
        {
            var sucursal = await _context.Sucursales
                .Include(i => i.municipio)
                .Include(i => i.ciudad)
                .Include(t => t.estado)
                .Include(t => t.pais)
                .FirstOrDefaultAsync(x => x.sucursal_id == id);

            if (sucursal == null)
            {
                throw new Exception("No existe la sucursal");
            }

            SucursalVM sucursalVm = new SucursalVM
            {
                sucursal_id = sucursal.sucursal_id,

                nombre = sucursal.nombre,

                cia_id = sucursal.cia_id,
                cia = sucursal.cia.nombre,

                pais_id = sucursal.pais_id,
                pais = sucursal.pais.nombre,

                estado_id = sucursal.estado_id,
                estado = sucursal.estado.nombre,

                ciudad_id = sucursal.ciudad.ciudad_id,
                ciudad = sucursal.ciudad.nombre,

                municipio_id = sucursal.municipio_id,
                municipio = sucursal.municipio.nombre
            };

            return sucursalVm;
        }
        //----------------------------------------------------------------------

    }
}
