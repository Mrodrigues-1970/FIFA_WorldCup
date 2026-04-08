using FIFA_WorldCup.Entidades;
using FIFA_WorldCup.Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FIFA_WorldCup.RN
{
    /// <summary>
    /// Vagas para Copas do Mundo registradas no Banco de Dados
    /// </summary>
    public class RNVagas
    {

        public List<VagaMasculino> SelPorCopa(Int16 Copa_ID)
        {
            DalVagas dalVagas = new DalVagas();
            return dalVagas.SelPorCopa(Copa_ID);
        }

        public VagaMasculino Sel(Int16 Copa_ID, Confederacao Confederacao)
        {
            DalVagas dalVagas = new DalVagas();
            return dalVagas.Sel(Copa_ID, Confederacao);
        }

        public void Salvar(VagaMasculino oVaga, bool Inclusao)
        {
            if (Inclusao)
            {
                Ins(oVaga);
            }
            else
            {
                Upd(oVaga);
            }
        }

        private void Ins(VagaMasculino vVaga)
        {
            DalVagas dalVagas = new DalVagas();
            dalVagas.Ins(vVaga);
        }

        private void Upd(VagaMasculino vVaga)
        {
            DalVagas dalVagas = new DalVagas();
            dalVagas.Upd(vVaga);
        }

        public List<Confederacao> ConfederacoesUsadas(Int16 Copa_ID)
        {
            DalVagas dalVagas = new DalVagas();
            return dalVagas.ConfederacoesUsadas(Copa_ID);
        }

    }
}
