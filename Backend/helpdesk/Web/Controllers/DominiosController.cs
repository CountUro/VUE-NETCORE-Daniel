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

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DominiosController : ControllerBase
    {
        // ---------------------------------------------------------

        private readonly DbContextHd _context;
        private IDominioService _servicioDominio;

        public DominiosController(DbContextHd context, IDominioService servicioDominio)
        {
            _context = context;
            _servicioDominio = servicioDominio;
        }

        // ---------------------------------------------------------

        // GET: api/Dominios
        [HttpGet]
        public IEnumerable<Dominio> GetDominios()
        {
            return _context.Dominios;
        }

        // ---------------------------------------------------------

        // GET: api/Dominios/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetDominio([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var traer = await _servicioDominio.Get(id);
            return Ok(traer);
        }

        // ---------------------------------------------------------

        // PUT: api/Dominios/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDominio([FromBody] Dominio dominio)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var actualizar = await _servicioDominio.Update(dominio);
            return Ok(actualizar);
        }

        // ---------------------------------------------------------

        // POST: api/Dominios
        [HttpPost]
        public async Task<IActionResult> PostDominio([FromBody] Dominio dominio)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var agregar = await _servicioDominio.Add(dominio);
            return Ok(agregar);
        }

        // ---------------------------------------------------------

        // DELETE: api/Dominios/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDominio([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var borrar = await _servicioDominio.Delete(id);
            return Ok();
        }

        // ---------------------------------------------------------

        private bool DominioExists(int id)
        {
            return _context.Dominios.Any(e => e.dominio_id == id);
        }

        // ---------------------------------------------------------
    }
}