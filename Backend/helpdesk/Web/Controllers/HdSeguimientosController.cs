using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Datos.Contexto;
using Entidades.Modelo;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HdSeguimientosController : ControllerBase
    {
        // ---------------------------------------------------------

        private readonly DbContextHd _context;
        //private db

        public HdSeguimientosController(DbContextHd context)
        {
            _context = context;
        }

        // ---------------------------------------------------------

        // GET: api/HdSeguimientos
        [HttpGet]
        public IEnumerable<HdSeguimiento> GetHdSeguimientos()
        {
            return _context.HdSeguimientos;
        }

        // ---------------------------------------------------------

        // GET: api/HdSeguimientos/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetHdSeguimiento([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var hdSeguimiento = await _context.HdSeguimientos.FindAsync(id);

            if (hdSeguimiento == null)
            {
                return NotFound();
            }

            return Ok(hdSeguimiento);
        }

        // ---------------------------------------------------------

        // PUT: api/HdSeguimientos/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHdSeguimiento([FromRoute] int id, [FromBody] HdSeguimiento hdSeguimiento)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != hdSeguimiento.hd_seguimiento_id)
            {
                return BadRequest();
            }

            _context.Entry(hdSeguimiento).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HdSeguimientoExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // ---------------------------------------------------------

        // POST: api/HdSeguimientos
        [HttpPost]
        public async Task<IActionResult> PostHdSeguimiento([FromBody] HdSeguimiento hdSeguimiento)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.HdSeguimientos.Add(hdSeguimiento);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetHdSeguimiento", new { id = hdSeguimiento.hd_seguimiento_id }, hdSeguimiento);
        }

        // ---------------------------------------------------------

        // DELETE: api/HdSeguimientos/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHdSeguimiento([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var hdSeguimiento = await _context.HdSeguimientos.FindAsync(id);
            if (hdSeguimiento == null)
            {
                return NotFound();
            }

            _context.HdSeguimientos.Remove(hdSeguimiento);
            await _context.SaveChangesAsync();

            return Ok(hdSeguimiento);
        }

        // ---------------------------------------------------------

        private bool HdSeguimientoExists(int id)
        {
            return _context.HdSeguimientos.Any(e => e.hd_seguimiento_id == id);
        }

        // ---------------------------------------------------------
    }
}