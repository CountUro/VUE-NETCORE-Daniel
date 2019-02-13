using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades.ViewModels
{
    public class HdArchivoCreateVM
    {
        public int hd_doc_id { get; set; }
        public string descripcion { get; set; }
        public string nombrefile { get; set; }
        public int usuario_id { get; set; }
    }
}
