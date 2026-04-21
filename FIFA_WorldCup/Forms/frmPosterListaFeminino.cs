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
    public partial class frmPosterListaFeminino : Form
    {
        public frmPosterListaFeminino()
        {
            InitializeComponent();
        }

        private void frmPosterListaFeminino_Shown(object sender, EventArgs e)
        {
            //Muda as imagens para stretch
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox9.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox10.SizeMode = PictureBoxSizeMode.StretchImage;
        }


        private void AbrirTabelaCopa(Int16 vCopaID)
        {
            int NumeroGrupos = 0;
            RNCopa rn = new RNCopa();
            Copa oCopa = rn.Sel(vCopaID);
            switch (oCopa.Ano)
            {
                case 1991:
                case 1995:
                    NumeroGrupos = 3;
                    break;

                case 1999:
                case 2003:
                case 2007:
                case 2011:
                    NumeroGrupos = 4;
                    break;

                case 2015:
                case 2019:
                    NumeroGrupos = 6;
                    break;

                case 2023:
                case 2027:
                case 2031:
                case 2035:
                    NumeroGrupos = 8;
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
