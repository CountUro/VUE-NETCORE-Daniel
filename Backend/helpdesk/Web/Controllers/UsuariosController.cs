using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Datos.Contexto;
using Entidades.Modelo;
using Microsoft.Extensions.Configuration;
using Negocios.Servicios;
using Entidades.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Negocios.Extensiones;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;
using System.Text;

namespace Web.Controllers
{
    [Authorize]
    //[Authorize(Roles = "Administrador")]
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        // ---------------------------------------------------------

        private readonly DbContextHd _context;
        private readonly IConfiguration _config;
        private IUsuarioService _usuarioService;

        public UsuariosController(DbContextHd context, IConfiguration config, IUsuarioService userService)
        {
            _context = context;
            _config = config;
            _usuarioService = userService;
        }

        // ---------------------------------------------------------

        // GET: api/Usuarios
        [HttpGet]
        public async Task<IEnumerable<UsuarioVM>> GetUsuarios()
        {
            string rol = HttpContext.Request.Query["rol"].ToString();
            string soporte = HttpContext.Request.Query["soporte"].ToString();
            string nombre = HttpContext.Request.Query["nombre"].ToString();
            string correo = HttpContext.Request.Query["correo"].ToString();
            string movil = HttpContext.Request.Query["movil"].ToString();
            string oficina = HttpContext.Request.Query["oficina"].ToString();
            string activoStr = HttpContext.Request.Query["activo"].ToString();
            string programadorStr = HttpContext.Request.Query["programador"].ToString();

            int IdRol = rol.TrueInt();
            int IdSoporte = soporte.TrueInt();

            int activo = activoStr.TrueInt();
            int programador = programadorStr.TrueInt();
            nombre = (nombre.EsNulaOVacia()) ? string.Empty : nombre.Trim();
            correo = (correo.EsNulaOVacia()) ? string.Empty : correo.Trim();
            movil = (movil.EsNulaOVacia()) ? string.Empty : movil.Trim();
            oficina = (oficina.EsNulaOVacia()) ? string.Empty : oficina.Trim();

            UsuarioFiltro filtro = new UsuarioFiltro();

            filtro.rol = IdRol;
            filtro.soporte = IdSoporte;
            filtro.nombre = nombre;
            filtro.email = correo;
            filtro.tlf_movil = movil;
            filtro.tlf_oficina = oficina;
            filtro.activo = activo;
            filtro.programador = programador;

            var regreso = await _usuarioService.GetAllVM(filtro);
            return regreso;

        }

        // ---------------------------------------------------------

        // GET: api/Usuarios/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetUsuario([FromRoute] int id)
        {
            if (id < 1)
            {
                return BadRequest(ModelState);
            }

            var regreso = await _usuarioService.GetVM(id);
            return Ok(regreso);

        }

        // ---------------------------------------------------------

        // PUT: api/Usuarios
        [Authorize(Roles = "Administrador")]
        [HttpPut]
        public async Task<IActionResult> PutUsuario([FromBody] UsuarioUpdateVM modelo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }


            var user = await _usuarioService.Update(modelo);

            var regreso = await _usuarioService.GetVM(user.usuario_id);
            return Ok(regreso);


        }

        // ---------------------------------------------------------

        // POST: api/Usuarios
        //[Authorize(Roles = "Administrador")]
        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> PostUsuario([FromBody] UsuarioCreaVM model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }


            var user = await _usuarioService.Add(model);
            var regreso = await _usuarioService.GetVM(user.usuario_id);

            return Ok(regreso);


        }

        // ---------------------------------------------------------

        // DELETE: api/Usuarios/5
        //[Authorize(Roles = "Administrador")]
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUsuario([FromRoute] int id)
        {
            bool elimino = await _usuarioService.Delete(id);
            //if (!elimino)
            //{
            //    throw new Exception("No se eliminó el usuario");
            //}

            return Ok();
        }

        // ---------------------------------------------------------

        // PUT: api/Usuarios/CambiarRol
        [Authorize(Roles = "Administrador")]
        [HttpPut("[action]")]
        public async Task<IActionResult> CambiarRol([FromBody] UsuarioRolVM model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            //if (model.peticion_id <= 0 || model.usuario_id <= 0 || model.rol_id <= 0)
            //{
            //    return BadRequest();
            //}


            string Idstr = HttpContext.GetClaim("usuarioId");
            //string Rolstr = HttpContext.GetClaim("rol");

            //if (Idstr.EsNulaOVacia())
            //{
            //    throw new Exception("No existe el Id del Usuario");
            //}
            int IdUSer = int.Parse(Idstr);

            if (IdUSer != model.peticion_id)
            {
                throw new Exception("El Id de la petición no coincide con el usuario conectado");
            }

            //if (Rolstr != "Administrador")
            //{
            //    throw new Exception("Esta opción solo la puede realizar un usuario administrador");
            //}

            bool regreso = await _usuarioService.CambiarRol(model);

            return Ok();


        }

        // ---------------------------------------------------------

        // PUT: api/Usuarios/CambiarPwAdm
        [Authorize(Roles = "Administrador")]
        [HttpPut("[action]")]
        public async Task<IActionResult> CambiarPwAdm([FromBody] UsuarioChangePwAdminVM model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (model.usuario_id <= 0)
            {
                return BadRequest();
            }

            string Idstr = HttpContext.GetClaim("usuarioId");
            string Rolstr = HttpContext.GetClaim("rol");

            if (Idstr.EsNulaOVacia())
            {
                throw new Exception("No existe el Id del Usuario");
            }
            int IdUSer = int.Parse(Idstr);

            if (IdUSer != model.user_id_conectado)
            {
                throw new Exception("El Id de la petición no coincide con el usuario conectado");
            }

            if (Rolstr != "Administrador")
            {
                throw new Exception("Esta opción solo la puede realizar un usuario administrador");
            }


            var userconnect = await _context.Usuarios.Include(i => i.rol).FirstOrDefaultAsync(x => x.usuario_id == model.user_id_conectado);
            if (userconnect == null)
            {
                return NotFound();
            }

            if (userconnect.rol.nombre != "Administrador")
            {
                throw new Exception("El usuario conectado no es Administrador");
            }

            var user = await _context.Usuarios.FirstOrDefaultAsync(x => x.usuario_id == model.usuario_id);
            if (user == null)
            {
                return NotFound();
            }

            _usuarioService.CrearPasswordHash(model.password, out byte[] passwordHash, out byte[] passwordSalt);
            user.password_hash = passwordHash;
            user.password_salt = passwordSalt;



            await _context.SaveChangesAsync();


            return Ok();
        }

        // ---------------------------------------------------------

        // PUT: api/Usuarios/CambiarPw

        [HttpPut("[action]")]
        public async Task<IActionResult> CambiarPw([FromBody] UsuarioChangePwVM model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (model.usuario_id <= 0)
            {
                return BadRequest();
            }

            string Idstr = HttpContext.GetClaim("usuarioId");

            if (Idstr.EsNulaOVacia())
            {
                throw new Exception("No existe el Id del Usuario");
            }
            int IdUSer = int.Parse(Idstr);

            if (IdUSer != model.usuario_id)
            {
                throw new Exception("El Id del Usuario no coincide con el usuario conectado");
            }

            if (model.password != model.passwordConfirm)
            {
                return BadRequest("Los password no coinciden");
            }

            var user = await _context.Usuarios.FirstOrDefaultAsync(x => x.usuario_id == model.usuario_id);
            if (user == null)
            {
                return NotFound();
            }

            bool okPwOld = _usuarioService.ChkPassword(model.passwordold, user);

            if (okPwOld == false)
            {
                return BadRequest("El Password anterior no coincide");
            }

            _usuarioService.CrearPasswordHash(model.password, out byte[] passwordHash, out byte[] passwordSalt);
            user.password_hash = passwordHash;
            user.password_salt = passwordSalt;


            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                // guardar el error
                return BadRequest();
            }

            return Ok();
        }

        // ---------------------------------------------------------

        // POST: api/Usuarios/Login
        [AllowAnonymous]
        [HttpPost("[action]")]
        public async Task<IActionResult> Login([FromBody] LoginVM model)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                string email = model.email.ToLower();

                var user = await _context.Usuarios
                            .Where(a => a.activo == true)
                            .Include(y => y.rol)
                            .FirstOrDefaultAsync(x => x.email == email);

                if (user == null)
                {
                    return NotFound();
                }

                bool okPassword = _usuarioService.VerificarPassword(model.password, user.password_hash, user.password_salt);

                if (!okPassword)
                {
                    return BadRequest("Las Credenciales no son correctas");
                };

                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.NameIdentifier, user.usuario_id.ToString()),
                    new Claim(ClaimTypes.Email, email),
                    new Claim(ClaimTypes.Role, user.rol.nombre ),
                    new Claim("usuarioId", user.usuario_id.ToString() ),
                    new Claim("rol", user.rol.nombre ),
                    new Claim("nombre", user.nombre ),
                    new Claim("correo", user.email ),
                    new Claim("rol_id", user.rol_id.ToString() ),
                    new Claim("pais_id", user.pais_id.ToString() )
                };

                var regToken = new { token = GenerarToken(claims) };

                await _usuarioService.SetLogin(user.usuario_id, regToken.token);

                return Ok(regToken);

                //return Ok(
                //        new { token = GenerarToken(claims) }
                //        );

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private string GenerarToken(List<Claim> claims)
        {
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
              _config["Jwt:Issuer"],
              _config["Jwt:Issuer"],
              expires: DateTime.Now.AddMinutes(30),
              signingCredentials: creds,
              claims: claims);

            return new JwtSecurityTokenHandler().WriteToken(token);

        }

        // ---------------------------------------------------------

        [HttpGet("[action]")]
        public async Task<IActionResult> PostLogin()
        {

            string Idstr = HttpContext.GetClaim("usuarioId");
            if (Idstr.EsNulaOVacia())
            {
                throw new Exception("No existe el Id del Usuario");
            }
            int IdUSer = int.Parse(Idstr);
            var user = await _usuarioService.GetVM(IdUSer);
            if (user == null)
            {
                throw new Exception("No encontro el usuario");
            }
            return Ok(user);

        }

        // ---------------------------------------------------------

        // GET: api/Personas/Select
        [HttpGet("[action]")]
        public async Task<IActionResult> Select()
        {

            string tipo = HttpContext.Request.Query["tipo"].ToString();
            if (tipo.EsNulaOVacia()) tipo = "";
            string tipoSelect = HttpContext.Request.Query["tipoSelect"].ToString();
            int intTipo = tipo.TrueInt();

            switch (intTipo)
            {
                case 2:
                    var regreso2 = await _usuarioService.Select2(tipo);
                    return Ok(regreso2);

                default:
                    var regreso = await _usuarioService.Select(tipo);
                    return Ok(regreso);
            }
        }

        // ---------------------------------------------------------

        // PUT: api/Usuarios/CambiarStatus
        [HttpPut("[action]")]
        public async Task<IActionResult> CambiarStatus([FromBody] ActivarVM modelo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var regreso = await _usuarioService.ActivarDesactivar(modelo.id, modelo.activar);
            if (!regreso)
            {
                throw new Exception("No actualizó el status de la ciudad");
            }
            return Ok();

        }

        // ---------------------------------------------------------

        // PUT: api/Usuarios/CambiarProgramador
        [HttpPut("[action]")]
        public async Task<IActionResult> CambiarProgramador([FromBody] ActivarVM modelo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }


            var regreso = await _usuarioService.CambiarProgramador(modelo.id, modelo.activar);
            if (!regreso)
            {
                throw new Exception("No actualizó el status del programador");
            }
            return Ok();

        }

        // ---------------------------------------------------------

        private bool UsuarioExists(int id)
        {
            return _context.Usuarios.Any(e => e.usuario_id == id);
        }

        // ---------------------------------------------------------



        // ---------------------------------------------------------
    }
}