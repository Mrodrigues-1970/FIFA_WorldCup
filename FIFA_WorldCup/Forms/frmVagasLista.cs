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
    public partial class frmVagasLista : Form
    {
        Int16 gCopaID;
        public frmVagasLista(Int16 Copa_ID)
        {
            InitializeComponent();
            gCopaID = Copa_ID;
            CarregarGrid();
            FormatarTitulo();
        }

        private void FormatarTitulo()
        {
            RNCopa rn = new RNCopa();
            string nomeCopa = rn.RetornaNomeCopa(gCopaID);
            lblTitulo.Text = "Lista de vagas da Copa " + nomeCopa;
        }

        private void CarregarGrid()
        {
            List<VagaMasculino> lista;
            RNVagas rn = new RNVagas();
            lista = rn.SelPorCopa(gCopaID);
            grdMain.DataSource = lista;
        }

        private void btIncluir_Click(object sender, EventArgs e)
        {
            IrParaDetalhe(true);
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            IrParaDetalhe(false);
        }

        private void IrParaDetalhe(bool Inclusao)
        {
            //Escolhe um valor padrão para o caso de uma inclusão
            Confederacao confederacaoEscolhida = Entidades.Confederacao.CONMEBOL; ;
            if (!Inclusao)
            {                
                //Confederacao é um ENUM. Não é possível determinar se a ação é inclusão ou alteração com ela.
                if (grdMain.SelectedRows.Count == 1)
                {
                    confederacaoEscolhida = (Confederacao)Convert.ToInt16(grdMain.SelectedRows[0].Cells["Confederacao"].Value);
                }
            }
            frmMain pai = (frmMain)this.MdiParent;
            pai.AbrirVagasDetalhe(gCopaID, Inclusao, confederacaoEscolhida);
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            frmMain pai = (frmMain)this.MdiParent;
            pai.AbrirCopaLista(Competicao.Masculino);
        }
    }
}
