using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades.Modelo
{
    public class Rol
    {
        public int rol_id { get; set; }
        public string nombre { get; set; }

        public ICollection<Usuario> usuarios { get; set; }
    }
}
