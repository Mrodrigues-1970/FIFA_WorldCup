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
    public partial class frmFinal : Form
    {
        Int16 gCopaID;
        public frmFinal(Int16 vCopaID)
        {
            InitializeComponent();
            gCopaID = vCopaID;
            CarregarFinal();
        }

        private void CarregarFinal()
        {
            RNPartida rn = new RNPartida();
            Partida oPartida = rn.SelFinal(gCopaID);
            if (oPartida != null)
            {
                //lblData.Text = oPartida.Data.ToString("dd/MM/yyyy");
                //lblEstadio.Text = oPartida.Estadio;
                FinalistaA.Image = RetornaImagem(oPartida.SelecaoID_A);
                FinalistaA.SizeMode = PictureBoxSizeMode.StretchImage;
                lblGolsA.Text = oPartida.Gols_A.ToString();
                lblNomeSelecaoA.Text = oPartida.NomePaisA;

                FinalistaB.Image = RetornaImagem(oPartida.SelecaoID_B);
                FinalistaB.SizeMode = PictureBoxSizeMode.StretchImage;                
                lblGolsB.Text = oPartida.Gols_B.ToString();
                lblNomeSelecaoB.Text = oPartida.NomePaisB;

                if (oPartida.Gols_A > oPartida.Gols_B)
                {
                    picCampeao.Image = RetornaImagem(oPartida.SelecaoID_A);
                }
                else
                {
                    picCampeao.Image = RetornaImagem(oPartida.SelecaoID_B);
                }
                picCampeao.SizeMode = PictureBoxSizeMode.StretchImage;
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
