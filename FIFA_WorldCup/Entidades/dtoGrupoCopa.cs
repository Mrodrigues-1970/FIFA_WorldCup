using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIFA_WorldCup.Entidades
{
    public class dtoGrupoCopa
    {
        public Int16 Grupo_ID { get; set; }
        public string Grupo { get; set; }
        public Int16 Pais_ID { get; set; }
        public string Pais { get; set; }
        public Int16 Rank { get; set; }
    }
}
