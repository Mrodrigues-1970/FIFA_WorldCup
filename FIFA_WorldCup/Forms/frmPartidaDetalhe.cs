using FIFA_WorldCup.Entidades;
using FIFA_WorldCup.RN;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace FIFA_WorldCup.Forms
{
    public partial class frmPartidaDetalhe : Form
    {
        Int16 gGrupoID;
        Int16 gPartidaID;
        Int16 gAno;
        Int16 gDesempateID;
        Int16 gCopaID;
        public frmPartidaDetalhe(Int16 vGrupoID, Int16 vPartidaID)
        {
            InitializeComponent();
            gGrupoID = vGrupoID;
            gPartidaID = vPartidaID;
            AjustaControles();
            CarregaLocais();
            CarregarSelecoes();
            CarregaTipodesempate();
            if(gPartidaID > 0)
            {
                CarregarPartidaDoBanco();
                CarregarBandeiraA();
                CarregarBandeiraB();
            }
        }

        private void RecuperaAno(Int16 vCopaID)
        {
            RNCopa rn = new RNCopa();
            gAno = Convert.ToInt16( rn.RetornaAnoCopa(vCopaID));
        }

        private void AjustaControles()
        {
            RNGrupo rn = new RNGrupo();
            RNCopa rnC = new RNCopa();

            Grupo retorno = rn.Sel(gGrupoID);
            gCopaID = retorno.CopaID;
            Copa oCopa = rnC.Sel(gCopaID);
            RecuperaAno(retorno.CopaID);
            lblTitulo.Text = "Edição de Partida do grupo " + retorno.Nome + " da Copa " + oCopa.Nome;
            txtGrupo.Text = retorno.Nome;
            dataEvento.MinDate = oCopa.Data_Inicial;
            dataEvento.MaxDate = oCopa.Data_Final;
            dataEvento.Value = oCopa.Data_Inicial;
        }

        private void CarregaLocais()
        {
            RNLocal rn = new RNLocal();
            List<Local> listaL = rn.Sel(gCopaID);
            ddlLocal.DisplayMember = "Estadio_Cidade";
            ddlLocal.ValueMember = "ID";
            ddlLocal.DataSource = listaL;
        }

        private void CarregarSelecoes()
        {
            RNPais rn = new RNPais();
            List<Pais> lista1 = rn.SelParticipantesSelecionados(gCopaID);
            List<Pais> lista2 = new List<Pais>();
            lista2.AddRange(lista1);

            ddlSelecaoA.DisplayMember = "NOME";
            ddlSelecaoA.ValueMember = "ID";
            ddlSelecaoA.DataSource = lista1;

            ddlSelecaoB.DisplayMember = "NOME";
            ddlSelecaoB.ValueMember = "ID";
            ddlSelecaoB.DataSource = lista2;

        }

        private void chkDesempate_Click(object sender, EventArgs e)
        {
            //TO DO  excluir desempate EXISTENTE NO BANCO quando salvar com o checkbox desmarcado
            AdequarCamposDesempate();
        }

        private void AdequarCamposDesempate()
        {
            if (chkDesempate.Checked)
            {
                grpDesempate.Enabled = true;
                lblSelecaoDesempateA.Text = ((Pais)ddlSelecaoA.SelectedItem).Nome;
                lblSelecaoDesempateB.Text = ((Pais)ddlSelecaoB.SelectedItem).Nome;
            }
            else
            {
                ScoreDesempateA.Value = 0;
                ScoreDesempateB.Value = 0;
                lblSelecaoDesempateA.Text = "A";
                lblSelecaoDesempateB.Text = "B";
                grpDesempate.Enabled = false;
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            IrParaLista();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            RNPartida rn = new RNPartida();
            if ((ddlSelecaoA.SelectedIndex == ddlSelecaoB.SelectedIndex) && ddlSelecaoA.Text != "REPESCAGEM")
            {
                MessageBox.Show("Seleção A é igual a seleção B", "Seleções iguais", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Partida oPartida = CarregarDoForm();            
            rn.Salvar(oPartida);
            IrParaLista();
        }

        private void CarregarPartidaDoBanco()
        {
            RNPartida rn = new RNPartida();
            Partida oPartida = rn.Sel(gPartidaID);
            if(oPartida != null)
            {
                dataEvento.Value = oPartida.Data;
                ddlLocal.SelectedValue = oPartida.Local;
                ddlSelecaoA.SelectedValue = oPartida.SelecaoID_A;
                ddlSelecaoB.SelectedValue = oPartida.SelecaoID_B;
                scoreA.Value = oPartida.Gols_A;
                scoreB.Value = oPartida.Gols_B;
                if (oPartida.Desempate != null)
                {
                    chkDesempate.Checked = true;
                    AdequarCamposDesempate();
                    gDesempateID = oPartida.Desempate.ID;
                    ddlTipoDesempate.SelectedItem = (TipoDesempate)oPartida.Desempate.Tipo;
                    ScoreDesempateA.Value = oPartida.Desempate.Gols_A;
                    ScoreDesempateB.Value = oPartida.Desempate.Gols_B;
                }
            }
        }

        private void CarregaTipodesempate()
        {
            List<TipoDesempate> lista = new List<TipoDesempate>();
            lista.Add(TipoDesempate.Novo_Jogo);
            lista.Add(TipoDesempate.Prorrogacao);
            lista.Add(TipoDesempate.Penaltis);
            ddlTipoDesempate.DataSource = lista;
        }

        private Partida CarregarDoForm()
        {
            Partida oPartida = new Partida();
            oPartida.ID = gPartidaID;
            oPartida.Data = dataEvento.Value;
            oPartida.GrupoID = gGrupoID;
            oPartida.Local = Convert.ToInt16(ddlLocal.SelectedValue);
            oPartida.SelecaoID_A = Convert.ToInt16(ddlSelecaoA.SelectedValue);
            oPartida.SelecaoID_B = Convert.ToInt16(ddlSelecaoB.SelectedValue);
            oPartida.Gols_A = Convert.ToInt16(scoreA.Value);
            oPartida.Gols_B = Convert.ToInt16(scoreB.Value);
            if (chkDesempate.Checked)
            {
                Desempate oDesempate = new Desempate();
                oDesempate.ID = gDesempateID;
                oDesempate.Partida = gPartidaID;
                oDesempate.Tipo = (TipoDesempate)ddlTipoDesempate.SelectedValue;
                oDesempate.Gols_A = (Int16)ScoreDesempateA.Value;
                oDesempate.Gols_B = (Int16)ScoreDesempateB.Value;
                oPartida.Desempate = oDesempate;
            }
            return oPartida;
        }

        private void IrParaLista()
        {
            frmMain frm = (frmMain)this.MdiParent;
            frm.AbrirPartidasLista(gCopaID, gGrupoID);
        }

        private void CarregarBandeiraA()
        {
            string path = GlobalVariables.pathFlags;
            Image img = new Bitmap(path + ddlSelecaoA.SelectedValue + ".png");
            imgTeamA.SizeMode = PictureBoxSizeMode.StretchImage;
            imgTeamA.Image = img;
        }

        private void CarregarBandeiraB()
        {
            string path = GlobalVariables.pathFlags;
            Image img = new Bitmap(path + ddlSelecaoB.SelectedValue + ".png");
            imgTeamB.SizeMode = PictureBoxSizeMode.StretchImage;
            imgTeamB.Image = img;
        }

        private void ddlSelecaoA_SelectedValueChanged(object sender, EventArgs e)
        {
            if (ddlSelecaoA.SelectedValue != null)
            {
                CarregarBandeiraA();
            }
        }

        private void ddlSelecaoB_SelectedValueChanged(object sender, EventArgs e)
        {
            if (ddlSelecaoB.SelectedValue != null)
            {
                CarregarBandeiraB();
            }
        }
    }
}
