using FIFA_WorldCup.RN;
using FIFA_WorldCup.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FIFA_WorldCup.Forms
{
    public partial class frmCidadeLista : Form
    {
        Int16 gPaisID;
        public frmCidadeLista(Int16 PaisID)
        {
            InitializeComponent();
            gPaisID = PaisID;
            CarregarCidades();
            ComplementaTitulo();
        }

        private void CarregarCidades()
        {
            RNCidade rn = new RNCidade();
            List<Cidade> lista = rn.SelPorPais(gPaisID);
            grdMain.DataSource = lista;
        }

        private void ComplementaTitulo()
        {
            RNPais rn = new RNPais();
            Pais p = rn.Sel(gPaisID);
            lblTitulo.Text = "Cidades do país: " + p.Nome;
        }


        private void picIncluir_Click(object sender, EventArgs e)
        {
            IrParaDetalhe(0);
        }

        private void picAlterar_Click(object sender, EventArgs e)
        {
            if(grdMain.SelectedRows.Count == 1)
            {
                Int16 CidadeID = Convert.ToInt16(grdMain.SelectedRows[0].Cells["ID"].Value);
                IrParaDetalhe(CidadeID);
            }
        }


        private void IrParaDetalhe(Int16 CidadeID)
        {
            frmMain pai = (frmMain)this.MdiParent;
            pai.AbrirCidadeDetalhe(CidadeID, gPaisID);
        }

        private void frmCidadeLista_Shown(object sender, EventArgs e)
        {
            //centraliza o titulo do formulário
            lblTitulo.Left = (this.ClientSize.Width - lblTitulo.Width) / 2;
        }

        private void picCancelar_Click(object sender, EventArgs e)
        {
            frmMain pai = (frmMain)this.MdiParent;
            pai.AbrirPaisLista();
        }
    }
}
