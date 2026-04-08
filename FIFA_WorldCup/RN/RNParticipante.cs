using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FIFA_WorldCup.Entidades;
using FIFA_WorldCup.Dal;

namespace FIFA_WorldCup.RN
{
    public class RNParticipante
    {
        public void Salvar(Int16 vCopaID, List<Pais> vLista)
        {
            DalParticipante oDal = new DalParticipante();
            oDal.Salvar(vCopaID, vLista);
        }


        public List<Int16> CopasParticipadas(Int16 PaisID, Competicao oCompeticao)
        {
            DalParticipante oDal = new DalParticipante();
            return oDal.CopasParticipadas(PaisID, oCompeticao);
        }

    }
}
