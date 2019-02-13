using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades.Modelo
{
    public class HdSeguimiento
    {
        // K
        public int hd_seguimiento_id { get; set; }

        // F
        public string observaciones { get; set; }
        public DateTime f_crea { get; set; }

        //FK
        public int hd_doc_id { get; set; }
        public HdDoc hdDoc { get; set; }

        public int usuario_id { get; set; }
        public Usuario usuario { get; set; }

        public long status_175_id { get; set; }
        public DominioDet status175 { get; set; }




    }
}
