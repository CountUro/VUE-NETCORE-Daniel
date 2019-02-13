using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades.ViewModels
{
    public class HdArchivoVM
    {
        public int hd_archivo_id { get; set; }
        public int hd_doc_id { get; set; }
        public int Numero { get; set; }
        public string descripcion { get; set; }
        public string nombrefile { get; set; }
        public DateTime f_crea { get; set; }
        public int usuario_id { get; set; }
        public string usuario { get; set; }
    }
}
