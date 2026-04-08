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
using FIFA_WorldCup.Dal;
using FIFA_WorldCup.RN;


namespace FIFA_WorldCup.Forms
{
    public partial class frmPaisLista : Form
    {
        public frmPaisLista()
        {
            InitializeComponent();
            CarregarConfederacoes();
            CarregarGrid();
        }

        protected void CarregarGrid()
        {
            try
            {
                RNPais rn = new RNPais();
                Pais filtro = new Pais();
                filtro.Confederacao = (Confederacao)Convert.ToInt16(cboConfederacao.SelectedValue);
                List<Pais> lista = rn.Sel(filtro);
                grdMain.DataSource = lista;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro na aplicação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected void CarregarConfederacoes()
        {
            try
            {
                List<Confederacao> lista = new List<Confederacao>();
                lista.Add(Entidades.Confederacao.CONMEBOL);
                lista.Add(Entidades.Confederacao.UEFA);
                lista.Add(Entidades.Confederacao.CAF);
                lista.Add(Entidades.Confederacao.CONCACAF);
                lista.Add(Entidades.Confederacao.AFC);
                lista.Add(Entidades.Confederacao.OFC);
                cboConfederacao.DataSource = lista;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro na aplicação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void cboConfederacao_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        protected void EditarObjeto(Int16 vPaisID)
        {
            frmMain frm = (frmMain)this.MdiParent;
            frm.AbrirPaisDetalhe(vPaisID, (Confederacao)cboConfederacao.SelectedValue);
        }

        private void grdMain_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            string path = GlobalVariables.pathFlags;
            try
            {
                foreach (DataGridViewRow iLinha in grdMain.Rows)
                {
                    DataGridViewImageCell img = (DataGridViewImageCell)iLinha.Cells["Bandeira"];
                    img.ImageLayout = DataGridViewImageCellLayout.Stretch;

                    string PaisID = iLinha.Cells["ID"].Value.ToString();
                    string nomeArquivo = path + PaisID + ".png";
                    Image flag = new Bitmap(nomeArquivo);
                    img.Value = (Image)flag;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            EditarObjeto(0);
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (grdMain.SelectedRows.Count > 0)
            {
                Int16 PaisID = Convert.ToInt16(grdMain.SelectedRows[0].Cells["ID"].Value);
                EditarObjeto(PaisID);
            }
        }

        private void btnLigacoes_Click(object sender, EventArgs e)
        {
            if (grdMain.SelectedRows.Count > 0)
            {
                Int16 PaisID = Convert.ToInt16(grdMain.SelectedRows[0].Cells["ID"].Value);
                frmMain frm = (frmMain)this.MdiParent;
                frm.AbrirLigacoesLista(PaisID);
            }
        }

        private void btnEstatisticas_Click(object sender, EventArgs e)
        {
            if (grdMain.SelectedRows.Count > 0)
            {
                Int16 PaisID = Convert.ToInt16(grdMain.SelectedRows[0].Cells["ID"].Value);
                frmMain frm = (frmMain)this.MdiParent;
                frm.AbrirEstatisticas(PaisID);
            }
        }

        private void btnPerformance_Click(object sender, EventArgs e)
        {
            if (grdMain.SelectedRows.Count > 0)
            {
                Int16 PaisID = Convert.ToInt16(grdMain.SelectedRows[0].Cells["ID"].Value);
                frmMain frm = (frmMain)this.MdiParent;
                frm.AbrirPerformance(PaisID);
            }
        }



    }
}
