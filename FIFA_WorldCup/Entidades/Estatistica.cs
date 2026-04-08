using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIFA_WorldCup.Entidades
{
    public class Estatistica
    {

        public Int16 PaisID { get; set; }
        public Int16 NumeroPartidas { get; set; }
        public Int16 NumeroVitorias { get; set; }
        public Int16 NumeroEmpates { get; set; }
        public Int16 NumeroDerrotas { get; set; }
        public Int16 GolsMarcados { get; set; }
        public Int16 GolsSofridos { get; set; }
        public Int16 PontuacaoGeral { get; set; }
        public List<Int16> Copas { get; set; }
        public Competicao Competicao { get; set; }

        /// <summary>
        /// Saldo = Gols Macrados - Gols Sofridos
        /// </summary>
        public Int16 SaldoGols
        {
            get { return Convert.ToInt16( this.GolsMarcados - this.GolsSofridos); }
        }

    }
}
