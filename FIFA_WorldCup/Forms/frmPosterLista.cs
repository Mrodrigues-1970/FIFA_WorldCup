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
    public partial class frmPosterLista : Form
    {
        public frmPosterLista()
        {
            InitializeComponent();
        }

        #region Posters

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AbrirTabelaCopa(1);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            AbrirTabelaCopa(2);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            AbrirTabelaCopa(3);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            AbrirTabelaCopa(4);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            AbrirTabelaCopa(5);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            AbrirTabelaCopa(6);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            AbrirTabelaCopa(7);
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            AbrirTabelaCopa(8);
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            AbrirTabelaCopa(9);
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            AbrirTabelaCopa(10);
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            AbrirTabelaCopa(11);
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            AbrirTabelaCopa(12);
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            AbrirTabelaCopa(13);
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            AbrirTabelaCopa(14);
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            AbrirTabelaCopa(16);
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            AbrirTabelaCopa(18);
        }
        private void pictureBox20_Click(object sender, EventArgs e)
        {
            AbrirTabelaCopa(20);
        }
        private void pictureBox22_Click(object sender, EventArgs e)
        {
            AbrirTabelaCopa(22);
        }
        private void pictureBox24_Click(object sender, EventArgs e)
        {
            AbrirTabelaCopa(24);
        }
        private void pictureBox26_Click(object sender, EventArgs e)
        {
            AbrirTabelaCopa(26);
        }

        private void pictureBox28_Click(object sender, EventArgs e)
        {
            AbrirTabelaCopa(28);
        }

        private void pictureBox30_Click(object sender, EventArgs e)
        {
            AbrirTabelaCopa(30);
        }

        private void pictureBox32_Click(object sender, EventArgs e)
        {
            AbrirTabelaCopa(32);
        }

        private void pictureBox33_Click(object sender, EventArgs e)
        {
            AbrirTabelaCopa(33);
        }

        #endregion

        private void AbrirTabelaCopa(Int16 vCopaID)
        {
            int NumeroGrupos;
            RNCopa rn = new RNCopa();
            Copa oCopa = rn.Sel(vCopaID);
            switch (oCopa.Ano)
            {
                case 1934:
                case 1938:
                    NumeroGrupos = 0;
                    break;

                case 1930:
                case 1950:
                case 1954:
                case 1958:
                case 1962:
                case 1966:
                case 1970:
                case 1974:
                case 1978:
                    NumeroGrupos = 4;
                    break;

                case 1982:
                case 1986:
                case 1990:
                case 1994:
                    NumeroGrupos = 6;
                    break;

                case 1998:
                case 2002:
                case 2006:
                case 2010:
                case 2014:
                case 2018:
                case 2022:
                    NumeroGrupos = 8;
                    break;

                case 2026:
                case 2030:
                case 2034:
                default:
                    NumeroGrupos = 12;
                    break;
            }

            frmMain pai = (frmMain)this.MdiParent;
            switch (NumeroGrupos)
            {
                case 0:
                    pai.AbrirTreeView(vCopaID);
                    break;

                case 4:
                    pai.AbrirFaseGrupos4(vCopaID);
                    break;

                case 6:
                    pai.AbrirFaseGrupos6(vCopaID);
                    break;

                case 8:
                    pai.AbrirFaseGrupos8(vCopaID);
                    break;

                case 12:
                    pai.AbrirFaseGrupos12(vCopaID);
                    break;
            }


        }


    }
}
