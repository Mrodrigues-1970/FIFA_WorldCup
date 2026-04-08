using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FIFA_WorldCup.Entidades;
using FIFA_WorldCup.RN;

namespace FIFA_WorldCup.Forms
{
    public partial class frmRanking3Lugar6 : Form
    {
        Int16 gCopaID;
        public frmRanking3Lugar6(Int16 Copa_ID)
        {
            InitializeComponent();
            gCopaID = Copa_ID;
            CarregarDados();
        }


        private void CarregarDados()
        {
            RNGrupo oRNGrupo = new RNGrupo();
            RNRankingGeral oRNRankingGeral = new RNRankingGeral();

            Int16 FaseGrupos = 1;
            List<Grupo> listaGrupo = oRNGrupo.SelPorCopaETipoFase(gCopaID, FaseGrupos);
            foreach (Grupo oGrupo in listaGrupo)
            {


                
            }

            
        }


    }
}
