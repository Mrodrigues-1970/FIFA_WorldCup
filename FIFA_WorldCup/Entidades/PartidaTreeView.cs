using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIFA_WorldCup.Entidades
{
    public class PartidaTreeView
    {
        public Int16 Tipo_Fase { get; set; }
        public Int16 SelecaoA { get; set; }
        public string NomeSelecaoA { get; set; }
        public Int16 Gols_A { get; set; }
        public Int16 SelecaoB { get; set; }
        public string NomeSelecaoB { get; set; }
        public Int16 Gols_B { get; set; }
        public Int16? Ordem { get; set; }
        public DateTime? DataPartida { get; set; }
    }
}
