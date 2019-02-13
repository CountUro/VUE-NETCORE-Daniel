using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades.ViewModels
{
    public  class PersonaVM
    {
        public int persona_id { get; set; }
        public string cedula { get; set; }
        public string nombre1 { get; set; }
        public string nombre2 { get; set; }
        public string apellido1 { get; set; }
        public string apellido2 { get; set; }
        public string nombre_comp { get; set; }
        public string tlf_movil { get; set; }
        public string tlf_local { get; set; }
        public string email { get; set; }
        public string cargo { get; set; }
        public long sexo_6_id { get; set; }
        public string sexo6 { get; set; }
    }
}
