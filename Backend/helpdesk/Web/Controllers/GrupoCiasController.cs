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
    public class GrupoCiasController : ControllerBase
    {
        // ---------------------------------------------------------

        private readonly DbContextHd _context;
        private IGrupoCiaService _servicioGrupoCias;

        public GrupoCiasController(DbContextHd context, IGrupoCiaService grupoCiasService)
        {
            _context = context;
            _servicioGrupoCias = grupoCiasService;
        }

        // ---------------------------------------------------------

        // GET: api/GrupoCias
        [HttpGet]
        public async Task<IEnumerable<GrupoCia>> GetGrupoCias()
        {
            var lista = await _servicioGrupoCias.GetAll();
            return _context.GrupoCias;
        }

        // ---------------------------------------------------------

        // GET: api/GrupoCias/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetGrupoCia([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var grupoCia = await _servicioGrupoCias.Get(id);

            return Ok(grupoCia);
        }

        // ---------------------------------------------------------

        // Actualizar
        // PUT: api/GrupoCias/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutGrupoCia([FromRoute] int id, [FromBody] GrupoCia modelo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var grupo = await _servicioGrupoCias.Update(modelo);
            return Ok(grupo);
        }

        // ---------------------------------------------------------

        // Añadir
        // POST: api/GrupoCias
        [HttpPost]
        public async Task<IActionResult> PostGrupoCia([FromBody] GrupoCia modelo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var grupo = await _servicioGrupoCias.Add(modelo);
            return Ok(grupo);
        }

        // ---------------------------------------------------------

        // DELETE: api/GrupoCias/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteGrupoCia([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            bool elimino = await _servicioGrupoCias.Delete(id);
            //if (!elimino)
            //{
            //    throw new Exception("No se ha eliminado el registro");
            //}
            return Ok();
        }

        // ---------------------------------------------------------

        private bool GrupoCiaExists(int id)
        {
            return _context.GrupoCias.Any(e => e.grupo_cia_id == id);
        }

        // ---------------------------------------------------------
        // ---------------------------------------------------------
        // ---------------------------------------------------------

        // GET: api/GrupoCias/Select
        [HttpGet("[action]")]
        public async Task<IActionResult> Select()
        {
            string tipo = HttpContext.Request.Query["tipo"].ToString();
            int intTipo = tipo.TrueInt();

            switch (intTipo)
            {
                case 2:
                    var regreso2 = await _servicioGrupoCias.Select2();
                    return Ok(regreso2);

                default:
                    var regreso = await _servicioGrupoCias.Select();
                    return Ok(regreso);
            }
        }

        // ---------------------------------------------------------
    }
}