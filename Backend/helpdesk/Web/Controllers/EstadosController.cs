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

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstadosController : ControllerBase
    {
        // ---------------------------------------------------------

        // DB
        private readonly DbContextHd _context;

        // Interfaz (servicio estado clase)
        private IEstadoService _servicioEstado;

        // Quien referencia?
        public EstadosController(DbContextHd context, IEstadoService serviceEstado)
        {
            _context = context;
            _servicioEstado = serviceEstado;
        }

        // ---------------------------------------------------------

        // TRAER TODOS
        // No se va a usar?
        // GET: api/Estados
        [HttpGet]
        public IEnumerable<Estado> GetEstados()
        {
            return _context.Estados;
        }

        // ---------------------------------------------------------

        // GET
        // GET: api/Estados/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetEstado([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var estado = await _servicioEstado.GetVM(id);

            return Ok(estado);
        }

        // ---------------------------------------------------------

        // ACTUALIZAR
        // PUT: api/Estados/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEstado([FromBody]EstadoUpdateVM estado)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var elEstado = await _servicioEstado.Update(estado);
            return Ok(elEstado);
        }

        // ---------------------------------------------------------

        // AÑADIR
        // POST: api/Estados
        [HttpPost]
        public async Task<IActionResult> PostEstado([FromBody] EstadoCreaVM estado)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var elEstado = await _servicioEstado.Add(estado);
            return Ok(elEstado);
        }

        // ---------------------------------------------------------

        // BORRAR
        // DELETE: api/Estados/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEstado([FromRoute] int id)
        {


            bool elimino = await _servicioEstado.Delete(id);
            //if (!elimino)
            //{
            //    throw new Exception("No se ha eliminado el registro");
            //}

            return Ok();
        }

        // ---------------------------------------------------------

        private bool EstadoExists(int id)
        {
            return _context.Estados.Any(e => e.estado_id == id);
        }

        // ---------------------------------------------------------
        // ---------------------------------------------------------
        // ---------------------------------------------------------

        // GET: api/Estados/GetAllVM/5
        [HttpGet("[action]/{id}")]
        public async Task<IEnumerable<EstadoVM>> GetAllVM(int id)
        {

            var regreso = await _servicioEstado.GetAllVM(id);
            return regreso;

        }

        // ---------------------------------------------------------

        // GET: api/Estados/Select/id
        [HttpGet("[action]/{id}")]
        public async Task<IActionResult> Select(int id)
        {
            string tipo = HttpContext.Request.Query["tipo"].ToString();
            int intTipo = tipo.TrueInt();

            switch (intTipo)
            {
                case 2:
                    var regreso2 = await _servicioEstado.Select2(id);
                    return Ok(regreso2);

                default:
                    var regreso = await _servicioEstado.Select(id);
                    return Ok(regreso);
            }
        }

        // ---------------------------------------------------------

        // PUT: api/Estados/CambiarStatus
        [HttpPut("[action]")]
        public async Task<IActionResult> CambiarStatus([FromBody] ActivarVM modelo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await _servicioEstado.ActivarDesactivar(modelo.id, modelo.activar);
            return Ok();
        }
    }
}