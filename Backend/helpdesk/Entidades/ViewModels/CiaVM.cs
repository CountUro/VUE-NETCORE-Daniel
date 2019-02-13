using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades.ViewModels
{
    public class CiaVM
    {
        public int cia_id { get; set; }
        public string rif { get; set; }
        public string nombre { get; set; }
        public int grupo_cia_id { get; set; }
        public string grupocia { get; set; }
        public long tipo_166_id { get; set; }
        public string tipos166 { get; set; }
        public int pais_id { get; set; }
        public string pais { get; set; }
        public int estado_id { get; set; }
        public string estado { get; set; }
        public int ciudad_id { get; set; }
        public string ciudad { get; set; }
        public long marca_87_id { get; set; }
        public string marca87 { get; set; }
        public int soporte_id { get; set; }
        public string soporte { get; set; }
        public string codigo_bd { get; set; }
        public bool activa { get; set; }
        public bool bloqueada { get; set; }
        public DateTime? f_aplica_bloqueo { get; set; }
        public int lic_alquiler { get; set; }
        public int lic_vta { get; set; }
        public string version_app { get; set; }
        public string version_bd { get; set; }
        public string marca { get; set; }
    }
}
