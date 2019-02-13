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
using Negocios.Extensiones;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaisesController : ControllerBase
    {
        // ---------------------------------------------------------

        private readonly DbContextHd _context;
        private IPaisService _servicioPais;

        public PaisesController(DbContextHd context, IPaisService servicioPais)
        {
            _context = context;
            _servicioPais = servicioPais;
        }

        // ---------------------------------------------------------

        //// GET: api/Paises
        //[HttpGet]
        //public async Task<IEnumerable<Pais>> GetPaises()
        //{
        //    //return _context.Paises; // ToList? Await?

        //    var paises = await _servicioPais.GetAll();
        //    return paises;
        //}

        // ---------------------------------------------------------

        // GET: api/Paises/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetPais([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var pais = await _servicioPais.Get(id);

            return Ok(pais);
        }

        // ---------------------------------------------------------

        // PUT: api/Paises/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPais([FromBody] Pais pais)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var elPais = await _servicioPais.Update(pais);

            return Ok(elPais);
        }

        // ---------------------------------------------------------

        // POST: api/Paises
        [HttpPost]
        public async Task<IActionResult> PostPais([FromBody] Pais pais)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var elPais = await _servicioPais.Add(pais);
            //return Ok(elPais);

            return CreatedAtAction("GetPais", new { id = pais.pais_id }, pais);
        }

        // ---------------------------------------------------------

        // DELETE: api/Paises/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePais([FromRoute] int id)
        {
            bool elimino = await _servicioPais.Delete(id);
            //if (!elimino)
            //{
            //    throw new Exception("No se ha podido eliminar el registro");
            //}

            return Ok();
        }

        // ---------------------------------------------------------
        // ---------------------------------------------------------
        // ---------------------------------------------------------

        // GET: api/Pais/Select
        [HttpGet("[action]")]
        public async Task<IActionResult> Select()
        {
            string tipo = HttpContext.Request.Query["tipo"].ToString();
            int intTipo = tipo.TrueInt();

            switch (intTipo)
            {
                case 2:
                    var regreso2 = await _servicioPais.Select2();
                    return Ok(regreso2);

                default:
                    var regreso = await _servicioPais.Select();
                    return Ok(regreso);
            }
        }

        // ---------------------------------------------------------

        // Existe?
        // Salvar lista (solo inicial, no?)
        // 
    }
}