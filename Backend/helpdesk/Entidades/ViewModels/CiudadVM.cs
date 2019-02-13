using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades.ViewModels
{
    public class CiudadVM
    {
        public int ciudad_id { get; set; }
        public string nombre { get; set; }
        public string codigo { get; set; }
        public bool activo { get; set; }
        public int estado_id { get; set; }
        public string estado { get; set; }
        public int pais_id { get; set; }
        public string pais { get; set; }
    }
}

