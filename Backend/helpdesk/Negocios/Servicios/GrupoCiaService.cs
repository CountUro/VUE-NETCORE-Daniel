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
    public interface IGrupoCiaService
    {
        Task<bool> Existe(int id);
        Task<IEnumerable<GrupoCia>> GetAll();
        Task<GrupoCia> Get(int id);
        Task<IEnumerable<SelectVM>> Select();
        Task<IEnumerable<SelectVM2>> Select2();
        Task<Boolean> Delete(int id);
        Task<GrupoCia> Update(GrupoCia model);
        Task<GrupoCia> Add(GrupoCia model);

    }

    public class GrupoCiaService : IGrupoCiaService
    {
        // Base de datos
        private readonly DbContextHd _context;

        // Constructor
        public GrupoCiaService(DbContextHd context)
        {
            _context = context;
        }

        //----------------------------------------------------------------------

        public async Task<GrupoCia> Add(GrupoCia model)
        {
            var buscar = await _context.GrupoCias.FirstOrDefaultAsync(f => f.nombre == model.nombre);
            if (buscar != null)
            {
                throw new Exception("El nombre de este grupo de compañias ya existe");
            }

            _context.GrupoCias.Add(model);
            await _context.SaveChangesAsync();

            return model;
        }

        //----------------------------------------------------------------------

        public async Task<bool> Delete(int id)
        {
            if (id < 1)
            {
                throw new Exception("ID insertada incorrecta.");
            }

            var encontrar = await _context.GrupoCias.FindAsync(id);
            if (encontrar == null)
            {
                throw new Exception("No se ha eliminado el registro");
                return false;
            }

            _context.GrupoCias.Remove(encontrar);
            await _context.SaveChangesAsync();

            return true;
        }

        //----------------------------------------------------------------------

        public async Task<bool> Existe(int id)
        {
            var encontrar = await _context.GrupoCias.FindAsync(id);
            return (encontrar != null) ? true : false;
        }

        //----------------------------------------------------------------------

        public async Task<GrupoCia> Get(int id)
        {
            var traer = await _context.GrupoCias.FindAsync(id);
            if (traer == null)
            {
                throw new Exception("El registro no se ha encontrado");
            }

            return traer;
        }

        //----------------------------------------------------------------------

        public async Task<IEnumerable<GrupoCia>> GetAll()
        {
            var todos = await _context.GrupoCias.ToListAsync();

            return todos;
        }

        //----------------------------------------------------------------------

        public async Task<IEnumerable<SelectVM>> Select()
        {
            var modelos = await _context.GrupoCias
                .OrderBy(o=>o.nombre)
                .Select(s => new SelectVM
                {
                    value = s.grupo_cia_id,
                    text = s.nombre
                })
                .ToListAsync();

            return modelos;
        }

        //----------------------------------------------------------------------

        public async Task<IEnumerable<SelectVM2>> Select2()
        {
            var modelos = await _context.GrupoCias
                .OrderBy(o => o.nombre)
                .Select(s => new SelectVM2
                {
                    value = s.grupo_cia_id.ToString(),
                    label = s.nombre
                })
                .ToListAsync();

            return modelos;
        }

        //----------------------------------------------------------------------

        public async Task<GrupoCia> Update(GrupoCia model)
        {
            var actualizar = await _context.GrupoCias.FindAsync(model.grupo_cia_id);
            if (actualizar == null)
            {
                throw new Exception("El registro no se ha encontrado");
            }

            actualizar.nombre = model.nombre;
            _context.GrupoCias.Update(actualizar);
            await _context.SaveChangesAsync();

            return actualizar;
        }

        //----------------------------------------------------------------------

    }
}
