using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FIFA_WorldCup.Forms;
using FIFA_WorldCup.Entidades;

namespace FIFA_WorldCup
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        #region Menu

        private void mnCopa_Click(object sender, EventArgs e)
        {
            AbrirCopaLista(Competicao.Masculino);
        }

        private void mnPais_Click(object sender, EventArgs e)
        {
            AbrirPaisLista();
        }

        private void mnAnfitrioes_Click(object sender, EventArgs e)
        {
            AbrirAnfitrioes();
        }

        private void mnParticipacoes_Click(object sender, EventArgs e)
        {
            AbrirParticipacoes();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnQuadrangular_Click(object sender, EventArgs e)
        {
                AbrirSimuladorQuadrangular();
        }

        private void mnCopaMasculina_Click(object sender, EventArgs e)
        {
            AbrirSimuladorCopaMasculino();
        }

        private void mnFIFARanking_Click(object sender, EventArgs e)
        {
            AbrirFIFARanking();
        }

        private void mnTabelas_Click(object sender, EventArgs e)
        {
            AbrirPosterLista();
        }

        #endregion

        #region Forms

        public void AbrirCopaLista(Competicao Competicao)
        {
            frmCopaLista frm = new frmCopaLista(Competicao);
            TratamentoNovoFormulario(frm);
        }

        public void AbrirPaisLista()
        {
            frmPaisLista frm = new frmPaisLista();
            TratamentoNovoFormulario(frm);
        }

        public void AbrirPaisDetalhe(Int16 vPaisID, Confederacao vConfederaacao)
        {
            frmPaisDetalhe frm = new frmPaisDetalhe(vPaisID, vConfederaacao);
            TratamentoNovoFormulario(frm);
        }

        public void AbrirParticipantes(Int16 vCopaID)
        {
            frmParticipanteLista frm = new frmParticipanteLista(vCopaID);
            TratamentoNovoFormulario(frm);
        }

        public void AbrirGruposLista(Int16 vCopaID)
        {
            frmGrupoLista frm = new frmGrupoLista(vCopaID);
            TratamentoNovoFormulario(frm);
        }

        public void AbrirGrupoDetalhe(Int16 vGrupoID, Int16 vCopaID)
        {
            frmGrupoDetalhe frm = new frmGrupoDetalhe(vGrupoID, vCopaID);
            TratamentoNovoFormulario(frm);
        }

        public void AbrirPartidasLista(Int16 vCopaID, Int16 vGrupoID)
        {
            frmPartidasLista frm = new frmPartidasLista(vCopaID, vGrupoID);
            TratamentoNovoFormulario(frm);
        }

        public void AbrirLocalLista(Int16 vCopaID)
        {
            frmLocalLista frm = new frmLocalLista(vCopaID);
            TratamentoNovoFormulario(frm);
        }

        public void AbrirLocalDetalhe(Int16 vCopaID, Int16 vLocalID)
        {
            frmLocalDetalhe frm = new frmLocalDetalhe(vCopaID, vLocalID);
            TratamentoNovoFormulario(frm);
        }

        public void AbrirPartidaDetalhe(Int16 vGrupoID, Int16 vPartidaID)
        {
            frmPartidaDetalhe frm = new frmPartidaDetalhe(vGrupoID, vPartidaID);
            TratamentoNovoFormulario(frm);
        }

        public void AbrirAnfitrioes()
        {
            frmAnfitrioes frm = new frmAnfitrioes();
            TratamentoNovoFormulario(frm);
        }

        public void AbrirLigacoesLista(Int16 vPaisPai_ID)
        {
            frmLigacaoLista frm = new frmLigacaoLista(vPaisPai_ID);
            TratamentoNovoFormulario(frm);
        }

        public void AbrirLigacaoDetalhe(Int16 vPaisPaiID)
        {
            frmLigacaoDetalhe frm = new frmLigacaoDetalhe(vPaisPaiID);
            TratamentoNovoFormulario(frm);
        }

        public void AbrirEstatisticas(Int16 vPaisID)
        {
            frmEstatisticas frm = new frmEstatisticas(vPaisID);
            TratamentoNovoFormulario(frm);
        }

        public void AbrirResultado(Int16 vCopaID)
        {
            frmResultado frm = new frmResultado(vCopaID);
            TratamentoNovoFormulario(frm);
        }

        public void AbrirParticipacoes()
        {
            frmParticipacoes frm = new frmParticipacoes();
            TratamentoNovoFormulario(frm);
        }

        public void AbrirSimuladorQuadrangular()
        {
            frmSimuladorQuadrangular frm = new frmSimuladorQuadrangular();
            TratamentoNovoFormulario(frm);
        }

        public void AbrirSimuladorCopaMasculino()
        {
            frmSimCopaMasculina frm = new frmSimCopaMasculina();
            TratamentoNovoFormulario(frm);
        }

        public void AbrirFIFARanking()
        {
            frmFIFARanking frm = new frmFIFARanking();
            TratamentoNovoFormulario(frm);
        }

        public void AbrirTreeView(Int16 CopaID)
        {
            frmTreeView frm = new frmTreeView(CopaID);
            TratamentoNovoFormulario(frm);
        }

        public void AbrirTreeView32(Int16 CopaID)
        {
            frmTreeview32 frm = new frmTreeview32(CopaID);
            TratamentoNovoFormulario(frm);
        }

        public void AbrirPosterLista()
        {
            frmPosterLista frm = new frmPosterLista();
            TratamentoNovoFormulario(frm);
        }

        public void AbrirFaseGrupos4(Int16 CopaID)
        {
            frmFaseGrupos4 frm = new frmFaseGrupos4(CopaID);
            TratamentoNovoFormulario(frm);
        }

        public void AbrirFaseGrupos6(Int16 CopaID)
        {
            frmFaseGrupos6 frm = new frmFaseGrupos6(CopaID);
            TratamentoNovoFormulario(frm);
        }

        public void AbrirFaseGrupos8(Int16 CopaID)
        {
            frmFaseGrupos8 frm = new frmFaseGrupos8(CopaID);
            TratamentoNovoFormulario(frm);
        }

        public void AbrirFaseGrupos12(Int16 CopaID)
        {
            frmFaseGrupos12 frm = new frmFaseGrupos12(CopaID);
            TratamentoNovoFormulario(frm);
        }

        public void AbrirSemiFinal(Int16 CopaID)
        {
            frmSemiFinal frm = new frmSemiFinal(CopaID);
            TratamentoNovoFormulario(frm);
        }

        public void AbrirFaseDetalhe(Int16 vCopaID, string vNomeGrupo, Int16 origem)
        {
            frmFaseDetalhe frm = new frmFaseDetalhe(vCopaID, vNomeGrupo, origem);
            TratamentoNovoFormulario(frm);
        }

        public void AbrirFaseGrupos2(Int16 CopaID)
        {
            frmFaseGrupos2 frm = new frmFaseGrupos2(CopaID);
            TratamentoNovoFormulario(frm);
        }

        public void AbrirFinal(Int16 CopaID)
        {
            frmFinal frm = new frmFinal(CopaID);
            TratamentoNovoFormulario(frm);
        }

        public void AbrirListaVagas(Int16 CopaID)
        {
            frmVagasLista frm = new frmVagasLista(CopaID);
            TratamentoNovoFormulario(frm);
        }

        public void AbrirVagasDetalhe(Int16 vCopaID, bool vInclusao, Confederacao vConfederacao)
        {
            frmVagasDetalhe frm = new frmVagasDetalhe(vCopaID, vInclusao, vConfederacao);
            TratamentoNovoFormulario(frm);
        }

        public void AbrirCalculoRankingGeral(Competicao oCompeticao)
        {
            frmCalculoRankingGeral frm = new frmCalculoRankingGeral(oCompeticao);
            TratamentoNovoFormulario(frm);
        }
        public void AbrirPerformance(Int16 vPaisID)
        {
            frmPerformance frm = new frmPerformance(vPaisID);
            TratamentoNovoFormulario(frm);
        }

        public void AbrirDisplayParticipantes(Int16 vCopaID)
        {
            frmParticipantesDisplay frm = new frmParticipantesDisplay(vCopaID);
            TratamentoNovoFormulario(frm);
        }

        public void AbrirDisplayResultados(Int16 vCopaID)
        {
            frmResultadoDisplay frm = new frmResultadoDisplay(vCopaID);
            TratamentoNovoFormulario(frm);
        }

        public void AbrirGrupoPosicaoDetalhe(Int16 vGrupoID, Int16 vCopaID)
        {
            frmGrupoPosicaoDetalhe frm = new frmGrupoPosicaoDetalhe(vGrupoID, vCopaID);
            TratamentoNovoFormulario(frm);
        }

        #endregion

        #region Geral

        protected void TratamentoNovoFormulario(Form frm)
        {
            Cursor = Cursors.WaitCursor;
            try
            {
                FecharFormularios();
                frm.MdiParent = this;
                frm.Show();
                frm.WindowState = FormWindowState.Maximized;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void FecharFormularios()
        {
            foreach (Form iFrm in this.MdiChildren)
            {
                iFrm.Close();
            }
        }









        #endregion


    }
}
