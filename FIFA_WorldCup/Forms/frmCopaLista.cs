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
    public partial class frmCopaLista : Form
    {
        public frmCopaLista(Competicao vCompeticao)
        {
            InitializeComponent();
            CarregarCompeticoes(vCompeticao);
            CarregarGrid();
        }

        protected void CarregarGrid()
        {
            try
            {
                DalCopa dal = new DalCopa();
                Copa filtro = new Copa();
                filtro.Competicao = (Competicao)cboCompeticao.SelectedValue;
                List<Copa> lista = dal.Sel(filtro);
                grdMain.DataSource = lista;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro na aplicação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        protected void CarregarCompeticoes(Competicao selecionado)
        {
            List<Competicao> lista = new List<Competicao>();
            lista.Add(Competicao.Masculino);
            lista.Add(Competicao.Feminino);
            lista.Add(Competicao.Confederacoes);
            cboCompeticao.DataSource = lista;
            cboCompeticao.SelectedItem = selecionado;
        }

        private void cboCompeticao_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        private NocauteDisponivel TipoNocaute(Int16 CopaID) {

            RNCopa rn = new RNCopa();
            NocauteDisponivel nocautes = rn.NocauteCopa(CopaID);
            return nocautes;
        }

        private void btnParticipantes_Click(object sender, EventArgs e)
        {
            Int16 CopaID = Convert.ToInt16(grdMain.SelectedRows[0].Cells["ID"].Value);
            frmMain frm = (frmMain)this.MdiParent;
            //frm.AbrirParticipantes(Ano);
            frm.AbrirDisplayParticipantes(CopaID);
        }

        private void btnGrupos_Click(object sender, EventArgs e)
        {
            Int16 CopaID = Convert.ToInt16(grdMain.SelectedRows[0].Cells["ID"].Value);
            frmMain frm = (frmMain)this.MdiParent;
            frm.AbrirGruposLista(CopaID);
        }

        private void btnLocais_Click(object sender, EventArgs e)
        {
            Int16 CopaID = Convert.ToInt16(grdMain.SelectedRows[0].Cells["ID"].Value);
            frmMain frm = (frmMain)this.MdiParent;
            frm.AbrirLocalLista(CopaID);
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            Int16 CopaID = Convert.ToInt16(grdMain.SelectedRows[0].Cells["ID"].Value);
            frmMain frm = (frmMain)this.MdiParent;
            frm.AbrirDisplayResultados(CopaID);
        }

        private void btnMatamata_Click(object sender, EventArgs e)
        {
            Int16 CopaID = Convert.ToInt16(grdMain.SelectedRows[0].Cells["ID"].Value);
            NocauteDisponivel nocautes = TipoNocaute(CopaID);
            frmMain frm = (frmMain)this.MdiParent;
            switch (nocautes)
            {
                case NocauteDisponivel.Nenhum:
                    MessageBox.Show("Não é possível exibir o Mata Mata para esta Copa do Mundo.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case NocauteDisponivel.Oitavas:
                case NocauteDisponivel.Quartas:
                    frm.AbrirTreeView(CopaID);
                    break;

                case NocauteDisponivel.Hexavas:
                    frm.AbrirTreeView32(CopaID);
                    break;
            }
        }

        private void btnVagas_Click(object sender, EventArgs e)
        {
            Int16 CopaID = Convert.ToInt16(grdMain.SelectedRows[0].Cells["ID"].Value);
            frmMain frm = (frmMain)this.MdiParent;
            frm.AbrirListaVagas(CopaID);
        }

        private void masculinoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExecutarCalculoRankingGeral(Competicao.Masculino);
        }

        private void femininoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExecutarCalculoRankingGeral(Competicao.Feminino);
        }

        private void confederaçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExecutarCalculoRankingGeral(Competicao.Confederacoes);
        }

        private void ExecutarCalculoRankingGeral(Competicao oCompeticao)
        {
            frmMain pai = (frmMain)this.MdiParent;
            pai.AbrirCalculoRankingGeral(oCompeticao);
        }


    }
}
