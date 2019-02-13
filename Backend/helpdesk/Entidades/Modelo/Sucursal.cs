using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades.Modelo
{
    public class Sucursal
    {
        // PK
        public int sucursal_id { get; set; }

        // C
        public string nombre { get; set; }

        // FK
        public int cia_id { get; set; }
        public Cia cia { get; set; }

        public int pais_id { get; set; }
        public Pais pais { get; set; }

        public int estado_id { get; set; }
        public Estado estado { get; set; }

        public int ciudad_id { get; set; }
        public Ciudad ciudad { get; set; }

        public int? municipio_id { get; set; }
        public Municipio municipio { get; set; }
    }
}
