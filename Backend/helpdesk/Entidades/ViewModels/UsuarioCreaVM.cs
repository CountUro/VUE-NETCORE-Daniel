using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades.ViewModels
{
    public class UsuarioCreaVM
    {
        public int rol_id { get; set; }
        public int soporte_id { get; set; }
        public int pais_id { get; set; }
        public string nombre { get; set; }
        public string email { get; set; }
        public string tlf_movil { get; set; }
        public string tlf_oficina { get; set; }
        public string password { get; set; }
        public string passwordconfirm { get; set; }
       
    }
}


 
