using Datos.Contexto;
using Entidades.Modelo;
using Entidades.ViewModels;
//using Entidades.VerModelo;
using Microsoft.EntityFrameworkCore;
using Negocios.Extensiones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Negocios.Servicios.CiaService;


namespace Negocios.Servicios
{
    public interface IRolService
    {
        Task<bool> Existe(int id);
        Task<IEnumerable<Rol>> GetAll();
        Task<Rol> Get(int id);
        Task<Boolean> Delete(int id);
        Task<Rol> Update(Rol model);
        Task<Rol> Add(RolCreaVM model);
        Task<IEnumerable<SelectVM>> Select();
        Task<IEnumerable<SelectVM2>> Select2();

    }

    public class RolService : IRolService
    {
        // Base de datos
        private readonly DbContextHd _context;

        // Constructor
        public RolService(DbContextHd context)
        {
            _context = context;
        }

        //----------------------------------------------------------------------

        public async Task<Rol> Add(RolCreaVM model)
        {
            var encontrado = await _context.Roles.Where(w => w.nombre == model.nombre).FirstOrDefaultAsync();
            if (encontrado != null)
            {
                throw new Exception("Este rol ya existe");
            }

            Rol rol = new Rol { nombre = model.nombre };
            _context.Roles.Add(rol);

            await _context.SaveChangesAsync();
            

            return rol;
        }

        //----------------------------------------------------------------------

        public async Task<bool> Delete(int id)
        {
            if (id < 1)
            {
                throw new Exception("Id No existe");
            }

            bool borrado = true;
            var encontrar = await _context.Roles.FindAsync(id);
            if (encontrar == null)
            {
                throw new Exception("No eliminó el registro");
                borrado = false;
                return borrado;
            }

            _context.Roles.Remove(encontrar);
            await _context.SaveChangesAsync();

            return borrado;
        }

        //----------------------------------------------------------------------

        public async Task<bool> Existe(int id)
        {
            bool existe = true;
            var encontrar = await _context.Roles.FindAsync(id);
            if (encontrar == null)
            {
                existe = false;
                return existe;
            }

            return existe;
        }

        //----------------------------------------------------------------------

        public async Task<Rol> Get(int id)
        {
            var encontrar = await _context.Roles.FindAsync(id);
            if (encontrar == null)
            {
                throw new Exception("Registro no encontrado");
            }

           

            return encontrar;
        }

        //----------------------------------------------------------------------

        public async Task<IEnumerable<Rol>> GetAll()
        {
            var todos = await _context.Roles.OrderBy(o=>o.nombre).ToListAsync();

            return todos;
        }

        //----------------------------------------------------------------------

        public async Task<IEnumerable<SelectVM>> Select()
        {
            var rolVms = await _context.Roles
                .OrderBy(o => o.nombre)
                .Select(s => new SelectVM
            {
                value = s.rol_id,
                text = s.nombre
                
            }).ToListAsync();

            return rolVms;
        }

        //----------------------------------------------------------------------

        public async Task<IEnumerable<SelectVM2>> Select2()
        {
            var rolVms = await _context.Roles
                .OrderBy(o => o.nombre)
                .Select(s => new SelectVM2
            {
                value = s.rol_id.ToString(),
                label = s.nombre

            }).ToListAsync();

            return rolVms;
        }

        //----------------------------------------------------------------------

        public async Task<Rol> Update(Rol model)
        {
            if (model.rol_id < 1)
            {
                throw new Exception("La ID insertada es incorrecta.");
            }

            var actualizar = await _context.Roles.FindAsync(model.rol_id);
            if (actualizar == null)
            {
                throw new Exception("Registro no encontrado");
            }

            actualizar.nombre = model.nombre;

            _context.Roles.Update(actualizar);

            await _context.SaveChangesAsync();
            return actualizar;
        }

        //----------------------------------------------------------------------

    }
}
