using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades.ViewModels
{
    public class SucursalCreaVM
    {
        public string nombre { get; set; }
        public int cia_id { get; set; }
        public int pais_id { get; set; }
        public int estado_id { get; set; }
        public int ciudad_id { get; set; }
        public int? municipio_id { get; set; }
    }
}
