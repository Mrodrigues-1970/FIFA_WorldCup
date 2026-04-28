using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FIFA_WorldCup.RN;
using FIFA_WorldCup.Entidades;


namespace FIFA_WorldCup.Forms
{
    public partial class frmCidadeDetalhe : Form
    {
        Int16 gCidade_ID;
        Int16 gPaisID;
        public frmCidadeDetalhe(Int16 CidadeID, Int16 PaisID)
        {
            InitializeComponent();
            gCidade_ID = CidadeID;
            gPaisID = PaisID;
            CarregarPais();
            if (gCidade_ID != 0)
            {
                CarregarDoBanco();
            }            
        }


        private void CarregarDoBanco() {  
            RNCidade rn = new RNCidade();
            Cidade oCidade = rn.Sel(gCidade_ID);
            if (oCidade != null)
            {
                txtNome.Text = oCidade.Nome;
                txtNomeIngles.Text = oCidade.NomeIngles;
            }
        }

        private void CarregarPais()
        {
            RNPais rn = new RNPais();
            Pais oPais = rn.Sel(gPaisID);
            if (oPais != null)
            {
                lblNomePais.Text = oPais.Nome;
            }
        }

        private Cidade CarregarDoForm()
        {                       
            Cidade oCidade = new Cidade();
            oCidade.ID = gCidade_ID;
            oCidade.Nome = txtNome.Text;
            oCidade.NomeIngles = txtNomeIngles.Text;
            oCidade.PaisID = gPaisID;
            return oCidade;
        }


        private void picSalvar_Click(object sender, EventArgs e)
        {
            RNCidade rn = new RNCidade();
            rn.Salvar(CarregarDoForm());
            IrParaLista();
        }

        private void picCancelar_Click(object sender, EventArgs e)
        {
            IrParaLista();
        }

        private void IrParaLista()
        {
            frmMain pai = (frmMain)this.MdiParent;
            pai.AbrirListaCidades(gPaisID);
        }

        private void lblCopiar_Click(object sender, EventArgs e)
        {
            txtNomeIngles.Text = txtNome.Text;
        }
    }
}
