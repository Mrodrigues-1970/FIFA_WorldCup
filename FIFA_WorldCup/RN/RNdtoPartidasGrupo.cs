using FIFA_WorldCup.Dal;
using FIFA_WorldCup.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FIFA_WorldCup.Entidades;

namespace FIFA_WorldCup.RN
{
    public class RNdtoPartidasGrupo
    {

        public List<dtoPartidasGrupo> Sel(Int16 vCopaID, string vGrupo)
        {
            DalDtoPartidasGrupo dal = new DalDtoPartidasGrupo();
            return dal.Sel(vCopaID, vGrupo);
        }

    }
}
