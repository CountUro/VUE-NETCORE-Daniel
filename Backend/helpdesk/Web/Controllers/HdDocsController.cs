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

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HdDocsController : ControllerBase
    {
        // ---------------------------------------------------------

        private readonly DbContextHd _context;
        private IHdDocService _servicioHdDoc;

        public HdDocsController(DbContextHd context, IHdDocService servicioHdDoc)
        {
            _context = context;
            _servicioHdDoc = servicioHdDoc;
        }

        // ---------------------------------------------------------

        // GET: api/HdDocs
        [HttpGet]
        public IEnumerable<HdDoc> GetHdDocs()
        {
            return _context.HdDocs;
        }

        // ---------------------------------------------------------

        // GET: api/HdDocs/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetHdDoc([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var traer = await _servicioHdDoc.Get(id);
            return Ok(traer);
        }

        // ---------------------------------------------------------

        // PUT: api/HdDocs/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHdDoc([FromBody] HdDocUpdateVM hdDoc)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var actualizar = await _servicioHdDoc.Update(hdDoc);
            return Ok(actualizar);
        }

        // ---------------------------------------------------------

        // POST: api/HdDocs
        [HttpPost]
        public async Task<IActionResult> PostHdDoc([FromBody] HdDocCreateVM hdDoc)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var agregar = await _servicioHdDoc.Add(hdDoc);
            return Ok(agregar);
        }

        // ---------------------------------------------------------

        // DELETE: api/HdDocs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHdDoc([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var borrar = await _servicioHdDoc.Delete(id);
            return Ok();
        }

        // ---------------------------------------------------------

        private bool HdDocExists(int id)
        {
            return _context.HdDocs.Any(e => e.hd_doc_id == id);
        }

        // ---------------------------------------------------------
    }
}