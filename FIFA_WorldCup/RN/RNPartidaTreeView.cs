using FIFA_WorldCup.Dal;
using FIFA_WorldCup.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIFA_WorldCup.RN
{
    public class RNPartidaTreeView
    {

        public List<PartidaTreeView> Sel(Int16 vCopaID)
        {
            DalPartidaTreeview dal = new DalPartidaTreeview();
            return dal.Sel(vCopaID);
        }

        public List<PartidaTreeView> SelSemiFinaisEFinal(Int16 vCopaID)
        {
            DalPartidaTreeview dal = new DalPartidaTreeview();
            return dal.SelSemiFinaisEFinal(vCopaID);
        }

    }
}
