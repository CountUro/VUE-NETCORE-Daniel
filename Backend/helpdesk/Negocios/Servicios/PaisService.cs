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
    public interface IPaisService
    {
        Task<bool> Existe(int id);
        Task<IEnumerable<Pais>> GetAll();
        Task<Pais> Get(int id);
        Task<IEnumerable<SelectVM>> Select();
        Task<IEnumerable<SelectVM2>> Select2();
        Task<Boolean> Delete(int id);
        Task<Pais> Update(Pais model);
        Task<Pais> Add(Pais model);
        Task<bool> SalvarLista(List<Pais> lista);
        Task AgregarPais(List<Pais> lista, int id, string nombre, string nombre_comp, string continente, string iso2, string iso3, string cia, string tlf, string internet, string veh, string iso3166);


    }

    public class PaisService : IPaisService
    {
        // Base de datos
        private readonly DbContextHd _context;

        // Constructor
        public PaisService(DbContextHd context)
        {
            _context = context;
        }

        //----------------------------------------------------------------------

        public async Task<Pais> Add(Pais model)
        {
            var pais = await _context.Paises.FirstOrDefaultAsync(x => x.nombre == model.nombre);
            if (pais != null)
            {
                throw new Exception("El nombre ya existe de este pais");
            }

            var pais2 = await _context.Paises.FirstOrDefaultAsync(x => x.pais_id == model.pais_id);
            if (pais2 != null)
            {
                throw new Exception("El id ya existe de este pais");
            }

            _context.Paises.Add(model);
            await _context.SaveChangesAsync();

            return model;
        }

        //------------------------------------

        //////////////////////////////////////////////////////////////////////////
        //           AGREGA - un pais a una lista unica y luego la lista a la BD.
        /////////////////////////////////////////////////////////////////////////
        public async Task AgregarPais(List<Pais> lista, int id, string nombre, string nombre_comp, string continente, string iso2, string iso3, string cia, string tlf, string internet, string veh, string iso3166)
        {
            string nombremin = nombre.ToLower();
            if (ExisteEnLista(lista, id, nombremin))
            {
                return;
            }

            if (await ExisteEnBD(id, nombremin))
            {
                return;
            }

            var newPais = new Pais
            {
                // Pais ID deberia de ser un long? Esta malo?
                pais_id = BuildIdPais(iso3166),
                //pais_id = Convert.ToInt32(id),

                nombre = nombre,
                nombre_completo = nombre_comp,
                continente = continente,
                iso2 = iso2,
                iso3 = iso3,
                iso3166 = iso3166,
                cia = cia,
                telefono = tlf,
                internet = internet,
                vehiculo = veh
            };

            //_context.Paises.Add(paisAgregar);
            //await _context.SaveChangesAsync();

            newPais = CheckProperties(newPais);
            
            lista.Add(newPais);

            return;
        }

        ////
        // Acomoda todos los valores
        ////
        private Pais CheckProperties (Pais insertado)
        {
            insertado.nombre = insertado.nombre.Left(150);
            insertado.nombre_completo = insertado.nombre_completo.Left(150);
            insertado.continente = insertado.continente.Left(20);
            insertado.iso2 = insertado.iso2.Left(4);
            insertado.iso3 = insertado.iso3.Left(4);
            insertado.iso3166 = insertado.iso3166.Left(4);
            insertado.cia = insertado.cia.Left(10);
            insertado.telefono = insertado.telefono.Left(20);
            insertado.internet = insertado.internet.Left(4);
            insertado.vehiculo = insertado.vehiculo.Left(10);

            return insertado;
        }

        ////
        // Revisa si existe en la BD
        ////
        private async Task<bool> ExisteEnBD(int id, string nombre)
        {
            var pais = await _context.Paises.FindAsync(id);
            //return (pais != null) ? true : false;

            if (pais != null)
            {
                return true;
            }

            var pais2 = await _context.Paises.FirstOrDefaultAsync(x => x.nombre == nombre);

            if (pais2 != null)
            {
                return true;
            }

            return false;
        }

        //////////////////////////
        // Crea la ID de forma correcta
        /////////////////////////
        private int BuildIdPais(string iso3166)
        {
            string pais;
            string codigo = iso3166.Trim();
            int largo = iso3166.Trim().Length;

            switch (largo)
            {
                case 1:
                    pais = "100" + codigo;
                    break;
                case 2:
                    pais = "10" + codigo;
                    break;
                case 3:
                    pais = "1" + codigo;
                    break;
                default:
                    pais = codigo;
                    break;
            }

            int result = Convert.ToInt32(pais);

            return result;
        }

        //////////////////////////
        // Revisa si existe en la lista de usuario.
        /////////////////////////
        private bool ExisteEnLista(List<Pais> lista, int id, string nombre)
        {
            nombre.ToLower();

            bool regreso = false;

            foreach (var pais in lista)
            {
                if (pais.pais_id == id && pais.nombre.ToLower() == nombre)
                {
                    regreso = true;
                    break;
                }

            }

            return regreso;
        }

        //------------------------------------

        public async Task<bool> Delete(int id)
        {
            if (id < 1)
            {
                throw new Exception("La ID insertada es incorrecta.");
            }

            var borrar = await _context.Paises.FindAsync(id);
            if (borrar == null)
            {
                throw new Exception("No se ha podido eliminar el registro");
                return false;
            }

            _context.Paises.Remove(borrar);
            await _context.SaveChangesAsync();

            return true;
        }

        //------------------------------------

        public async Task<bool> Existe(int id)
        {
            var encontrar = await _context.Paises.FindAsync(id);
            return (encontrar != null) ? true : false;
        }

        //------------------------------------

        public async Task<Pais> Get(int id)
        {
            var trae = await _context.Paises.FindAsync(id);
            if (trae == null)
            {
                throw new Exception("Registo no encontrado");
            }

            return trae;
        }

        //------------------------------------

        public async Task<IEnumerable<Pais>> GetAll()
        {
            var todos = await _context.Paises.ToListAsync();

            return todos;
        }

        //------------------------------------

        public async Task<bool> SalvarLista(List<Pais> lista)
        {
            _context.Paises.AddRange(lista);
            await _context.SaveChangesAsync();

            // cuando es return false?

            return true;
        }

        //------------------------------------

        public async Task<IEnumerable<SelectVM>> Select()
        {
            var registros = await _context.Paises
                 .OrderBy(o => o.nombre)
                 .Select(s => new SelectVM
                 {
                     value = s.pais_id,
                     text = s.nombre

                 }).ToListAsync();

            return registros;
        }

        //------------------------------------

        public async Task<IEnumerable<SelectVM2>> Select2()
        {
            var registros = await _context.Paises
                 .OrderBy(o => o.nombre)
                 .Select(s => new SelectVM2
                 {
                     value = s.pais_id.ToString(),
                     label = s.nombre

                 }).ToListAsync();

            return registros;
        }

        //------------------------------------

        public async Task<Pais> Update(Pais model)
        {
            if (model.pais_id < 1)
            {
                throw new Exception("La ID insertada es incorrecta.");
            }

            var actualizar = await _context.Paises.FindAsync(model.pais_id);
            if (actualizar == null)
            {
                throw new Exception("Registro no encontrado");
            }

            actualizar.nombre = model.nombre;
            actualizar.nombre_completo = model.nombre_completo;
            actualizar.continente = model.continente;
            actualizar.iso2 = model.iso2;
            actualizar.iso3 = model.iso3;
            actualizar.iso3166 = model.iso3166;
            actualizar.cia = model.cia;
            actualizar.telefono = model.telefono;
            actualizar.internet = model.internet;
            actualizar.vehiculo = model.vehiculo;

            _context.Paises.Update(actualizar);
            await _context.SaveChangesAsync();

            return actualizar;
        }

        //------------------------------------
    }
}
