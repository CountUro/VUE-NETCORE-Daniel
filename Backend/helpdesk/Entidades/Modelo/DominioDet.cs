using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades.Modelo
{
    public class DominioDet
    {
        public long dominio_det_id { get; set; }

        public short codigo { get; set; }
        public string descripcion { get; set; }

        public int dominio_id { get; set; }
        public Dominio dominio { get; set; }

        public int pais_id { get; set; }
        public Pais pais { get; set; }

        public string descrip_corta { get; set; }
        public int signo { get; set; }
        public int entero1 { get; set; }
        public int entero2 { get; set; }

        public ICollection<Cia> ciasTipo { get; set; }
        public ICollection<Cia> ciasMarca { get; set; }

        public ICollection<HdDoc> hdAplicaciones178 { get; set; }
        public ICollection<HdDoc> hdUrgencias170 { get; set; }
        public ICollection<HdDoc> hdTipo172 { get; set; }
        public ICollection<HdDoc> hdStatus175 { get; set; }
        public ICollection<HdDoc> hdModulo214 { get; set; }
        public ICollection<HdDoc> hdMotivos298 { get; set; }

        public ICollection<Persona> personasSexo { get; set; }
        public ICollection<HdSeguimiento> hdSeguimientos { get; set; }
    }
}
