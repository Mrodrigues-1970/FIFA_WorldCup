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
using FIFA_WorldCup.Entidades;


namespace FIFA_WorldCup.Forms
{
    public partial class frmResultadoDisplay : Form
    {
        Int16 gCopaID;

        public frmResultadoDisplay(Int16 CopaID)
        {
            InitializeComponent();
            gCopaID = CopaID;
            CarregarDadosResultado();
            CarregarTitulo();
        }

        private void CarregarDadosResultado()
        {
            RNResultado rn = new RNResultado();
            ResultadoCopa resultado = rn.Sel(gCopaID);

            string path = GlobalVariables.pathFlags;

            Image img1 = new Bitmap(path + resultado.Posicao1_ID + ".png");
            picCampeao.SizeMode = PictureBoxSizeMode.StretchImage;
            picCampeao.Image = img1;

            Image img2 = new Bitmap(path + resultado.Posicao2_ID + ".png");
            picViceCampeao.SizeMode = PictureBoxSizeMode.StretchImage;
            picViceCampeao.Image = img2;

            Image img3 = new Bitmap(path + resultado.Posicao3_ID + ".png");
            pic3Lugar.SizeMode = PictureBoxSizeMode.StretchImage;
            pic3Lugar.Image = img3;

            Image img4 = new Bitmap(path + resultado.Posicao4_ID + ".png");
            pic4Lugar.SizeMode = PictureBoxSizeMode.StretchImage;
            pic4Lugar.Image = img4;

            lblCampeao.Text = resultado.Posicao1_nome;
            lblViceCampeao.Text = resultado.Posicao2_nome;
            lbl3Lugar.Text = resultado.Posicao3_nome;
            lbl4Lugar.Text = resultado.Posicao4_nome;
        }

        private void picAlterar_Click(object sender, EventArgs e)
        {
            frmMain pai = (frmMain)this.MdiParent;
            pai.AbrirResultado(gCopaID);
        }

        private void piVoltar_Click(object sender, EventArgs e)
        {
            RNCopa rn = new RNCopa();
            Competicao TipoCompeticao = rn.RetornaTipoCompeticao(gCopaID);
            frmMain frm = (frmMain)this.MdiParent;
            frm.AbrirCopaLista(TipoCompeticao);
        }

        private void CarregarTitulo()
        {
            RNCopa rn = new RNCopa();
            lblTitulo.Text = "Resultado da Copa " + rn.RetornaNomeCopa(this.gCopaID); ;
        }

        private void frmResultadoDisplay_Shown(object sender, EventArgs e)
        {
            //centraliza o titulo
            lblTitulo.Left = (this.ClientSize.Width - lblTitulo.Width) / 2;
        }
    }
    
}
