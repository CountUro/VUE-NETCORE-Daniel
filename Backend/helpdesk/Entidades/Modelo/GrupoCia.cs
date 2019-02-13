using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades.Modelo
{
    public class GrupoCia
    {
        public int grupo_cia_id { get; set; }
        public string nombre { get; set; }

        public ICollection<Cia> cias { get; set; }
    }
}
