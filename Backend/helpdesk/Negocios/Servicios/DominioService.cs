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
    public interface IDominioService
    {
        Task<bool> Existe(int id);

        Task<IEnumerable<Dominio>> GetAll();
        Task<Dominio> Get(int id);
        Task<Boolean> Delete(int id);
        Task<Dominio> Update(Dominio model);
        Task<Dominio> Add(Dominio model);
        Task AgregarDom(List<Dominio> lista, int id, string descripcion);
        Task<bool> SalvarLista(List<Dominio> lista);
    }

    public class DominioService : IDominioService
    {
        // Base de datos
        private readonly DbContextHd _context;

        // Constructor
        public DominioService(DbContextHd context)
        {
            _context = context;
        }

        //----------------------------------------------------------------------

        public async Task<Dominio> Add(Dominio model)
        {
            var buscar = await _context.Dominios.FirstOrDefaultAsync(f => f.descripcion == model.descripcion);
            if (buscar == null)
            {
                throw new Exception("Este dominio ya existe");
            }

            _context.Dominios.Add(model);
            await _context.SaveChangesAsync();

            return model; 
        }

        //----------------------------------------------------------------------

        public async Task AgregarDom(List<Dominio> lista, int id, string descripcion)
        {
            bool existe = await Existe(id);
            if (existe)
            {
                return;
            }

            Dominio dom = new Dominio
            {
                dominio_id = id,
                descripcion = descripcion
            };

            lista.Add(dom);

            return;
        }

        //----------------------------------------------------------------------

        public async Task<bool> Delete(int id)
        {
            if (id < 1)
            {
                throw new Exception("La ID insertada es invalida");
            }
            var borrar = await _context.Dominios.FindAsync(id);
            if (borrar == null)
            {
                throw new Exception("No se ha podido borrar el registro");
                return false;
            }

            _context.Dominios.Remove(borrar);
            await _context.SaveChangesAsync();

            return true;
        }

        //----------------------------------------------------------------------

        public async Task<bool> Existe(int id)
        {
            var existe = await _context.Dominios.FindAsync(id);
            return (existe != null) ? true : false;
        }

        //----------------------------------------------------------------------

        public async Task<Dominio> Get(int id)
        {
            var traer = await _context.Dominios.FindAsync(id);
            if (traer == null)
            {
                throw new Exception("Registro no encontrado");
            }

            return traer;
        }

        //----------------------------------------------------------------------

        public async Task<IEnumerable<Dominio>> GetAll()
        {
            var todos = await _context.Dominios.ToListAsync();

            return todos;
        }

        //----------------------------------------------------------------------

        public async Task<bool> SalvarLista(List<Dominio> lista)
        {
            _context.Dominios.AddRange(lista);
            await _context.SaveChangesAsync();

            // como return cuando falle?
            // return false

            return true;
        }

        //----------------------------------------------------------------------

        public async Task<Dominio> Update(Dominio model)
        {
            var dominio = await _context.Dominios.FirstOrDefaultAsync(x => x.dominio_id == model.dominio_id);
            if (dominio == null)
            {
                return null;
            }

            if (dominio.descripcion != model.descripcion.Left(100))
            {
                var reg = await _context.Dominios.FirstOrDefaultAsync(x => x.dominio_id != model.dominio_id && x.descripcion == model.descripcion);
                if (reg != null)
                {
                    throw new Exception("El nombre del dominio existe con otro Id");
                }
            }

            dominio.descripcion = model.descripcion.Left(100);

            await _context.SaveChangesAsync();
            return dominio;
        }

        //----------------------------------------------------------------------

    }
}
