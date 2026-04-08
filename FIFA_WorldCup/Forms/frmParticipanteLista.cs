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
    public partial class frmParticipanteLista : Form
    {
        Int16 gCopaID;

        public frmParticipanteLista(Int16 vCopaID)
        {
            InitializeComponent();
            gCopaID = vCopaID;
            AjustaTitulo();
            CarregarDisponiveisDoBanco(gCopaID);
            CarregarAssociadosDoBanco(gCopaID);
        }

        private void AjustaTitulo()
        {
            RNCopa rn = new RNCopa();
            lblTitulo.Text = "Lista de Participantes da Copa " + rn.RetornaNomeCopa(gCopaID);
        }

        private void CarregarDisponiveisDoBanco(Int16 vCopaID)
        {
            RNPais rn = new RNPais();
            List<Pais> lista = rn.SelParticipantesDisponiveis(vCopaID);
            CarregaListaDisponiveis(lista);
        }

        private void CarregarAssociadosDoBanco(Int16 vCopaID)
        {
            RNPais rn = new RNPais();
            List<Pais> lista = rn.SelParticipantesSelecionados(vCopaID);
            CarregaListaAssociados(lista);
        }

        private void btAssociar_Click(object sender, EventArgs e)
        {
            Associa();
        }

        private void btDesaciociar_Click(object sender, EventArgs e)
        {
            Desassocia();
        }

        private void Associa()
        {
            Pais oPais = (Pais)lstDisponiveis.SelectedItem;
            if (oPais != null)
            {
                List<Pais> listaDisponiveis = (List<Pais>)lstDisponiveis.DataSource;
                listaDisponiveis.Remove(oPais);
                CarregaListaDisponiveis(listaDisponiveis);

                List<Pais> listaAssociados = (List<Pais>)lstAssociados.DataSource;
                listaAssociados.Add(oPais);
                CarregaListaAssociados(listaAssociados);
            }

        }

        private void Desassocia()
        {
            Pais oPais = (Pais)lstAssociados.SelectedItem;

            if(oPais != null)
            {
                List<Pais> listaAssociados = (List<Pais>)lstAssociados.DataSource;
                listaAssociados.Remove(oPais);
                CarregaListaAssociados(listaAssociados);

                List<Pais> listaDisponiveis = (List<Pais>)lstDisponiveis.DataSource;
                listaDisponiveis.Add(oPais);
                CarregaListaDisponiveis(listaDisponiveis);
            }
        }

        private void CarregaListaDisponiveis(List<Pais> vLista)
        {
            lstDisponiveis.DataSource = new List<Pais>();
            lstDisponiveis.DisplayMember = "Nome";
            lstDisponiveis.ValueMember = "ID";
            lstDisponiveis.DataSource = vLista;
        }

        private void CarregaListaAssociados(List<Pais> vLista)
        {
            lstAssociados.DataSource = new List<Pais>();
            lstAssociados.DisplayMember = "Nome";
            lstAssociados.ValueMember = "ID";
            lstAssociados.DataSource = vLista;
            lblAssociados.Text = "Países Associados (" + vLista.Count.ToString() + ")";
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            List<Pais> lista = (List<Pais>)lstAssociados.DataSource;
            RNParticipante rn = new RNParticipante();
            rn.Salvar(gCopaID, lista);
            Cursor = Cursors.Default;
            IrParaLista();
        }

        private void lstDisponiveis_DoubleClick(object sender, EventArgs e)
        {
            Associa();
        }

        private void lstAssociados_DoubleClick(object sender, EventArgs e)
        {
            Desassocia();
        }

        private void btCopaLista_Click(object sender, EventArgs e)
        {
            IrParaLista();
        }

        private void IrParaLista()
        {
            RNCopa rn = new RNCopa();
            Competicao TipoCompeticao = rn.RetornaTipoCompeticao(gCopaID);
            frmMain frm = (frmMain)this.MdiParent;
            frm.AbrirCopaLista(TipoCompeticao);
        }
    }
}
