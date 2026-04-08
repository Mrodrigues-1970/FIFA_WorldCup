using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FIFA_WorldCup.Entidades
{
    public class Pais
    {
        public Int16 ID { get; set; }
        public Confederacao Confederacao { get; set; }
        public string Nome { get; set; }
        public string Nome_Ingles { get; set; }
        public bool? Ativo { get; set; }
        public Int16 Rank { get; set; }
        public string NomeRank {
            get { return Nome + " (" + Rank + ")"; }
        }
    }
}
