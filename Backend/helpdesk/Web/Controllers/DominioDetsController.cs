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
    public class DominioDetsController : ControllerBase
    {
        // ---------------------------------------------------------

        private readonly DbContextHd _context;
        private IDominioDetService _servicioDominioDet;

        public DominioDetsController(DbContextHd context, IDominioDetService servicioDominioDet)
        {
            _context = context;
            _servicioDominioDet = servicioDominioDet;
        }

        // ---------------------------------------------------------

        // GET: api/DominioDets
        [HttpGet]
        public IEnumerable<DominioDet> GetDominioDets()
        {
            return _context.DominioDets;
        }

        // ---------------------------------------------------------

        // GET: api/DominioDets/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetDominioDet([FromRoute] long id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var traer = await _servicioDominioDet.Get(id);
            return Ok(traer);
        }

        // ---------------------------------------------------------

        // PUT: api/DominioDets/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDominioDet([FromBody] DominioDet dominioDet)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var actualizar = await _servicioDominioDet.Update(dominioDet);

            return Ok(actualizar);
        }

        // ---------------------------------------------------------

        // POST: api/DominioDets
        [HttpPost]
        public async Task<IActionResult> PostDominioDet([FromBody] DominioDet dominioDet)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var agregar = await _servicioDominioDet.Add(dominioDet);
            return Ok(agregar);
        }

        // ---------------------------------------------------------

        // DELETE: api/DominioDets/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDominioDet([FromRoute] long id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var borrado = await _servicioDominioDet.Delete(id);
            return Ok();
        }

        // ---------------------------------------------------------

        private bool DominioDetExists(long id)
        {
            return _context.DominioDets.Any(e => e.dominio_det_id == id);
        }

        // ---------------------------------------------------------
        // ---------------------------------------------------------

        // GET: api/DominioDets/Select
        [HttpGet("[action]")]
        public async Task<IActionResult> Select()
        {
            string pais = HttpContext.Request.Query["pais"].ToString();
            string dominio = HttpContext.Request.Query["dominio"].ToString();
            string noaplica = HttpContext.Request.Query["noaplica"].ToString();
            string tipo = HttpContext.Request.Query["tipo"].ToString();

            int intNoAplica = noaplica.TrueInt();
            int IdDom = dominio.TrueInt();
            int IdPais = pais.TrueInt();
            int intTipo = tipo.TrueInt();

            if (IdPais == 0)
            {
                IdPais = 1862;
            }

            bool bNoAplica = (intNoAplica == 0) ? false : true;

            switch (intTipo)
            {
                case 2:
                    var regreso2 = await _servicioDominioDet.Select2(IdPais, IdDom, bNoAplica);
                    return Ok(regreso2);
                
                default:
                    var regreso = await _servicioDominioDet.Select(IdPais, IdDom, bNoAplica);
                    return Ok(regreso);
                    break;
            }
        }
    }
}