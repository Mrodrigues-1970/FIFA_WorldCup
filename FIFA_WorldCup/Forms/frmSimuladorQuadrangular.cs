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
    /*
    
    PREVISÃO:
    3 rodadas ==> 729 combinações
    2 rodadas ==> 81 combinações
    1 rodada  ==> 9 combinações

    Rodada 1
    A x B
    C x D

    Rodada 2
    A x C
    B x D

    Rodada 3
    A x D
    B x C


    RESULTADO MANDANTES
    Vitoria Vitoria
    Vitoria Empate
    Vitoria Derrota
    Empate Vitoria
    Empate Empate
    Empate Derrota
    Derrota Vitoria
    Derrota Empate
    Derrota Derrota

    */

    public partial class frmSimuladorQuadrangular : Form
    {
        public frmSimuladorQuadrangular()
        {
            InitializeComponent();
        }

        private void chk_rodada1_CheckedChanged(object sender, EventArgs e)
        {
            rb_J1TA.Enabled = !chk_SimularR1.Checked;
            rb_J1TB.Enabled = !chk_SimularR1.Checked;
            J1E.Enabled = !chk_SimularR1.Checked;

            rb_J2TA.Enabled = !chk_SimularR1.Checked;
            rb_J2TB.Enabled = !chk_SimularR1.Checked;
            J2E.Enabled = !chk_SimularR1.Checked;
        }

        private void txtTimeA_TextChanged(object sender, EventArgs e)
        {
            rb_J1TA.Text = txtTimeA.Text;
            rb_J3TA.Text = txtTimeA.Text;
            rb_J5TA.Text = txtTimeA.Text;
        }

        private void txtTimeB_TextChanged(object sender, EventArgs e)
        {
            rb_J1TB.Text = txtTimeB.Text;
            rb_J4TA.Text = txtTimeB.Text;
            rb_J6TA.Text = txtTimeB.Text;
        }

        private void txtTimeC_TextChanged(object sender, EventArgs e)
        {
            rb_J2TA.Text = txtTimeC.Text;
            rb_J3TB.Text = txtTimeC.Text;
            rb_J6TB.Text = txtTimeC.Text;
        }

        private void txtTimeD_TextChanged(object sender, EventArgs e)
        {
            rb_J2TB.Text = txtTimeD.Text;
            rb_J4TB.Text = txtTimeD.Text;
            rb_J5TB.Text = txtTimeD.Text;
        }
    }
}
