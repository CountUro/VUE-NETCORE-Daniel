using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades.ViewModels
{
    public class UsuarioVM
    {
        public int usuario_id { get; set; }
        public int rol_id { get; set; }
        public string rol { get; set; }
        public int pais_id { get; set; }
        public string pais { get; set; }
        public int soporte_id { get; set; }
        public string soporte { get; set; }
        public string nombre { get; set; }
        public string email { get; set; }
        public bool activo { get; set; }
        public bool programador { get; set; }
        public string tlf_movil { get; set; }
        public string tlf_oficina { get; set; }
        public DateTime? f_login { get; set; }
    }
}
