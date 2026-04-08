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
    public partial class frmAnfitrioes : Form
    {
        public frmAnfitrioes()
        {
            InitializeComponent();
            CarregarGrid();
        }

        protected void CarregarGrid()
        {
            try
            {
                RNSede rn = new RNSede();
                List<Sede> lista = rn.SelTodos();
                grdMain.DataSource = lista;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro na aplicação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
