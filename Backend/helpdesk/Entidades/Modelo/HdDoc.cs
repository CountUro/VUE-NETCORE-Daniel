using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades.Modelo
{
    public class HdDoc
    {
        public int hd_doc_id { get; set; }

        //////
        ///Usuarios
        //////
        public int consultor_id { get; set; }
        public Usuario consultor { get; set; }

        public int programador_id { get; set; }
        public Usuario programador { get; set; }



        public int cia_id { get; set; }
        public Cia cia { get; set; }

        public int persona_id { get; set; }
        public Persona persona { get; set; }

        public int pais_id { get; set; }
        public Pais pais { get; set; }



        public long aplicacion_178_id { get; set; }
        public DominioDet aplicacion178 { get; set; }

        public long urgencia_170_id { get; set; }
        public DominioDet urgencia170 { get; set; }

        public long tipo_172_id { get; set; }
        public DominioDet tipo172 { get; set; }

        public long status_175_id { get; set; }
        public DominioDet status175 { get; set; }

        public long modulo_214_id { get; set; }
        public DominioDet modulo214 { get; set; }

        public long motivo_298_id { get; set; }
        public DominioDet motivo298 { get; set; }




        public int numero { get; set; }
        public string titulo { get; set; }
        public string descripcion { get; set; }
        public DateTime f_crea { get; set; }
        public string version_app { get; set; }
        public string version_bd { get; set; }
        public DateTime f_correcion { get; set; }
        public string solucion { get; set; }
        public string version_solucion { get; set; }
        public DateTime f_solucion { get; set; }
        public string nombre_contacto { get; set; }
        public string email_contacto { get; set; }
        public string tlf_contacto { get; set; }
        public string nombre_ventana { get; set; }
        public bool leido_consultor { get; set; }
        public bool leido_programador { get; set; }

        public ICollection<HdSeguimiento> hdSeguimientos { get; set; }
        public ICollection<HdArchivo> hdArchivos { get; set; }
    }
}
