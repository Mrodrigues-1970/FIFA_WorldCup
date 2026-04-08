using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIFA_WorldCup.Entidades
{
    public class RankingGeral
    {
        public Int16 CopaID { get; set; }
        public Int16 PaisID { get; set; }
        public Int16 Jogos { get; set; }
        public Int16 Vitorias { get; set; }
        public Int16 Empates { get; set; }
        public Int16 Derrotas { get; set; }
        public Int16 GolsPro { get; set; }
        public Int16 GolsContra { get; set; }
        public Int16 Saldo { get; set; }
        public Int16 Pontos { get; set; }
        public Int16 TipoFase { get; set; }

        // Propriedade INEXISTENTES na tabela RANKING_GERAL
        public Int16 Ano { get; set; }

    }
}
