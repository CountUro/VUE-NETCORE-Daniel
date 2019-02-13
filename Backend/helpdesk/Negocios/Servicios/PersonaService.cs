using Datos.Contexto;
using Entidades.Modelo;
using Entidades.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Negocios.Extensiones;

namespace Negocios.Servicios
{
    public interface IPersonaService
    {
        Task<bool> Existe(int id);
        Task<IEnumerable<PersonaVM>> GetAllVM(PersonaFiltro filtro);
        Task<IEnumerable<Persona>> GetAll(PersonaFiltro filtro);
        Task<PersonaVM> GetVM(int id);
        Task<Persona> Get(int id);
        Task<Boolean> Delete(int id);
        Task<Persona> Update(PersonaUpdateVM model);
        Task<Persona> Add(PersonaCreaVM model);
        Task<IEnumerable<SelectVM>> Select();
        Task<IEnumerable<SelectVM2>> Select2();
        string NombreCompleto(string n1, string n2, string a1, string a2);
    }

    public class PersonaService : IPersonaService
    {
        // Base de datos
        private readonly DbContextHd _context;

        // Constructor
        public PersonaService(DbContextHd context)
        {
            _context = context;
        }

        //----------------------------------------------------------------------

        // Agrega desde VM
        public async Task<Persona> Add(PersonaCreaVM model)
        {
            Persona persona = new Persona
            {
                cedula = model.cedula,
                nombre1 = model.nombre1,
                nombre2 = model.nombre2,
                apellido1 = model.apellido1,
                apellido2 = model.apellido2,
                nombre_comp = NombreCompleto(model.nombre1, model.nombre2, model.apellido1, model.apellido2),
                tlf_movil = model.tlf_movil,
                tlf_local = model.tlf_local,
                email = model.email,
                cargo = model.cargo,
                sexo_6_id = model.sexo_6_id
            };

            _context.Personas.Add(persona);
            await _context.SaveChangesAsync();


            return persona;
        }

        //------------------------------------

        //Borra 
        public async Task<bool> Delete(int id)
        {
            if (id < 1)
            {
                throw new Exception("La ID no es valida");
            }

            var borrar = await _context.Personas.FindAsync(id);
            if (borrar == null)
            {
                throw new Exception("No se elimino el registro");

                return false;
            }

            _context.Personas.Remove(borrar);
            await _context.SaveChangesAsync();

            return true;
        }

        //------------------------------------

        public async Task<bool> Existe(int id)
        {
            var existe = await _context.Personas.FindAsync(id);
            return (existe != null) ? true : false;
        }

        //------------------------------------

        public async Task<Persona> Get(int id)
        {
            var devuelve = await _context.Personas.FindAsync(id);
            if (devuelve == null)
            {
                throw new Exception("Registro no encontrado");
            }

            return devuelve;
        }

        //------------------------------------

        public async Task<IEnumerable<Persona>> GetAll(PersonaFiltro filtro)
        {

            int icedula = (filtro.cedula.EsNulaOVacia()) ? 0 : 1;
            int inombre = (filtro.nombre.EsNulaOVacia()) ? 0 : 1;
            int icorreo = (filtro.correo.EsNulaOVacia()) ? 0 : 1;
            int icargo = (filtro.cargo.EsNulaOVacia()) ? 0 : 1;
            int isexo = (filtro.sexo > 0) ? 0 : 1;

            if (icedula == 1) filtro.cedula = filtro.cedula.Trim().ToLower();
            if (inombre == 1) filtro.nombre = filtro.nombre.Trim().ToLower();
            if (icorreo == 1) filtro.correo = filtro.correo.Trim().ToLower();
            if (icargo == 1) filtro.cargo = filtro.cargo.Trim().ToLower();

            var todos = await _context.Personas
                .Where(w =>
                ((icedula == 0) || (w.cedula.ToLower().Contains(filtro.cedula))) &&
                ((inombre == 0) || (w.nombre_comp.ToLower().Contains(filtro.nombre))) &&
                ((icorreo == 0) || (w.email.ToLower().Contains(filtro.correo))) &&
                ((icargo == 0) || (w.cargo.ToLower().Contains(filtro.cargo))) &&
                ((isexo == 0) || (w.sexo_6_id == filtro.sexo))
                ).OrderBy(o => o.nombre1)
                .ToListAsync();


            return todos;
        }

        //------------------------------------

        public async Task<IEnumerable<PersonaVM>> GetAllVM(PersonaFiltro filtro)
        {
            int icedula = (filtro.cedula.EsNulaOVacia()) ? 0 : 1;
            int inombre = (filtro.nombre.EsNulaOVacia()) ? 0 : 1;
            int icorreo = (filtro.correo.EsNulaOVacia()) ? 0 : 1;
            int icargo = (filtro.cargo.EsNulaOVacia()) ? 0 : 1;
            int isexo = (filtro.sexo > 0) ? 1 : 0;

            if (icedula == 1) filtro.cedula = filtro.cedula.Trim().ToLower();
            if (inombre == 1) filtro.nombre = filtro.nombre.Trim().ToLower();
            if (icorreo == 1) filtro.correo = filtro.correo.Trim().ToLower();
            if (icargo == 1) filtro.cargo = filtro.cargo.Trim().ToLower();

            var todos = await _context.Personas
                .Include(i => i.sexo6)
                .Where(w =>
                ((icedula == 0) || (w.cedula.ToLower().Contains(filtro.cedula))) &&
                ((inombre == 0) || (w.nombre_comp.ToLower().Contains(filtro.nombre))) &&
                ((icorreo == 0) || (w.email.ToLower().Contains(filtro.correo))) &&
                ((icargo == 0) || (w.cargo.ToLower().Contains(filtro.cargo))) &&
                ((isexo == 0) || (w.sexo_6_id == filtro.sexo))
                )
                .OrderBy(o => o.nombre1)
                .Select(s => new PersonaVM
                {
                    persona_id = s.persona_id,
                    cedula = s.cedula,
                    nombre1 = s.nombre1,
                    nombre2 = s.nombre2,
                    apellido1 = s.apellido1,
                    apellido2 = s.apellido2,
                    nombre_comp = s.nombre_comp,
                    tlf_movil = s.tlf_movil,
                    tlf_local = s.tlf_local,
                    email = s.email,
                    cargo = s.cargo,
                    sexo_6_id = s.sexo_6_id,
                    sexo6 = s.sexo6.descripcion
                })
                .ToListAsync();

            return todos;
        }

        public async Task<PersonaVM> GetVM(int id)
        {
            var encontrado = await _context.Personas
                .Include(i => i.sexo6)
                .FirstOrDefaultAsync(f => f.persona_id == id);

            PersonaVM personavm = new PersonaVM
            {
                cedula = encontrado.cedula,
                nombre1 = encontrado.nombre1,
                nombre2 = encontrado.nombre2,
                nombre_comp = encontrado.nombre_comp,
                apellido1 = encontrado.apellido1,
                apellido2 = encontrado.apellido2,
                tlf_movil = encontrado.tlf_movil,
                tlf_local = encontrado.tlf_local,
                email = encontrado.email,
                cargo = encontrado.cargo,
                sexo_6_id = encontrado.sexo_6_id,
                sexo6 = encontrado.sexo6.descripcion

            };

            return personavm;
        }

        //------------------------------------

        public string NombreCompleto(string n1, string n2, string a1, string a2)
        {
            string nombreEntero = n1 + ((n2.EsNulaOVacia()) ? "" : " " + n2) + " " + a1 + " " + a2;
            return nombreEntero.Trim();
        }

        //------------------------------------

        public async Task<IEnumerable<SelectVM>> Select()
        {
            var listaSVM = await _context.Personas
                .OrderBy(o => o.nombre_comp)
                .Select(s => new SelectVM
                {
                    value = s.persona_id,
                    text = s.nombre_comp,
                })
                .ToListAsync();

            return listaSVM;
        }

        //------------------------------------

        public async Task<IEnumerable<SelectVM2>> Select2()
        {
            var listaSVM = await _context.Personas
                .OrderBy(o => o.nombre_comp)
                .Select(s => new SelectVM2
                {
                    value = s.persona_id.ToString(),
                    label = s.nombre_comp,
                })
                .ToListAsync();

            return listaSVM;
        }

        //------------------------------------

        public async Task<Persona> Update(PersonaUpdateVM model)
        {
            var actualizar = await _context.Personas.FindAsync(model.persona_id);
            if (actualizar == null)
            {
                throw new Exception("Registro no encontrado");
            }

            actualizar.cedula = model.cedula;
            actualizar.nombre1 = model.nombre1;
            actualizar.nombre2 = model.nombre2;
            actualizar.apellido1 = model.apellido1;
            actualizar.apellido2 = model.apellido2;
            actualizar.nombre_comp =
                NombreCompleto(model.nombre1, model.nombre2, model.apellido1, model.apellido2);
            actualizar.tlf_movil = model.tlf_movil;
            actualizar.tlf_local = model.tlf_local;
            actualizar.email = model.email;
            actualizar.cargo = model.cargo;
            actualizar.sexo_6_id = model.sexo_6_id;

            _context.Personas.Update(actualizar);
            await _context.SaveChangesAsync();

            return actualizar;
        }

        //------------------------------------

    }
}
