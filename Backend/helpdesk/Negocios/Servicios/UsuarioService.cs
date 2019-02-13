using Datos.Contexto;
using Entidades.Modelo;
using Entidades.ViewModels;
using Microsoft.EntityFrameworkCore;
using Negocios.Extensiones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios.Servicios
{
    public interface IUsuarioService
    {
        Task<bool> Existe(int id);
        Task<IEnumerable<UsuarioVM>> GetAllVM(UsuarioFiltro filtro);
        Task<IEnumerable<Usuario>> GetAll(UsuarioFiltro filtro);
        Task<UsuarioVM> GetVM(int id);
        Task<Usuario> Get(int id);
        Task<Boolean> Delete(int id);
        Task<Usuario> Update(UsuarioUpdateVM model);
        Task<Usuario> Add(UsuarioCreaVM model);
        Task<IEnumerable<SelectVM>> Select(string tipo);
        Task<IEnumerable<SelectVM2>> Select2(string tipo);
        Task<bool> CambiarPassword(UsuarioChangePwVM model);
        Task<bool> ActivarDesactivar(int IdUser, bool accion);
        bool VerificarPassword(string password, byte[] passwordHashAlmacenado, byte[] passwordSalt);
        bool ChkPassword(string password, Usuario model);
        void CrearPasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt);
        Task SetLogin(int Id, string token);
        Task<bool> CambiarRol(UsuarioRolVM modelo);
        Task<bool> CambiarProgramador(int IdUser, bool accion);

    }

    public class UsuarioService : IUsuarioService
    {
        // Base de datos
        private readonly DbContextHd _context;

        // Constructor
        public UsuarioService(DbContextHd context)
        {
            _context = context;
        }

        //----------------------------------------------------------------------

        public async Task<bool> ActivarDesactivar(int IdUser, bool accion)
        {
            var usuario = await _context.Usuarios.FindAsync(IdUser);
            if (usuario == null)
            {
                return false;
            }

            usuario.activo = accion;

            _context.Usuarios.Update(usuario);
            await _context.SaveChangesAsync();

            return true;
        }

        //----------------------------------------------------------------------

        public async Task<Usuario> Add(UsuarioCreaVM model)
        {
            var usuarios = _context.Usuarios;
            var correo = model.email.ToLower();

            if (await _context.Usuarios.AnyAsync(u => u.email == correo))
            {
                throw new Exception("El email ya existe");
            }

            CrearPasswordHash(model.password, out byte[] passwordHash, out byte[] passwordSalt);

            Usuario agregar = new Usuario
            {
                rol_id = model.rol_id,
                soporte_id = model.soporte_id,
                pais_id = model.pais_id,
                nombre = model.nombre,
                email = model.email,
                activo = true,
                programador = false,
                tlf_movil = model.tlf_movil,
                tlf_oficina = model.tlf_oficina,
                password_hash = passwordHash,
                password_salt = passwordSalt,
            };

            _context.Usuarios.Add(agregar);
            await _context.SaveChangesAsync();

            return agregar;
        }

        //----------------------------------------------------------------------

        public async Task<bool> CambiarPassword(UsuarioChangePwVM model)
        {
            if (model.usuario_id <= 0)
            {
                throw new Exception("El ID de este usuario es invalido");
            }

            if (model.password != model.passwordConfirm)
            {
                throw new Exception("El password no coincide con el de confirmacion");
            }

            var usuario = await _context.Usuarios.FindAsync(model.usuario_id);

            if (usuario == null)
            {
                throw new Exception("No existe un usuario con esa ID");
            }

            bool okPwOld = ChkPassword(model.passwordold, usuario);

            if (!okPwOld)
            {
                throw new Exception("Este password no coincide con el anterior");
            }

            CrearPasswordHash(model.password, out byte[] passwordHash, out byte[] passwordSalt);
            usuario.password_hash = passwordHash;
            usuario.password_salt = passwordSalt;

            await _context.SaveChangesAsync();

            return true;
        }

        //----------------------------------------------------------------------

        public async Task<bool> CambiarProgramador(int IdUser, bool accion)
        {
            var usuario = await _context.Usuarios.FindAsync(IdUser);
            if (usuario == null)
            {
                return false;
            }

            usuario.programador = accion;

            _context.Usuarios.Update(usuario);
            await _context.SaveChangesAsync();

            return true;
        }

        //----------------------------------------------------------------------

        public async Task<bool> CambiarRol(UsuarioRolVM modelo)
        {
            if (modelo.rol_id < 1 || modelo.peticion_id < 1 || modelo.usuario_id < 1)
            {
                throw new Exception("Alguna de las ID insertadas es invalida");
            }

            //esta peticio_id significa el usuario_id de quien hace la peticion para cambiar el rol
            var usuarioQuePeticiona = await _context.Usuarios.Include(a => a.rol).FirstOrDefaultAsync(f => f.usuario_id == modelo.peticion_id);

            if (usuarioQuePeticiona.rol.nombre != "Administrador")
            {
                throw new Exception("");
            }

            var usuario = await _context.Usuarios.FindAsync(modelo.usuario_id);
            if (usuario == null)
            {
                throw new Exception("La ID del usuario no existe");
            }

            usuario.rol_id = modelo.rol_id;

            _context.Usuarios.Update(usuario);
            await _context.SaveChangesAsync();

            return true;
        }

        //----------------------------------------------------------------------

        public bool ChkPassword(string password, Usuario model)
        {
            bool okPassword = VerificarPassword(password, model.password_hash, model.password_salt);

            return okPassword;
            //return true;
        }

        //----------------------------------------------------------------------

        public void CrearPasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            // ??
            using (var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }
        }

        //----------------------------------------------------------------------

        public async Task<bool> Delete(int id)
        {
            if (id < 1)
            {
                throw new Exception("La ID insertada no es valida.");
            }

            var borrar = await _context.Usuarios.FindAsync(id);
            if (borrar == null)
            {
                throw new Exception("No se eliminó el usuario");
                return false;
            }

            _context.Usuarios.Remove(borrar);
            await _context.SaveChangesAsync();

            return true;
        }

        //----------------------------------------------------------------------

        public async Task<bool> Existe(int id)
        {
            var existe = await _context.Usuarios.FindAsync(id);
            return (existe != null) ? true : false;
        }

        //----------------------------------------------------------------------

        public async Task<Usuario> Get(int id)
        {
            var traer = await _context.Usuarios.FindAsync(id);
            if (traer == null)
            {
                throw new Exception("El usuario no ha sido encontrado");
            }

            return traer;
        }

        //----------------------------------------------------------------------

        public async Task<IEnumerable<Usuario>> GetAll(UsuarioFiltro filtro)
        {
            // ------------------

            int rolBusca = (filtro.rol < 1) ? 0 : 1;

            int soporteBusca = (filtro.soporte < 1) ? 0 : 1;

            int nombreBusca = (filtro.nombre.EsNulaOVacia()) ? 0 : 1;
            if (nombreBusca == 1)
            {
                filtro.nombre = filtro.nombre.Trim().ToLower();
            }

            bool activoBool = (filtro.activo == 1) ? true : false;

            bool programadorBool = (filtro.activo == 1) ? true : false;

            int movilBusca = (filtro.tlf_movil == null) ? 0 : 1;
            if (movilBusca == 1)
            {
                filtro.tlf_movil = filtro.tlf_movil.Trim().ToLower();
            }

            int oficinaBusca = (filtro.tlf_oficina == null) ? 0 : 1;
            if (oficinaBusca == 1)
            {
                filtro.tlf_oficina = filtro.tlf_oficina.Trim().ToLower();
            }

            // ------------------

            //Busqueda
            var todos = await _context.Usuarios.Where(w =>

            ((rolBusca == 0) || (w.rol_id == filtro.rol)) &&
            ((soporteBusca == 0) || (w.soporte_id == filtro.soporte)) &&
            ((nombreBusca == 0) || (w.nombre.ToLower().Contains(filtro.nombre))) &&
            ((filtro.activo == -1) || (w.activo == activoBool)) &&
            ((filtro.programador == -1) || (w.programador == programadorBool)) &&
            ((movilBusca == 0) || (w.tlf_movil.ToLower().Contains(filtro.tlf_movil))) &&
            ((oficinaBusca == 0) || (w.tlf_oficina.ToLower().Contains(filtro.tlf_oficina)))
            ).OrderBy(o => o.nombre)
            .ToListAsync();

            // ------------------

            return todos;
        }

        //----------------------------------------------------------------------

        public async Task<IEnumerable<UsuarioVM>> GetAllVM(UsuarioFiltro filtro)
        {
            // ------------------

            int rolBusca = (filtro.rol < 1) ? 0 : 1;

            int soporteBusca = (filtro.soporte < 1) ? 0 : 1;

            int nombreBusca = (filtro.nombre.EsNulaOVacia()) ? 0 : 1;
            if (nombreBusca == 1)
            {
                filtro.nombre = filtro.nombre.Trim().ToLower();
            }

            bool activoBool = (filtro.activo == 1) ? true : false;

            bool programadorBool = (filtro.activo == 1) ? true : false;

            int movilBusca = (filtro.tlf_movil == null) ? 0 : 1;
            if (movilBusca == 1)
            {
                filtro.tlf_movil = filtro.tlf_movil.Trim().ToLower();
            }

            int oficinaBusca = (filtro.tlf_oficina == null) ? 0 : 1;
            if (oficinaBusca == 1)
            {
                filtro.tlf_oficina = filtro.tlf_oficina.Trim().ToLower();
            }

            // ------------------

            //Busqueda
            var todos = await _context.Usuarios
                .Include(a => a.pais)
                .Include(b => b.soporte)
                .Include(c => c.rol)
                .Where(w =>
            ((rolBusca == 0) || (w.rol_id == filtro.rol)) &&
            ((soporteBusca == 0) || (w.soporte_id == filtro.soporte)) &&
            ((nombreBusca == 0) || (w.nombre.ToLower().Contains(filtro.nombre))) &&
            ((filtro.activo == -1) || (w.activo == activoBool)) &&
            ((filtro.programador == -1) || (w.programador == programadorBool)) &&
            ((movilBusca == 0) || (w.tlf_movil.ToLower().Contains(filtro.tlf_movil))) &&
            ((oficinaBusca == 0) || (w.tlf_oficina.ToLower().Contains(filtro.tlf_oficina)))
            ).OrderBy(o => o.nombre)
            .Select(s => new UsuarioVM
            {
                usuario_id = s.usuario_id,
                rol_id = s.rol_id,
                rol = s.rol.nombre,
                pais_id = s.pais_id,
                pais = s.pais.nombre,
                soporte_id = s.soporte_id,
                soporte = s.soporte.nombre,
                nombre = s.nombre,
                email = s.email,
                activo = s.activo,
                programador = s.programador,
                tlf_movil = s.tlf_movil,
                tlf_oficina = s.tlf_oficina,
                f_login = s.f_login // Este login es el que manda el filtro?
            })
            .ToListAsync();

            // ------------------

            return todos;
        }

        //----------------------------------------------------------------------

        public async Task<UsuarioVM> GetVM(int id)
        {
            var traer = await _context.Usuarios
                                .Include(a => a.pais)
                .Include(b => b.soporte)
                .Include(c => c.rol)
                .FirstOrDefaultAsync(f => f.usuario_id == id);

            if (traer == null)
            {
                throw new Exception("Usuario no encontrado");
            }

            UsuarioVM modelo = new UsuarioVM
            {
                usuario_id = traer.usuario_id,
                rol_id = traer.rol_id,
                rol = traer.rol.nombre,
                pais_id = traer.pais_id,
                pais = traer.pais.nombre,
                soporte_id = traer.soporte_id,
                soporte = traer.soporte.nombre,
                nombre = traer.nombre,
                email = traer.email,
                activo = traer.activo,
                programador = traer.programador,
                tlf_movil = traer.tlf_movil,
                tlf_oficina = traer.tlf_oficina,
                f_login = traer.f_login
            };

            return modelo;
        }

        //----------------------------------------------------------------------

        public async Task<IEnumerable<SelectVM>> Select(string tipo)
        {
            string tipoUsuario = tipo.Trim().ToUpper();
            switch (tipoUsuario)
            {
                case "ADMINISTRADOR":
                case "CONSULTOR":
                case "USUARIO":
                case "CXC":
                    return await RolVMs1(tipoUsuario);
                    break;

                case "P":
                    return await ProgramadoresVM1();
                    break;

                default:
                    return await TodosVM1();
                    break;
            }
        }

        // Buscar por rol
        private async Task<IEnumerable<SelectVM>> RolVMs1(string tipoUsuario)
        {
            var modelos = await _context.Usuarios
                .Include(i => i.rol)
                .Where(w => (w.activo == true) &&
                (w.rol.nombre.ToLower() == tipoUsuario))
                .OrderBy(o => o.nombre)
                .Select(s => new SelectVM
                {
                    value = s.usuario_id,
                    text = s.nombre

                }).ToListAsync();

            return modelos;
        }

        // Buscar por Programador
        private async Task<IEnumerable<SelectVM>> ProgramadoresVM1()
        {
            var modelos = await _context.Usuarios.Where(w =>
            w.activo == true && w.programador == true)
            .OrderBy(o => o.nombre)
            .Select(s => new SelectVM
            {
                value = s.usuario_id,
                text = s.nombre

            }).ToListAsync();

            return modelos;
        }

        // Buscar Todos
        private async Task<IEnumerable<SelectVM>> TodosVM1()
        {
            var todos = await _context.Usuarios
                .Where(w => w.activo == true)
                .OrderBy(o => o.nombre)
                .Select(s => new SelectVM
                {
                    value = s.usuario_id,
                    text = s.nombre

                }).ToListAsync();

            return todos;
        }

        //----------------------------------------------------------------------

        public async Task<IEnumerable<SelectVM2>> Select2(string tipo)
        {
            
            string tipoUsuario = tipo.Trim().ToUpper();
            switch (tipoUsuario)
            {
                case "ADMINISTRADOR":
                case "CONSULTOR":
                case "USUARIO":
                case "CXC":
                    return await RolVMs2(tipoUsuario);
                    break;

                case "P":
                    return await ProgramadoresVM2();
                    break;

                default:
                    return await TodosVM2();
                    break;
            }
        }

        // Buscar por rol
        private async Task<IEnumerable<SelectVM2>> RolVMs2(string tipoUsuario)
        {
            var modelos = await _context.Usuarios
                .Include(i => i.rol)
                .Where(w => (w.activo == true) &&
                (w.rol.nombre.ToLower() == tipoUsuario))
                .OrderBy(o => o.nombre)
                .Select(s => new SelectVM2
                {
                    value = s.usuario_id.ToString(),
                    label = s.nombre

                }).ToListAsync();

            return modelos;
        }

        // Buscar por Programador
        private async Task<IEnumerable<SelectVM2>> ProgramadoresVM2()
        {
            var modelos = await _context.Usuarios.Where(w =>
            w.activo == true && w.programador == true)
            .OrderBy(o => o.nombre)
            .Select(s => new SelectVM2
            {
                value = s.usuario_id.ToString(),
                label = s.nombre

            }).ToListAsync();

            return modelos;
        }

        // Buscar Todos
        private async Task<IEnumerable<SelectVM2>> TodosVM2()
        {
            var todos = await _context.Usuarios
                .Where(w => w.activo == true)
                .OrderBy(o => o.nombre)
                .Select(s => new SelectVM2
                {
                    value = s.usuario_id.ToString(),
                    label = s.nombre

                }).ToListAsync();

            return todos;
        }

        //----------------------------------------------------------------------

        public async Task SetLogin(int Id, string token)
        {
            var usuario = await _context.Usuarios.FindAsync(Id);
            if (usuario == null)
            {
                throw new Exception("No se ha encontrado el usuario");
            }

            usuario.token = token;
            usuario.f_login = DateTime.Now;

            _context.Usuarios.Update(usuario);
            await _context.SaveChangesAsync();
            return;

        }

        //----------------------------------------------------------------------

        public async Task<Usuario> Update(UsuarioUpdateVM model)
        {
            var registro = await _context.Usuarios.FindAsync(model.usuario_id);
            if (registro == null)
            {
                throw new Exception("Usuario no encontrado");
            }
            if (model.email != registro.email)
            {
                var reg2 = await _context.Usuarios.FirstOrDefaultAsync(x => x.usuario_id != model.usuario_id && x.email == model.email);
                if (reg2 != null)
                {
                    throw new Exception("El correo existe en otro usuario");
                }

                registro.email = model.email;
            }

            registro.rol_id = model.rol_id;
            registro.pais_id = model.pais_id;
            registro.soporte_id = model.soporte_id;
            registro.nombre = model.nombre;
            registro.tlf_movil = model.tlf_movil;
            registro.tlf_oficina = model.tlf_oficina;

            _context.Usuarios.Update(registro);
            await _context.SaveChangesAsync();

            return registro;
        }

        //----------------------------------------------------------------------

        public bool VerificarPassword(string password, byte[] passwordHashAlmacenado, byte[] passwordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512(passwordSalt))
            {
                var passwordHashNuevo = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                return new ReadOnlySpan<byte>(passwordHashAlmacenado).SequenceEqual(new ReadOnlySpan<byte>(passwordHashNuevo));
            }
        }

        //----------------------------------------------------------------------


    }
}
