using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIFA_WorldCup.Entidades
{
    /// <summary>
    /// Mostra o confronto de uma seleção sobre a outra
    /// </summary>
    public class ConfrontoPais
    {
        public Int16 AdversarioID { get; set; }
        public string NomeAdversario { get; set; }
        public Confederacao ConfederacaoAdversario { get; set; }
        public Int16 Vitorias { get; set; }
        public Int16 Empates { get; set; }
        public Int16 Derrotas { get; set; }
        public Int16 GolsMarcados { get; set; }
        public Int16 GolsSofridos { get; set; }
        public Competicao Competicao { get; set; }

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
