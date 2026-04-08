using FIFA_WorldCup.Entidades;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FIFA_WorldCup.RN;

namespace FIFA_WorldCup.Forms
{
    /// <summary>
    /// LOCAL é palavra reservada, portanto a tabela foi renomeada para ESTADIO
    /// </summary>
    public partial class frmLocalLista : Form
    {
        Int16 gCopaID;
        public frmLocalLista(Int16 vCopaID)
        {
            InitializeComponent();
            gCopaID = vCopaID;
            CarregarGrid();
        }

        protected void CarregarGrid()
        {
            try
            {
                RNLocal rn = new RNLocal();
                RNCopa rnC = new RNCopa();
                List<Local> lista = rn.Sel(gCopaID);
                lblTitulo.Text = "Lista de locais da Copa " + rnC.RetornaNomeCopa(gCopaID);
                grdMain.DataSource = lista;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro na aplicação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmLocalLista_Shown(object sender, EventArgs e)
        {
            //centraliza itens da tela
            lblTitulo.Left = (this.ClientSize.Width - lblTitulo.Width) / 2;
            grdMain.Left = (this.ClientSize.Width - grdMain.Width) / 2;
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            frmMain frm = (frmMain)this.MdiParent;
            frm.AbrirLocalDetalhe(gCopaID, 0);
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (grdMain.SelectedRows.Count > 0)
            {
                Int16 LocalID = (Int16)grdMain.SelectedRows[0].Cells["ID"].Value;
                frmMain frm = (frmMain)this.MdiParent;
                frm.AbrirLocalDetalhe(gCopaID, LocalID);
            }
        }

        private void btnListaCopas_Click(object sender, EventArgs e)
        {
            RNCopa rn = new RNCopa();
            Competicao TipoCompeticao = rn.RetornaTipoCompeticao(gCopaID);
            frmMain frm = (frmMain)this.MdiParent;
            frm.AbrirCopaLista(TipoCompeticao);
        }

        private void btnGrupos_Click(object sender, EventArgs e)
        {
            frmMain frm = (frmMain)this.MdiParent;
            frm.AbrirGruposLista(gCopaID);
        }
    }
}
