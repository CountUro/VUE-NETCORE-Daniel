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
    public interface ICiudadService
    {
        Task<bool> Existe(int id);
        Task<IEnumerable<CiudadVM>> GetAllVM(int IdEstado);
        Task<IEnumerable<Ciudad>> GetAll(int IdEstado);
        Task<CiudadVM> GetVM(int id);
        Task<Ciudad> Get(int id);
        Task<Boolean> Delete(int id);
        Task<Ciudad> Update(CiudadUpdateVM model);
        Task<Ciudad> Add(CiudadCreaVM model);
        Task<bool> ActivarDesactivar(int id, bool activar);
        Task<IEnumerable<SelectVM>> Select(int estado);
        Task<IEnumerable<SelectVM2>> Select2(int estado);
        Ciudad CheckPropiedades(Ciudad data);
        Task SalvarLista(List<Ciudad> lista);
        Task AgregaCiudad(List<Ciudad> lista, int estadoid, string nombre, string codigo, bool activo);
    }

    public class CiudadService : ICiudadService
    {
        // Base de datos
        private readonly DbContextHd _context;

        // Constructor
        public CiudadService(DbContextHd context)
        {
            _context = context;
        }

        public async Task<bool> ActivarDesactivar(int id, bool activar)
        {
            var modelo = await _context.Ciudades.FindAsync(id);
            if (modelo == null)
            {
                throw new Exception("No actualizó el status de la ciudad");
                return false;
            }

            modelo.activo = activar;

            _context.Ciudades.Update(modelo);
            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<Ciudad> Add(CiudadCreaVM model)
        {
            Ciudad ciudad = new Ciudad
            {
                nombre = model.nombre,
                codigo = model.codigo,
                estado_id = model.estado_id,
                activo = true
            };

            ciudad = CheckPropiedades(ciudad);

            _context.Ciudades.Add(ciudad);
            await _context.SaveChangesAsync();

            return ciudad;
        }

        public async Task AgregaCiudad(List<Ciudad> lista, int estadoid, string nombre, string codigo, bool activo)
        {
            string nombreLow = nombre.Trim().ToLower();

            bool existeenlalista = ExisteEnLaLista(lista, estadoid, nombre);
            if (existeenlalista)
            {
                return;
            }

            var ciudadSearch = await _context.Ciudades.FirstOrDefaultAsync(m => m.estado_id == estadoid && m.nombre.ToLower() == nombreLow);

            if (ciudadSearch != null)
            {
                return;
            }

            Ciudad ciudad = new Ciudad
            {
                estado_id = estadoid,
                nombre = nombre.Trim(),
                codigo = codigo,
                activo = activo
            };

            Ciudad datosOk = CheckPropiedades(ciudad);

            lista.Add(datosOk);

            return;
        }

        private bool ExisteEnLaLista(List<Ciudad> lista, int estado_id, string nombre)
        {

            bool existe = false;

            foreach (var ciudad in lista)
            {
                if (ciudad.estado_id == estado_id && ciudad.nombre == nombre)
                {
                    existe = true;
                    break;
                };
            }
            return existe;

        }

        public Ciudad CheckPropiedades(Ciudad data)
        {
            data.nombre = data.nombre.Left(150);
            data.codigo = data.codigo.Left(6);
            return data;
        }

        public async Task<bool> Delete(int id)
        {
            if (id < 1)
            {
                throw new Exception("La ID insertada es incorrecta.");
            }

            var modelo = await _context.Ciudades.FindAsync(id);
            if (modelo == null)
            {
                throw new Exception("No Eliminó el registro");
                return false;
            }

            _context.Ciudades.Remove(modelo);
            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<bool> Existe(int id)
        {
            var modelo = await _context.Ciudades.FindAsync(id);
            bool regreso = (modelo == null) ? false : true;

            return regreso;
        }

        public async Task<Ciudad> Get(int id)
        {
            var modelo = await _context.Ciudades.FindAsync(id);
            return modelo;
        }

        public async Task<IEnumerable<Ciudad>> GetAll(int IdEstado)
        {
            var modelos = await _context.Ciudades.Where(x => x.estado_id == IdEstado).ToListAsync();

            return modelos;
        }

        public async Task<IEnumerable<CiudadVM>> GetAllVM(int IdEstado)
        {
            var modelos = await _context.Ciudades
                .Include(a => a.estado).ThenInclude(b => b.pais)
                .Where(x => x.estado_id == IdEstado)
                .Select(c => new CiudadVM
                {
                    ciudad_id = c.ciudad_id,
                    nombre = c.nombre,
                    codigo = c.codigo,
                    activo = c.activo,
                    estado_id = c.estado_id,
                    estado = c.estado.nombre,
                    pais_id = c.estado.pais_id,
                    pais = c.estado.pais.nombre
                })
                .ToListAsync();

            return modelos;
        }

        public async Task<CiudadVM> GetVM(int id)
        {
            var modelo = await _context.Ciudades
                .Include(a => a.estado).ThenInclude(b => b.pais)
                .FirstOrDefaultAsync(x => x.ciudad_id == id);
            if (modelo == null)
            {
                throw new Exception("Registro no encontrado");
            }

            CiudadVM ciudadvm = new CiudadVM
            {
                ciudad_id = modelo.ciudad_id,
                nombre = modelo.nombre,
                codigo = modelo.codigo,
                activo = modelo.activo,
                estado_id = modelo.estado_id,
                estado = modelo.estado.nombre,
                pais_id = modelo.estado.pais_id,
                pais = modelo.estado.pais.nombre
            };

            return ciudadvm;
        }

        public async Task SalvarLista(List<Ciudad> lista)
        {
            if (lista.Count > 0)
            {
                await _context.Ciudades.AddRangeAsync(lista);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<SelectVM>> Select(int estado)
        {
            var modelos = await _context.Ciudades.Where(x => x.estado_id == estado)
                .Select(s => new SelectVM
                {
                    value = s.ciudad_id,
                    text = s.nombre

                }).ToListAsync();

            return modelos;
        }

        public async Task<IEnumerable<SelectVM2>> Select2(int estado)
        {
            var modelos = await _context.Ciudades.Where(x => x.estado_id == estado)
                .Select(s => new SelectVM2
                {
                    value = s.ciudad_id.ToString(),
                    label = s.nombre

                }).ToListAsync();

            return modelos;
        }

        public async Task<Ciudad> Update(CiudadUpdateVM model)
        {
            if (model.ciudad_id < 1)
            {
                throw new Exception("La ID insertada es incorrecta.");
            }

            var modelo = await _context.Ciudades.FindAsync(model.ciudad_id);
            if (model == null)
            {
                throw new Exception("Registro no encontrado");
            }

            modelo.nombre = model.nombre;
            modelo.codigo = model.codigo;

            _context.Ciudades.Update(modelo);
            await _context.SaveChangesAsync();

            return modelo;
        }
    }
}
