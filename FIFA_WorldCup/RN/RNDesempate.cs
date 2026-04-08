using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FIFA_WorldCup.Entidades;
using FIFA_WorldCup.Dal;

namespace FIFA_WorldCup.RN
{
    public class RNDesempate
    {

        public Desempate Sel(Int16 vDesempateID)
        {
            DalDesempate oDal = new DalDesempate();
            return oDal.Sel(vDesempateID);
        }

        public void Salvar(Desempate vDesempate)
        {
            DalDesempate oDal = new DalDesempate();
            oDal.Salvar(vDesempate);
        }

    }
}
