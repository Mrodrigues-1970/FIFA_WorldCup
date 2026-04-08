using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FIFA_WorldCup.Entidades;
using FIFA_WorldCup.Dal;

namespace FIFA_WorldCup.RN
{
    public class RNTipoFase
    {
        public List<TipoFase> Sel(TipoFase vTipoFase)
        {
            DalTipoFase oDal = new DalTipoFase();
            return oDal.Sel(vTipoFase);
        }

        public TipoFase Sel(Int16 vTipoFaseID)
        {
            DalTipoFase oDal = new DalTipoFase();
            return oDal.Sel(vTipoFaseID);
        }

        public List<TipoFase> SelTodos()
        {
            DalTipoFase oDal = new DalTipoFase();
            return oDal.SelTodos();
        }

    }
}
