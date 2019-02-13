using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades.Modelo
{
    public class Municipio
    {
        public int municipio_id { get; set; }

        public int estado_id { get; set; }
        public Estado estado { get; set; }

        public string nombre { get; set; }
        public string codigo { get; set; }
        public string referencia { get; set; }

        public ICollection<Sucursal> sucursales { get; set; }
    }
}
