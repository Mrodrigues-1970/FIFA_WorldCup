using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIFA_WorldCup.Entidades
{
    public class Partida
    {
        public Int16 ID { get; set; }
        public DateTime Data { get; set; }
        public Int16 Local { get; set; }
        public Int16 GrupoID { get; set; }
        public Int16 SelecaoID_A { get; set; }
        public Confederacao ConfederacaoA { get; set; }
        public Int16 Gols_A { get; set; }
        public Int16 SelecaoID_B { get; set; }
        public Confederacao ConfederacaoB { get; set; }
        public Int16 Gols_B { get; set; }
        public Int16? Ordem_Treeview { get; set; } // Ordem de exibição no TreeView, se for nulo, não será exibido no TreeView

        //========Campos não presentes na tabela
        public Int16 CopaID { get; set; }
        public string CopaNome { get; set; }
        public string Estadio { get; set; }
        public string NomePaisA { get; set; }
        public string NomePaisB { get; set; }
        public Competicao Competicao { get; set; }
























        public Desempate Desempate { get; set; }

    }
}
