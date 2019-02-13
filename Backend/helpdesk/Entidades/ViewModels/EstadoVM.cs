using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades.ViewModels
{
    public class EstadoVM
    {
        public int estado_id { get; set; }
        public string nombre { get; set; }
        public int pais_id { get; set; }
        public string pais { get; set; }
        public string codigo { get; set; }
        public Boolean activo { get; set; }
    }
}
