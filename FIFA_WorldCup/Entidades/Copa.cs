using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIFA_WorldCup.Entidades
{
    public class Copa
    {
        public Int16 ID { get; set; }
        public string Nome { get; set; }
        public Int16 Ano { get; set; }
        public string Mascote { get; set; }
        public StatusCopa Status { get; set; }
        public List<Pais> Sede { get; set; }
        public Competicao Competicao { get; set; }
        public DateTime Data_Inicial { get; set; }
        public DateTime Data_Final { get; set; }
    }
}
