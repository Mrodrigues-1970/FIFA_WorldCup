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
    public partial class frmCalculoRankingGeral : Form
    {
        Competicao gCompeticao;
        public frmCalculoRankingGeral(Competicao oCompeticao)
        {
            InitializeComponent();
            gCompeticao = oCompeticao;
            AjustarTitulo();
        }

        private void AjustarTitulo()
        {
            string nomeCompeticao = "";
            switch (gCompeticao)
            {
                case Competicao.Masculino:
                    nomeCompeticao = " Copa do Mundo Masculina";
                    break;

                case Competicao.Feminino:
                    nomeCompeticao = " Copa do Mundo Feminina";
                    break;

                case Competicao.Confederacoes:
                    nomeCompeticao = " Copa das Confederações";
                    break;
            }
            lblTitulo.Text = "Cálculo do Ranking Geral:" + nomeCompeticao;
        }

        private void frmCalculoRankingGeral_Shown(object sender, EventArgs e)
        {
            lblTitulo.Left = (this.ClientSize.Width - lblTitulo.Width) / 2;

        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            AjustarBarraProgresso();
            string pergunta = "Esta ação irá calcular os dados de TODOS os participantes de TODAS as copas do tipo " + gCompeticao + "\rTem certeza?";
            DialogResult resultado = MessageBox.Show(pergunta, "Cálculo de Ranking Geral", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resultado == DialogResult.Yes) {
                btCalcular.Enabled = false;
                Cursor = Cursors.WaitCursor;
                RNRankingGeral rn = new RNRankingGeral();
                rn.RecalcularTodosPaisesTodasCopas(gCompeticao, ref pbCalculoRankinGeral);
                Cursor = Cursors.Default;
                MessageBox.Show("Cálculo finalizado", "Cálculo Ranking Geral", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }


        private void AjustarBarraProgresso()
        {
            switch (gCompeticao)
            {
                case Competicao.Masculino:
                    pbCalculoRankinGeral.ForeColor = Color.Blue;
                    break;
                case Competicao.Feminino:
                    pbCalculoRankinGeral.ForeColor = Color.Red;
                    break;
                case Competicao.Confederacoes:
                    pbCalculoRankinGeral.ForeColor = Color.Yellow;
                    break;
            }
        }

    }
}
