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
    public partial class frmPerformance : Form
    {
        Int16 gPaisID;
        public frmPerformance(Int16 PaisID)
        {
            InitializeComponent();
            gPaisID = PaisID;
            CarregarDados();
            AjustarTitulo();
        }

        private void CarregarDados()
        {
            RNRankingGeral rn = new RNRankingGeral();
            List<RankingGeral> lista = rn.PerformanceDe1Pais(gPaisID, Competicao.Masculino);
            grdMain.DataSource = lista;
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            frmMain pai = (frmMain)this.MdiParent;
            pai.AbrirPaisLista();
        }

        private void AjustarTitulo()
        {
            RNPais oRN = new RNPais();
            Pais oPais = oRN.Sel(gPaisID);
            lblTitulo.Text = "Performance em Copas do Mundo: " + oPais.Nome;
        }

        private void frmPerformance_Shown(object sender, EventArgs e)
        {
            //centraliza elementos da tela
            lblTitulo.Left = (this.ClientSize.Width - lblTitulo.Width) / 2;
            grdMain.Left = (this.ClientSize.Width - grdMain.Width) / 2;

            // Se o pais for Tchéquia, Alemanha, Iugoslávia, União Soviética, Sérvia ou Zaire
            if (gPaisID == 69 || gPaisID == 80 || gPaisID == 11 || gPaisID == 47 || gPaisID == 44)
            {
                string paisRelacionado = "";
                switch (gPaisID)
                {
                    case 69: paisRelacionado = "Tchecoslovaquia"; break;
                    case 80: paisRelacionado = "Iugoslávia"; break;
                    case 11: paisRelacionado = "Alemanha Ocidental"; break;
                    case 47: paisRelacionado = "União Soviética"; break;
                    case 44: paisRelacionado = "Zaire"; break;
                }
                MessageBox.Show("ATENÇÃO: Possui dados de " + paisRelacionado + "!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
