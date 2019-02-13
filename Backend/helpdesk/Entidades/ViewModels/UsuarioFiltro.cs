using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades.ViewModels
{
    public class UsuarioFiltro
    {
        public int rol { get; set; }
        public int soporte { get; set; }
        public string nombre { get; set; }
        public string email { get; set; }
        public int activo { get; set; }
        public int programador { get; set; }
        public string tlf_movil { get; set; }
        public string tlf_oficina { get; set; }

    }
}
