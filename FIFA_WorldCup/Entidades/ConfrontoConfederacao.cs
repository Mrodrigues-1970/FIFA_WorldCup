using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIFA_WorldCup.Entidades
{
    public class ConfrontoConfederacao
    {

        public Confederacao Confederacao { get; set; }
        public Int16 Vitorias { get; set; }
        public Int16 Empates { get; set; }
        public Int16 Derrotas { get; set; }
        public Int16 GolsMarcados { get; set; }
        public Int16 GolsSofridos { get; set; }


        public Int16 SaldoGols
        {
            get { return Convert.ToInt16(this.GolsMarcados - this.GolsSofridos); }
        }

        public Int16 Partidas
        {
            get { return Convert.ToInt16(this.Vitorias + this.Empates + this.Derrotas); }
        }
    }
}
