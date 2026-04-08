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
        public frmGrupoPosicaoDetalhe(Int16 GrupoID, Int16 CopaID)
        {
            InitializeComponent();
            CarregarPaises(GrupoID);
        }


        private void CarregarPaises(Int16 GrupoID)
        {
            RNPais rnP = new RNPais();
            List<Pais> lista1 = rnP.MembrosDoGrupo(GrupoID);
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

            cboPosicao4.DataSource = lista4;
            cboPosicao4.DisplayMember = "Nome";
            cboPosicao4.ValueMember = "ID";
        }


        private bool ValidarSelecao()
        {
            bool selecaoCorreta = true;

            // Pegando os valores selecionados
            var selecionados = new[]
            {
                ((Pais)cboPosicao1.SelectedItem).Nome,
                ((Pais)cboPosicao2.SelectedItem).Nome,
                ((Pais)cboPosicao3.SelectedItem).Nome,
                ((Pais)cboPosicao4.SelectedItem).Nome
            };

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
                MessageBox.Show("As 4 posições precisam ter países diferentes.", "Seleção errada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                selecaoCorreta = false;
            }
                return selecaoCorreta;
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            if (ValidarSelecao())
            {

            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {

        }
    }
}
