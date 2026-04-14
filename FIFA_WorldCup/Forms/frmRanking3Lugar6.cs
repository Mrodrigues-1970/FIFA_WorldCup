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
            RNRankingGeral rn = new RNRankingGeral();
            List<RankingGeral> lista = rn.Ranking3Lugar(gCopaID);
            grdRanking.DataSource = lista;
        }

        private void frmRanking3Lugar6_Shown(object sender, EventArgs e)
        {
            //Deixa as 4 primeiras linhas do grid com a cor de fundo diferente, para destacar os 4 primeiros colocados
            for (int i = 0; i < 4; i++)
            {
                grdRanking.Rows[i].DefaultCellStyle.BackColor = Color.LightBlue;
            }
        }
    }
}
