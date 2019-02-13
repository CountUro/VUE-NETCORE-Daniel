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
    public interface IDominioDetService
    {
        Task<bool> Existe(long id);
        Task<IEnumerable<DominioDet>> GetAll(int IdPais, int IdDominio);
        Task<DominioDet> Get(long id);
        Task<Boolean> Delete(long id);
        Task<DominioDet> Update(DominioDet model);
        Task<DominioDet> Add(DominioDet model);
        Task<IEnumerable<SelectVM>> Select(int IdPais, int IdDominio, bool IncluirNoAplica);
        Task<IEnumerable<SelectVM2>> Select2(int IdPais, int IdDominio, bool IncluirNoAplica);
        Task LlenaDomDet(List<DominioDet> lista,
                                    int pais_id,
                                    int dominio,
                                    short codigo,
                                    string descripcion,
                                    string descri_corta,
                                    int signo,
                                    int ent1,
                                    int ent2);
        Task<bool> SalvarLista(List<DominioDet> lista);
    }

    public class DominioDetService : IDominioDetService
    {
        // Base de datos
        private readonly DbContextHd _context;

        // Constructor
        public DominioDetService(DbContextHd context)
        {
            _context = context;
        }

        //----------------------------------------------------------------------

        public async Task<DominioDet> Add(DominioDet model)
        {
            var buscar = await _context.DominioDets.FindAsync(model.dominio_det_id);
            if (buscar != null)
            {
                throw new Exception("El id ya existe");
            }

            var registro = await _context.DominioDets.FirstOrDefaultAsync(x =>
            x.descripcion == model.descripcion &&
            x.dominio_det_id != model.dominio_det_id &&
            x.dominio_id == model.dominio_id &&
            x.pais_id == model.pais_id);

            if (registro != null)
            {
                throw new Exception("La descripcion ya existe en otro id en el mismo dominio");
            }

            var registro2 = await _context.DominioDets.FirstOrDefaultAsync(x =>
            x.codigo == model.codigo &&
            x.dominio_det_id != model.dominio_det_id &&
            x.dominio_id == model.dominio_id &&
            x.pais_id == model.pais_id);

            if (registro2 != null)
            {
                throw new Exception("El codigo ya existe en otro id en el mismo dominio");
            }

            _context.DominioDets.Add(model);
            await _context.SaveChangesAsync();

            return model;
        }

        //------------------------------------

        public async Task<bool> Delete(long id)
        {
            if (id < 1)
            {
                throw new Exception("La ID insertada no es correcta");
            }
            var borrar = await _context.DominioDets.FindAsync(id);
            if (borrar == null)
            {
                throw new Exception("No se ha borrado el registro.");
                return false;
            }

            _context.DominioDets.Remove(borrar);
            await _context.SaveChangesAsync();

            return true;
        }

        //------------------------------------

        public async Task<bool> Existe(long id)
        {
            var existe = await _context.DominioDets.FindAsync(id);
            return (existe != null) ? true : false;
        }

        //------------------------------------

        public async Task<DominioDet> Get(long id)
        {
            var trae = await _context.DominioDets.FindAsync(id);
            if (trae == null)
            {
                throw new Exception("Registro no existente");
            }

            return trae;
        }

        //------------------------------------

        public async Task<IEnumerable<DominioDet>> GetAll(int IdPais, int IdDominio)
        {
            int i_IdPais = (IdPais < 1) ? 0 : 1;
            int i_IdDominio = (IdDominio < 1) ? 0 : 1;

            // los pases son obligatorios ya que son IDs?

            var todos = await _context.DominioDets
                .Where(w =>
                (i_IdPais == 0 || w.pais_id == IdPais) &&
                (i_IdDominio == 0 || w.dominio_id == IdDominio))
                .ToListAsync();

            return todos;
        }

        //------------------------------------

        public async Task LlenaDomDet(List<DominioDet> lista, int pais_id, int dominio, short codigo, string descripcion, string descri_corta, int signo, int ent1, int ent2)
        {
            long Id = BuildId(pais_id, dominio, codigo);

            if (ExisteEnLista(lista, Id))
            {
                return;
            }
            
            if (await ExisteEnBD(Id) == true)
            {
                return;
            }
                        
            DominioDet dominioDet = new DominioDet
            {
                dominio_det_id = Id,
                codigo = codigo,
                descripcion = descripcion,
                dominio_id = dominio,
                pais_id = pais_id,
                descrip_corta = descri_corta,
                signo = signo,
                entero1 = ent1,
                entero2 = ent2
            };

            lista.Add(dominioDet);

            return;
        }

        public long BuildId(int IdPais, int IdDominio, short codigo)
        {
            string pais = IdPais.ToString();
            string codstr = codigo.ToString();
            string domstr = IdDominio.ToString();

            switch (codstr.Length)
            {
                case 1:
                    codstr = "00" + codstr;
                    break;
                case 2:
                    codstr = "0" + codstr;
                    break;
            }


            switch (domstr.Length)
            {
                case 1:
                    domstr = "00" + domstr;
                    break;
                case 2:
                    domstr = "0" + domstr;
                    break;
            }

            var regresoStr = pais + domstr + codstr;

            int regreso = int.Parse(regresoStr);

            return regreso;

        }

        private bool ExisteEnLista(List<DominioDet> lista, long id)
        {
            bool existe = false;
            foreach (var item in lista)
            {

                if (item.dominio_det_id == id)
                {
                    existe = true;
                    return existe;
                }
            }

            return existe;
        }

        private async Task<bool> ExisteEnBD(long id)
        {
            bool existe = false;
            var encontrado = await _context.DominioDets.FindAsync(id);

            if (encontrado != null)
            {
                existe = true;
                return existe;
            }

            return existe;
        }

        //------------------------------------

        public async Task<bool> SalvarLista(List<DominioDet> lista)
        {
            _context.DominioDets.AddRange(lista);
            await _context.SaveChangesAsync();
            return true;
        }

        //------------------------------------

        public async Task<IEnumerable<SelectVM>> Select(int IdPais, int IdDominio, bool shownCero)
        {
            // los pases son obligatorios ya que son IDs?
            // que es un inclurnoaplica?
            var listaVM = await _context.DominioDets
                .Where(w =>
                w.dominio_id == IdDominio &&
                w.pais_id == IdPais &&
                (shownCero || w.codigo != 0)
                )
                .OrderBy(o=>o.descripcion)
                .Select(s => new SelectVM
                {
                    value = s.dominio_det_id,
                    text = s.descripcion
                })
                .ToListAsync();

            return listaVM;
        }

        //------------------------------------

        public async Task<IEnumerable<SelectVM2>> Select2(int IdPais, int IdDominio, bool shownCero)
        {
            // los pases son obligatorios ya que son IDs?
            // que es un inclurnoaplica?
            var listaVM = await _context.DominioDets
                .Where(w =>
                w.dominio_id == IdDominio &&
                w.pais_id == IdPais &&
                (shownCero ||  w.codigo != 0)
                )
                .OrderBy(o=>o.descripcion)
                .Select(s => new SelectVM2
                {
                    value = s.dominio_det_id.ToString(),
                    label = s.descripcion
                })
                .ToListAsync();

            return listaVM;
        }

        //------------------------------------

        public async Task<DominioDet> Update(DominioDet model)
        {
            var actualizar = await _context.DominioDets.FindAsync(model.dominio_det_id);
            if (actualizar == null)
            {
                throw new Exception("Registro no encontrado");
            }

            var registro = await _context.DominioDets.FirstOrDefaultAsync(x =>
            x.descripcion == model.descripcion &&
            x.dominio_det_id != model.dominio_det_id &&
            x.dominio_id == model.dominio_id &&
            x.pais_id == model.pais_id);

            if (registro != null)
            {
                throw new Exception("La descripcion ya existe en otro id en el mismo dominio");
            }

            var registro2 = await _context.DominioDets.FirstOrDefaultAsync(x =>
            x.codigo == model.codigo &&
            x.dominio_det_id != model.dominio_det_id &&
            x.dominio_id == model.dominio_id &&
            x.pais_id == model.pais_id);

            if (registro2 != null)
            {
                throw new Exception("El codigo ya existe en otro id en el mismo dominio");
            }

            actualizar.codigo = model.codigo;
            actualizar.descripcion = model.descripcion;
            actualizar.dominio_id = model.dominio_id;
            actualizar.pais_id = model.pais_id;
            actualizar.descrip_corta = model.descrip_corta;
            actualizar.signo = model.signo;
            actualizar.entero1 = model.entero1;
            actualizar.entero2 = model.entero2;

            _context.DominioDets.Update(actualizar);
            await _context.SaveChangesAsync();

            return actualizar;
        }

        //------------------------------------

    }
}
