using FIFA_WorldCup.Dal;
using FIFA_WorldCup.Entidades;
using FIFA_WorldCup.RN;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FIFA_WorldCup.Forms
{
    public partial class frmSemiFinal : Form
    {
        Int16 gCopaID;
        public frmSemiFinal(Int16 vCopaID)
        {
            InitializeComponent();
            gCopaID = vCopaID;
            AjustarTitulo();
            PreencherTreeview();
            ColocarBandeiraCampeao();
        }

        private void AjustarTitulo()
        {
            Copa filtro = new Copa();
            RNCopa rn = new RNCopa();
            Copa oCopa = rn.Sel(gCopaID);
            lblNomeCopa.Text = oCopa.Nome;
        }

        private void PreencherTreeview()
        {
            RNPartidaTreeView rnPTV = new RNPartidaTreeView();
            List<PartidaTreeView> listaPartidas = rnPTV.SelSemiFinaisEFinal(gCopaID);

            picSF1.Image = RetornaImagem(listaPartidas[0].SelecaoA);
            GolsSF1.Text = listaPartidas[0].Gols_A.ToString();
            lblNomeSemiFinal1.Text = listaPartidas[0].NomeSelecaoA;
            picSF2.Image = RetornaImagem(listaPartidas[0].SelecaoB);
            GolsSF2.Text = listaPartidas[0].Gols_B.ToString();
            lblNomeSemiFinal2.Text = listaPartidas[0].NomeSelecaoB; 
            picSF3.Image = RetornaImagem(listaPartidas[1].SelecaoA);
            GolsSF3.Text = listaPartidas[1].Gols_A.ToString();
            lblNomeSemiFinal3.Text = listaPartidas[1].NomeSelecaoA;
            picSF4.Image = RetornaImagem(listaPartidas[1].SelecaoB);
            GolsSF4.Text = listaPartidas[1].Gols_B.ToString();
            lblNomeSemiFinal4.Text = listaPartidas[1].NomeSelecaoB;

            picF1.Image = RetornaImagem(listaPartidas[2].SelecaoA);
            GolsF1.Text = listaPartidas[2].Gols_A.ToString();
            lblNomeFinal1.Text = listaPartidas[2].NomeSelecaoA;
            picF2.Image = RetornaImagem(listaPartidas[2].SelecaoB);
            GolsF2.Text = listaPartidas[2].Gols_B.ToString();
            lblNomeFinal2.Text = listaPartidas[2].NomeSelecaoB;
        }

        private void ColocarBandeiraCampeao()
        {
            RNResultado rn = new RNResultado();
            ResultadoCopa oResultado = rn.Sel(gCopaID);
            if (oResultado != null)
            {
                picChampion.Image = RetornaImagem(oResultado.Posicao1_ID);
                picChampion.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private Image RetornaImagem(Int16 PaisID)
        {
            string path = GlobalVariables.pathFlags;
            Image img = new Bitmap(path + PaisID + ".png");
            return img;
        }

    }
}
