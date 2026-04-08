using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FIFA_WorldCup.Entidades;
using FIFA_WorldCup.Dal;
using System.Windows.Forms;

namespace FIFA_WorldCup.RN
{
    public class RNPartida
    {
        public List<Partida> Sel(Partida vPartida)
        {
            DalPartida oDal = new DalPartida();
            return oDal.Sel(vPartida);
        }

        public List<Partida> SelPartidasDoPais(Int16 vPaisID)
        {
            DalPartida oDal = new DalPartida();
            return oDal.SelPartidasDoPais(vPaisID);
        }

        public Partida Sel(Int16 vPartidaID)
        {
            DalPartida oDal = new DalPartida();
            return oDal.Sel(vPartidaID);
        }

        public bool PaisPossuiPartidas(Int16 PaisID, Int16 CopaID)
        {
            DalPartida oDal = new DalPartida();
            return oDal.PaisPossuiPartidas(PaisID, CopaID);
        }

        public bool PaisPossuiPartidasEmTipoCopa(Int16 PaisID, Competicao TipoCopa)
        {
            DalPartida oDal = new DalPartida();
            return oDal.PaisPossuiPartidasEmTipoCopa(PaisID, TipoCopa);
        }


        public void Salvar(Partida vPartida)
        {
            DalPartida oDal = new DalPartida();
            oDal.Salvar(vPartida);
        }

        public Int16 UltimoID()
        {
            DalPartida oDal = new DalPartida();
            return oDal.UltimoID();
        }

        public Partida SelFinal(Int16 vCopaID)
        {
            DalPartida oDal = new DalPartida();
            return oDal.SelFinal(vCopaID);
        }


    }
}
