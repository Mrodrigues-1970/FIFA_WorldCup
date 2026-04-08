using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIFA_WorldCup.Entidades
{
    public class Desempate
    {
        public Int16 ID { get; set; }
        public Int16 Partida { get; set; }
        public TipoDesempate Tipo { get; set; }
        public Int16 Gols_A { get; set; }
        public Int16 Gols_B { get; set; }

    }
}
