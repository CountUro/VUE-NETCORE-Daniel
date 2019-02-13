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
    public interface IMunicipioService
    {
        Task<bool> Existe(int id);
        Task<IEnumerable<MunicipioVM>> GetAllVM(int IdEstado);
        Task<IEnumerable<Municipio>> GetAll(int IdEstado);
        Task<MunicipioVM> GetVM(int id);
        Task<Municipio> Get(int id);
        Task<Boolean> Delete(int id);
        Task<Municipio> Update(MunicipioUpdateVM model);
        Task<Municipio> Add(MunicipioCreaVM model);
        Task<IEnumerable<SelectVM>> Select(int estado);
        Task<IEnumerable<SelectVM2>> Select2(int estado);
        Municipio CheckPropiedades(Municipio data);
        Task SalvarLista(List<Municipio> lista);
        Task AgregaMunicipio(List<Municipio> lista, int estadoid, string nombre, string nomestado);

    }

    public class MunicipioService : IMunicipioService
    {
        // Base de datos
        private readonly DbContextHd _context;

        // Constructor
        public MunicipioService(DbContextHd context)
        {
            _context = context;
        }

        //----------------------------------------------------------------------

        //----------
        // ADD
        //----------
        public async Task<Municipio> Add(MunicipioCreaVM model)
        {
            Municipio municipio = new Municipio
            {
                estado_id = model.estado_id,
                nombre = model.nombre,
                codigo = model.codigo,
                referencia = model.referencia,
            };

            municipio = CheckPropiedades(municipio);

            _context.Municipios.Add(municipio);
            await _context.SaveChangesAsync();

            return municipio;
        }

        //------------------------------------

        public Municipio CheckPropiedades(Municipio data)
        {
            data.nombre = data.nombre.Left(100);
            data.codigo = data.codigo.Left(6);
            data.referencia = data.referencia.Left(6);
            return data;
        }

        //-----------

        public async Task SalvarLista(List<Municipio> lista)
        {
            _context.Municipios.AddRange(lista);
            await _context.SaveChangesAsync();
            return;
        }

        //-----------

        private bool ExisteEnLista(List<Municipio> lista, int estadoid, string nombre)
        {
            bool regreso = false;
            foreach (var mun in lista)
            {
                if (mun.estado_id == estadoid && mun.nombre.ToLower() == nombre)
                {
                    regreso = true;
                    break;
                }
            }
            return regreso;
        }

        private async Task<bool> ExisteEnBd(int estadoid, string nombre)
        {
            var registro = await _context.Municipios.FirstOrDefaultAsync(x => x.estado_id == estadoid && x.nombre.ToLower() == nombre);

            return (registro != null) ? true : false;
        }

        public async Task AgregaMunicipio(List<Municipio> lista, int estadoid, string nombre, string nomestado)
        {
            nombre = nombre.ToLower();
            if (ExisteEnLista(lista, estadoid, nombre))
            {
                return;
            }

            if (await ExisteEnBd(estadoid, nombre))
            {
                return;
            }


            Municipio mun = new Municipio
            {
                estado_id = estadoid,
                nombre = nombre
            };

            lista.Add(mun);
            return;
            

        }

        //------------------------------------

        public async Task<bool> Delete(int id)
        {
            if (id < 1)
            {
                throw new Exception("La ID insertada es incorrecta.");
            }

            var modelo = await _context.Municipios.FindAsync(id);
            if (modelo == null)
            {
                throw new Exception("No eliminó el registro");
                return false;
            }

            _context.Municipios.Remove(modelo);
            await _context.SaveChangesAsync();

            return true;
        }

        //------------------------------------

        public async Task<bool> Existe(int id)
        {

            var modelo = await _context.Municipios.FindAsync(id);

            return (modelo != null) ? true : false;

        }

        //------------------------------------

        public async Task<Municipio> Get(int id)
        {
            if (id < 1)
            {
                throw new Exception("No existe el Id del Municipio");
            }

            var modelo = await _context.Municipios.FindAsync(id);
            if (modelo == null)
            {
                throw new Exception("Registro no encontrado");
            }

            return modelo;
        }

        //------------------------------------

        public async Task<IEnumerable<Municipio>> GetAll(int IdEstado)
        {
            var modelos = await _context.Municipios
                .Where(w => w.estado_id == IdEstado)
                .OrderBy(o => o.nombre)
                .ToListAsync();

            return modelos;
        }

        //------------------------------------

        public async Task<IEnumerable<MunicipioVM>> GetAllVM(int IdEstado)
        {
            if (IdEstado < 1)
            {
                throw new Exception("No existe el Id del Estado");
            }

            var modelos = await _context.Municipios
                        .Include(i => i.estado).ThenInclude(p => p.pais)
                        .Where(w => w.estado_id == IdEstado)
                        .OrderBy(o => o.nombre)
                        .Select(s => new MunicipioVM
                        {
                            municipio_id = s.municipio_id,
                            estado_id = s.estado_id,
                            estado = s.estado.nombre,
                            pais_id = s.estado.pais_id,
                            pais = s.estado.pais.nombre,
                            codigo = s.codigo,
                            referencia = s.referencia

                        }).ToListAsync();

            return modelos;
        }

        //------------------------------------

        public async Task<MunicipioVM> GetVM(int id)
        {
            var modelo = await _context.Municipios
                                    .Include(a => a.estado).ThenInclude(b => b.pais)
                                    .FirstOrDefaultAsync(x => x.municipio_id == id);

            MunicipioVM municipiovm = new MunicipioVM
            {
                municipio_id = modelo.municipio_id,
                estado_id = modelo.estado_id,
                estado = modelo.estado.nombre,
                pais_id = modelo.estado.pais_id,
                pais = modelo.estado.pais.nombre,
                nombre = modelo.nombre,
                codigo = modelo.codigo,
                referencia = modelo.referencia
            };

            return municipiovm;
        }

        //------------------------------------

        public async Task<IEnumerable<SelectVM>> Select(int IdEstado)
        {
            var modelos = await _context.Municipios
                .Where(w => w.estado_id == IdEstado)
                .OrderBy(o => o.nombre)
                .Select(s => new SelectVM
                {
                    value = s.municipio_id,
                    text = s.nombre

                }).ToListAsync();

            return modelos;
        }

        //------------------------------------

        public async Task<IEnumerable<SelectVM2>> Select2(int IdEstado)
        {
            var modelos = await _context.Municipios
                .Where(w => w.estado_id == IdEstado)
                .OrderBy(o => o.nombre)
                .Select(s => new SelectVM2
                {
                    value = s.municipio_id.ToString(),
                    label = s.nombre

                }).ToListAsync();

            return modelos;
        }

        //------------------------------------

        public async Task<Municipio> Update(MunicipioUpdateVM model)
        {
            if (model.municipio_id < 1)
            {
                throw new Exception("La ID insertada es incorrecta.");
            }

            var actualizar = await _context.Municipios.FindAsync(model.municipio_id);

            if (actualizar == null)
            {
                throw new Exception("No existe el municipio con ese id");
            }

            actualizar.nombre = model.nombre;
            actualizar.codigo = model.codigo;
            actualizar.referencia = model.referencia;

            actualizar = CheckPropiedades(actualizar);

            _context.Municipios.Update(actualizar);
            await _context.SaveChangesAsync();

            return actualizar;
        }

        //------------------------------------
    }
}
