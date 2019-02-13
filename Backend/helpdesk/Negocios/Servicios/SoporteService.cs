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
    public interface ISoporteService
    {
        Task<bool> Existe(int id);
        Task<IEnumerable<Soporte>> GetAll();
        Task<Soporte> Get(int id);
        Task<Boolean> Delete(int id);
        Task<Soporte> Update(Soporte model);
        Task<Soporte> Add(SoporteCreaVM model);
        Task<IEnumerable<SelectVM>> Select();
        Task<IEnumerable<SelectVM2>> Select2();

    }

    public class SoporteService : ISoporteService
    {
        // Base de datos
        private readonly DbContextHd _context;

        // Constructor
        public SoporteService(DbContextHd context)
        {
            _context = context;
        }

        //----------------------------------------------------------------------

        public async Task<Soporte> Add(SoporteCreaVM model)
        {
            var buscar = await _context.Soportes
            .FirstOrDefaultAsync(w =>
            w.nombre == model.nombre);

            if (buscar != null)
            {
                throw new Exception("Este soporte ya existe");
            }

            Soporte soporte = new Soporte { nombre = model.nombre };

            _context.Soportes.Add(soporte);
            await _context.SaveChangesAsync();

           

            return soporte;
        }

        //----------------------------------------------------------------------

        public async Task<bool> Delete(int id)
        {
            if (id < 1)
            {
                throw new Exception("La ID insertada es incorrecta.");
            }

            var borrar = await _context.Soportes.FindAsync(id);
            if (borrar == null)
            {
                throw new Exception("No eliminó el registro");
                return false;
            }

            _context.Soportes.Remove(borrar);
            await _context.SaveChangesAsync();

            return true;
        }

        //----------------------------------------------------------------------

        public async Task<bool> Existe(int id)
        {

            var encontrar = await _context.Soportes.FindAsync(id);
            return (encontrar == null) ? false : true;
           
        }

        //----------------------------------------------------------------------

        public async Task<Soporte> Get(int id)
        {
            var trae = await _context.Soportes.FindAsync(id);
            return trae;
        }

        //----------------------------------------------------------------------

        public async Task<IEnumerable<Soporte>> GetAll()
        {
            var todos = await _context.Soportes
                .OrderBy(o=>o.nombre)
                .ToListAsync();
            return todos;
        }

        //----------------------------------------------------------------------

        public async Task<IEnumerable<SelectVM>> Select()
        {
            var modelos = await _context.Soportes.OrderBy(o => o.nombre).Select(s => new SelectVM
            {
                value = s.soporte_id,
                text = s.nombre

            }).ToListAsync();

            return modelos;
        }

        //----------------------------------------------------------------------

        public async Task<IEnumerable<SelectVM2>> Select2()
        {
            var modelos = await _context.Soportes
                .OrderBy(o => o.nombre)
                .Select(s => new SelectVM2
            {
                value = s.soporte_id.ToString(),
                label = s.nombre

            }).ToListAsync();

            return modelos;
        }

        //----------------------------------------------------------------------

        public async Task<Soporte> Update(Soporte model)
        {
            var actualizar = await _context.Soportes.FindAsync(model.soporte_id);
            if (actualizar == null)
            {
                throw new Exception("Registro no encontrado");
            }

            actualizar.nombre = model.nombre;

            _context.Soportes.Update(actualizar);
            await _context.SaveChangesAsync();

            return actualizar;
        }

        //----------------------------------------------------------------------

    }
}
