using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades.ViewModels
{
    public class HdDocVM
    {
        public int hd_doc_id { get; set; }
        public int consultor_id { get; set; }
        public string consultor { get; set; }
        public int programador_id { get; set; }
        public string programador { get; set; }
        public int cia_id { get; set; }
        public string cia { get; set; }
        public int persona_id { get; set; }
        public string persona { get; set; }
        public long aplicacion_178_id { get; set; }
        public string aplicacion178 { get; set; }
        public long urgencia_170_id { get; set; }
        public string urgencia170 { get; set; }
        public long tipo_172_id { get; set; }
        public string tipo172 { get; set; }
        public long status_175_id { get; set; }
        public string status175 { get; set; }
        public long modulo_214_id { get; set; }
        public string modulo214 { get; set; }
        public long? motivo_298_id { get; set; }
        public string motivo298 { get; set; }
        public int pais_id { get; set; }
        public string pais { get; set; }
        public int numero { get; set; }
        public string titulo { get; set; }
        public string descripcion { get; set; }
        public DateTime f_crea { get; set; }
        public string version_app { get; set; }
        public string version_bd { get; set; }
        public DateTime? f_correccion { get; set; }
        public string solucion { get; set; }
        public string version_solucion { get; set; }
        public DateTime? f_solucionn { get; set; }
        public string nombre_contacto { get; set; }
        public string email_contacto { get; set; }
        public string tlf_contacto { get; set; }
        public string nombre_ventana { get; set; }
        public bool leido_consultor { get; set; }
        public bool leido_programador { get; set; }
    }
}
