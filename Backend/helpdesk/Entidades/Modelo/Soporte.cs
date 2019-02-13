using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades.Modelo
{
   public class Soporte
    {
        public int soporte_id { get; set; }
        public string nombre { get; set; }

        public ICollection<Cia> cias { get; set; }
        public ICollection<Usuario> usuarios { get; set; }
    }
}
