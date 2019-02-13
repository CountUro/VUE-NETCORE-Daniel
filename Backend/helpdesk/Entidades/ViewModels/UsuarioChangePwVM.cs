using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades.ViewModels
{
    public class UsuarioChangePwVM
    {
        public int usuario_id { get; set; }
        public string passwordold { get; set; }
        public string password { get; set; }
        public string passwordConfirm { get; set; }
    }
}
