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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FIFA_WorldCup.Forms
{
    public partial class frmGrupoPosicaoDetalhe : Form
    {
        Int16 gCopaID;
        Int16 gGrupoID;
        Int16 gQuantidadePaises;
        public frmGrupoPosicaoDetalhe(Int16 GrupoID, Int16 CopaID)
        {
            InitializeComponent();
            CarregarPaises(GrupoID);
            gCopaID = CopaID;
            gGrupoID = GrupoID;
            AtualizarTitulo();
            CarregarPosicoes();
        }

        private void AtualizarTitulo()
        {
            RNCopa rnCopa = new RNCopa();
            Copa copa = rnCopa.Sel(gCopaID);
            RNGrupo rnG = new RNGrupo();
            Grupo oGrupo = rnG.Sel(gGrupoID);
            lblTitulo.Text = $"Definir posições do {oGrupo.Nome} - {copa.Nome}";
        }


        private void CarregarPosicoes()
        {
            RNPosicaoGrupo rnP = new RNPosicaoGrupo();
            List<PosicaoGrupo> lista = rnP.Sel(gGrupoID);
            if (lista.Count > 0)
            {
                cboPosicao1.SelectedValue = lista.Where(x => x.Posicao == 1).FirstOrDefault().PaisID;
                cboPosicao2.SelectedValue = lista.Where(x => x.Posicao == 2).FirstOrDefault().PaisID;
                cboPosicao3.SelectedValue = lista.Where(x => x.Posicao == 3).FirstOrDefault().PaisID;
                if (gQuantidadePaises == 4)
                    cboPosicao4.SelectedValue = lista.Where(x => x.Posicao == 4).FirstOrDefault().PaisID;
            }
        }



        private void CarregarPaises(Int16 GrupoID)
        {
            RNPais rnP = new RNPais();
            List<Pais> lista1 = rnP.MembrosDoGrupo(GrupoID);
            gQuantidadePaises = (short)lista1.Count;
            List<Pais> lista2 = new List<Pais>();
            lista2.AddRange(lista1);
            List<Pais> lista3 = new List<Pais>();
            lista3.AddRange(lista1);
            List<Pais> lista4 = new List<Pais>();
            lista4.AddRange(lista1);

            cboPosicao1.DataSource = lista1;
            cboPosicao1.DisplayMember = "Nome";
            cboPosicao1.ValueMember = "ID";

            cboPosicao2.DataSource = lista2;
            cboPosicao2.DisplayMember = "Nome";
            cboPosicao2.ValueMember = "ID";

            cboPosicao3.DataSource = lista3;
            cboPosicao3.DisplayMember = "Nome";
            cboPosicao3.ValueMember = "ID";

            if(gQuantidadePaises == 4)
             {
                cboPosicao4.DataSource = lista4;
                cboPosicao4.DisplayMember = "Nome";
                cboPosicao4.ValueMember = "ID";
            }

        }


        private bool ValidarSelecao()
        {
            bool selecaoCorreta = true;
            var selecionados = new[] {""};

            //// Pegando os valores selecionados
            if (gQuantidadePaises == 4)
            {
                selecionados = new[]
                {
                    ((Pais)cboPosicao1.SelectedItem).Nome,
                    ((Pais)cboPosicao2.SelectedItem).Nome,
                    ((Pais)cboPosicao3.SelectedItem).Nome,
                    ((Pais)cboPosicao4.SelectedItem).Nome
                };
            } else
            {
                selecionados = new[]
                {
                    ((Pais)cboPosicao1.SelectedItem).Nome,
                    ((Pais)cboPosicao2.SelectedItem).Nome,
                    ((Pais)cboPosicao3.SelectedItem).Nome
                };
            }


            // Verifica se algum está nulo (não selecionado)
            if (selecionados.Any(x => x == null))
            {
                MessageBox.Show("Selecione um país para cada posição.", "Seleção incompleta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                selecaoCorreta = false;
            }

            // Verifica se todos são distintos
            bool todosDiferentes = selecionados.Distinct().Count() == selecionados.Length;

            if (!todosDiferentes)
            {
                MessageBox.Show("As posições precisam ter países diferentes.", "Seleção errada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                selecaoCorreta = false;
            }
            return selecaoCorreta;
        }


        private void IrParaGrupos()
        {
            frmMain pai = (frmMain)this.MdiParent;
            pai.AbrirGruposLista(gCopaID);

        }

        private void frmGrupoPosicaoDetalhe_Shown(object sender, EventArgs e)
        {
            //centralizar titulo
            lblTitulo.Left = (this.ClientSize.Width - lblTitulo.Width) / 2;
        }

        private void picSalvar_Click(object sender, EventArgs e)
        {
            if (ValidarSelecao())
            {
                List<PosicaoGrupo> lista = new List<PosicaoGrupo>();
                RNPosicaoGrupo rN = new RNPosicaoGrupo();
                PosicaoGrupo oPosicao1 = new PosicaoGrupo
                {
                    GrupoID = gGrupoID,
                    PaisID = (short)cboPosicao1.SelectedValue,
                    Posicao = 1
                };
                lista.Add(oPosicao1);

                PosicaoGrupo oPosicao2 = new PosicaoGrupo
                {
                    GrupoID = gGrupoID,
                    PaisID = (short)cboPosicao2.SelectedValue,
                    Posicao = 2
                };
                lista.Add(oPosicao2);

                PosicaoGrupo oPosicao3 = new PosicaoGrupo
                {
                    GrupoID = gGrupoID,
                    PaisID = (short)cboPosicao3.SelectedValue,
                    Posicao = 3
                };
                lista.Add(oPosicao3);

                if (gQuantidadePaises == 4)
                {
                    PosicaoGrupo oPosicao4 = new PosicaoGrupo
                    {
                        GrupoID = gGrupoID,
                        PaisID = (short)cboPosicao4.SelectedValue,
                        Posicao = 4
                    };
                    lista.Add(oPosicao4);
                }
                rN.InserirPosicoes(lista);
                IrParaGrupos();
            }
        }

        private void picVoltar_Click(object sender, EventArgs e)
        {
            IrParaGrupos();
        }
    }
}
