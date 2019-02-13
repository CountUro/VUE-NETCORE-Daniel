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
    public class MunicipiosController : ControllerBase
    {
        // ---------------------------------------------------------

        private readonly DbContextHd _context;

        private IMunicipioService _servicioMunicipio;

        public MunicipiosController(DbContextHd context, IMunicipioService servicioMunicipio)
        {
            _context = context;
            _servicioMunicipio = servicioMunicipio;
        }

        // ---------------------------------------------------------

        // Traer Todos (sin uso?)
        // GET: api/Municipios
        [HttpGet]
        public IEnumerable<Municipio> GetMunicipios()
        {
            return _context.Municipios;
        }

        // ---------------------------------------------------------

        // Traer un municipio segun su ID
        // GET: api/Municipios/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetMunicipio([FromRoute] int id)
        {
            // Esto que hace??
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var municipio = await _servicioMunicipio.Get(id);
            return Ok(municipio);
        }

        // ---------------------------------------------------------

        // Actualizar
        // PUT: api/Municipios/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMunicipio([FromBody]MunicipioUpdateVM modelo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

              var elMunicipio = await _servicioMunicipio.Update(modelo);

            return Ok(elMunicipio);
        }

        // ---------------------------------------------------------

        // POST: api/Municipios
        [HttpPost]
        public async Task<IActionResult> PostMunicipio([FromBody] MunicipioCreaVM municipio)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var agregar = await _servicioMunicipio.Add(municipio);
            return Ok(agregar);
        }

        // ---------------------------------------------------------

        // DELETE: api/Municipios/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMunicipio([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await _servicioMunicipio.Delete(id);
            return Ok();
        }

        // ---------------------------------------------------------

        private bool MunicipioExists(int id)
        {
            return _context.Municipios.Any(e => e.municipio_id == id);
        }

        // ---------------------------------------------------------
        // ---------------------------------------------------------
        // ---------------------------------------------------------

        // GET: api/Municipios/GetAllVM/5
        [HttpGet("[action]/{id}")]
        public async Task<IEnumerable<MunicipioVM>> GetAllVM(int id)
        {
            var municipios = await _servicioMunicipio.GetAllVM(id);
            return municipios;

        }

        // ---------------------------------------------------------

        // GET: api/Municipios/Select
        [HttpGet("[action]/{id}")]
        public async Task<IActionResult> Select(int id)
        {
            string tipo = HttpContext.Request.Query["tipo"].ToString();

            int intTipo = tipo.TrueInt();


            switch (intTipo)
            {
                case 2:
                    var regreso2 = await _servicioMunicipio.Select2(id);
                    return Ok(regreso2);

                default:
                    var regreso = await _servicioMunicipio.Select(id);
                    return Ok(regreso);
            }


        }

        // ---------------------------------------------------------
    }
}