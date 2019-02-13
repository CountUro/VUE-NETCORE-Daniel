using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades.ViewModels
{
    public class HdDocCreateVM
    {
        public int consultor_id { get; set; }
        public int programador_id { get; set; }
        public int cia_id { get; set; }
        public int persona_id { get; set; }
        public long aplicacion_178_id { get; set; }
        public long urgencia_170_id { get; set; }
        public long tipo_172_id { get; set; }
        public long status_175_id { get; set; }
        public long modulo_214_id { get; set; }
        public long? motivo_298_id { get; set; }
        public int pais_id { get; set; }
        public string titulo { get; set; }
        public string descripcion { get; set; }
        public string version_app { get; set; }
        public string version_bd { get; set; }
        public string nombre_contacto { get; set; }
        public string email_contacto { get; set; }
        public string tlf_contacto { get; set; }
        public string nombre_ventana { get; set; }

    }
}
