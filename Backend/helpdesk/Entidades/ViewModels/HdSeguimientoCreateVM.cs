using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades.ViewModels
{
    public class HdSeguimientoCreateVM
    {
        public int hd_doc_id { get; set; }
        public int usuario_id { get; set; }
        public long status_175_id { get; set; }
        public string observaciones { get; set; }
    }
}
