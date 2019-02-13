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
    public class SucursalesController : ControllerBase
    {
        // ---------------------------------------------------------

        private readonly DbContextHd _context;
        private ISucursalService _servicioSucursal;

        public SucursalesController(DbContextHd context, ISucursalService servicioSucursal)
        {
            _context = context;
            _servicioSucursal = servicioSucursal;
        }

        // ---------------------------------------------------------

        // GET: api/Sucursales/GetAllVM/5
        [HttpGet("{id}")]
        public async Task<IEnumerable<SucursalVM>> GetAllVM([FromRoute] int id)
        {
            var regreso = await _servicioSucursal.GetAllVM(id);
            return regreso;
        }

        // ---------------------------------------------------------

        // GET: api/Sucursales/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetSucursal([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var sucursal = await _servicioSucursal.Get(id);
            return Ok(sucursal);
        }

        // ---------------------------------------------------------

        // UPDATE
        // PUT: api/Sucursales/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSucursal([FromBody] SucursalUpdateVM sucursal)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var actualizar = await _servicioSucursal.Update(sucursal);
            return Ok(actualizar);
        }

        // ---------------------------------------------------------

        // ADD
        // POST: api/Sucursales
        [HttpPost]
        public async Task<IActionResult> PostSucursal([FromBody] SucursalCreaVM sucursal)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var agregar = await _servicioSucursal.Add(sucursal);
            return Ok(agregar);
        }

        // ---------------------------------------------------------

        // DELETE: api/Sucursales/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSucursal([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var borrado = await _servicioSucursal.Delete(id);
            return Ok();
        }

        // ---------------------------------------------------------

        private bool SucursalExists(int id)
        {
            return _context.Sucursales.Any(e => e.sucursal_id == id);
        }

        // ---------------------------------------------------------
        // ---------------------------------------------------------
        // ---------------------------------------------------------

        // GET: api/Sucursales/Select
        [HttpGet("[action]/{id}")]
        public async Task<IActionResult> Select(int id)
        {
            string tipo = HttpContext.Request.Query["tipo"].ToString();
            int intTipo = tipo.TrueInt();

            switch (intTipo)
            {
                case 2:
                    var regreso2 = await _servicioSucursal.Select2(id);
                    return Ok(regreso2);
                default:
                    var regreso = await _servicioSucursal.Select(id);
                    return Ok(regreso);
            }
        }

        // ---------------------------------------------------------
    }
}