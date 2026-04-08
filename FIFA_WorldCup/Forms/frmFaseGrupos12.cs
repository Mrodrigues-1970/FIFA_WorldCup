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
    public partial class frmFaseGrupos12 : Form
    {
        Int16 gCopaID;

        public frmFaseGrupos12(Int16 vCopaID)
        {
            InitializeComponent();
            gCopaID = vCopaID;
            CarregarSelecoes();
            CarregarDadosCopa();
        }


        private void CarregarSelecoes()
        {
            Int16 TipoFase = 1;
            int posicao = 0;
            RNDtoGrupoCopa rn = new RNDtoGrupoCopa();
            List<dtoGrupoCopa> lista = rn.Sel(gCopaID, TipoFase);
            foreach (dtoGrupoCopa iGrupoCopa in lista)
            {
                posicao++;
                //acabou o grupo A?
                if (iGrupoCopa.Grupo == "Grupo B" && posicao < 5)
                {
                    posicao = 5;
                }
                //acabou o grupo B?
                if (iGrupoCopa.Grupo == "Grupo C" && posicao < 9)
                {
                    posicao = 9;
                }
                //acabou o grupo C?
                if (iGrupoCopa.Grupo == "Grupo D" && posicao < 13)
                {
                    posicao = 13;
                }
                //acabou o grupo D?
                if (iGrupoCopa.Grupo == "Grupo E" && posicao < 17)
                {
                    posicao = 17;
                }
                //acabou o grupo E?
                if (iGrupoCopa.Grupo == "Grupo F" && posicao < 21)
                {
                    posicao = 21;
                }
                //acabou o grupo F?
                if (iGrupoCopa.Grupo == "Grupo G" && posicao < 25)
                {
                    posicao = 25;
                }
                //acabou o grupo G?
                if (iGrupoCopa.Grupo == "Grupo H" && posicao < 29)
                {
                    posicao = 29;
                }
                //acabou o grupo H?
                if (iGrupoCopa.Grupo == "Grupo I" && posicao < 33)
                {
                    posicao = 33;
                }
                //acabou o grupo I?
                if (iGrupoCopa.Grupo == "Grupo J" && posicao < 37)
                {
                    posicao = 37;
                }
                //acabou o grupo J?
                if (iGrupoCopa.Grupo == "Grupo K" && posicao < 41)
                {
                    posicao = 41;
                }
                //acabou o grupo K?
                if (iGrupoCopa.Grupo == "Grupo L" && posicao < 45)
                {
                    posicao = 45;
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
                    case 25:
                        pictureBox25.Image = RetornaImagem(iGrupoCopa.Pais_ID);
                        pictureBox25.SizeMode = PictureBoxSizeMode.StretchImage;
                        lblPais25.Text = iGrupoCopa.Pais;
                        break;
                    case 26:
                        pictureBox26.Image = RetornaImagem(iGrupoCopa.Pais_ID);
                        pictureBox26.SizeMode = PictureBoxSizeMode.StretchImage;
                        lblPais26.Text = iGrupoCopa.Pais;
                        break;
                    case 27:
                        pictureBox27.Image = RetornaImagem(iGrupoCopa.Pais_ID);
                        pictureBox27.SizeMode = PictureBoxSizeMode.StretchImage;
                        lblPais27.Text = iGrupoCopa.Pais;
                        break;
                    case 28:
                        pictureBox28.Image = RetornaImagem(iGrupoCopa.Pais_ID);
                        pictureBox28.SizeMode = PictureBoxSizeMode.StretchImage;
                        lblPais28.Text = iGrupoCopa.Pais;
                        break;
                    case 29:
                        pictureBox29.Image = RetornaImagem(iGrupoCopa.Pais_ID);
                        pictureBox29.SizeMode = PictureBoxSizeMode.StretchImage;
                        lblPais29.Text = iGrupoCopa.Pais;
                        break;
                    case 30:
                        pictureBox30.Image = RetornaImagem(iGrupoCopa.Pais_ID);
                        pictureBox30.SizeMode = PictureBoxSizeMode.StretchImage;
                        lblPais30.Text = iGrupoCopa.Pais;
                        break;
                    case 31:
                        pictureBox31.Image = RetornaImagem(iGrupoCopa.Pais_ID);
                        pictureBox31.SizeMode = PictureBoxSizeMode.StretchImage;
                        lblPais31.Text = iGrupoCopa.Pais;
                        break;
                    case 32:
                        pictureBox32.Image = RetornaImagem(iGrupoCopa.Pais_ID);
                        pictureBox32.SizeMode = PictureBoxSizeMode.StretchImage;
                        lblPais32.Text = iGrupoCopa.Pais;
                        break;
                    case 33:
                        pictureBox33.Image = RetornaImagem(iGrupoCopa.Pais_ID);
                        pictureBox33.SizeMode = PictureBoxSizeMode.StretchImage;
                        lblPais33.Text = iGrupoCopa.Pais;
                        break;
                    case 34:
                        pictureBox34.Image = RetornaImagem(iGrupoCopa.Pais_ID);
                        pictureBox34.SizeMode = PictureBoxSizeMode.StretchImage;
                        lblPais34.Text = iGrupoCopa.Pais;
                        break;
                    case 35:
                        pictureBox35.Image = RetornaImagem(iGrupoCopa.Pais_ID);
                        pictureBox35.SizeMode = PictureBoxSizeMode.StretchImage;
                        lblPais35.Text = iGrupoCopa.Pais;
                        break;
                    case 36:
                        pictureBox36.Image = RetornaImagem(iGrupoCopa.Pais_ID);
                        pictureBox36.SizeMode = PictureBoxSizeMode.StretchImage;
                        lblPais36.Text = iGrupoCopa.Pais;
                        break;
                    case 37:
                        pictureBox37.Image = RetornaImagem(iGrupoCopa.Pais_ID);
                        pictureBox37.SizeMode = PictureBoxSizeMode.StretchImage;
                        lblPais37.Text = iGrupoCopa.Pais;
                        break;
                    case 38:
                        pictureBox38.Image = RetornaImagem(iGrupoCopa.Pais_ID);
                        pictureBox38.SizeMode = PictureBoxSizeMode.StretchImage;
                        lblPais38.Text = iGrupoCopa.Pais;
                        break;
                    case 39:
                        pictureBox39.Image = RetornaImagem(iGrupoCopa.Pais_ID);
                        pictureBox39.SizeMode = PictureBoxSizeMode.StretchImage;
                        lblPais39.Text = iGrupoCopa.Pais;
                        break;
                    case 40:
                        pictureBox40.Image = RetornaImagem(iGrupoCopa.Pais_ID);
                        pictureBox40.SizeMode = PictureBoxSizeMode.StretchImage;
                        lblPais40.Text = iGrupoCopa.Pais;
                        break;
                    case 41:
                        pictureBox41.Image = RetornaImagem(iGrupoCopa.Pais_ID);
                        pictureBox41.SizeMode = PictureBoxSizeMode.StretchImage;
                        lblPais41.Text = iGrupoCopa.Pais;
                        break;
                    case 42:
                        pictureBox42.Image = RetornaImagem(iGrupoCopa.Pais_ID);
                        pictureBox42.SizeMode = PictureBoxSizeMode.StretchImage;
                        lblPais42.Text = iGrupoCopa.Pais;
                        break;
                    case 43:
                        pictureBox43.Image = RetornaImagem(iGrupoCopa.Pais_ID);
                        pictureBox43.SizeMode = PictureBoxSizeMode.StretchImage;
                        lblPais43.Text = iGrupoCopa.Pais;
                        break;
                    case 44:
                        pictureBox44.Image = RetornaImagem(iGrupoCopa.Pais_ID);
                        pictureBox44.SizeMode = PictureBoxSizeMode.StretchImage;
                        lblPais44.Text = iGrupoCopa.Pais;
                        break;
                    case 45:
                        pictureBox45.Image = RetornaImagem(iGrupoCopa.Pais_ID);
                        pictureBox45.SizeMode = PictureBoxSizeMode.StretchImage;
                        lblPais45.Text = iGrupoCopa.Pais;
                        break;
                    case 46:
                        pictureBox46.Image = RetornaImagem(iGrupoCopa.Pais_ID);
                        pictureBox46.SizeMode = PictureBoxSizeMode.StretchImage;
                        lblPais46.Text = iGrupoCopa.Pais;
                        break;
                    case 47:
                        pictureBox47.Image = RetornaImagem(iGrupoCopa.Pais_ID);
                        pictureBox47.SizeMode = PictureBoxSizeMode.StretchImage;
                        lblPais47.Text = iGrupoCopa.Pais;
                        break;
                    case 48:
                        pictureBox48.Image = RetornaImagem(iGrupoCopa.Pais_ID);
                        pictureBox48.SizeMode = PictureBoxSizeMode.StretchImage;
                        lblPais48.Text = iGrupoCopa.Pais;
                        break;
                }

            }
        }


        private void CarregarDadosCopa()
        {
            RNCopa rn = new RNCopa();
            Copa oCopa = rn.Sel(gCopaID);
            lblNomeCopa.Text = oCopa.Nome;

            string path = GlobalVariables.pathPosters;
            Image img = new Bitmap(path + gCopaID + ".jpg");

            posterCopa.Image = img;
            posterCopa.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private Image RetornaImagem(Int16 PaisID)
        {
            string path = GlobalVariables.pathFlags;
            Image img = new Bitmap(path + PaisID + ".png");
            return img;
        }

        #region Detalhes do Grupo

        private void lblA_Click(object sender, EventArgs e)
        {
            IrParaFaseDetalhes("Grupo A");
        }

        private void lblB_Click(object sender, EventArgs e)
        {
            IrParaFaseDetalhes("Grupo B");
        }

        private void lblC_Click(object sender, EventArgs e)
        {
            IrParaFaseDetalhes("Grupo C");
        }

        private void lblD_Click(object sender, EventArgs e)
        {
            IrParaFaseDetalhes("Grupo D");
        }

        private void lblE_Click(object sender, EventArgs e)
        {
            IrParaFaseDetalhes("Grupo E");
        }

        private void lblF_Click(object sender, EventArgs e)
        {
            IrParaFaseDetalhes("Grupo F");
        }

        private void lblG_Click(object sender, EventArgs e)
        {
            IrParaFaseDetalhes("Grupo G");
        }

        private void lblH_Click(object sender, EventArgs e)
        {
            IrParaFaseDetalhes("Grupo H");
        }

        private void lblI_Click(object sender, EventArgs e)
        {
            IrParaFaseDetalhes("Grupo I");
        }

        private void lblJ_Click(object sender, EventArgs e)
        {
            IrParaFaseDetalhes("Grupo J");
        }

        private void lblK_Click(object sender, EventArgs e)
        {
            IrParaFaseDetalhes("Grupo K");
        }

        private void lblL_Click(object sender, EventArgs e)
        {
            IrParaFaseDetalhes("Grupo L");
        }

        private void IrParaFaseDetalhes(string vNomeGrupo)
        {
            frmMain formPai = (frmMain)this.MdiParent;
            formPai.AbrirFaseDetalhe(gCopaID, vNomeGrupo, 12);
        }




        #endregion

        private void btProxFase_Click(object sender, EventArgs e)
        {
            frmMain pai = (frmMain)this.MdiParent;
            pai.AbrirTreeView32(gCopaID);
        }
    }
}
