using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades.ViewModels
{
    public class HdSeguimientoVM
    {
        public int hd_seguimiento_id { get; set; }
        public int hd_doc_id { get; set; }
        public int hddoc { get; set; }
        public int usuario_id { get; set; }
        public string usuario { get; set; }
        public long status_175_id { get; set; }
        public string status175 { get; set; }
        public string observaciones { get; set; }
        public DateTime f_crea { get; set; }
    }
}
