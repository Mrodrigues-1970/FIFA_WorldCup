using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIFA_WorldCup.Entidades
{
    public class dtoPartidasGrupo
    {

        public Int16 Grupo_ID { get; set; }
        public string Grupo_Nome { get; set; }
        public DateTime Data { get; set; }
        public string Pais_A { get; set; }
        public Int16 Gols_A { get; set; }
        public string Pais_B { get; set; }
        public Int16 Gols_B { get; set; }
        public Int16 PaisID_A { get; set; }
        public Int16 PaisID_B { get; set; }
    }
}
