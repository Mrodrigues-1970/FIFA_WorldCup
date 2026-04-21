using FIFA_WorldCup.Entidades;
using FIFA_WorldCup.RN;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace FIFA_WorldCup.Forms
{
    public partial class frmFormatoDisplay : Form
    {
        Int16 gCopaID;
        public frmFormatoDisplay(Int16 CopaID)
        {
            InitializeComponent();
            gCopaID = CopaID;
            FormatarImagem();
        }


        private void FormatarImagem()
        {
            RNCopa rn = new RNCopa();
            Copa oCopa = rn.Sel(gCopaID);
            lblNomeCopa.Text = oCopa.Nome;
            string nomeFormato = "";

            switch (oCopa.Ano)
            {
                case 1930:
                    nomeFormato = "Formato1";
                    break;

                case 1934:
                case 1938:
                    nomeFormato = "Formato2";
                    break;

                case 1950:
                    nomeFormato = "Formato3";
                    break;

                case 1954:
                case 1958:
                case 1962:
                case 1966:
                case 1970:
                    nomeFormato = "Formato4";
                    break;

                case 1974:
                case 1978:
                    nomeFormato = "Formato5";
                    break;

                case 1982:
                    nomeFormato = "Formato6";
                    break;

                case 1986:
                case 1990:
                case 1994:
                    nomeFormato = "Formato7";
                    break;

                case 1998:
                case 2002:
                case 2006:
                case 2010:
                case 2014:
                case 2018:
                case 2022:
                    nomeFormato = "Formato8";
                    break;

                case 2026:
                case 2030:
                case 2034:
                    nomeFormato = "Formato9";
                    break;

            }
            CarregarFundo(nomeFormato);
        }

        private void CarregarFundo(string nomeFormato)
        {
            string path = GlobalVariables.pathFormatos;
            Image img = new Bitmap(path + nomeFormato + ".png");
            picFormato.SizeMode = PictureBoxSizeMode.StretchImage;
            picFormato.Image = img;
        }

        private void picInfo_Click(object sender, EventArgs e)
        {
            frmPopupFormato popup = new frmPopupFormato(gCopaID);
            popup.StartPosition = FormStartPosition.CenterScreen;
            popup.ShowDialog();
        }

        private void picVoltar_Click(object sender, EventArgs e)
        {
            frmMain pai = (frmMain)this.MdiParent;
            pai.AbrirListaFormatos();
        }

        private void frmFormatoDisplay_Shown(object sender, EventArgs e)
        {
            //centraliza o titulo
            lblNomeCopa.Left = (this.ClientSize.Width - lblNomeCopa.Width) / 2;
        }
    }
}
