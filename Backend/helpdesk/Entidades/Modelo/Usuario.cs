using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades.Modelo
{
    public class Usuario
    {
        // PK
        public int usuario_id { get; set; }

        // C
        public string nombre { get; set; }
        public string email { get; set; }
        public bool activo { get; set; }
        public string tlf_movil { get; set; }
        public string tlf_oficina { get; set; }
        public DateTime f_login { get; set; }

        
        public string token { get; set; }
        public bool programador { get; set; }

        //FK
        public int soporte_id { get; set; }
        public Soporte soporte { get; set; }

        public int pais_id { get; set; }
        public Pais pais { get; set; }

        public int rol_id { get; set; }
        public Rol rol { get; set; }

        public byte[] password_hash { get; set; }
        public byte[] password_salt { get; set; }


        // 
        public ICollection<HdDoc> hdConsultores { get; set; }
        public ICollection<HdDoc> hdProgramadores { get; set; }

        public ICollection<HdSeguimiento> hdSeguimientos { get; set; }
        public ICollection<HdArchivo> hdArchivos { get; set; }
    }
}
