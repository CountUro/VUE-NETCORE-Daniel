using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades.ViewModels
{
    public class SucursalVM
    {
        public int sucursal_id { get; set; }
        public string nombre { get; set; }
        public int cia_id { get; set; }
        public string cia { get; set; }
        public int pais_id { get; set; }
        public string pais { get; set; }
        public int estado_id { get; set; }
        public string estado { get; set; }
        public int ciudad_id { get; set; }
        public string ciudad { get; set; }
        public int? municipio_id { get; set; }
        public string municipio { get; set; }
    }
}
