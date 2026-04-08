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

namespace FIFA_WorldCup.Forms
{
    public partial class frmGrupoDetalhe : Form
    {
        Int16 gGrupoID;
        Int16 gCopaID;
        public frmGrupoDetalhe(Int16 vGrupoID, Int16 vCopaID)
        {
            InitializeComponent();
            gGrupoID = vGrupoID;
            gCopaID = vCopaID;
            CarregarTiposFase();
            CarregarObjetoBanco();
            txtNome.Focus();
        }

        private void CarregarObjetoBanco()
        {
            if(gGrupoID > 0)
            {
                DalGrupo dal = new DalGrupo();
                Grupo oGrupo = dal.Sel(gGrupoID);
                ddlTipoFase.SelectedValue = oGrupo.TipoFaseID;
                txtNome.Text = oGrupo.Nome;
            }
        }

        private void CarregarTiposFase()
        {
            DalTipoFase dal = new DalTipoFase();
            List<TipoFase> lista = dal.SelTodos();
            ddlTipoFase.DisplayMember = "NOME";
            ddlTipoFase.ValueMember = "ID";
            ddlTipoFase.DataSource = lista;
        }


        private void btSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Grupo oGrupo = new Grupo();
                oGrupo.Nome = txtNome.Text;
                oGrupo.CopaID = gCopaID;
                oGrupo.ID = gGrupoID;
                oGrupo.TipoFaseID = (Int16)ddlTipoFase.SelectedValue;                
                DalGrupo dal = new DalGrupo();
                dal.Salvar(oGrupo);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro na aplicação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
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
            frm.AbrirGruposLista(gCopaID);

        }

        private void btCopiaNome_Click(object sender, EventArgs e)
        {
            string nome = ((TipoFase)ddlTipoFase.SelectedItem).Nome;
            txtNome.Text = nome;
        }
    }
}
