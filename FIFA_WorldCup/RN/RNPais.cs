using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FIFA_WorldCup.Entidades;
using FIFA_WorldCup.Dal;

namespace FIFA_WorldCup.RN
{
    public class RNPais
    {

        public void Salvar(Pais vPais)
        {
            DalPais oDal = new DalPais();
            if (vPais.ID == 0)
            {
                oDal.Ins(vPais);
            }
            else
            {
                oDal.Upd(vPais);
            }
        }


        public List<Pais> Sel(Pais vPais)
        {
            DalPais oDal = new DalPais();
            return oDal.Sel(vPais);
        }

        public List<Pais> SelParticipantesDisponiveis(Int16 vCopaID)
        {
            DalPais oDal = new DalPais();
            return oDal.SelParticipantesDisponiveis(vCopaID);

        }

        public List<Pais> SelParticipantesSelecionados(Int16 vCopaID)
        {
            DalPais oDal = new DalPais();
            return oDal.SelParticipantesSelecionados(vCopaID);
        }

        public Pais Sel(Int16 vPaisID)
        {
            DalPais oDal = new DalPais();
            return oDal.Sel(vPaisID);
        }

        public List<Pais> MembrosDoGrupo(Int16 vGrupoID) { 
            DalPais oDal = new DalPais();
            return oDal.MembrosDoGrupo(vGrupoID);
        }

    }
}
