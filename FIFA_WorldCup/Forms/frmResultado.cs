using FIFA_WorldCup.Entidades;
using FIFA_WorldCup.RN;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FIFA_WorldCup.Forms
{
    public partial class frmResultado : Form
    {
        Int16 gCopaID;
        string AnoCopa;
        public frmResultado(Int16 vCopaID)
        {
            InitializeComponent();
            this.gCopaID = vCopaID;
            AjustaTitulo();
            CarregarParticipantes();
            CarregarDados();
        }

        private void AjustaTitulo()
        {
            RNCopa rn = new RNCopa();
            lblTitulo.Text = "Resultado da Copa " + rn.RetornaNomeCopa(this.gCopaID); ;
        }

        private void CarregarParticipantes()
        {
            RNPais rn = new RNPais();

            List<Pais> lista1 = rn.SelParticipantesSelecionados(gCopaID);
            List<Pais> lista2 = new List<Pais>();
            List<Pais> lista3 = new List<Pais>();
            List<Pais> lista4 = new List<Pais>();
            lista2.AddRange(lista1);
            lista3.AddRange(lista1);
            lista4.AddRange(lista1);

            ddl1.DisplayMember = "Nome";
            ddl1.ValueMember = "ID";
            ddl2.DisplayMember = "Nome";
            ddl2.ValueMember = "ID";
            ddl3.DisplayMember = "Nome";
            ddl3.ValueMember = "ID";
            ddl4.DisplayMember = "Nome";
            ddl4.ValueMember = "ID";

            ddl1.DataSource = lista1;
            ddl2.DataSource = lista2;
            ddl3.DataSource = lista3;
            ddl4.DataSource = lista4;
        }

        private void CarregarDados()
        {
            RNResultado rn = new RNResultado();
            ResultadoCopa oResultado = rn.Sel(gCopaID);
            if(oResultado != null)
            {
                ddl1.SelectedValue = oResultado.Posicao1_ID;
                ddl2.SelectedValue = oResultado.Posicao2_ID;
                ddl3.SelectedValue = oResultado.Posicao3_ID;
                ddl4.SelectedValue = oResultado.Posicao4_ID;
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            RNCopa rn = new RNCopa();
            Competicao TipoCompeticao = rn.RetornaTipoCompeticao(gCopaID);
            frmMain frm = (frmMain)this.MdiParent;
            frm.AbrirCopaLista(TipoCompeticao);
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            RNResultado rn = new RNResultado();
            ResultadoCopa oResultado = CarregarDoForm();
            rn.Salvar(oResultado);
            MessageBox.Show("Resultado da copa de " + AnoCopa + " foi gravado com sucesso", "Gravação de Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            IrParaLista(Competicao.Feminino);
        }

        private ResultadoCopa CarregarDoForm()
        {
            ResultadoCopa oRes = new ResultadoCopa();
            oRes.CopaID = gCopaID;
            oRes.Posicao1_ID = (Int16)ddl1.SelectedValue;
            oRes.Posicao2_ID = (Int16)ddl2.SelectedValue;
            oRes.Posicao3_ID = (Int16)ddl3.SelectedValue;
            oRes.Posicao4_ID = (Int16)ddl4.SelectedValue;
            return oRes;
        }

        private void IrParaLista(Competicao Competicao)
        {
            frmMain frm = (frmMain)this.MdiParent;
            frm.AbrirCopaLista(Competicao);
        }
    }
}
