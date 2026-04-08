using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FIFA_WorldCup.Entidades;
using FIFA_WorldCup.Dal;

namespace FIFA_WorldCup.RN
{
    public class RNLigacao
    {
        public List<Ligacao> SelLista(Int16 vPaisID)
        {
            DalLigacao oDal = new DalLigacao();
            return oDal.SelLista(vPaisID);
        }

        public Ligacao Sel(Int16 vPais1ID)
        {
            DalLigacao oDal = new DalLigacao();
            return oDal.Sel(vPais1ID);
        }

        public void Ins(Ligacao vLigacao)
        {
            DalLigacao oDal = new DalLigacao();
            oDal.Ins(vLigacao);
        }

        public void Del(Int16 vLigacaoID)
        {
            DalLigacao oDal = new DalLigacao();
            oDal.Del(vLigacaoID);
        }

        public bool ExisteLigacao(Int16 vPaisID)
        {
            DalLigacao oDal = new DalLigacao();
            return oDal.ExisteLigacao(vPaisID);
        }

    }
}
