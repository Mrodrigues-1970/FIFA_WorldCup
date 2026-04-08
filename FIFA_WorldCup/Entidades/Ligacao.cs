using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIFA_WorldCup.Entidades
{
    public class Ligacao
    {
        public Int16 ID { get; set; }
        public Int16 PaisID1 { get; set; }
        public string Nome1 { get; set; }
        public Int16 PaisID2 { get; set; }
        public string Nome2 { get; set; }
        public TipoLigacao Tipo { get; set; }
    }
}
