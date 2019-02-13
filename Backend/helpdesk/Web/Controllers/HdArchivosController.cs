using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Datos.Contexto;
using Entidades.Modelo;
using Negocios.Servicios;
using Entidades.ViewModels;
using Negocios.Extensiones;
using System.IO;
using System.Transactions;
using System.Net.Http.Headers;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HdArchivosController : ControllerBase
    {
        // ---------------------------------------------------------

        private readonly DbContextHd _context;
        private IHdArchivoService _servicioArchivo;

        public HdArchivosController(DbContextHd context, IHdArchivoService servicioArchivo)
        {
            _context = context;
            _servicioArchivo = servicioArchivo;
        }

        // ---------------------------------------------------------

        //// GET: api/HdArchivos
        //[HttpGet]
        //public IEnumerable<HdArchivo> GetHdArchivos()
        //{
        //    return _context.HdArchivos;
        //}

        // ---------------------------------------------------------

        // GET: api/HdArchivos/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetHdArchivo([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var traer = await _servicioArchivo.Get(id);
            return Ok(traer);
        }

        // ---------------------------------------------------------

        // PUT: api/HdArchivos/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHdArchivo([FromBody] HdArchivoUpdateVM hdArchivo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var actualizar = await _servicioArchivo.Update(hdArchivo);

            return Ok(actualizar);
        }

        // ---------------------------------------------------------

        //// POST: api/HdArchivos
        //[HttpPost]
        //public async Task<IActionResult> PostHdArchivo([FromBody] HdArchivoCreateVM hdArchivo)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    var agregar = await _servicioArchivo.Add(hdArchivo);

        //    return Ok(agregar);
        //}

        // ---------------------------------------------------------

        private bool HdArchivoExists(int id)
        {
            return _context.HdArchivos.Any(e => e.hd_archivo_id == id);
        }

        // ---------------------------------------------------------
        // ---------------------------------------------------------
        // ---------------------------------------------------------

        // GET: api/HdArchivos
        [HttpGet]
        public async Task<IEnumerable<HdArchivoVM>> GetHdArchivos()
        {
            string hd_doc_idStr = HttpContext.Request.Query["hd_doc_id"].ToString();
            int id = hd_doc_idStr.TrueInt();
            var regreso = await _servicioArchivo.GetAll(id);
            return regreso;
        }

        // ---------------------------------------------------------

        // DELETE: api/HdArchivos/DeleteHdArchivo
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHdArchivo([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var delete = await _servicioArchivo.Delete(id);
            return Ok();
        }

        // ---------------------------------------------------------

        [HttpGet("[action]/{id}")]
        public async Task<IActionResult> GetFile(int id)
        {
            if (id < 1)
            {
                throw new Exception("No pasó el id del registro");
            }

            var registro = await _servicioArchivo.Get(id);

            string nombreFile = registro.nombrefile;

            if (nombreFile.EsNulaOVacia())
            {
                throw new Exception("Este registro no tiene un archivo");
            }


            var path = Path.Combine(
                       Directory.GetCurrentDirectory(),
                       "wwwroot/imagenes", nombreFile);

            var memory = new MemoryStream();
            using (var stream = new FileStream(path, FileMode.Open))
            {
                await stream.CopyToAsync(memory);
            }
            memory.Position = 0;
            //"application
            //    GetContentType(path)
            var regreso = File(memory, GetContentType(path), Path.GetFileName(path));
            //return File(memory, GetContentType(path), Path.GetFileName(path));
            return regreso;


        }

        // ---------------------------------------------------------

        [HttpPost("[action]"), DisableRequestSizeLimit]
        public async Task<IActionResult> UploadUnFile()
        {

            using (var scope = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
            {
                var file = Request.Form.Files[0];

                if (file.Length <= 0)
                {
                    throw new Exception("No envio un archivo");
                }

                string descripcion = HttpContext.Request.Form["descripcion"].ToString();
                string IdDocStr = HttpContext.Request.Form["hd_doc_id"].ToString();
                string Idstr = HttpContext.GetClaim("usuarioId");
                int usuario_id = Idstr.TrueInt();
                int IdDoc = IdDocStr.TrueInt();

                string fileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');

                fileName = GetUniqueFileName(fileName);


                HdArchivoCreateVM modelo = new HdArchivoCreateVM
                {
                    hd_doc_id = IdDoc,
                    descripcion = descripcion,
                    nombrefile = fileName,
                    usuario_id = usuario_id
                };

                var regreso = await _servicioArchivo.Add(modelo);

                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/imagenes", fileName);

                using (var fileStream = new FileStream(path, FileMode.Create))
                {
                    await file.CopyToAsync(fileStream);
                    fileStream.Flush();
                }

                scope.Complete();

                return Ok(regreso);
            }

        }

        // ---------------------------------------------------------

        private string GetContentType(string path)
        {
            var types = GetMimeTypes();
            var ext = Path.GetExtension(path).ToLowerInvariant();
            return types[ext];
        }

        // ---------------------------------------------------------

        private Dictionary<string, string> GetMimeTypes()
        {
            return new Dictionary<string, string>
            {
                {".txt", "text/plain"},
                {".pdf", "application/pdf"},
                {".doc", "application/vnd.ms-word"},
                {".docx", "application/vnd.ms-word"},
                {".xls", "application/vnd.ms-excel"},
                {".xlsx", "application/vnd.openxmlformatsofficedocument.spreadsheetml.sheet"},
                {".pbd", "application/pbd"},
                {".pbl", "application/pbl"},
                {".exe", "application/exe"},
                {".mp4", "application/mp4"},
                {".avi", "application/avi"},
                {".png", "image/png"},
                {".jpg", "image/jpeg"},
                {".jpeg", "image/jpeg"},
                {".gif", "image/gif"},
                {".csv", "text/csv"}
            };
        }

        // ---------------------------------------------------------

        private string GetUniqueFileName(string fileName)
        {
            fileName = Path.GetFileName(fileName);

            string nombre = fileName.Left(240);
            return Path.GetFileNameWithoutExtension(nombre)
                      + "_" + Guid.NewGuid().ToString().Substring(0, 4)
                      + Path.GetExtension(nombre);
        }

        // ---------------------------------------------------------
    }
}