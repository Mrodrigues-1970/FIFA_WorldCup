using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FIFA_WorldCup.Entidades;
using FIFA_WorldCup.Dal;

namespace FIFA_WorldCup.RN
{
    public class RNLocal
    {
        public List<Local> Sel(Int16 vCopaID)
        {
            DalLocal oDal = new DalLocal();
            return oDal.Sel(vCopaID);
        }


        public Local SelPorID(Int16 vLocalID)
        {
            DalLocal oDal = new DalLocal();
            return oDal.SelPorID(vLocalID);

        }

        public void Salvar(Local vLocal)
        {
            DalLocal oDal = new DalLocal();
            oDal.Salvar(vLocal);

        }
    }
}
