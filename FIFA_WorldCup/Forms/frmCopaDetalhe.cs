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
    public partial class frmCopaDetalhe : Form
    {
        Int16 gCopaID;
        Competicao gCompeticao;
        public frmCopaDetalhe(Int16 CopaID)
        {
            InitializeComponent();
            gCopaID = CopaID;
            CarregarTipoCopas();
            CarregarStatusCopa();
            if (gCopaID > 0)
            {
                CarregarDoBanco();
            }
        }


        private void CarregarTipoCopas()
        {
            List<Competicao> lstCompeticao = new List<Competicao>();
            lstCompeticao.Add(Competicao.Masculino);
            lstCompeticao.Add(Competicao.Feminino);
            //Copa das Confederações não é mais realizada, então não será adicionada à lista de competições
            //lstCompeticao.Add(Competicao.Confederacoes);
            cboTipoCopa.DataSource = lstCompeticao;
        }

        private void CarregarStatusCopa()
        {
            List<StatusCopa> lstStatusCopa = new List<StatusCopa>();
            lstStatusCopa.Add(StatusCopa.Realizada);
            lstStatusCopa.Add(StatusCopa.Corrente);
            lstStatusCopa.Add(StatusCopa.Futura);
            cboStatus.DataSource = lstStatusCopa;
        }


        private void CarregarDoBanco()
        {
            RNCopa rn = new RNCopa();
            Copa copa = rn.Sel(gCopaID);
            if (copa != null) {
                txtNomeCopa.Text = copa.Nome;
                txtAnoCopa.Text = copa.Ano.ToString();
                txtMascote.Text = copa.Mascote;
                cboTipoCopa.SelectedItem = copa.Competicao;
                dataInicial.Value = copa.Data_Inicial;
                dataFinal.Value = copa.Data_Final;
                cboTipoCopa.SelectedItem = copa.Competicao;
                cboStatus.SelectedItem = copa.Status;
            }
            gCompeticao = copa.Competicao;
        }

        private Copa CarregarDoForm()
        {
            Copa copa = new Copa();
            copa.ID = gCopaID;
            copa.Nome = txtNomeCopa.Text;
            copa.Ano = Convert.ToInt16(txtAnoCopa.Text);
            copa.Mascote = txtMascote.Text;
            copa.Competicao = (Competicao)cboTipoCopa.SelectedItem;
            copa.Data_Inicial = dataInicial.Value;
            copa.Data_Final = dataFinal.Value;
            copa.Status = (StatusCopa)cboStatus.SelectedItem;
            return copa;
        }


        private void btSalvar_Click(object sender, EventArgs e)
        {
            Copa oCopa = CarregarDoForm();
            RNCopa rn = new RNCopa();
            rn.Salvar(oCopa);
            IrParaLista();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            IrParaLista();
        }

        private void IrParaLista()
        {
            frmMain pai = (frmMain)this.MdiParent;
            pai.AbrirCopaLista(gCompeticao);
        }
    }
}
