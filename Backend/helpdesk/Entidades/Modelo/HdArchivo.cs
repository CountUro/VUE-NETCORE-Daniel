using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades.Modelo
{
    public class HdArchivo
    {
        public int hd_archivo_id { get; set; }

        public int hd_doc_id { get; set; }
        public HdDoc hdDoc { get; set; }

        public string descripcion { get; set; }
        public string nombrefile { get; set; }
        public DateTime f_crea { get; set; }

        public int usuario_id { get; set; }
        public Usuario usuario { get; set; }

    }
}
