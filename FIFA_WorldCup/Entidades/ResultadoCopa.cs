using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIFA_WorldCup.Entidades
{
    public class ResultadoCopa
    {
        public Int16 CopaID { get; set; }
        public Int16 Posicao1_ID { get; set; }
        public string Posicao1_nome { get; set; }

        public Int16 Posicao2_ID { get; set; }
        public string Posicao2_nome { get; set; }

        public Int16 Posicao3_ID { get; set; }
        public string Posicao3_nome { get; set; }

        public Int16 Posicao4_ID { get; set; }
        public string Posicao4_nome { get; set; }

    }
}
