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
    public interface ICiaService
    {
        Task<bool> Existe(int id);
        Task<IEnumerable<Cia>> GetAll();

        Task<IEnumerable<CiaVM>> GetAllVM();
        Task<CiaVM> GetVM(int id);

        Task<Cia> Get(int id);
        Task<Boolean> Delete(int id);

        Task<CiaVM> Update(CiaUpdateVM model);
        Task<CiaVM> Add(CiaVMCreate model);
        Task<bool> Bloquear(CiaBlkVM model);

        Task<bool> DesBloquear(int id);
        Task<bool> ActivarDesactivar(int id, bool activar);

        Task<IEnumerable<SelectVM>> Select(EnumActiva Eactiva, EnumBloqueada Ebloqueada);
        Task<IEnumerable<SelectVM2>> Select2(EnumActiva Eactiva, EnumBloqueada Ebloqueada);
    }

    public class CiaService : ICiaService
    {
        // Base de datos
        private readonly DbContextHd _context;

        // Constructor
        public CiaService(DbContextHd context)
        {
            _context = context;
        }


        //
        public enum EnumActiva
        {
            Todos,
            Activa,
            Desactiva
        }

        public enum EnumBloqueada
        {
            Todos,
            Bloqueada,
            Desbloqueada
        }


        public async Task<bool> ActivarDesactivar(int id, bool activar)
        {
            var modelo = await _context.Cias.FindAsync(id);
            if (modelo == null)
            {
                throw new Exception("No existe");
                return false;
            }

            modelo.activa = activar;
            _context.Cias.Update(modelo);

            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<bool> Delete(int id)
        {
            if (id < 0)
            {
                throw new Exception("La ID no es valida");
            }

            var modelo = await _context.Cias.FindAsync(id);
            if (modelo == null)
            {
                throw new Exception("no se elimino el registro");
                return false;
            }

            _context.Cias.Remove(modelo);
            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<bool> DesBloquear(int id)
        {
            var model = await _context.Cias.FindAsync(id);
            if (model == null)
            {
                throw new Exception("No existe el registro.");
                return false;
            }

            model.bloqueada = false;
            model.f_aplica_bloqueo = null;

            _context.Cias.Update(model);

            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<bool> Existe(int id)
        {
            var model = await _context.Cias.FindAsync(id);
            var regreso = (model == null) ? false : true;

            return regreso;
        }

        public async Task<Cia> Get(int id)
        {
            var model = await _context.Cias.FindAsync(id);
            return model;
        }

        public async Task<IEnumerable<Cia>> GetAll()
        {
            var regreso = await _context.Cias.ToListAsync();
            return regreso;
        }

        public async Task<IEnumerable<CiaVM>> GetAllVM()
        {
            var regreso = await _context.Cias
                            .Include(a => a.grupoCia)
                            .Include(b => b.tipo166)
                            .Include(c => c.pais)
                            .Include(d => d.estado)
                            .Include(e => e.ciudad)
                            .Include(f => f.marca)
                            .Include(g => g.soporte)

                            .Select(x => new CiaVM
                            {
                                cia_id = x.cia_id,
                                rif = x.rif,
                                nombre = x.nombre,
                                grupo_cia_id = x.grupo_cia_id,
                                grupocia = x.grupoCia.nombre,
                                tipo_166_id = x.tipo_166_id,
                                tipos166 = x.tipo166.descripcion,
                                pais_id = x.pais_id,
                                pais = x.pais.nombre,
                                marca_87_id = x.marca_87_id,
                                marca87 = x.marca87.descripcion,
                                codigo_bd = x.codigo_bd,
                                activa = x.activa,
                                bloqueada = x.bloqueada,
                                f_aplica_bloqueo = x.f_aplica_bloqueo,
                                lic_alquiler = x.lic_alquiler,
                                lic_vta = x.lic_vta,
                                version_app = x.version_app,
                                version_bd = x.version_bd,
                                marca = x.marca,
                                soporte_id = x.soporte_id,
                                soporte = x.soporte.nombre,
                                ciudad_id = x.ciudad_id,
                                ciudad = x.ciudad.nombre,
                                estado_id = x.estado_id,
                                estado = x.estado.nombre

                            }).ToListAsync();

            return regreso;
        }

        public async Task<CiaVM> GetVM(int id)
        {
            if (id < 1)
            {
                throw new Exception("La ID insertada no es valida");
            }

            var modelo = await _context.Cias
                            .Include(a => a.grupoCia)
                            .Include(b => b.tipo166)
                            .Include(c => c.pais)
                            .Include(d => d.estado)
                            .Include(e => e.ciudad)
                            .Include(f => f.marca87)
                            .Include(g => g.soporte)
                            .FirstOrDefaultAsync(x => x.cia_id == id);

            var patata = 2 + 2;

            var regreso = new CiaVM
            {
                cia_id = modelo.cia_id,
                rif = modelo.rif,
                nombre = modelo.nombre,
                grupo_cia_id = modelo.grupo_cia_id,
                grupocia = modelo.grupoCia.nombre,
                tipo_166_id = modelo.tipo_166_id,
                tipos166 = modelo.tipo166.descripcion,
                pais_id = modelo.pais_id,
                pais = modelo.pais.nombre,
                marca_87_id = modelo.marca_87_id,
                marca87 = modelo.marca87.descripcion,
                codigo_bd = modelo.codigo_bd,
                activa = modelo.activa,
                bloqueada = modelo.bloqueada,
                f_aplica_bloqueo = modelo.f_aplica_bloqueo,
                lic_alquiler = modelo.lic_alquiler,
                lic_vta = modelo.lic_vta,
                version_app = modelo.version_app,
                version_bd = modelo.version_bd,
                marca = modelo.marca,
                soporte_id = modelo.soporte_id,
                soporte = modelo.soporte.nombre,
                ciudad_id = modelo.ciudad_id,
                ciudad = modelo.ciudad.nombre,
                estado_id = modelo.estado_id,
                estado = modelo.estado.nombre
            };

            return regreso;
        }

        public async Task<CiaVM> Update(CiaUpdateVM model)
        {
            if (model.cia_id < 1)
            {
                throw new Exception("La ID insertada es incorrecta.");
            }

            var cia = await _context.Cias.FindAsync(model.cia_id);
            if (cia == null)
            {
                throw new Exception("No existe tal registro.");
            }

            cia.rif = model.rif;
            cia.nombre = model.nombre;
            cia.grupo_cia_id = model.grupo_cia_id;
            cia.tipo_166_id = model.tipo_166_id;
            cia.pais_id = model.pais_id;
            cia.estado_id = model.estado_id;
            cia.ciudad_id = model.ciudad_id;
            cia.soporte_id = model.soporte_id;
            cia.marca_87_id = model.marca_87_id;
            cia.codigo_bd = model.codigo_bd;
            cia.lic_alquiler = model.lic_alquiler;
            cia.lic_vta = model.lic_vta;
            cia.version_app = model.version_app;
            cia.version_bd = model.version_bd;
            cia.marca = model.marca;

            _context.Cias.Update(cia);
            await _context.SaveChangesAsync();

            var regreso = await GetVM(cia.cia_id);
            return regreso;

        }

        private Cia ChkModel(CiaVMCreate model)
        {
            Cia regreso = new Cia
            {
                rif = model.rif.Left(20),
                nombre = model.nombre.Left(100),
                codigo_bd = model.codigo_bd.Left(12),
                version_app = model.version_app.Left(8),
                version_bd = model.version_bd.Left(12),
                marca = model.marca.Left(60),
                grupo_cia_id = model.grupo_cia_id,
                soporte_id = model.soporte_id,
                tipo_166_id = model.tipo_166_id,
                pais_id = model.pais_id,
                estado_id = model.estado_id,
                ciudad_id = model.ciudad_id,
                marca_87_id = model.marca_87_id,
                activa = true,
                bloqueada = false,
                lic_alquiler = model.lic_alquiler,
                lic_vta = model.lic_vta
            };

            return regreso;
        }

        public async Task<CiaVM> Add(CiaVMCreate model)
        {
            Cia cia = ChkModel(model);
            _context.Cias.Add(cia);
            await _context.SaveChangesAsync();

            var regreso = await GetVM(cia.cia_id);

            return regreso;

        }

        public async Task<bool> Bloquear(CiaBlkVM model)
        {
            var cia = await _context.Cias.FindAsync(model.cia_id);
            if (cia == null)
            {
                return false;
            }

            cia.bloqueada = true;
            cia.f_aplica_bloqueo = model.fecha;

            _context.Cias.Update(cia);
            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<IEnumerable<SelectVM>> Select(EnumActiva Eactiva, EnumBloqueada Ebloqueada)
        {
            int activo = 0;
            int bloqueado = 0;
            bool valorActiva = true;
            bool valorBloqueado = true;
            switch (Eactiva)
            {

                case EnumActiva.Todos:
                    activo = 0;
                    break;
                case EnumActiva.Activa:
                    activo = 1;
                    break;
                case EnumActiva.Desactiva:
                    activo = -1;
                    valorActiva = false;
                    break;
            }

            switch (Ebloqueada)
            {
                case EnumBloqueada.Todos:
                    bloqueado = 0;
                    break;
                case EnumBloqueada.Bloqueada:
                    bloqueado = 1;
                    break;
                case EnumBloqueada.Desbloqueada:
                    bloqueado = -1;
                    valorBloqueado = false;
                    break;
                default:
                    break;
            }


            var cias = await _context.Cias
                .Where(w => ((activo == 0) || ((activo != 0) && (w.activa == valorActiva))) &&
                           ((bloqueado == 0) || ((bloqueado != 0) && (w.bloqueada == valorBloqueado))))
                .OrderBy(x => x.nombre).ToListAsync();


            var regresoVM = cias.Select(x => new SelectVM
            {
                value = x.cia_id,
                text = x.nombre
            });

            return regresoVM;
        }

        public async Task<IEnumerable<SelectVM2>> Select2(EnumActiva Eactiva, EnumBloqueada Ebloqueada)
        {
            int activo = 0;
            int bloqueado = 0;
            bool valorActiva = true;
            bool valorBloqueado = true;
            switch (Eactiva)
            {

                case EnumActiva.Todos:
                    activo = 0;
                    break;
                case EnumActiva.Activa:
                    activo = 1;
                    break;
                case EnumActiva.Desactiva:
                    activo = -1;
                    valorActiva = false;
                    break;
            }

            switch (Ebloqueada)
            {
                case EnumBloqueada.Todos:
                    bloqueado = 0;
                    break;
                case EnumBloqueada.Bloqueada:
                    bloqueado = 1;
                    break;
                case EnumBloqueada.Desbloqueada:
                    bloqueado = -1;
                    valorBloqueado = false;
                    break;
                default:
                    break;
            }


            var cias = await _context.Cias
                .Where(w => ((activo == 0) || ((activo != 0) && (w.activa == valorActiva))) &&
                           ((bloqueado == 0) || ((bloqueado != 0) && (w.bloqueada == valorBloqueado))))
                .OrderBy(x => x.nombre).ToListAsync();


            var regresoVM = cias.Select(x => new SelectVM2
            {
                value = x.cia_id.ToString(),
                label = x.nombre
            });

            return regresoVM;
        }
    }
}
