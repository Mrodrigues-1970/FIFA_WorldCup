using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIFA_WorldCup.Entidades
{
    public class PosicaoGrupo
    {
        public Int16 GrupoID { get; set; }
        public Int16 Posicao { get; set; }
        public Int16 PaisID { get; set; }

        //Propriedade não consta na tabela
        public string NomePais { get; set; }


    }
}
