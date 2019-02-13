using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades.Modelo
{
    public class Dominio
    {
        public int dominio_id { get; set; }
        public string descripcion { get; set; }

        public ICollection<DominioDet> dominiosDet { get; set; }
    }
}
