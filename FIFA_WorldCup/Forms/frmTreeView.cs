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
    public partial class frmTreeView : Form
    {
        Int16 gCopaID;
        public frmTreeView(Int16 vCopaID)
        {
            InitializeComponent();
            gCopaID = vCopaID;
            AjustarTitulo();
            PreencherTreeview();
        }

        private void AjustarTitulo()
        {
            Copa filtro = new Copa();
            RNCopa rn = new RNCopa();
            Copa oCopa = rn.Sel(gCopaID);
            AdequarBackground(oCopa.Ano);
            lblNomeCopa.Text = oCopa.Nome;
            if (oCopa.Nome.Length > 13) {
                lblNomeCopa.Location = new Point(390, lblNomeCopa.Location.Y);
            }
        }

        private void AdequarBackground(Int16 AnoCopa)
        {
            if (AnoCopa == 1934 || AnoCopa == 1938 )
            {
                string path = GlobalVariables.pathImagens;
                Image img = new Bitmap(path + "KO_JulesRimet.png");
                this.BackgroundImage = img;
            }
            
            if (AnoCopa == 1954 || AnoCopa == 1958 || AnoCopa == 1962 || AnoCopa == 1966 || AnoCopa == 1970)
            {
                string path = GlobalVariables.pathImagens;
                Image img = new Bitmap(path + "KO4_JulesRimet.png");
                this.BackgroundImage = img;
                lblNomeCopa.ForeColor = Color.Black;
                imgO1.Visible = false;
                imgO2.Visible = false;
                imgO3.Visible = false;
                imgO4.Visible = false;
                imgO5.Visible = false;
                imgO6.Visible = false;
                imgO7.Visible = false;
                imgO8.Visible = false;
                imgO9.Visible = false;
                imgO10.Visible = false;
                imgO11.Visible = false;
                imgO12.Visible = false;
                imgO13.Visible = false;
                imgO14.Visible = false;
                imgO15.Visible = false;
                imgO16.Visible = false;
                lblGol01.Visible = false;
                lblGol02.Visible = false;
                lblGol03.Visible = false;
                lblGol04.Visible = false;
                lblGol05.Visible = false;
                lblGol06.Visible = false;
                lblGol07.Visible = false;
                lblGol08.Visible = false;
                lblGol09.Visible = false;
                lblGol10.Visible = false;
                lblGol11.Visible = false;
                lblGol12.Visible = false;
                lblGol13.Visible = false;
                lblGol14.Visible = false;
                lblGol15.Visible = false;
                lblGol16.Visible = false;
                lblNomeO1.Visible = false;
                lblNomeO2.Visible = false;
                lblNomeO3.Visible = false;
                lblNomeO4.Visible = false;
                lblNomeO5.Visible = false;
                lblNomeO6.Visible = false;
                lblNomeO7.Visible = false;
                lblNomeO8.Visible = false;
                lblNomeO9.Visible = false;
                lblNomeO10.Visible = false;
                lblNomeO11.Visible = false;
                lblNomeO12.Visible = false;
                lblNomeO13.Visible = false;
                lblNomeO14.Visible = false;
                lblNomeO15.Visible = false;
                lblNomeO16.Visible = false;
                lblNomeQ1.ForeColor = Color.Black;
                lblNomeQ2.ForeColor = Color.Black;
                lblNomeQ3.ForeColor = Color.Black;
                lblNomeQ4.ForeColor = Color.Black;
                lblNomeQ5.ForeColor = Color.Black;
                lblNomeQ6.ForeColor = Color.Black;
                lblNomeQ7.ForeColor = Color.Black;
                lblNomeQ8.ForeColor = Color.Black;
                lblNomeSF1.ForeColor = Color.Black;
                lblNomeSF2.ForeColor = Color.Black;
                lblNomeSF3.ForeColor = Color.Black;
                lblNomeSF4.ForeColor = Color.Black;
                lblNomeFinalista1.ForeColor = Color.Black;
                lblNomeFinalista2.ForeColor = Color.Black;
                //lblNomeQ1.BackColor = Color.White;
                //lblNomeQ2.BackColor = Color.White;
                //lblNomeQ3.BackColor = Color.White;
                //lblNomeQ4.BackColor = Color.White;
                //lblNomeQ5.BackColor = Color.White;
                //lblNomeQ6.BackColor = Color.White;
                //lblNomeQ7.BackColor = Color.White;
                //lblNomeQ8.BackColor = Color.White;
                lblNomeSF1.BackColor = Color.White;
                lblNomeSF2.BackColor = Color.White;
                lblNomeSF3.BackColor = Color.White;
                lblNomeSF4.BackColor = Color.White;
                lblNomeFinalista1.BackColor = Color.White;
                lblNomeFinalista2.BackColor = Color.White;
            }

        }

        private void PreencherTreeview()
        {
            
            RNCopa rnCopa = new RNCopa();
            NocauteDisponivel nocautes = rnCopa.NocauteCopa(gCopaID);

            if(nocautes != NocauteDisponivel.Nenhum)
            {
                //Se a copa não tiver oitavas, partidas das quartas serão os primeiros itens da lista.
                //portanto a indexação precisará de um SHIFT para ajustar o índice das partidas.
                Int16 shift = 8;
                RNPartidaTreeView rnPTV = new RNPartidaTreeView();
                List<PartidaTreeView> listaPartidas = rnPTV.Sel(gCopaID);

                if(nocautes == NocauteDisponivel.Oitavas)
                {
                    shift = 0;
                    imgO1.Image = RetornaImagem(listaPartidas[0].SelecaoA);
                    lblGol01.Text = listaPartidas[0].Gols_A.ToString();
                    lblNomeO1.Text = listaPartidas[0].NomeSelecaoA;
                    imgO2.Image = RetornaImagem(listaPartidas[0].SelecaoB);
                    lblGol02.Text = listaPartidas[0].Gols_B.ToString();
                    lblNomeO2.Text = listaPartidas[0].NomeSelecaoB;

                    imgO3.Image = RetornaImagem(listaPartidas[1].SelecaoA);
                    lblGol03.Text = listaPartidas[1].Gols_A.ToString();
                    lblNomeO3.Text = listaPartidas[1].NomeSelecaoA;
                    imgO4.Image = RetornaImagem(listaPartidas[1].SelecaoB);
                    lblGol04.Text = listaPartidas[1].Gols_B.ToString();
                    lblNomeO4.Text = listaPartidas[1].NomeSelecaoB;

                    imgO5.Image = RetornaImagem(listaPartidas[2].SelecaoA);
                    lblGol05.Text = listaPartidas[2].Gols_A.ToString();
                    lblNomeO5.Text = listaPartidas[2].NomeSelecaoA;
                    imgO6.Image = RetornaImagem(listaPartidas[2].SelecaoB);
                    lblGol06.Text = listaPartidas[2].Gols_B.ToString();
                    lblNomeO6.Text = listaPartidas[2].NomeSelecaoB;

                    imgO7.Image = RetornaImagem(listaPartidas[3].SelecaoA);
                    lblGol07.Text = listaPartidas[3].Gols_A.ToString();
                    lblNomeO7.Text = listaPartidas[3].NomeSelecaoA;
                    imgO8.Image = RetornaImagem(listaPartidas[3].SelecaoB);
                    lblGol08.Text = listaPartidas[3].Gols_B.ToString();
                    lblNomeO8.Text = listaPartidas[3].NomeSelecaoB;

                    imgO9.Image = RetornaImagem(listaPartidas[4].SelecaoA);
                    lblGol09.Text = listaPartidas[4].Gols_A.ToString();
                    lblNomeO9.Text = listaPartidas[4].NomeSelecaoA;
                    imgO10.Image = RetornaImagem(listaPartidas[4].SelecaoB);
                    lblGol10.Text = listaPartidas[4].Gols_B.ToString();
                    lblNomeO10.Text = listaPartidas[4].NomeSelecaoB;

                    imgO11.Image = RetornaImagem(listaPartidas[5].SelecaoA);
                    lblGol11.Text = listaPartidas[5].Gols_A.ToString();
                    lblNomeO11.Text = listaPartidas[5].NomeSelecaoA;
                    imgO12.Image = RetornaImagem(listaPartidas[5].SelecaoB);
                    lblGol12.Text = listaPartidas[5].Gols_B.ToString();
                    lblNomeO12.Text = listaPartidas[5].NomeSelecaoB;

                    imgO13.Image = RetornaImagem(listaPartidas[6].SelecaoA);
                    lblGol13.Text = listaPartidas[6].Gols_A.ToString();
                    lblNomeO13.Text = listaPartidas[6].NomeSelecaoA;
                    imgO14.Image = RetornaImagem(listaPartidas[6].SelecaoB);
                    lblGol14.Text = listaPartidas[6].Gols_B.ToString();
                    lblNomeO14.Text = listaPartidas[6].NomeSelecaoB;

                    imgO15.Image = RetornaImagem(listaPartidas[7].SelecaoA);
                    lblGol15.Text = listaPartidas[7].Gols_A.ToString();
                    lblNomeO15.Text = listaPartidas[7].NomeSelecaoA;
                    imgO16.Image = RetornaImagem(listaPartidas[7].SelecaoB);
                    lblGol16.Text = listaPartidas[7].Gols_B.ToString();
                    lblNomeO16.Text = listaPartidas[7].NomeSelecaoB;
                }

                imgQ1.Image = RetornaImagem(listaPartidas[8 - shift].SelecaoA);
                GolQ1.Text = listaPartidas[8 - shift].Gols_A.ToString();
                lblNomeQ1.Text = listaPartidas[8 - shift].NomeSelecaoA;
                imgQ2.Image = RetornaImagem(listaPartidas[8 - shift].SelecaoB);
                GolQ2.Text = listaPartidas[8 - shift].Gols_B.ToString();
                lblNomeQ2.Text = listaPartidas[8 - shift].NomeSelecaoB;

                imgQ3.Image = RetornaImagem(listaPartidas[9 - shift].SelecaoA);
                lblNomeQ3.Text = listaPartidas[9 - shift].NomeSelecaoA;
                GolQ3.Text = listaPartidas[9 - shift].Gols_A.ToString();
                imgQ4.Image = RetornaImagem(listaPartidas[9 - shift].SelecaoB);
                lblNomeQ4.Text = listaPartidas[9 - shift].NomeSelecaoB;
                GolQ4.Text = listaPartidas[9 - shift].Gols_B.ToString();

                imgQ5.Image = RetornaImagem(listaPartidas[10 - shift].SelecaoA);
                lblNomeQ5.Text = listaPartidas[10 - shift].NomeSelecaoA;
                GolQ5.Text = listaPartidas[10 - shift].Gols_A.ToString();
                imgQ6.Image = RetornaImagem(listaPartidas[10 - shift].SelecaoB);
                lblNomeQ6.Text = listaPartidas[10 - shift].NomeSelecaoB;
                GolQ6.Text = listaPartidas[10 - shift].Gols_B.ToString();

                imgQ7.Image = RetornaImagem(listaPartidas[11 - shift].SelecaoA);
                lblNomeQ7.Text = listaPartidas[11 - shift].NomeSelecaoA;
                GolQ7.Text = listaPartidas[11 - shift].Gols_A.ToString();
                imgQ8.Image = RetornaImagem(listaPartidas[11 - shift].SelecaoB);
                lblNomeQ8.Text = listaPartidas[11 - shift].NomeSelecaoB;
                GolQ8.Text = listaPartidas[11 - shift].Gols_B.ToString();


                imgSF1.Image = RetornaImagem(listaPartidas[12 - shift].SelecaoA);
                GolSF1.Text = listaPartidas[12 - shift].Gols_A.ToString();
                lblNomeSF1.Text = listaPartidas[12 - shift].NomeSelecaoA;
                imgSF2.Image = RetornaImagem(listaPartidas[12 - shift].SelecaoB);
                GolSF2.Text = listaPartidas[12 - shift].Gols_B.ToString();
                lblNomeSF2.Text = listaPartidas[12 - shift].NomeSelecaoB;

                imgSF3.Image = RetornaImagem(listaPartidas[13 - shift].SelecaoA);
                GolSF3.Text = listaPartidas[13 - shift].Gols_A.ToString();
                lblNomeSF3.Text = listaPartidas[13 - shift].NomeSelecaoA;
                imgSF4.Image = RetornaImagem(listaPartidas[13 - shift].SelecaoB);
                GolSF4.Text = listaPartidas[13 - shift].Gols_B.ToString();
                lblNomeSF4.Text = listaPartidas[13 - shift].NomeSelecaoB;
                //Partida com indice 14 é a disputa pelo 3º lugar
                imgFinalista1.Image = RetornaImagem(listaPartidas[15 - shift].SelecaoA);
                GolFinalista1.Text = listaPartidas[15 - shift].Gols_A.ToString();
                lblNomeFinalista1.Text = listaPartidas[15 - shift].NomeSelecaoA;
                imgFinalista2.Image = RetornaImagem(listaPartidas[15 - shift].SelecaoB);
                GolFinalista2.Text = listaPartidas[15 - shift].Gols_B.ToString();
                lblNomeFinalista2.Text = listaPartidas[15 - shift].NomeSelecaoB;
            }

            RNResultado rn = new RNResultado();
            ResultadoCopa resultado = rn.Sel(gCopaID);
            imgCampeao.Image = RetornaImagem(resultado.Posicao1_ID);
        }

        private Image RetornaImagem(Int16 PaisID)
        {
            string path = GlobalVariables.pathFlags;
            Image img = new Bitmap(path + PaisID + ".png");
            return img;
        }

        private void imgCampeao_Click(object sender, EventArgs e)
        {
            frmMain pai = (frmMain)this.MdiParent;
            pai.AbrirPosterLista();
        }
    }
}
