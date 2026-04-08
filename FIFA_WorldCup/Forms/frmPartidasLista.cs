using FIFA_WorldCup.Entidades;
using FIFA_WorldCup.RN;
using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace FIFA_WorldCup.Forms
{
    public partial class frmPartidasLista : Form
    {
        Int16 vCopaID;
        Int16 gGrupoID;
        public frmPartidasLista(Int16 vCopaID, Int16 vGrupoID)
        {
            InitializeComponent();
            this.vCopaID = vCopaID;
            gGrupoID = vGrupoID;
            CarregarGrid();
            AtualizarTitulo();
        }

        protected void CarregarGrid()
        {
            try
            {
                RNPartida rn = new RNPartida();
                Partida filtro = new Partida();
                filtro.GrupoID = gGrupoID;
                List<Partida> lista = rn.Sel(filtro);
                grdMain.DataSource = lista;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro na aplicação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AtualizarTitulo()
        {
            RNGrupo rn = new RNGrupo();
            RNCopa rnC = new RNCopa();
            Grupo oGrupo = rn.Sel(gGrupoID);
            if(oGrupo != null)
            {
                lblTitulo.Text = "Lista de partidas do grupo '" + oGrupo.Nome + "' da copa " + rnC.RetornaNomeCopa(vCopaID);
            }
        }


        private void frmPartidasLista_Shown(object sender, EventArgs e)
        {
            //centraliza itens
            lblTitulo.Left = (this.ClientSize.Width - lblTitulo.Size.Width) / 2;
            grdMain.Left = (this.ClientSize.Width - grdMain.Size.Width) / 2;
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            frmMain frm = (frmMain)this.MdiParent;
            frm.AbrirPartidaDetalhe(gGrupoID, 0);
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (grdMain.SelectedRows.Count > 0)
            {
                Int16 PartidaID = (Int16)grdMain.SelectedRows[0].Cells["ID"].Value;
                frmMain frm = (frmMain)this.MdiParent;
                frm.AbrirPartidaDetalhe(gGrupoID, PartidaID);
            }
        }

        private void btnGrupos_Click(object sender, EventArgs e)
        {
            frmMain frm = (frmMain)this.MdiParent;
            frm.AbrirGruposLista(vCopaID);
        }
    }
}
