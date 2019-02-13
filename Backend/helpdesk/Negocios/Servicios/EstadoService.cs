using Datos.Contexto;
using Entidades.Modelo;
using Entidades.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Negocios.Extensiones;

namespace Negocios.Servicios
{
    public interface IEstadoService
    {
        Task<bool> Existe(int id);
        Task<IEnumerable<EstadoVM>> GetAllVM(int IdPais);
        Task<IEnumerable<Estado>> GetAll(int IdPais);
        Task<EstadoVM> GetVM(int id);
        Task<Estado> Get(int id);
        Task<IEnumerable<SelectVM>> Select(int IdPais);
        Task<IEnumerable<SelectVM2>> Select2(int IdPais);
        //Task<IEnumerable<SelectVMLabel>> SelectLabel(int IdPais);
        Task<Boolean> Delete(int id);
        Task<Estado> Update(EstadoUpdateVM model);
        Task<Estado> Add(EstadoCreaVM model);
        Task<bool> ActivarDesactivar(int id, bool activar);
        Task<Estado> AgregaEstado(int paisId, string nombre, string codigo, bool activo);
    }

    public class EstadoService : IEstadoService
    {
        // Base de datos
        private readonly DbContextHd _context;

        // Constructor
        public EstadoService(DbContextHd context)
        {
            _context = context;
        }

        public async Task<bool> ActivarDesactivar(int id, bool activar)
        {
            var modelo = await _context.Estados.FindAsync(id);
            if (modelo == null)
            {
                throw new Exception("No actualizó el status del estado");
                return false;
            }

            modelo.activo = activar;
            _context.Estados.Update(modelo);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<Estado> Add(EstadoCreaVM model)
        {
            Estado estado = new Estado
            {
                nombre = model.nombre,
                pais_id = model.pais_id,
                codigo = model.codigo,
                activo = true
            };

            _context.Estados.Add(estado);
            await _context.SaveChangesAsync();

            return estado;
        }

        public async Task<Estado> AgregaEstado(int paisId, string nombre, string codigo, bool activo)
        {
            var regreso = await _context.Estados
                .FirstOrDefaultAsync(x => x.pais_id == paisId && x.nombre == nombre);
            if (regreso != null)
            {
                return regreso;
                //throw new Exception("El registro ya existe.");
            }

            Estado estado = new Estado
            {
                nombre = nombre,
                pais_id = paisId,
                codigo = codigo,
                activo = true,
            };

            _context.Estados.Add(estado);
            await _context.SaveChangesAsync();

            return estado;
        }

        public async Task<bool> Delete(int id)
        {
            if (id < 1)
            {
                throw new Exception("No pasó el id de la ciudad");
            }

            var modelo = await _context.Estados.FindAsync(id);
            
            if (modelo == null)
            {
                throw new Exception("No se ha eliminado el registro");
                return false;
            }

            _context.Estados.Remove(modelo);
            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<bool> Existe(int id)
        {
            var modelo = await _context.Estados.FindAsync(id);
            return (modelo == null) ? false : true;
            //if (modelo == null)
            //{
            //    return false;
            //}

            //return true;
        }

        public async Task<Estado> Get(int id)
        {
            var modelo = await _context.Estados.FindAsync(id);
            
            return modelo;
        }

        public async Task<IEnumerable<Estado>> GetAll(int IdPais)
        {
            var modelos = await _context.Estados
                .Where(x => x.pais_id == IdPais)
                .ToListAsync();

            return modelos;
        }

        public async Task<IEnumerable<EstadoVM>> GetAllVM(int IdPais)
        {
            var modelos = await _context.Estados
                .Include(y => y.pais)
                .Where(x => x.pais_id == IdPais)
                .OrderBy(o => o.nombre)
                .Select(s => new EstadoVM
                {
                    estado_id = s.estado_id,
                    nombre = s.nombre,
                    pais_id = s.pais_id,
                    pais = s.pais.nombre,
                    codigo = s.codigo,
                    activo = s.activo
                })
                .ToListAsync();

            return modelos;
        }

        public async Task<EstadoVM> GetVM(int id)
        {
            var modelo = await _context.Estados
                .Include(x => x.pais)
                .FirstOrDefaultAsync(y => y.estado_id == id);

            if (modelo == null)
            {
                throw new Exception("Registro no encontrado");
            }

            EstadoVM estadovm = new EstadoVM
            {
                estado_id = modelo.estado_id,
                nombre = modelo.nombre,
                pais_id = modelo.pais_id,
                pais = modelo.pais.nombre,
                codigo = modelo.codigo,
                activo = modelo.activo
            };

            return estadovm;
        }

        public async Task<IEnumerable<SelectVM>> Select(int IdPais)
        {
            var modelos = await _context.Estados
                .Where(w => w.pais_id == IdPais)
                .Select(s => new SelectVM
                {
                    value = s.estado_id,
                    text = s.nombre
                }).OrderBy(o => o.text)
                .ToListAsync();

            return modelos;
        }

        public async Task<IEnumerable<SelectVM2>> Select2(int IdPais)
        {
            var modelos = await _context.Estados
                .Where(w => w.pais_id == IdPais)
                .Select(s => new SelectVM2
                {
                    value = s.estado_id.ToString(),
                    label = s.nombre
                }).OrderBy(o => o.label)
                .ToListAsync();

            return modelos;
        }

        public async Task<Estado> Update(EstadoUpdateVM model)
        {
            if (model.estado_id < 1)
            {
                throw new Exception("La ID insertada es incorrecta.");
            }

            var modelo = await _context.Estados.FindAsync(model.estado_id);

            modelo.nombre = model.nombre;
            modelo.codigo = model.codigo;

            _context.Estados.Update(modelo);
            await _context.SaveChangesAsync();
            return modelo;
        }
    }
}
