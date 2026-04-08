using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIFA_WorldCup.Entidades
{
    public class Sede
    {
        public Int16 CopaID { get; set; }
        public string Nome { get; set; }
        public Competicao Competicao { get; set; }
        /// <summary>
        /// Para ser usado em consulta
        /// </summary>
        public Int16 Ano { get; set; }
    }
}
