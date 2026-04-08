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
    public partial class frmFaseGrupos2 : Form
    {
        Int16 gCopaID;
        Int16 gAnoCopa;
        public frmFaseGrupos2(Int16 vCopaID)
        {
            InitializeComponent();
            gCopaID = vCopaID;
            CarregarSelecoes();
            CarregarDadosCopa();
        }


        private Image RetornaImagem(Int16 PaisID)
        {
            string path = GlobalVariables.pathFlags;
            Image img = new Bitmap(path + PaisID + ".png");
            return img;
        }

        private void CarregarSelecoes()
        {
            int posicao = 0;
            Int16 TipoFase = 7;
            RNDtoGrupoCopa rn = new RNDtoGrupoCopa();
            List<dtoGrupoCopa> lista = rn.Sel(gCopaID, TipoFase);
            foreach (dtoGrupoCopa iGrupoCopa in lista)
            {
                posicao++;
                switch (posicao)
                {
                    case 1:
                        pictureBox1.Image = RetornaImagem(iGrupoCopa.Pais_ID);
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                        lblPais01.Text = iGrupoCopa.Pais;
                        break;
                    case 2:
                        pictureBox2.Image = RetornaImagem(iGrupoCopa.Pais_ID);
                        pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                        lblPais02.Text = iGrupoCopa.Pais;
                        break;
                    case 3:
                        pictureBox3.Image = RetornaImagem(iGrupoCopa.Pais_ID);
                        pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
                        lblPais03.Text = iGrupoCopa.Pais;
                        break;
                    case 4:
                        pictureBox4.Image = RetornaImagem(iGrupoCopa.Pais_ID);
                        pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
                        lblPais04.Text = iGrupoCopa.Pais;
                        break;
                    case 5:
                        pictureBox5.Image = RetornaImagem(iGrupoCopa.Pais_ID);
                        pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
                        lblPais05.Text = iGrupoCopa.Pais;
                        break;
                    case 6:
                        pictureBox6.Image = RetornaImagem(iGrupoCopa.Pais_ID);
                        pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
                        lblPais06.Text = iGrupoCopa.Pais;
                        break;
                    case 7:
                        pictureBox7.Image = RetornaImagem(iGrupoCopa.Pais_ID);
                        pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
                        lblPais07.Text = iGrupoCopa.Pais;
                        break;
                    case 8:
                        pictureBox8.Image = RetornaImagem(iGrupoCopa.Pais_ID);
                        pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
                        lblPais08.Text = iGrupoCopa.Pais;
                        break;

                }
            }
        }


        private void picVoltar_Click(object sender, EventArgs e)
        {

        }
        private void picAvancar_Click(object sender, EventArgs e)
        {
            frmMain pai = (frmMain)this.MdiParent;
            pai.AbrirFinal(gCopaID);
        }

        private void lblGrupo2_Click(object sender, EventArgs e)
        {
            MostrarGrupo("Grupo B");
        }

        private void lblGrupo1_Click(object sender, EventArgs e)
        {
            MostrarGrupo("Grupo A");
        }

        private void CarregarDadosCopa()
        {
            RNCopa rn = new RNCopa();
            Copa oCopa = rn.Sel(gCopaID);
            lblNomeCopa.Text = oCopa.Nome;
            gAnoCopa = oCopa.Ano;

            string path = GlobalVariables.pathPosters;
            Image img = new Bitmap(path + gCopaID + ".jpg");

            posterCopa.Image = img;
            posterCopa.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void MostrarGrupo(string vNomeGrupo)
        {
            frmMain pai = (frmMain)this.MdiParent;
            pai.AbrirFaseDetalhe(gCopaID, vNomeGrupo, 2);
        }


    }
}
