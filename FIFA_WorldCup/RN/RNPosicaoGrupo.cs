using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FIFA_WorldCup.Entidades;
using FIFA_WorldCup.Dal;

namespace FIFA_WorldCup.RN
{
    public class RNPosicaoGrupo
    {
        public List<PosicaoGrupo> Sel(Int16 GrupoID)
        {
            DalPosicaoGrupo dal = new DalPosicaoGrupo();
            return dal.Sel(GrupoID);
        }


        public void InserirPosicoes(List<PosicaoGrupo> lista)
        {
            DalPosicaoGrupo dal = new DalPosicaoGrupo();
            dal.InserirPosicoes(lista);
        }






    }
}
