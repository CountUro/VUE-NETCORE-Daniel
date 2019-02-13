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
    public class CiudadesController : ControllerBase
    {
        // ---------------------------------------------------------

        private readonly DbContextHd _context;
        private ICiudadService _servicioCiudad;
        public CiudadesController(DbContextHd context, ICiudadService serviceCiudad)
        {
            _context = context;
            _servicioCiudad = serviceCiudad;
        }

        // ---------------------------------------------------------

        // Get All
        // GET: api/Ciudades
        [HttpGet]
        public IEnumerable<Ciudad> GetCiudades()
        {
            return _context.Ciudades;
        }

        // ---------------------------------------------------------

        // Traer todos VM
        // GET: api/Ciudades/GetAllVM/5
        [HttpGet("[action]/{id}")]
        public async Task<IEnumerable<CiudadVM>> GetAllVM(int id)
        {
            
            var ciudades = await _servicioCiudad.GetAllVM(id);
            return ciudades;

        }

        // ---------------------------------------------------------

        // Traer ciudad
        // Ruta por defecto
        // GET: api/Ciudades/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCiudad([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var ciudad = await _servicioCiudad.GetVM(id);
            return Ok(ciudad);

        }

        // ---------------------------------------------------------

        // Actualizar
        // PUT: api/Ciudades
        [HttpPut]
        public async Task<IActionResult> PutCiudad([FromBody] CiudadUpdateVM modelo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var ciudad = await _servicioCiudad.Update(modelo);
            return Ok(ciudad);

        }

        // ---------------------------------------------------------

        // Añadir
        // POST: api/Ciudades
        [HttpPost]
        public async Task<IActionResult> PostCiudad([FromBody] CiudadCreaVM modelo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var ciudad = await _servicioCiudad.Add(modelo);
            return Ok(ciudad);

        }

        // ---------------------------------------------------------

        // DELETE: api/Ciudades/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCiudad([FromRoute] int id)
        {

            bool elimino = await _servicioCiudad.Delete(id);

            return Ok();
        }

        // ---------------------------------------------------------

        // Traer
        // GET: api/Ciudades/Select
        [HttpGet("[action]/{id}")]
        public async Task<IActionResult> Select(int id)
        {
            string tipo = HttpContext.Request.Query["tipo"].ToString();
            int intTipo = tipo.TrueInt();


            switch (intTipo)
            {
                case 2:
                    var regreso2 = await _servicioCiudad.Select2(id);
                    return Ok(regreso2);

                default:
                    var regreso = await _servicioCiudad.Select(id);
                    return Ok(regreso);
            }
        }

        // ---------------------------------------------------------

        // Actualizar status
        // PUT: api/Ciudades/CambiarStatus
        [HttpPut("[action]")]
        public async Task<IActionResult> CambiarStatus([FromBody] ActivarVM modelo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var regreso = await _servicioCiudad.ActivarDesactivar(modelo.id, modelo.activar);
            //if (!regreso)
            //{
            //    throw new Exception("No actualizó el status de la ciudad");
            //}

            return Ok();
        }

        // ---------------------------------------------------------

        //?
        // A quien referencia
        private bool CiudadExists(int id)
        {
            return _context.Ciudades.Any(e => e.ciudad_id == id);
        }

        // ---------------------------------------------------------
    }
}
