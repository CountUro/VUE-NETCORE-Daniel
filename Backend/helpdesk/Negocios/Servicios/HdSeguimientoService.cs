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
    public interface IHdSeguimientoService
    {
        Task<bool> Existe(int id);
        Task<IEnumerable<HdSeguimientoVM>> GetAllVM(int IdHdoc);
        Task<IEnumerable<HdSeguimiento>> GetAll(int IdHdoc);
        Task<HdSeguimientoVM> GetVM(int id);
        Task<HdSeguimiento> Get(int id);
        Task<Boolean> Delete(int id);
        Task<HdSeguimiento> Update(HdSeguimientoUpdateVM model);
        Task<HdSeguimiento> Add(HdSeguimientoCreateVM model);
    }

    public class HdSeguimientoService : IHdSeguimientoService
    {
        // Base de datos
        private readonly DbContextHd _context;

        // Constructor
        public HdSeguimientoService(DbContextHd context)
        {
            _context = context;
        }

        //----------------------------------------------------------------------

        public async Task<HdSeguimiento> Add(HdSeguimientoCreateVM model)
        {
            HdSeguimiento agregar = new HdSeguimiento
            {
                observaciones = model.observaciones,
                f_crea = DateTime.Now,
                hd_doc_id = model.hd_doc_id,
                usuario_id = model.usuario_id,
                status_175_id = model.status_175_id,
            };

            _context.HdSeguimientos.Add(agregar);
            await _context.SaveChangesAsync();

            return agregar;
        }

        //----------------------------------------------------------------------

        public async Task<bool> Delete(int id)
        {
            var borrar = await _context.HdSeguimientos.FindAsync(id);
            if (borrar == null)
            {
                return false;
            }

            _context.HdSeguimientos.Remove(borrar);
            await _context.SaveChangesAsync();

            return true;
        }

        //----------------------------------------------------------------------

        public async Task<bool> Existe(int id)
        {
            var existe = await _context.HdSeguimientos.FindAsync(id);
            return (existe != null) ? true : false;
        }

        //----------------------------------------------------------------------

        public async Task<HdSeguimiento> Get(int id)
        {
            var traer = await _context.HdSeguimientos.FindAsync(id);
            if (traer == null)
            {
                throw new Exception("Registro no encontrado");
            }

            return traer;
        }

        //----------------------------------------------------------------------

        public async Task<IEnumerable<HdSeguimiento>> GetAll(int IdHdoc)
        {
            var todos = await _context.HdSeguimientos
                                    .Where(w => w.hd_doc_id == IdHdoc)
                                    .ToListAsync();

            return todos;
        }

        //----------------------------------------------------------------------

        public async Task<IEnumerable<HdSeguimientoVM>> GetAllVM(int IdHdoc)
        {
            var todosVm = await _context.HdSeguimientos
                .Include(a=>a.usuario)
                .Include(b=>b.status175)
                .Include(c=>c.hdDoc)
                .Where(x=> x.hd_doc_id == IdHdoc)
                .OrderBy(o=>o.f_crea)
                .Select(s => new HdSeguimientoVM
            {
                hd_seguimiento_id = s.hd_seguimiento_id,
                hd_doc_id = s.hd_doc_id,
                hddoc = s.hdDoc.numero,
                usuario_id = s.usuario_id,
                usuario = s.usuario.nombre,
                status_175_id = s.status_175_id, // El include hace falta cuando este ya tiene foreign key?
                status175 = s.status175.descripcion,
                observaciones = s.observaciones,
                f_crea = s.f_crea,
                
            }).ToListAsync();

            return todosVm;
        }

        //----------------------------------------------------------------------

        public async Task<HdSeguimientoVM> GetVM(int id)
        {
            var s = await _context.HdSeguimientos
                .Include(a => a.usuario)
                .Include(b => b.status175)
                .Include(c => c.hdDoc)
                .Where(x => x.hd_doc_id == id)
                .FirstOrDefaultAsync(f => f.hd_seguimiento_id == id);

            HdSeguimientoVM modelo = new HdSeguimientoVM
            {
                hd_seguimiento_id = s.hd_seguimiento_id,
                hd_doc_id = s.hd_doc_id,
                hddoc = s.hdDoc.numero,
                usuario_id = s.usuario_id,
                usuario = s.usuario.nombre,
                status_175_id = s.status_175_id, // El include hace falta cuando este ya tiene foreign key?
                status175 = s.status175.descripcion,
                observaciones = s.observaciones,
                f_crea = s.f_crea,
            };

            return modelo;
        }

        //----------------------------------------------------------------------

        public async Task<HdSeguimiento> Update(HdSeguimientoUpdateVM model)
        {
            var actualizar = await _context.HdSeguimientos.FindAsync(model.hd_seguimiento_id);
            if (actualizar == null)
            {
                throw new Exception("Registro no encontrado");
            }

            actualizar.observaciones = model.observaciones;
            actualizar.status_175_id = model.status_175_id;

            _context.HdSeguimientos.Update(actualizar);
            await _context.SaveChangesAsync();

            return actualizar;
        }

        //----------------------------------------------------------------------

    }
}
