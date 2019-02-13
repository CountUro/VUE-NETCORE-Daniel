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
using System.Transactions;

namespace Negocios.Servicios
{
    public interface IHdArchivoService
    {
        Task<bool> Existe(int id);
        Task<IEnumerable<HdArchivoVM>> GetAll(int IdHdoc);
        Task<HdArchivoVM> Get(int id);
        Task<IEnumerable<SelectVM>> Select(int IdHdoc);
        Task<IEnumerable<SelectVM2>> Select2(int IdHdoc);
        Task<Boolean> Delete(int id);
        Task<HdArchivoVM> Update(HdArchivoUpdateVM model);
        Task<HdArchivoVM> Add(HdArchivoCreateVM model);

    }
    public class HdArchivoService : IHdArchivoService
    {
        // ---------------------------------------------------------

        private readonly DbContextHd _context;

        public HdArchivoService(DbContextHd context)
        {
            _context = context;
        }

        // ---------------------------------------------------------

        public async Task<HdArchivoVM> Add(HdArchivoCreateVM model)
        {
            try
            {


                HdArchivo hdarchivo = new HdArchivo
                {
                    hd_doc_id = model.hd_doc_id,
                    descripcion = model.descripcion.Left(150),
                    nombrefile = model.nombrefile.Left(250),
                    f_crea = DateTime.Now,
                    usuario_id = model.usuario_id
                };

                await _context.HdArchivos.AddAsync(hdarchivo);
                await _context.SaveChangesAsync();

                var regreso = await Get(hdarchivo.hd_archivo_id);
                return regreso;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        // ---------------------------------------------------------

        public async Task<bool> Delete(int id)
        {
            if (id < 1)
            {
                throw new Exception("La ID insertada no es valida");
            }

            using (var scope = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
            {
                var registro = await Get(id);

                string nombreFile = registro.nombrefile;
                BorraFile(nombreFile);

                //await Delete(id);

                var reg = await _context.HdArchivos.FindAsync(id);
                if (reg == null)
                {
                    throw new Exception("El registro no pudo borrarse");
                    return false;
                }

                _context.HdArchivos.Remove(reg);

                await _context.SaveChangesAsync();

                scope.Complete();

                return true;
            }
        }

        private bool BorraFile(string filename)
        {
            var path = System.IO.Path.Combine(System.IO.Directory.GetCurrentDirectory(), "wwwroot/imagenes", filename);

            System.IO.File.Delete(path);

            return true;

            // when False?
        }

        // ---------------------------------------------------------

        public async Task<bool> Existe(int id)
        {
            try
            {
                var reg = await _context.HdArchivos.FirstOrDefaultAsync(x => x.hd_archivo_id == id);
                bool regreso = (reg == null) ? false : true;
                return regreso;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // ---------------------------------------------------------

        public async Task<HdArchivoVM> Get(int id)
        {
            if (id < 1)
            {
                throw new Exception("La ID insertada no es valida");
            }
            var reg = await _context.HdArchivos
                                .Include(a => a.hdDoc)
                                .Include(b => b.usuario)
                                .FirstOrDefaultAsync(x => x.hd_archivo_id == id);

            HdArchivoVM regreso = new HdArchivoVM
            {
                hd_archivo_id = reg.hd_archivo_id,
                hd_doc_id = reg.hd_doc_id,
                Numero = reg.hdDoc.numero,
                descripcion = reg.descripcion,
                nombrefile = reg.nombrefile,
                f_crea = reg.f_crea,
                usuario_id = reg.usuario_id,
                usuario = reg.usuario.nombre
            };

            if (regreso == null)
            {
                throw new Exception("No existe el registro del archivo");
            }

            return regreso;

        }

        // ---------------------------------------------------------

        public async Task<IEnumerable<HdArchivoVM>> GetAll(int IdHdoc)
        {
            try
            {
                var registros = await _context.HdArchivos
                                        .Include(a => a.hdDoc)
                                        .Include(b => b.usuario)
                                        .Where(x => (IdHdoc == 0) ||
                                              (IdHdoc != 0 && x.hd_doc_id == IdHdoc))
                                         .Select(s => new HdArchivoVM
                                         {
                                             hd_archivo_id = s.hd_archivo_id,
                                             hd_doc_id = s.hd_doc_id,
                                             Numero = s.hdDoc.numero,
                                             descripcion = s.descripcion,
                                             nombrefile = s.nombrefile,
                                             f_crea = s.f_crea,
                                             usuario_id = s.usuario_id,
                                             usuario = s.usuario.nombre
                                         }
                                         )
                                        .ToListAsync();

                return registros;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // ---------------------------------------------------------

        public async Task<IEnumerable<SelectVM>> Select(int IdHdoc)
        {
            try
            {
                var registros = await _context.HdArchivos
                         .Where(x => (IdHdoc != 0 && x.hd_doc_id == IdHdoc))
                         .Select(s => new SelectVM
                         {
                             value = s.hd_archivo_id,
                             text = s.descripcion
                         })
                         .ToListAsync();

                return registros;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // ---------------------------------------------------------

        public async Task<IEnumerable<SelectVM2>> Select2(int IdHdoc)
        {

            var registros = await _context.HdArchivos
                        .Where(x => (IdHdoc != 0 && x.hd_doc_id == IdHdoc))
                        .Select(s => new SelectVM2
                        {
                            value = s.hd_archivo_id.ToString(),
                            label = s.descripcion
                        })
                        .ToListAsync();

            return registros;


        }

        // ---------------------------------------------------------

        public async Task<HdArchivoVM> Update(HdArchivoUpdateVM model)
        {
            try
            {
                var reg = await _context.HdArchivos.FirstOrDefaultAsync(x => x.hd_archivo_id == model.hd_archivo_id);
                if (reg == null)
                {
                    return null;
                }

                reg.descripcion = model.descripcion.Left(150);

                _context.HdArchivos.Update(reg);
                await _context.SaveChangesAsync();

                var regreso = await Get(reg.hd_archivo_id);
                return regreso;
            }
            catch (Exception)
            {
                throw;
            }
        }

        // ---------------------------------------------------------
    }
}