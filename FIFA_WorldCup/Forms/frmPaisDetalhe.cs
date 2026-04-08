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
    public partial class frmPaisDetalhe : Form
    {
        Int16 gPaisID;

        public frmPaisDetalhe(Int16 vPaisID, Confederacao vConfederacao)
        {
            InitializeComponent();
            gPaisID = vPaisID;
            CarregarConfederacoes(vConfederacao);
            CarregarObjetoBanco();
        }

        private void CarregarObjetoBanco()
        {
            if(gPaisID > 0)
            {
                RNPais rn = new RNPais();
                Pais oPais = rn.Sel(gPaisID);
                cboConfederacao.SelectedItem = oPais.Confederacao;
                txtNomePortugues.Text = oPais.Nome;
                txtNomeIngles.Text = oPais.Nome_Ingles;
                txtRank.Text = oPais.Rank.ToString();
                chkAtivo.Checked = oPais.Ativo.Value;
                CarregarBandeira();
                CarregarConfederacao(oPais.Confederacao);
            }
        }

        protected void CarregarConfederacoes(Confederacao vConfederacao)
        {
            try
            {

                List<Confederacao> lista = new List<Confederacao>();
                lista.Add(Confederacao.CONMEBOL);
                lista.Add(Confederacao.UEFA);
                lista.Add(Confederacao.CAF);
                lista.Add(Confederacao.CONCACAF);
                lista.Add(Confederacao.AFC);
                lista.Add(Confederacao.OFC);
                cboConfederacao.DataSource = lista;
                cboConfederacao.SelectedItem = vConfederacao;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro na aplicação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Pais oPais = new Pais();
                oPais.Nome = txtNomePortugues.Text;
                oPais.Nome_Ingles = txtNomeIngles.Text;
                oPais.Confederacao = (Confederacao)cboConfederacao.SelectedValue;
                oPais.ID = gPaisID;
                oPais.Rank = Convert.ToInt16(txtRank.Text);
                oPais.Ativo = chkAtivo.Checked;
                RNPais rn = new RNPais();
                rn.Salvar(oPais);
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro na aplicação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } finally
            {
                IrParaLista();
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            IrParaLista();
        }

        protected void IrParaLista()
        {
            frmMain frm = (frmMain)this.MdiParent;
            frm.AbrirPaisLista();

        }

        private void CarregarBandeira()
        {
            string path = GlobalVariables.pathFlags;
            Image img = new Bitmap(path + gPaisID  + ".png");
            imgBandeira.SizeMode = PictureBoxSizeMode.StretchImage;
            imgBandeira.Image = img;
            

        }

        private void CarregarConfederacao(Confederacao vConfederacao)
        {
            string path = GlobalVariables.pathFlags;
            Image img = new Bitmap(path + (Int16)vConfederacao + ".png");
            imgConfederacao.SizeMode = PictureBoxSizeMode.Normal;
            imgConfederacao.Image = img;
        }

    }
}
