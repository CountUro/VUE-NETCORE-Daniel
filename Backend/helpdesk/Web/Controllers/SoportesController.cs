using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Datos.Contexto;
using Entidades.Modelo;
using Entidades.ViewModels;
using Negocios.Servicios;
using Negocios.Extensiones;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SoportesController : ControllerBase
    {
        // ---------------------------------------------------------

        private readonly DbContextHd _context;
        private ISoporteService _servicioSoporte;

        public SoportesController(DbContextHd context, ISoporteService serviceSoporte)
        {
            _context = context;
            _servicioSoporte = serviceSoporte;
        }

        // ---------------------------------------------------------

        // GET: api/Soportes
        [HttpGet]
        public IEnumerable<Soporte> GetSoportes()
        {
            return _context.Soportes;
        }

        // ---------------------------------------------------------

        // GET: api/Soportes/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetSoporte([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var traer = await _servicioSoporte.Get(id);
            return Ok(traer);
        }

        // ---------------------------------------------------------

        // PUT: api/Soportes/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSoporte([FromBody] Soporte soporte)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var regreso = await _servicioSoporte.Update(soporte);
            return Ok(regreso);
        }

        // ---------------------------------------------------------

        // POST: api/Soportes
        [HttpPost]
        public async Task<IActionResult> PostSoporte([FromBody] SoporteCreaVM soporte)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var regreso = await _servicioSoporte.Add(soporte);
            return Ok(regreso);
        }

        // ---------------------------------------------------------

        // DELETE: api/Soportes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSoporte([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await _servicioSoporte.Delete(id);

            return Ok();
        }

        // ---------------------------------------------------------

        private bool SoporteExists(int id)
        {
            return _context.Soportes.Any(e => e.soporte_id == id);
        }

        // ---------------------------------------------------------
        // ---------------------------------------------------------
        // ---------------------------------------------------------

        // GET: api/Soportes/Select
        [HttpGet("[action]")]
        public async Task<IActionResult> Select()
        {
            string tipo = HttpContext.Request.Query["tipo"].ToString();
            int intTipo = tipo.TrueInt();

            switch (intTipo)
            {
                case 2:
                    var regreso2 = await _servicioSoporte.Select2();
                    return Ok(regreso2);

                default:
                    var regreso = await _servicioSoporte.Select();
                    return Ok(regreso);
            }
        }

        // ---------------------------------------------------------
    }
}