using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades.Modelo
{
    public class Estado
    {
        public int estado_id { get; set; }
        public string nombre { get; set; }

        public int pais_id { get; set; }
        public Pais pais { get; set; }

        public string codigo { get; set; }
        public bool activo { get; set; }

        public ICollection<Cia> cias { get; set; }
        public ICollection<Ciudad> ciudades { get; set; }
        public ICollection<Municipio> municipios { get; set; }
        public ICollection<Sucursal> sucursales { get; set; }
    }
}
