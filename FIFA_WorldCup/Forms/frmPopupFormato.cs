using FIFA_WorldCup.Entidades;
using FIFA_WorldCup.RN;
using System;
using System.Windows.Forms;

namespace FIFA_WorldCup.Forms
{
    public partial class frmPopupFormato : Form
    {
        public frmPopupFormato(Int16 CopaID)
        {
            InitializeComponent();
            CarregaDados(CopaID);
        }

        private void frmPopupFormato_Shown(object sender, EventArgs e)
        {
            //centraliza o titulo
            lblNomeCopa.Left = (this.ClientSize.Width - lblNomeCopa.Width) / 2;
            txtDescricaoFormato.SelectionLength = 0;
        }


        private void CarregaDados(Int16 CopaID)
        {
            RNCopa rn = new RNCopa();
            Copa oCopa = rn.Sel(CopaID);
            lblNomeCopa.Text = oCopa.Nome;
            txtDescricaoFormato.Text = RetornaDescricaoFormato(oCopa.Ano);
        }



        private void btOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private string RetornaDescricaoFormato(Int16 CopaAno)
        {
            string descricao = "";
            switch (CopaAno)
            {
                case 1930:
                    descricao = "16 participantes (planejado)\r\nQuatro grupos onde os vencedores disputam as semifinais. Os vencedores disputam a final.";
                    break;

                case 1934: case 1938:
                    descricao = "16 participantes\r\nNão teve fase de grupos. A copa começou nas oitavas, os vencedores disputaram as quartas, os vencedores disputaram as semifinais e os vencedores destas participam da final.";
                    break;

                case 1950:
                    descricao = "16 participantes (planejado)\r\nQuatro grupos onde os vencedores se classificam para o grupo final. O vencedor deste grupo é campeão. Este formato não possui a partida conhecida como final.";
                    break;

                case 1954: case 1958: case 1962: case 1966: case 1970:
                    descricao = "16 participantes\r\nQuatro grupos onde os vencedores se classificam para as quartas de final. Os vencedores se classificam para as semifinais e os vencedores destas participam da final.";
                    break;

                case 1974: case 1978:
                    descricao = "16 participantes\r\nQuatro grupos onde os vencedores se classificam para os dois grupos da segunda fase. Os vencedores se classificam para as semifinais e os vencedores destas participam da final.";
                    break;

                case 1982:
                    descricao = "24 participantes\r\nSeis grupos onde os vencedores se classificam para os quatro grupos da segunda fase. Os vencedores se classificam para as semifinais e os vencedores destas participam da final.";
                    break;

                case 1986: case 1990: case 1994:
                    descricao = "24 participantes\r\nSeis grupos onde o 1º e 2º lugar de cada grupo se classificam para as oitavas. Os quatro melhores que ficaram em 3º lugar nos grupos também vão para as oitavas. Os vencedores se classificam para as quartas de final. Os vencedores se classificam para as semifinais e os vencedores destas participam da final.";
                    break;

                case 1998: case 2002: case 2006: case 2010: case 2014: case 2018: case 2022:
                    descricao = "32 participantes\r\nOito grupos onde o 1º e 2º lugar de cada grupo se classificam para as oitavas. Os vencedores se classificam para as quartas de final. Os vencedores se classificam para as semifinais e os vencedores destas participam da final.";
                    break;

                 
                case 2026: case 2030: case 2034:
                    descricao = "48 participantes\r\nDoze grupos onde o 1º e 2º lugar de cada grupo se classificam para as oitavas. Os quatro melhores que ficaram em 3º lugar nos grupos também vão para as oitavas. Os vencedores se classificam para as quartas de final. Os vencedores se classificam para as semifinais e os vencedores destas participam da final.";
                    break;

            }
            return descricao;
        }


    }
}
