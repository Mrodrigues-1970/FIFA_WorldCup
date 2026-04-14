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
            for (int i = 0; i < 6; i++)
            {
                grdRanking.Rows[i].Cells[0].Value = (i + 1).ToString();
                if (i < 4)
                {
                    grdRanking.Rows[i].DefaultCellStyle.BackColor = Color.LightBlue;
                }                
            }
        }

        private void grdRanking_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            string path = GlobalVariables.pathFlags;
            try
            {
                foreach (DataGridViewRow iLinha in grdRanking.Rows)
                {
                    DataGridViewImageCell img = (DataGridViewImageCell)iLinha.Cells["Flag"];
                    img.ImageLayout = DataGridViewImageCellLayout.Stretch;

                    string PaisID = iLinha.Cells["PaisID"].Value.ToString();
                    string nomeArquivo = path + PaisID + ".png";
                    Image flag = new Bitmap(nomeArquivo);
                    img.Value = (Image)flag;

                }



            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar as bandeiras: " + ex.Message);
            }
        }

        private void picVoltar_Click(object sender, EventArgs e)
        {
            frmMain pai = (frmMain)this.MdiParent;
            pai.AbrirFaseGrupos6(gCopaID);
        }
    }
}
