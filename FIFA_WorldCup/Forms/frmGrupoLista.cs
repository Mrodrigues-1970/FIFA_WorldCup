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
    public partial class frmGrupoLista : Form
    {
        Int16 gCopaID;
        public frmGrupoLista(Int16 vCopaID)
        {
            InitializeComponent();
            gCopaID = vCopaID;
            AjustaTitulo();
            CarregarGrid();
        }

        private void AjustaTitulo()
        {
            RNCopa rn = new RNCopa();
            lblTitulo.Text = "Lista de Grupos da Copa " + rn.RetornaNomeCopa(gCopaID);
        }

        protected void CarregarGrid()
        {
            try
            {
                RNGrupo rn = new RNGrupo();
                List<Grupo> lista = rn.SelPorCopa(gCopaID);
                grdMain.DataSource = lista;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro na aplicação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmGrupoLista_Shown(object sender, EventArgs e)
        {
            //centraliza itens
            lblTitulo.Left = (this.ClientSize.Width - lblTitulo.Size.Width) / 2;
            grdMain.Left = (this.ClientSize.Width - grdMain.Size.Width) / 2;
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            frmMain frm = (frmMain)MdiParent;
            frm.AbrirGrupoDetalhe(0, gCopaID);
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Int16 GrupoID = Convert.ToInt16(grdMain.SelectedRows[0].Cells["ID"].Value);
            frmMain frm = (frmMain)MdiParent;
            frm.AbrirGrupoDetalhe(GrupoID, gCopaID);
        }

        private void btnPartidas_Click(object sender, EventArgs e)
        {
            Int16 GrupoID = Convert.ToInt16(grdMain.SelectedRows[0].Cells["ID"].Value);
            frmMain frm = (frmMain)MdiParent;
            frm.AbrirPartidasLista(gCopaID, GrupoID);
        }

        private void btnListaCopas_Click(object sender, EventArgs e)
        {
            RNCopa rn = new RNCopa();
            Competicao TipoCompeticao = rn.RetornaTipoCompeticao(gCopaID);
            frmMain frm = (frmMain)MdiParent;
            frm.AbrirCopaLista(TipoCompeticao);
        }

        private void btDefinirPosicao_Click(object sender, EventArgs e)
        {
            Int16 TipoFase = (Int16)(grdMain.SelectedRows[0].Cells["TipoFaseID"].Value);
            if (TipoFase == 1)
            {
                Int16 GrupoID = Convert.ToInt16(grdMain.SelectedRows[0].Cells["ID"].Value);
                frmMain frm = (frmMain)MdiParent;
                frm.AbrirGrupoPosicaoDetalhe(GrupoID, gCopaID);
            }
            else
            {
                MessageBox.Show("Definir posição só é permitido para a fase de grupos.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
