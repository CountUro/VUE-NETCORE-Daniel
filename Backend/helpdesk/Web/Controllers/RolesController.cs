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
using Microsoft.AspNetCore.Authorization;
using Negocios.Extensiones;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RolesController : ControllerBase
    {
        // ---------------------------------------------------------

        private readonly DbContextHd _context;
        private IRolService _servicioRol;

        public RolesController(DbContextHd context, IRolService serviceRol)
        {
            _context = context;
            _servicioRol = serviceRol;
        }

        // ---------------------------------------------------------

        // GET: api/Roles
        [HttpGet]
        public IEnumerable<Rol> GetRoles()
        {
            throw new Exception();
            return _context.Roles;
        }

        // ---------------------------------------------------------

        // GET: api/Roles/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetRol([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var rol = _servicioRol.Get(id);

            return Ok(rol);
        }

        // ---------------------------------------------------------

        // PUT: api/Roles/5
        [HttpPut]
        public async Task<IActionResult> PutRol([FromBody]Rol rol)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var actualizar = await _servicioRol.Update(rol);
            return Ok(actualizar);
        }

        // ---------------------------------------------------------

        // POST: api/Roles
        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> PostRol([FromBody] RolCreaVM rol)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var regreso = await _servicioRol.Add(rol);
            return Ok(regreso);

        }

        // ---------------------------------------------------------

        // DELETE: api/Roles/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRol([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await _servicioRol.Delete(id);

            return Ok();
        }

        // ---------------------------------------------------------

        private bool RolExists(int id)
        {
            return _context.Roles.Any(e => e.rol_id == id);
        }

        // ---------------------------------------------------------
        // ---------------------------------------------------------
        // ---------------------------------------------------------

        // GET: api/Roles/Select
        [HttpGet("[action]")]
        public async Task<IActionResult> Select()
        {
            string tipo = HttpContext.Request.Query["tipo"].ToString();
            int intTipo = tipo.TrueInt();


            switch (intTipo)
            {
                case 2:
                    var regreso2 = await _servicioRol.Select2();
                    return Ok(regreso2);

                default:
                    var regreso = await _servicioRol.Select();
                    return Ok(regreso);
            }
        }

        // ---------------------------------------------------------
    }
}