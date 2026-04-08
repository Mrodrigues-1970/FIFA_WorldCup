using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FIFA_WorldCup.Entidades;
using FIFA_WorldCup.Dal;

namespace FIFA_WorldCup.RN
{
    public class RNGrupo
    {

        public List<Grupo> Sel(Grupo vGrupo)
        {
            DalGrupo oDal = new DalGrupo();
            return oDal.Sel(vGrupo);
        }

        public List<Grupo> SelPorCopa(Int16 vCopaID)
        {
            Grupo filtro = new Grupo();
            filtro.CopaID = vCopaID;
            return Sel(filtro);
        }

        public List<Grupo> SelPorCopaETipoFase(Int16 vCopaID, Int16 TipoFase)
        {
            Grupo filtro = new Grupo();
            filtro.CopaID = vCopaID;
            filtro.TipoFaseID = TipoFase;
            return Sel(filtro);
        }

        public Grupo Sel(Int16 vID)
        {
            DalGrupo oDal = new DalGrupo();
            return oDal.Sel(vID);
        }

        public void Salvar(Grupo vGrupo)
        {
            DalGrupo oDal = new DalGrupo();
            oDal.Salvar(vGrupo);
        }

    }
}
