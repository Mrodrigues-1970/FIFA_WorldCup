using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIFA_WorldCup.Entidades
{
    public class Grupo
    {
        public Int16 ID { get; set; }
        public Int16 CopaID { get; set; }
        public Int16 TipoFaseID { get; set; }
        public string Nome { get; set; }
    }
}
