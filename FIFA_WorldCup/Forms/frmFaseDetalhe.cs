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
    public partial class frmFaseDetalhe : Form
    {
        Int16 gCopaID;
        Int16 gOrigem;
        public frmFaseDetalhe(Int16 vCopaID, string vNomeGrupo, Int16 vOrigem)
        {
            InitializeComponent();
            CarregarPartidas(vCopaID, vNomeGrupo);
            lblNomeGrupo.Text = vNomeGrupo;
            gCopaID = vCopaID;
            gOrigem = vOrigem;
        }
                

        private void CarregarPartidas(Int16 vCopaID, string vNomeGrupo)
        {
            RNdtoPartidasGrupo rn = new RNdtoPartidasGrupo();
            List<dtoPartidasGrupo> lista = rn.Sel(vCopaID, vNomeGrupo);

            flag1A.Image = RetornaImagem(lista[0].PaisID_A);
            nome1a.Text = lista[0].Pais_A;
            gol1a.Text = lista[0].Gols_A.ToString();
            flag1B.Image = RetornaImagem(lista[0].PaisID_B);
            nome1b.Text = lista[0].Pais_B;
            gol1b.Text = lista[0].Gols_B.ToString();
            lblData1.Text = lista[0].Data.ToString("dd/MM/yyyy");
            if (lista[0].Data > DateTime.Today)
            {
                gol1a.Visible =false;
                gol1b.Visible = false;
            }


            if (lista.Count > 2)
            {
                flag2A.Image = RetornaImagem(lista[1].PaisID_A);
                nome2a.Text = lista[1].Pais_A;
                gol2a.Text = lista[1].Gols_A.ToString();
                flag2B.Image = RetornaImagem(lista[1].PaisID_B);
                nome2b.Text = lista[1].Pais_B;
                gol2b.Text = lista[1].Gols_B.ToString();
                lblData2.Text = lista[1].Data.ToString("dd/MM/yyyy");
                if (lista[1].Data > DateTime.Today)
                {
                    gol2a.Visible = false;
                    gol2b.Visible = false;
                }

                flag3A.Image = RetornaImagem(lista[2].PaisID_A);
                nome3a.Text = lista[2].Pais_A;
                gol3a.Text = lista[2].Gols_A.ToString();
                flag3B.Image = RetornaImagem(lista[2].PaisID_B);
                nome3b.Text = lista[2].Pais_B;
                gol3b.Text = lista[2].Gols_B.ToString();
                lblData3.Text = lista[2].Data.ToString("dd/MM/yyyy");
                if (lista[2].Data > DateTime.Today)
                {
                    gol3a.Visible = false;
                    gol3b.Visible = false;
                }

            }


            if (lista.Count > 3)
            {
                flag4A.Image = RetornaImagem(lista[3].PaisID_A);
                nome4a.Text = lista[3].Pais_A;
                gol4a.Text = lista[3].Gols_A.ToString();
                flag4B.Image = RetornaImagem(lista[3].PaisID_B);
                nome4b.Text = lista[3].Pais_B;
                gol4b.Text = lista[3].Gols_B.ToString();
                lblData4.Text = lista[3].Data.ToString("dd/MM/yyyy");
                if (lista[3].Data > DateTime.Today)
                {
                        gol4a.Visible = false;
                        gol4b.Visible = false;
                }

                if (lista.Count > 4)
                {
                    flag5A.Image = RetornaImagem(lista[4].PaisID_A);
                    nome5a.Text = lista[4].Pais_A;
                    gol5a.Text = lista[4].Gols_A.ToString();
                    flag5B.Image = RetornaImagem(lista[4].PaisID_B);
                    nome5b.Text = lista[4].Pais_B;
                    gol5b.Text = lista[4].Gols_B.ToString();
                    lblData5.Text = lista[4].Data.ToString("dd/MM/yyyy");
                    if (lista[4].Data > DateTime.Today)
                    {
                        gol5a.Visible = false;
                        gol5b.Visible = false;
                    }

                    if (lista.Count > 5)
                    {
                        flag6A.Image = RetornaImagem(lista[5].PaisID_A);
                        nome6a.Text = lista[5].Pais_A;
                        gol6a.Text = lista[5].Gols_A.ToString();
                        flag6B.Image = RetornaImagem(lista[5].PaisID_B);
                        nome6b.Text = lista[5].Pais_B;
                        gol6b.Text = lista[5].Gols_B.ToString();
                        lblData6.Text = lista[5].Data.ToString("dd/MM/yyyy");
                        if (lista[5].Data > DateTime.Today)
                        {
                            gol6a.Visible = false;
                            gol6b.Visible = false;
                        }
                    }

                }
            }
        }

        private Image RetornaImagem(Int16 PaisID)
        {
            string path = GlobalVariables.pathFlags;
            Image img = new Bitmap(path + PaisID + ".png");
            return img;
        }

        private void lblNomeGrupo_Click(object sender, EventArgs e)
        {
            frmMain pai = (frmMain)this.MdiParent;
            switch (gOrigem)
            {
                case 2:
                    pai.AbrirFaseGrupos2(gCopaID);
                    break;
                case 4:
                    pai.AbrirFaseGrupos4(gCopaID);
                    break;
                case 6:
                    pai.AbrirFaseGrupos6(gCopaID);
                    break;
                case 8:
                    pai.AbrirFaseGrupos8(gCopaID);
                    break;
                case 12:
                    pai.AbrirFaseGrupos12(gCopaID);
                    break;
                default:
                    break;
            }
            
        }





    }
}
