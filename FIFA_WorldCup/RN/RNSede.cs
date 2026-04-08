using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FIFA_WorldCup.Entidades;
using FIFA_WorldCup.Dal;

namespace FIFA_WorldCup.RN
{
    public class RNSede
    {
        public List<Sede> SelTodos()
        {
            DalSede oDal = new DalSede();
            return oDal.SelTodos();
        }

    }
}
