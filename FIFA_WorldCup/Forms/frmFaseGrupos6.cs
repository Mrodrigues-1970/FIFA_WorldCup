using FIFA_WorldCup.Dal;
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
    public partial class frmFaseGrupos6 : Form
    {
        Int16 gCopaID;
        Int16 gCopaAno;

        public frmFaseGrupos6(Int16 vCopaID)
        {
            InitializeComponent();
            gCopaID = vCopaID;
            CarregarSelecoes();
            CarregarDadosCopa();
        }


        private void CarregarSelecoes()
        {
            int posicao = 0;
            Int16 TipoFase = 1;
            RNDtoGrupoCopa rn = new RNDtoGrupoCopa();
            List<dtoGrupoCopa> lista = rn.Sel(gCopaID, TipoFase);
            foreach (dtoGrupoCopa iGrupoCopa in lista)
            {
                posicao++;
                //acabou o grupo 1?
                if (iGrupoCopa.Grupo == "Grupo B" && posicao < 5)
                {
                    posicao = 5;
                }
                //acabou o grupo 2?
                if (iGrupoCopa.Grupo == "Grupo C" && posicao < 9)
                {
                    posicao = 9;
                }
                //acabou o grupo 3?
                if (iGrupoCopa.Grupo == "Grupo D" && posicao < 13)
                {
                    posicao = 13;
                }
                //acabou o grupo 4?
                if (iGrupoCopa.Grupo == "Grupo E" && posicao < 17)
                {
                    posicao = 17;
                }
                //acabou o grupo 5?
                if (iGrupoCopa.Grupo == "Grupo F" && posicao < 21)
                {
                    posicao = 21;
                }
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
                    case 9:
                        pictureBox9.Image = RetornaImagem(iGrupoCopa.Pais_ID);
                        pictureBox9.SizeMode = PictureBoxSizeMode.StretchImage;
                        lblPais09.Text = iGrupoCopa.Pais;
                        break;
                    case 10:
                        pictureBox10.Image = RetornaImagem(iGrupoCopa.Pais_ID);
                        pictureBox10.SizeMode = PictureBoxSizeMode.StretchImage;
                        lblPais10.Text = iGrupoCopa.Pais;
                        break;
                    case 11:
                        pictureBox11.Image = RetornaImagem(iGrupoCopa.Pais_ID);
                        pictureBox11.SizeMode = PictureBoxSizeMode.StretchImage;
                        lblPais11.Text = iGrupoCopa.Pais;
                        break;
                    case 12:
                        pictureBox12.Image = RetornaImagem(iGrupoCopa.Pais_ID);
                        pictureBox12.SizeMode = PictureBoxSizeMode.StretchImage;
                        lblPais12.Text = iGrupoCopa.Pais;
                        break;
                    case 13:
                        pictureBox13.Image = RetornaImagem(iGrupoCopa.Pais_ID);
                        pictureBox13.SizeMode = PictureBoxSizeMode.StretchImage;
                        lblPais13.Text = iGrupoCopa.Pais;
                        break;
                    case 14:
                        pictureBox14.Image = RetornaImagem(iGrupoCopa.Pais_ID);
                        pictureBox14.SizeMode = PictureBoxSizeMode.StretchImage;
                        lblPais14.Text = iGrupoCopa.Pais;
                        break;
                    case 15:
                        pictureBox15.Image = RetornaImagem(iGrupoCopa.Pais_ID);
                        pictureBox15.SizeMode = PictureBoxSizeMode.StretchImage;
                        lblPais15.Text = iGrupoCopa.Pais;
                        break;
                    case 16:
                        pictureBox16.Image = RetornaImagem(iGrupoCopa.Pais_ID);
                        pictureBox16.SizeMode = PictureBoxSizeMode.StretchImage;
                        lblPais16.Text = iGrupoCopa.Pais;
                        break;
                    case 17:
                        pictureBox17.Image = RetornaImagem(iGrupoCopa.Pais_ID);
                        pictureBox17.SizeMode = PictureBoxSizeMode.StretchImage;
                        lblPais17.Text = iGrupoCopa.Pais;
                        break;
                    case 18:
                        pictureBox18.Image = RetornaImagem(iGrupoCopa.Pais_ID);
                        pictureBox18.SizeMode = PictureBoxSizeMode.StretchImage;
                        lblPais18.Text = iGrupoCopa.Pais;
                        break;
                    case 19:
                        pictureBox19.Image = RetornaImagem(iGrupoCopa.Pais_ID);
                        pictureBox19.SizeMode = PictureBoxSizeMode.StretchImage;
                        lblPais19.Text = iGrupoCopa.Pais;
                        break;
                    case 20:
                        pictureBox20.Image = RetornaImagem(iGrupoCopa.Pais_ID);
                        pictureBox20.SizeMode = PictureBoxSizeMode.StretchImage;
                        lblPais20.Text = iGrupoCopa.Pais;
                        break;
                    case 21:
                        pictureBox21.Image = RetornaImagem(iGrupoCopa.Pais_ID);
                        pictureBox21.SizeMode = PictureBoxSizeMode.StretchImage;
                        lblPais21.Text = iGrupoCopa.Pais;
                        break;
                    case 22:
                        pictureBox22.Image = RetornaImagem(iGrupoCopa.Pais_ID);
                        pictureBox22.SizeMode = PictureBoxSizeMode.StretchImage;
                        lblPais22.Text = iGrupoCopa.Pais;
                        break;
                    case 23:
                        pictureBox23.Image = RetornaImagem(iGrupoCopa.Pais_ID);
                        pictureBox23.SizeMode = PictureBoxSizeMode.StretchImage;
                        lblPais23.Text = iGrupoCopa.Pais;
                        break;
                    case 24:
                        pictureBox24.Image = RetornaImagem(iGrupoCopa.Pais_ID);
                        pictureBox24.SizeMode = PictureBoxSizeMode.StretchImage;
                        lblPais24.Text = iGrupoCopa.Pais;
                        break;
                }
            }
        }


        private Image RetornaImagem(Int16 PaisID)
        {
            string path = GlobalVariables.pathFlags;
            Image img = new Bitmap(path + PaisID + ".png");
            return img;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MostrarGrupo(lblGrupo1.Text);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            MostrarGrupo(lblGrupo2.Text);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            MostrarGrupo(lblGrupo3.Text);
        }

        private void label4_Click(object sender, EventArgs e)
        {
            MostrarGrupo(lblGrupo4.Text);
        }

        private void label5_Click(object sender, EventArgs e)
        {
            MostrarGrupo(lblGrupo5.Text);
        }

        private void label6_Click(object sender, EventArgs e)
        {
            MostrarGrupo(lblGrupo6.Text);
        }

        private void MostrarGrupo(string vNomeGrupo)
        {
            frmMain pai = (frmMain)this.MdiParent;
            pai.AbrirFaseDetalhe(gCopaID, vNomeGrupo, 6);
        }
        private void CarregarDadosCopa()
        {
            RNCopa rn = new RNCopa();
            Copa oCopa = rn.Sel(gCopaID);
            lblNomeCopa.Text = oCopa.Nome;
            gCopaAno = oCopa.Ano;

            string path = GlobalVariables.pathPosters;
            Image img = new Bitmap(path + gCopaID + ".jpg");

            posterCopa.Image = img;
            posterCopa.SizeMode = PictureBoxSizeMode.StretchImage;

            if (oCopa.Ano == 1982)
            {
                lblGrupo1.Text = "Grupo 1";
                lblGrupo2.Text = "Grupo 2";
                lblGrupo3.Text = "Grupo 3";
                lblGrupo4.Text = "Grupo 4";
                lblGrupo5.Text = "Grupo 5";
                lblGrupo6.Text = "Grupo 6";
            }

        }

        private void btProxFase_Click(object sender, EventArgs e)
        {
            frmMain pai = (frmMain)this.MdiParent;
            switch (gCopaAno) {
                case 1982:
                    //abrir grupo 4
                    pai.AbrirFaseGrupos4(gCopaID);
                    break;
                case 1986:
                case 1990:
                case 1994:
                    //abrir oitavas de final
                    pai.AbrirTreeView(gCopaID);
                    break;
                default:
                    //WTF isto não deveria ocorrer. Não fazer nada
                    break;
            }

        }


    }
}
