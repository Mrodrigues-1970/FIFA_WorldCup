using FIFA_WorldCup.RN;
using FIFA_WorldCup.Entidades;
using System;
using System.Windows.Forms;

namespace FIFA_WorldCup.Forms
{
    public partial class frmLocalDetalhe : Form
    {
        Int16 gCopaID;
        Int16 gLocalID;
        public frmLocalDetalhe(Int16 vCopaID, Int16 vLocalID)
        {
            RNCopa rn = new RNCopa();
            InitializeComponent();
            gCopaID = vCopaID;
            txtAno.Text = rn.RetornaAnoCopa(gCopaID);
            gLocalID = vLocalID;
            if(gLocalID > 0)
            {
                CarregarDoBanco();
            }
        }

        private void CarregarDoBanco()
        {
            RNLocal rn = new RNLocal();
            Local oLocal = rn.SelPorID(gLocalID);
            if (oLocal != null)
            {
                txtCidade.Text = oLocal.Cidade;
                txtEstadio.Text = oLocal.Estadio;
            }
        }


        private void btSalvar_Click(object sender, EventArgs e)
        {            
            try
            {
                RNLocal rn = new RNLocal();
                Local oLocal = CarregarDoForm();
                rn.Salvar(oLocal);
                IrParaLista();
            }
            catch (Exception ex) {
                throw ex;
            }
        }


        private Local CarregarDoForm()
        {
            Local oLocal = new Local();
            oLocal.ID = gLocalID;
            oLocal.CopaID = gCopaID;
            oLocal.Estadio = txtEstadio.Text;
            oLocal.Cidade = txtCidade.Text;
            return oLocal;
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            IrParaLista();
        }


        private void IrParaLista()
        {
            frmMain frm = (frmMain)this.MdiParent;
            frm.AbrirLocalLista(gCopaID);
        }


    }
}
