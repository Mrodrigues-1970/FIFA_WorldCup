using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FIFA_WorldCup.Dal;
using FIFA_WorldCup.Entidades;

namespace FIFA_WorldCup.Forms
{
    public partial class frmLigacaoDetalhe : Form
    {
        Int16 gPaisPaiID;
        public frmLigacaoDetalhe(Int16 vPaisPaiID)
        {
            InitializeComponent();
            gPaisPaiID = vPaisPaiID;
            CarregarPai();
            CarregarTipos();
            CarregarFilhos();
        }

        private void CarregarPai()
        {
            DalPais dal = new DalPais();
            Pais oPais = dal.Sel(gPaisPaiID);
            txtNomePais.Text = oPais.Nome;
        }

        private void CarregarTipos()
        {
            List<TipoLigacao> lista = new List<TipoLigacao>();
            lista.Add(TipoLigacao.Anexado_A);
            lista.Add(TipoLigacao.Dividido_Em);
            lista.Add(TipoLigacao.Fundido_Em);
            lista.Add(TipoLigacao.Renomeado_Para);
            ddlTipoLigacao.DataSource = lista;
        }

        private void CarregarFilhos()
        {
            DalPais dal = new DalPais();
            List<Pais> lista = dal.SelParticipantesDisponiveis(0);
            lstPaisesFilhos.ValueMember = "ID";
            lstPaisesFilhos.DisplayMember = "Nome";
            lstPaisesFilhos.DataSource = lista;
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            if(lstPaisesFilhos.SelectedItems.Count > 0)
            {
                Ligacao oLigacao = new Ligacao();
                oLigacao.PaisID1 = gPaisPaiID;
                oLigacao.PaisID2 = (Int16)lstPaisesFilhos.SelectedValue;
                oLigacao.Tipo = (TipoLigacao)ddlTipoLigacao.SelectedValue;
                DalLigacao dal = new DalLigacao();
                dal.Ins(oLigacao);
                IrParaLista();
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            IrParaLista();
        }

        private void IrParaLista()
        {
            frmMain frm = (frmMain)this.MdiParent;
            frm.AbrirLigacoesLista(gPaisPaiID);
        }

    }
}
