using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades.Modelo
{
    public class Ciudad
    {
        public int ciudad_id { get; set; }
        public string nombre { get; set; }
        public string codigo { get; set; }
        public bool activo { get; set; }

        public int estado_id { get; set; }
        public Estado estado { get; set; }

        public ICollection<Sucursal> sucursales { get; set; }
        public ICollection<Cia> cias { get; set; }
    }
}
