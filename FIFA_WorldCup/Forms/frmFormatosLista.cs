using FIFA_WorldCup.RN;
using FIFA_WorldCup.Entidades;
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
    public partial class frmFormatosLista : Form
    {
        public frmFormatosLista()
        {
            InitializeComponent();

        }

        private void pic1930_Click(object sender, EventArgs e)
        {
            AbreFormato(1930);
        }

        private void pic1934_Click(object sender, EventArgs e)
        {
            AbreFormato(1934);
        }

        private void pic1938_Click(object sender, EventArgs e)
        {
            AbreFormato(1938);
        }
        private void pic1950_Click(object sender, EventArgs e)
        {
            AbreFormato(1950);
        }

        private void pic1954_Click(object sender, EventArgs e)
        {
            AbreFormato(1954);
        }

        private void pic1958_Click(object sender, EventArgs e)
        {
            AbreFormato(1958);
        }

        private void pic1962_Click(object sender, EventArgs e)
        {
            AbreFormato(1962);
        }

        private void pic1966_Click(object sender, EventArgs e)
        {
            AbreFormato(1966);
        }

        private void pic1970_Click(object sender, EventArgs e)
        {
            AbreFormato(1970);
        }

        private void pic1974_Click(object sender, EventArgs e)
        {
            AbreFormato(1974);
        }

        private void pic1978_Click(object sender, EventArgs e)
        {
            AbreFormato(1978);
        }
        private void pic1982_Click(object sender, EventArgs e)
        {
            AbreFormato(1982);
        }

        private void pic1986_Click(object sender, EventArgs e)
        {
            AbreFormato(1986);
        }

        private void pic1990_Click(object sender, EventArgs e)
        {
            AbreFormato(1990);
        }

        private void pic1994_Click(object sender, EventArgs e)
        {
            AbreFormato(1994);
        }

        private void pic1998_Click(object sender, EventArgs e)
        {
            AbreFormato(1998);
        }

        private void pic2002_Click(object sender, EventArgs e)
        {
            AbreFormato(2002);
        }

        private void pic2006_Click(object sender, EventArgs e)
        {
            AbreFormato(2006);
        }

        private void pic2010_Click(object sender, EventArgs e)
        {
            AbreFormato(2010);
        }

        private void pic2014_Click(object sender, EventArgs e)
        {
            AbreFormato(2014);
        }

        private void pic2018_Click(object sender, EventArgs e)
        {
            AbreFormato(2018);
        }

        private void pic2022_Click(object sender, EventArgs e)
        {
            AbreFormato(2022);
        }

        private void pic2026_Click(object sender, EventArgs e)
        {
            AbreFormato(2026);
        }

        private void pic2030_Click(object sender, EventArgs e)
        {
            AbreFormato(2030);
        }

        private void pic2034_Click(object sender, EventArgs e)
        {
            AbreFormato(2034);
        }


        private void AbreFormato(Int16 AnoCompeticao)
        {
            RNCopa rn = new RNCopa();
            Int16 CopaID = rn.SelIDporAno(AnoCompeticao, Competicao.Masculino);
            frmMain pai = (frmMain)this.MdiParent;
            pai.AbrirFormatoDetalhe(CopaID);
        }

    }
}
