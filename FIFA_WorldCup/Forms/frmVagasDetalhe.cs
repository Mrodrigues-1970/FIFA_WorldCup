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
    public partial class frmVagasDetalhe : Form
    {
        Int16 gCopa_ID;
        bool gInclusao;
        Confederacao gConfederacao;
        public frmVagasDetalhe(Int16 vCopaID, bool vInclusao, Confederacao vConfederacao)
        {
            InitializeComponent();
            gCopa_ID = vCopaID;
            gInclusao = vInclusao;
            gConfederacao = vConfederacao;
            CarregarConfederacoes();
            FormatarTitulo();
            if (!gInclusao)
            {
                CarregarVagaDobanco();
            }
        }

        private void CarregarVagaDobanco()
        {
            VagaMasculino oVaga;
            RNVagas rn = new RNVagas();
            oVaga = rn.Sel(gCopa_ID, gConfederacao);
            if (oVaga != null) {
                cboConfederacoes.SelectedItem = oVaga.Confederacao;
                numVagasDiretas.Value = Convert.ToDecimal(oVaga.VagasDiretas);
                numVagasRepescagem.Value = Convert.ToDecimal(oVaga.VagasRepescagem);
                numTotalCandidatos.Value = Convert.ToDecimal(oVaga.TotalCandidatos);
            }
        }

        private VagaMasculino CarregarDoForm()
        {
            VagaMasculino oVaga = new VagaMasculino();
            oVaga.CopaID = gCopa_ID;
            oVaga.Confederacao = (Confederacao)cboConfederacoes.SelectedItem;
            oVaga.VagasDiretas = Convert.ToDouble( numVagasDiretas.Value );
            oVaga.VagasRepescagem = Convert.ToDouble(numVagasRepescagem.Value);
            oVaga.TotalCandidatos = Convert.ToInt16(numTotalCandidatos.Value);
            return oVaga;
        }

        private void CarregarConfederacoes()
        {
            List<Confederacao> listaFinal = new List<Confederacao>();
            List<Confederacao> lista = new List<Confederacao>();
            RNVagas rn = new RNVagas();
            List<Confederacao> ConfederacoesUsadas = rn.ConfederacoesUsadas(gCopa_ID);
            lista.Add(Confederacao.AFC);
            lista.Add(Confederacao.CONCACAF);
            lista.Add(Confederacao.CONMEBOL);
            lista.Add(Confederacao.CAF);
            lista.Add(Confederacao.UEFA);
            lista.Add(Confederacao.OFC);

            foreach (Confederacao iConf in lista)
            {
                //Só disponibiliza a confederação se ela ainda não foi usada nesta copa
                if (!ConfederacoesUsadas.Contains(iConf) )
                {
                    listaFinal.Add(iConf);
                }
            }

            cboConfederacoes.DataSource = listaFinal;

        }

        private void FormatarTitulo()
        {
            RNCopa rn = new RNCopa();
            string nomeCopa = rn.RetornaNomeCopa(gCopa_ID);
            lblTitulo.Text = "Lista de vagas da Copa " + nomeCopa;
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            VagaMasculino oVaga = CarregarDoForm();
            RNVagas rn = new RNVagas();
            rn.Salvar(oVaga, gInclusao);
            IrParaLista();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            IrParaLista();
        }

        private void IrParaLista()
        {
            frmMain pai = (frmMain)this.MdiParent;
            pai.AbrirListaVagas(gCopa_ID);
        }


    }
}
