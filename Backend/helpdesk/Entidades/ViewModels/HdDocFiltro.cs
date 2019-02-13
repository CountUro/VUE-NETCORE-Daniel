using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades.ViewModels
{
    public class HdDocFiltro
    {
        public int? consultor_id { get; set; }
        public int? programador_id { get; set; }
        public int? cia_id { get; set; }
        public int? persona_id { get; set; }
        public long? aplicacion_178_id { get; set; }
        public long? urgencia_170_id { get; set; }
        public long? tipo_172_id { get; set; }
        public long? status_175_id { get; set; }
        public long? modulo_214_id { get; set; }
        public long? motivo_298_id { get; set; }
        public int? pais_id { get; set; }
        public int? numero { get; set; }
        public string titulo { get; set; }
        public string descripcion { get; set; }
        public DateTime? f_ini { get; set; }
        public DateTime? f_fin { get; set; }
        public int? leido_consultor { get; set; }
        public int? leido_programador { get; set; }
    }
}

