using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades.ViewModels
{
    public class PersonaFiltro
    {
        public string cedula { get; set; }
        public string nombre { get; set; }
        public string correo { get; set; }
        public string cargo { get; set; }
        public long sexo { get; set; }
    }
}
