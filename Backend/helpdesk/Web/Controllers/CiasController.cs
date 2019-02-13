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
using static Negocios.Servicios.CiaService;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CiasController : ControllerBase
    {
        // ---------------------------------------------------------

        private readonly DbContextHd _context;
        private ICiaService _servicioCia;

        public CiasController(DbContextHd context, ICiaService serviceCia)
        {
            _context = context;
            _servicioCia = serviceCia;
        }

        // ---------------------------------------------------------

        // GET: api/Cias
        [HttpGet]
        public async Task<IEnumerable<CiaVM>> GetCias()
        {
            return await _servicioCia.GetAllVM();
        }

        // ---------------------------------------------------------

        // TRAER
        // GET: api/Cias/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCia([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var cia = await _servicioCia.GetVM(id);
            return Ok(cia);
        }

        // ---------------------------------------------------------

        // Actualizar
        // PUT: api/Cias/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCia([FromBody] CiaUpdateVM modelo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var cia = await _servicioCia.Update(modelo);
            return Ok(cia);
        }

        // ---------------------------------------------------------

            // Añadir
        // POST: api/Cias
        [HttpPost]
        public async Task<IActionResult> PostCia([FromBody] CiaVMCreate modelo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var cia = await _servicioCia.Add(modelo);
            return Ok(cia);
        }

        // ---------------------------------------------------------

        // DELETE: api/Cias/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCia([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            bool elimino = await _servicioCia.Delete(id);
            //if (!elimino)
            //{
            //    throw new Exception("no se elimino el registro");
            //}
            return Ok();
        }

        // ---------------------------------------------------------

        private bool CiaExists(int id)
        {
            return _context.Cias.Any(e => e.cia_id == id);
        }

        // ---------------------------------------------------------
        // ---------------------------------------------------------

        // PUT: api/Cias/Desbloquear
        [HttpPut("[action]/{id}")]
        public async Task<IActionResult> Bloquear([FromBody] CiaBlkVM modelo)
        {
            await _servicioCia.Bloquear(modelo);
            return Ok();
        }

        // ---------------------------------------------------------

        // PUT: api/Cias/Desbloquear
        [HttpPut("[action]/{id}")]
        public async Task<IActionResult> Desbloquear([FromRoute] int id)
        {
            await _servicioCia.DesBloquear(id);
            return Ok();
        }

        // ---------------------------------------------------------

        // PUT: api/Cias/CambiarStatus
        [HttpPut("[action]")]
        public async Task<IActionResult> CambiarStatus([FromBody] ActivarVM modelo)
        {
            await _servicioCia.ActivarDesactivar(modelo.id, modelo.activar);
            return Ok();
        }

        // ---------------------------------------------------------

        // GET: api/Cias/Select
        [HttpPut("[action]")]
        public async Task<IActionResult> Select()
        {
            string tipo = HttpContext.Request.Query["tipo"].ToString();
            int intTipo = tipo.TrueInt();

            switch (intTipo)
            {
                case 2:
                    var regreso2 = await _servicioCia.Select2(EnumActiva.Todos, EnumBloqueada.Todos);
                    return Ok(regreso2);

                default:
                    var regreso = await _servicioCia.Select(EnumActiva.Todos, EnumBloqueada.Todos);
                    return Ok(regreso);
            }
        }

        // ---------------------------------------------------------

        // Existe
        // Get all
        // GetAllVM
        // Get
        // Bloquear
    }
}