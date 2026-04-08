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
    /// <summary>
    /// Formulário para a fase de grupos das copas: 1930, 1950, 1954, 1958, 1962, 1966, 1970, 1974 e 1978
    /// Serve como 2ª fase para a copa de 1982
    /// </summary>
    public partial class frmFaseGrupos4 : Form
    {
        Int16 gCopaID;
        Int16 gAnoCopa;
        public frmFaseGrupos4(Int16 vCopaID)
        {
            InitializeComponent();
            gCopaID = vCopaID;
            CarregarDadosCopa();
            CarregarSelecoes();
            AjustaNomesGrupos();
        }

        private void CarregarSelecoes()
        {
            int posicao = 0;
            Int16 TipoFase = 1;
            string nomeGrupo2 = "Grupo 2";
            string nomeGrupo3 = "Grupo 3";
            string nomeGrupo4 = "Grupo 4";
            if (gAnoCopa == 1982)
            {
                TipoFase = 7;
                nomeGrupo2 = "Grupo B";
                nomeGrupo3 = "Grupo C";
                nomeGrupo4 = "Grupo D";
            }

            RNDtoGrupoCopa rn = new RNDtoGrupoCopa();
            List<dtoGrupoCopa> lista = rn.Sel(gCopaID, TipoFase);
            foreach (dtoGrupoCopa iGrupoCopa in lista)
            {
                posicao++;
                //acabou o grupo 1?
                if (iGrupoCopa.Grupo == nomeGrupo2 && posicao < 5)
                {
                    posicao = 5;
                }
                //acabou o grupo 2?
                if (iGrupoCopa.Grupo == nomeGrupo3 && posicao < 9)
                {
                    posicao = 9;
                }
                //acabou o grupo 3?
                if (iGrupoCopa.Grupo == nomeGrupo4 && posicao < 13)
                {
                    posicao = 13;
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
            MostrarGrupo(lblNomeGrupo1.Text);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            MostrarGrupo(lblNomeGrupo2.Text);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            MostrarGrupo(lblNomeGrupo3.Text);
        }

        private void label4_Click(object sender, EventArgs e)
        {
            MostrarGrupo(lblNomeGrupo4.Text);
        }

        private void MostrarGrupo(string vNomeGrupo)
        {
            frmMain pai = (frmMain)this.MdiParent;
            pai.AbrirFaseDetalhe(gCopaID, vNomeGrupo, 4);
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

        private void btProxFase_Click(object sender, EventArgs e)
        {
            frmMain pai = (frmMain)this.MdiParent;
            switch (gAnoCopa)
            {
                case 1930:
                    pai.AbrirSemiFinal(gCopaID);
                    break;

                case 1934:
                case 1938:
                    //WTF: isto não deveria acontecer
                    break;

                case 1950:
                    //vai para grupo final
                    pai.AbrirFaseDetalhe(gCopaID, "Rodada Final", 4);
                    break;

                case 1954:
                case 1958:
                case 1962:
                case 1966:
                case 1970:
                    //vai para quartas de final
                    pai.AbrirTreeView(gCopaID);
                    break;

                case 1974:
                case 1978:
                    //vai para 2ª fase com 2 grupos
                    pai.AbrirFaseGrupos2(gCopaID);
                    break;

                case 1982:
                    //vai para semifinais
                    pai.AbrirSemiFinal(gCopaID);
                    break;

                case 1986:
                case 1990:
                case 1994:
                case 1998:
                case 2002:
                case 2006:
                case 2010:
                case 2014:
                case 2018:
                case 2022:
                    //vai para oitavas de final
                    pai.AbrirTreeView(gCopaID);
                    break;

                case 2026:
                case 2030:
                case 2034:
                case 2038:
                    //Vai para 2ª fase / 16 avos de final
                    pai.AbrirTreeView32(gCopaID);
                    break;

            }
        }

        private void AjustaNomesGrupos()
        {
            if (gAnoCopa == 1982)
            {
                lblNomeGrupo1.Text = "Grupo A";
                lblNomeGrupo2.Text = "Grupo B";
                lblNomeGrupo3.Text = "Grupo C";
                lblNomeGrupo4.Text = "Grupo D";
            }
        }
    }
}
