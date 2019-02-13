using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades.Modelo
{
    public class Pais
    {
        public int pais_id { get; set; }

        public string nombre { get; set; }
        public string nombre_completo { get; set; }
        public string continente { get; set; }
        public string iso2 { get; set; }
        public string iso3 { get; set; }
        public string iso3166 { get; set; }
        public string cia { get; set; }
        public string telefono { get; set; }
        public string internet { get; set; }
        public string vehiculo { get; set; }

        public ICollection<Cia> cias { get; set; }
        public ICollection<Estado> estados { get; set; }
        public ICollection<Sucursal> sucursales { get; set; }
        public ICollection<Usuario> usuarios { get; set; }
        public ICollection<HdDoc> hdDocs { get; set; }
        public ICollection<DominioDet> dominiosDet { get; set; }
    }
}
