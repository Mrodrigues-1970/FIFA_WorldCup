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
    public partial class frmLigacaoLista : Form
    {
        Int16 gPaisPaiID;
        public frmLigacaoLista(Int16 vPaisPai_ID)
        {
            InitializeComponent();
            gPaisPaiID = vPaisPai_ID;
            TratarTitulo();
            CarregarGrid();
        }

        private void TratarTitulo()
        {
            DalPais dal = new DalPais();
            Pais oPais = dal.Sel(gPaisPaiID);
            lblNomePais.Text = oPais.Nome;
        }

        private void CarregarGrid()
        {
            DalLigacao dal = new DalLigacao();
            List<Ligacao> lista = dal.SelLista(gPaisPaiID);
            grdMain.DataSource = lista;
        }

        private void btIncluir_Click(object sender, EventArgs e)
        {
            frmMain frm = (frmMain)this.MdiParent;
            frm.AbrirLigacaoDetalhe(gPaisPaiID);
        }

        private void btApagar_Click(object sender, EventArgs e)
        {
            if(grdMain.SelectedRows.Count > 0)
            {
                Int16 ligacaoID = (Int16)grdMain.SelectedRows[0].Cells["ID"].Value;
                DalLigacao dal = new DalLigacao();
                dal.Del(ligacaoID);
                CarregarGrid();
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            frmMain frm = (frmMain)this.MdiParent;
            frm.AbrirPaisLista();
        }
    }
}
