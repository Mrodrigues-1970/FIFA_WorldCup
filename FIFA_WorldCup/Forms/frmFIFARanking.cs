using FIFA_WorldCup.Entidades;
using FIFA_WorldCup.RN;
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
    public partial class frmFIFARanking : Form
    {
        List<Pais> gLista;
        public frmFIFARanking()
        {
            InitializeComponent();
            CarregarGrid();
        }


        private void CarregarGrid()
        {
            RNPais rn = new RNPais();
            gLista = rn.Sel(new Pais() { Ativo = true });
            gLista = gLista.OrderBy(x => x.Rank).ToList();
            grdMain.DataSource = gLista;
        }

        private void btSubir_Click(object sender, EventArgs e)
        {
            ReposicionarNoRanking(true);
        }

        private void btDescer_Click(object sender, EventArgs e)
        {
            ReposicionarNoRanking(false);
        }

        private void ReposicionarNoRanking(bool Subir)
        {
            int posicionamento = Subir ? -1 : 1;
            Int16 ID = Convert.ToInt16(grdMain.CurrentRow.Cells["ID"].Value);
            Int16 Rank = Convert.ToInt16(grdMain.CurrentRow.Cells["Rank"].Value);
            Pais paisSelecionado = gLista.FirstOrDefault(x => x.ID == ID);
            Rank = (short)(Rank + (Int16)posicionamento);
            paisSelecionado.Rank = Rank;
            int indice = gLista.FindIndex(x => x.ID == ID);
            gLista.RemoveAt(indice);
            gLista.Insert(indice + posicionamento, paisSelecionado);
            grdMain.DataSource = new List<Pais>();
            grdMain.DataSource = gLista;

            //falta atualizar o pais afetado pela mudança de rank

        }
    }
}
