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
    public class PersonasController : ControllerBase
    {
        // ---------------------------------------------------------

        private readonly DbContextHd _context;
        private IPersonaService _servicioPersona;

        public PersonasController(DbContextHd context, IPersonaService servicePersona)
        {
            _context = context;
            _servicioPersona = servicePersona;
        }

        // ---------------------------------------------------------

        // GET: api/Personas
        [HttpGet]
        public IEnumerable<Persona> GetPersonas()
        {
            return _context.Personas;
        }

        // ---------------------------------------------------------

        // GET: api/Personas/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetPersona([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var traer = await _servicioPersona.Get(id);
            return Ok(traer);
        }

        // ---------------------------------------------------------

        // ACTUALIZAR
        // PUT: api/Personas/5
        [HttpPut]
        public async Task<IActionResult> PutPersona([FromBody] PersonaUpdateVM persona)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var actualizar = await _servicioPersona.Update(persona);
            return Ok(actualizar);
        }

        // ---------------------------------------------------------

        // Añadir
        // POST: api/Personas
        [HttpPost]
        public async Task<IActionResult> PostPersona([FromBody] PersonaCreaVM persona)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var agregar = await _servicioPersona.Add(persona);
            return Ok(agregar);
        }

        // ---------------------------------------------------------

        // DELETE: api/Personas/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePersona([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            bool elimino = await _servicioPersona.Delete(id);

            return Ok();
        }

        // ---------------------------------------------------------

        private bool PersonaExists(int id)
        {
            return _context.Personas.Any(e => e.persona_id == id);
        }

        // ---------------------------------------------------------
        // ---------------------------------------------------------
        // ---------------------------------------------------------

        // GET: api/Personas
        [HttpGet("[action]")]
        public async Task<IEnumerable<PersonaVM>> GetAllVM()
        {
            PersonaFiltro filtro = BuilFiltroPersona();

            var personas = await _servicioPersona.GetAllVM(filtro);
            return personas;
        }

        private PersonaFiltro BuilFiltroPersona()
        {

            string cedula = HttpContext.Request.Query["cedula"].ToString();
            string nombre = HttpContext.Request.Query["nombre"].ToString();
            string correo = HttpContext.Request.Query["correo"].ToString();
            string cargo = HttpContext.Request.Query["cargo"].ToString();
            string sexoStr = HttpContext.Request.Query["sexo"].ToString();

            int IdSexo = sexoStr.TrueInt();

            cedula = (cedula.EsNulaOVacia()) ? string.Empty : cedula.Trim();
            nombre = (nombre.EsNulaOVacia()) ? string.Empty : nombre.Trim();
            correo = (correo.EsNulaOVacia()) ? string.Empty : correo.Trim();
            cargo = (cargo.EsNulaOVacia()) ? string.Empty : cargo.Trim();


            PersonaFiltro filtro = new PersonaFiltro();

            filtro.cedula = cedula;
            filtro.nombre = nombre;
            filtro.correo = correo;
            filtro.cargo = cargo;
            filtro.sexo = IdSexo;

            return filtro;


        }

        // ---------------------------------------------------------

        // GET: api/Personas/Select
        [HttpGet("[action]")]
        public async Task<IActionResult> Select()
        {
            string tipo = HttpContext.Request.Query["tipo"].ToString();

            int intTipo = tipo.TrueInt();

            switch (intTipo)
            {
                case 2:
                    var regreso2 = await _servicioPersona.Select2();
                    return Ok(regreso2);

                default:
                    var regreso = await _servicioPersona.Select();
                    return Ok(regreso);
            }

        }

        // ---------------------------------------------------------
    }
}