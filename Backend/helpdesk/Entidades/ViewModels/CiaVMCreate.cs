using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades.ViewModels
{
    public class CiaVMCreate
    {         
        public string rif { get; set; }
        public string nombre { get; set; }
        public int grupo_cia_id { get; set; }        
        public long tipo_166_id { get; set; }
        public int pais_id { get; set; }
        public int estado_id { get; set; }
        public int ciudad_id { get; set; }
        public long marca_87_id { get; set; }
        public int soporte_id { get; set; }        
        public string codigo_bd { get; set; }     
        public int lic_alquiler { get; set; }
        public int lic_vta { get; set; }
        public string version_app { get; set; }
        public string version_bd { get; set; }
        public string marca { get; set; }
    }
}
