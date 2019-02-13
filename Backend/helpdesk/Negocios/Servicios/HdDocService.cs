using Datos.Contexto;
using Entidades.Modelo;
using Entidades.ViewModels;
using Microsoft.EntityFrameworkCore;
using Negocios.Extensiones;
using Negocios.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios.Servicios
{
    public interface IHdDocService
    {
        Task<bool> Existe(int id);
        Task<IEnumerable<HdDocVM>> GetAllVM(HdDocFiltro filtro);
        Task<IEnumerable<HdDoc>> GetAll(HdDocFiltro filtro);
        Task<HdDocVM> GetVM(int id);
        Task<HdDoc> Get(int id);
        Task<Boolean> Delete(int id);
        Task<HdDoc> Update(HdDocUpdateVM model);
        Task<HdDoc> Add(HdDocCreateVM model);
        Task<bool> LeidoConsultor(int id, bool leido);
        Task<bool> LeidoProgramador(int id, bool leido);
    }

    public class HdDocService : IHdDocService
    {
        private readonly DbContextHd _context;

        public HdDocService(DbContextHd context)
        {
            _context = context;
        }

        public async Task<HdDoc> Add(HdDocCreateVM model)
        {
            try
            {

                ConsecutivosMg consecutivo = new ConsecutivosMg(_context);
                int nro = await consecutivo.TraerConsecutivo(1);

                HdDoc doc = new HdDoc
                {
                    consultor_id = model.consultor_id,
                    programador_id = model.programador_id,
                    cia_id = model.cia_id,
                    persona_id = model.persona_id,
                    aplicacion_178_id = model.aplicacion_178_id,
                    urgencia_170_id = model.urgencia_170_id,
                    tipo_172_id = model.tipo_172_id,
                    status_175_id = model.status_175_id,
                    modulo_214_id = model.modulo_214_id,
                    motivo_298_id = (long)model.motivo_298_id,
                    pais_id = model.pais_id,
                    numero = nro,
                    titulo = model.titulo,
                    descripcion = model.descripcion,
                    f_crea = DateTime.Now,
                    version_app = model.version_app,
                    version_bd = model.version_bd,
                    //f_correccion = model.f_correccion,
                    //solucion = model.solucion,
                    //version_solucion = model.version_solucion,
                    //f_solucionn = model.f_solucionn,
                    nombre_contacto = model.nombre_contacto,
                    email_contacto = model.email_contacto,
                    tlf_contacto = model.tlf_contacto,
                    nombre_ventana = model.nombre_ventana,
                    leido_consultor = false,
                    leido_programador = false
                };

                _context.HdDocs.Add(doc);
                await _context.SaveChangesAsync();
                return doc;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<bool> Delete(int id)
        {
            if (id < 1)
            {
                throw new Exception("La ID insertada es invalida");
                return false;
            }

            var doc = await _context.HdDocs.FindAsync(id);
            if (doc == null)
            {
                throw new Exception("No se ha logrado borrar el registro");
                return false;
            }

            _context.HdDocs.Remove(doc);
            await _context.SaveChangesAsync();
            return true;

        }

        public async Task<bool> Existe(int id)
        {
            try
            {
                var doc = await _context.HdDocs.FirstOrDefaultAsync(x => x.hd_doc_id == id);
                bool regreso = (doc == null) ? false : true;
                return regreso;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            throw new NotImplementedException();
        }

        public async Task<HdDoc> Get(int id)
        {
            var doc = await _context.HdDocs.FirstOrDefaultAsync(x => x.hd_doc_id == id);
            return doc;
        }

        public async Task<HdDocVM> GetVM(int id)
        {
            try
            {
                var doc = await _context.HdDocs
                            .Include(a => a.consultor)
                            .Include(b => b.programador)
                            .Include(c => c.cia)
                            .Include(d => d.persona)
                            .Include(e => e.aplicacion178)
                            .Include(f => f.urgencia170)
                            .Include(g => g.tipo172)
                            .Include(h => h.status175)
                            .Include(i => i.modulo214)
                            .Include(j => j.motivo298)
                            .Include(k => k.pais)
                            .FirstOrDefaultAsync(x => x.hd_doc_id == id);

                if (doc == null)
                {
                    return null;
                }
                HdDocVM regreso = new HdDocVM
                {
                    hd_doc_id = doc.hd_doc_id,
                    consultor_id = doc.consultor_id,
                    consultor = doc.consultor.nombre,
                    programador_id = doc.programador_id,
                    programador = doc.programador.nombre,
                    cia_id = doc.cia_id,
                    cia = doc.cia.nombre,
                    persona_id = doc.persona_id,
                    persona = doc.persona.nombre_comp,
                    aplicacion_178_id = doc.aplicacion_178_id,
                    aplicacion178 = doc.aplicacion178.descripcion,
                    urgencia_170_id = doc.urgencia_170_id,
                    urgencia170 = doc.urgencia170.descripcion,
                    tipo_172_id = doc.tipo_172_id,
                    tipo172 = doc.tipo172.descripcion,
                    status_175_id = doc.status_175_id,
                    status175 = doc.status175.descripcion,
                    modulo_214_id = doc.modulo_214_id,
                    modulo214 = doc.modulo214.descripcion,
                    motivo_298_id = doc.motivo_298_id,
                    motivo298 = doc.motivo298.descripcion,
                    pais_id = doc.pais_id,
                    pais = doc.pais.nombre,
                    numero = doc.numero,
                    titulo = doc.titulo,
                    descripcion = doc.descripcion,
                    f_crea = doc.f_crea,
                    version_app = doc.version_app,
                    version_bd = doc.version_bd,
                    f_correccion = doc.f_correcion,
                    solucion = doc.solucion,
                    version_solucion = doc.version_solucion,
                    f_solucionn = doc.f_solucion,
                    nombre_contacto = doc.nombre_contacto,
                    email_contacto = doc.email_contacto,
                    tlf_contacto = doc.tlf_contacto,
                    nombre_ventana = doc.nombre_ventana,
                    leido_consultor = doc.leido_consultor,
                    leido_programador = doc.leido_programador
                };

                return regreso;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<bool> LeidoConsultor(int id, bool leido)
        {
            try
            {
                var doc = await _context.HdDocs.FirstOrDefaultAsync(x => x.hd_doc_id == id);
                if (doc == null)
                {
                    return false;
                }

                doc.leido_consultor = leido;
                _context.HdDocs.Update(doc);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<bool> LeidoProgramador(int id, bool leido)
        {
            try
            {
                var doc = await _context.HdDocs.FirstOrDefaultAsync(x => x.hd_doc_id == id);
                if (doc == null)
                {
                    return false;
                }

                doc.leido_programador = leido;
                _context.HdDocs.Update(doc);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<HdDoc> Update(HdDocUpdateVM model)
        {
            try
            {
                var doc = await _context.HdDocs.FirstOrDefaultAsync(x => x.hd_doc_id == model.hd_doc_id);
                if (doc == null)
                {
                    return null;
                }

                doc.consultor_id = model.consultor_id;
                doc.programador_id = model.programador_id;
                doc.cia_id = model.cia_id;
                doc.persona_id = model.persona_id;
                doc.aplicacion_178_id = model.aplicacion_178_id;
                doc.urgencia_170_id = model.urgencia_170_id;
                doc.tipo_172_id = model.tipo_172_id;
                doc.status_175_id = model.status_175_id;
                doc.modulo_214_id = model.modulo_214_id;
                doc.motivo_298_id = (long)model.motivo_298_id;
                doc.pais_id = model.pais_id;
                doc.titulo = model.titulo;
                doc.descripcion = model.descripcion;
                doc.version_app = model.version_app;
                doc.version_bd = model.version_bd;
                doc.nombre_contacto = model.nombre_contacto;
                doc.email_contacto = model.email_contacto;
                doc.tlf_contacto = model.tlf_contacto;
                doc.nombre_ventana = model.nombre_ventana;

                _context.HdDocs.Update(doc);
                await _context.SaveChangesAsync();

                return doc;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public async Task<IEnumerable<HdDoc>> GetAll(HdDocFiltro filtro)
        {
            try
            {
                int iconsultor = (filtro.consultor_id == 0) ? 0 : 1;
                int iprogramador = (filtro.programador_id == 0) ? 0 : 1;
                int icia = (filtro.cia_id == 0) ? 0 : 1;
                int i178 = (filtro.aplicacion_178_id == 0) ? 0 : 1;
                int i170 = (filtro.urgencia_170_id == 0) ? 0 : 1;
                int i172 = (filtro.tipo_172_id == 0) ? 0 : 1;
                int i175 = (filtro.status_175_id == 0) ? 0 : 1;
                int i214 = (filtro.modulo_214_id == 0) ? 0 : 1;
                int i298 = (filtro.motivo_298_id == 0) ? 0 : 1;
                int ipais = (filtro.pais_id == 0) ? 0 : 1;
                int inumero = (filtro.numero == 0) ? 0 : 1;
                int ititulo = (filtro.titulo.EsNulaOVacia()) ? 0 : 1;
                int idescri = (filtro.descripcion.EsNulaOVacia()) ? 0 : 1;



                filtro.consultor_id = (iconsultor == 0) ? -1 : filtro.consultor_id;
                filtro.programador_id = (iprogramador == 0) ? -1 : filtro.programador_id;
                filtro.cia_id = (icia == 0) ? -1 : filtro.cia_id;
                filtro.aplicacion_178_id = (i178 == 0) ? -1 : filtro.aplicacion_178_id;
                filtro.urgencia_170_id = (i170 == 0) ? -1 : filtro.urgencia_170_id;
                filtro.tipo_172_id = (i172 == 0) ? -1 : filtro.tipo_172_id;
                filtro.status_175_id = (i175 == 0) ? -1 : filtro.status_175_id;
                filtro.motivo_298_id = (i298 == 0) ? -1 : filtro.motivo_298_id;
                filtro.modulo_214_id = (i214 == 0) ? -1 : filtro.modulo_214_id;
                filtro.pais_id = (ipais == 0) ? -1 : filtro.pais_id;
                filtro.numero = (inumero == 0) ? -1 : filtro.numero;

                filtro.titulo = (ititulo == 0) ? filtro.titulo : filtro.titulo.Trim().ToLower();
                filtro.descripcion = (idescri == 0) ? filtro.descripcion : filtro.descripcion.Trim().ToLower();

                int ileidoc = (filtro.leido_consultor == -1) ? 0 : 1;
                int ileidop = (filtro.leido_programador == -1) ? 0 : 1;

                bool bleidoc = false;
                bool bleidop = false;

                if (filtro.leido_consultor == 1) bleidoc = true;
                if (filtro.leido_programador == 1) bleidop = true;

                if (ititulo == 1)
                {
                    filtro.titulo = filtro.titulo.ToLower();
                }
                if (idescri == 1)
                {
                    filtro.descripcion = filtro.descripcion.ToLower();
                }

                var docs = await _context.HdDocs
                                .Where(x => (
                                            ((iconsultor == 0) || ((iconsultor == 1) && (x.consultor_id == filtro.consultor_id))) &&
                                            ((iprogramador == 0) || ((iprogramador == 1) && (x.programador_id == filtro.programador_id))) &&
                                            ((icia == 0) || ((icia == 1) && (x.cia_id == filtro.cia_id))) &&
                                            ((i178 == 0) || ((i178 == 1) && (x.aplicacion_178_id == filtro.aplicacion_178_id))) &&
                                            ((i170 == 0) || ((i170 == 1) && (x.urgencia_170_id == filtro.urgencia_170_id))) &&
                                            ((i172 == 0) || ((i172 == 1) && (x.tipo_172_id == filtro.tipo_172_id))) &&
                                            ((i175 == 0) || ((i175 == 1) && (x.status_175_id == filtro.status_175_id))) &&
                                            ((i214 == 0) || ((i214 == 1) && (x.modulo_214_id == filtro.modulo_214_id))) &&
                                            ((i298 == 0) || ((i298 == 1) && (x.motivo_298_id == filtro.motivo_298_id))) &&
                                            ((ititulo == 0) || ((ititulo == 1) && (x.titulo.ToLower().Contains(filtro.titulo)))) &&
                                            ((idescri == 0) || ((idescri == 1 && x.descripcion.ToLower().Contains(filtro.descripcion)))) &&
                                            ((ileidoc == 0) || ((ileidoc == 1 && x.leido_consultor == bleidoc))) &&
                                            ((ileidop == 0) || ((ileidop == 1 && x.leido_programador == bleidop)))
                                            )
                                ).ToListAsync();
                return docs;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IEnumerable<HdDocVM>> GetAllVM(HdDocFiltro filtro)
        {
            try
            {
                int iconsultor = (filtro.consultor_id == 0) ? 0 : 1;
                int iprogramador = (filtro.programador_id == 0) ? 0 : 1;
                int icia = (filtro.cia_id == 0) ? 0 : 1;
                int i178 = (filtro.aplicacion_178_id == 0) ? 0 : 1;
                int i170 = (filtro.urgencia_170_id == 0) ? 0 : 1;
                int i172 = (filtro.tipo_172_id == 0) ? 0 : 1;
                int i175 = (filtro.status_175_id == 0) ? 0 : 1;
                int i214 = (filtro.modulo_214_id == 0) ? 0 : 1;
                int i298 = (filtro.motivo_298_id == 0) ? 0 : 1;
                int ipais = (filtro.pais_id == 0) ? 0 : 1;
                int inumero = (filtro.numero == 0) ? 0 : 1;
                int ititulo = (filtro.titulo.EsNulaOVacia()) ? 0 : 1;
                int idescri = (filtro.descripcion.EsNulaOVacia()) ? 0 : 1;



                filtro.consultor_id = (iconsultor == 0) ? -1 : filtro.consultor_id;
                filtro.programador_id = (iprogramador == 0) ? -1 : filtro.programador_id;
                filtro.cia_id = (icia == 0) ? -1 : filtro.cia_id;
                filtro.aplicacion_178_id = (i178 == 0) ? -1 : filtro.aplicacion_178_id;
                filtro.urgencia_170_id = (i170 == 0) ? -1 : filtro.urgencia_170_id;
                filtro.tipo_172_id = (i172 == 0) ? -1 : filtro.tipo_172_id;
                filtro.status_175_id = (i175 == 0) ? -1 : filtro.status_175_id;
                filtro.motivo_298_id = (i298 == 0) ? -1 : filtro.motivo_298_id;
                filtro.modulo_214_id = (i214 == 0) ? -1 : filtro.modulo_214_id;
                filtro.pais_id = (ipais == 0) ? -1 : filtro.pais_id;
                filtro.numero = (inumero == 0) ? -1 : filtro.numero;

                filtro.titulo = (ititulo == 0) ? filtro.titulo : filtro.titulo.Trim().ToLower();
                filtro.descripcion = (idescri == 0) ? filtro.descripcion : filtro.descripcion.Trim().ToLower();

                int ileidoc = (filtro.leido_consultor == -1) ? 0 : 1;
                int ileidop = (filtro.leido_programador == -1) ? 0 : 1;

                bool bleidoc = false;
                bool bleidop = false;

                if (filtro.leido_consultor == 1) bleidoc = true;
                if (filtro.leido_programador == 1) bleidop = true;

                if (ititulo == 1)
                {
                    filtro.titulo = filtro.titulo.ToLower();
                }
                if (idescri == 1)
                {
                    filtro.descripcion = filtro.descripcion.ToLower();
                }

                //(iconsultor == 0) || (iconsultor == 1 && x.consultor_id == filtro.consultor_id) &&
                //(iprogramador == 0) || (iprogramador == 1 && x.programador_id == filtro.programador_id) &&
                //(icia == 0) || (icia == 1 && x.cia_id == filtro.cia_id) &&
                //(i178 == 0) || (i178 == 1 && x.aplicacion_178_id == filtro.aplicacion_178_id) &&
                //(i170 == 0) || (i170 == 1 && x.urgencia_170_id == filtro.urgencia_170_id) &&
                //(i172 == 0) || (i172 == 1 && x.tipo_172_id == filtro.tipo_172_id) &&
                //(i175 == 0) || (i175 == 1 && x.status_175_id == filtro.status_175_id) &&
                //(i214 == 0) || (i214 == 1 && x.modulo_214_id == filtro.modulo_214_id) &&
                //(i298 == 0) || (i298 == 1 && x.motivo_298_id == filtro.motivo_298_id) &&
                //(ipais == 0) || (ipais == 1 && x.pais_id == filtro.pais_id) &&
                //(inumero == 0) || (inumero == 1 && x.numero == filtro.numero) &&
                //(ititulo == 0) || (ititulo == 1 && x.titulo.ToLower().Contains(filtro.titulo)) &&
                //(idescri == 0) || (idescri == 1 && x.descripcion.ToLower().Contains(filtro.descripcion)) &&
                //(ileidoc == 0) || (ileidoc == 1 && x.leido_consultor == bleidoc) &&
                //(ileidop == 0) || (ileidop == 1 && x.leido_programador == bleidop)

                var docs = await _context.HdDocs
                                .Where(x => (
                                ((iconsultor == 0) || ((iconsultor == 1) && (x.consultor_id == filtro.consultor_id))) &&
                                ((iprogramador == 0) || ((iprogramador == 1) && (x.programador_id == filtro.programador_id))) &&
                                ((icia == 0) || ((icia == 1) && (x.cia_id == filtro.cia_id))) &&
                                ((i178 == 0) || ((i178 == 1) && (x.aplicacion_178_id == filtro.aplicacion_178_id))) &&
                                ((i170 == 0) || ((i170 == 1) && (x.urgencia_170_id == filtro.urgencia_170_id))) &&
                                ((i172 == 0) || ((i172 == 1) && (x.tipo_172_id == filtro.tipo_172_id))) &&
                                ((i175 == 0) || ((i175 == 1) && (x.status_175_id == filtro.status_175_id))) &&
                                ((i214 == 0) || ((i214 == 1) && (x.modulo_214_id == filtro.modulo_214_id))) &&
                                ((i298 == 0) || ((i298 == 1) && (x.motivo_298_id == filtro.motivo_298_id))) &&
                                ((ititulo == 0) || ((ititulo == 1) && (x.titulo.ToLower().Contains(filtro.titulo)))) &&
                                ((idescri == 0) || ((idescri == 1 && x.descripcion.ToLower().Contains(filtro.descripcion)))) &&
                                ((ileidoc == 0) || ((ileidoc == 1 && x.leido_consultor == bleidoc))) &&
                                ((ileidop == 0) || ((ileidop == 1 && x.leido_programador == bleidop)))
                                )
                    ).Include(a => a.consultor)
                    .Include(b => b.programador)
                    .Include(c => c.cia)
                    .Include(d => d.aplicacion178)
                    .Include(e => e.urgencia170)
                    .Include(f => f.tipo172)
                    .Include(g => g.status175)
                    .Include(h => h.modulo214)
                    .Include(i => i.motivo298)
                    .Include(j => j.pais)
                    .Select(s => new HdDocVM
                    {
                        hd_doc_id = s.hd_doc_id,
                        consultor_id = s.consultor_id,
                        consultor = s.consultor.nombre,
                        programador_id = s.programador_id,
                        programador = s.programador.nombre,
                        cia_id = s.cia_id,
                        cia = s.cia.nombre,
                        persona_id = s.persona_id,
                        persona = s.persona.nombre_comp,
                        aplicacion_178_id = s.aplicacion_178_id,
                        aplicacion178 = s.aplicacion178.descripcion,
                        urgencia_170_id = s.urgencia_170_id,
                        urgencia170 = s.urgencia170.descripcion,
                        tipo_172_id = s.tipo_172_id,
                        tipo172 = s.tipo172.descripcion,
                        status_175_id = s.status_175_id,
                        status175 = s.status175.descripcion,
                        modulo_214_id = s.modulo_214_id,
                        modulo214 = s.modulo214.descripcion,
                        motivo_298_id = s.motivo_298_id,
                        motivo298 = s.motivo298.descripcion,
                        pais_id = s.pais_id,
                        pais = s.pais.nombre,
                        numero = s.numero,
                        titulo = s.titulo,
                        descripcion = s.descripcion,
                        f_crea = s.f_crea,
                        version_app = s.version_app,
                        version_bd = s.version_bd,
                        f_correccion = s.f_correcion,
                        solucion = s.solucion,
                        version_solucion = s.version_solucion,
                        f_solucionn = s.f_solucion,
                        nombre_contacto = s.nombre_contacto,
                        email_contacto = s.email_contacto,
                        tlf_contacto = s.tlf_contacto,
                        nombre_ventana = s.nombre_ventana,
                        leido_consultor = s.leido_consultor,
                        leido_programador = s.leido_programador
                    })
                    .ToListAsync();
                return docs;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
