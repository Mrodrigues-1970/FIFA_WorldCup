using FIFA_WorldCup.Dal;
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
    public partial class frmEstatisticas : Form
    {
        List<ConfrontoPais> listaFinalPaises = new List<ConfrontoPais>();
        List<ConfrontoConfederacao> listaFinalConfederacoes = new List<ConfrontoConfederacao>();
        Int16 gPaisID;
        bool ordemDecrescente = false;
        int ultimaColunaEscolhida = 0;
        public frmEstatisticas(Int16 vPaisID)
        {
            InitializeComponent();
            gPaisID = vPaisID;
            AlterarTitulo();
            CarregarDadosGerais();
            MontarQuadroTrofeus();
            MontarConfrontos();
            MontarConfrontosConfederacoes();
        }

        private void AlterarTitulo()
        {
            RNPais rn = new RNPais();
            Pais oPais = rn.Sel(gPaisID);
            lblTitulo.Text = "Estatísticas: " + oPais.Nome;
        }

        private void CarregarDadosGerais()
        {
            RNRankingGeral rn = new RNRankingGeral();
            List<RankingGeral> listaGeral = rn.PerformanceDe1Pais(gPaisID, Competicao.Masculino);
            grdGeral.DataSource = listaGeral;

        }
        
        private void btFechar_Click(object sender, EventArgs e)
        {
            frmMain frm = (frmMain)this.MdiParent;
            frm.AbrirPaisLista();
        }

        private void MontarQuadroTrofeus()
        {
            Int16 indiceConquista = 0;
            Int16 indiceTrofeu;
            RNResultado rn = new RNResultado();
            List<Conquista> Conquistas = rn.SelConquistas(gPaisID);
            foreach (Conquista iConquista in Conquistas)
            {
                indiceConquista += 1;
                indiceTrofeu = DefineIndiceTaca(iConquista);

                switch (indiceConquista)
                {
                    case 1:
                        cup1.Image = imageList1.Images[indiceTrofeu];
                        lblConquista1.Text = iConquista.Ano.ToString();
                        break;

                    case 2:
                        cup2.Image = imageList1.Images[indiceTrofeu];
                        lblConquista2.Text = iConquista.Ano.ToString();
                        break;

                    case 3:
                        cup3.Image = imageList1.Images[indiceTrofeu];
                        lblConquista3.Text = iConquista.Ano.ToString();
                        break;

                    case 4:
                        cup4.Image = imageList1.Images[indiceTrofeu];
                        lblConquista4.Text = iConquista.Ano.ToString();
                        break;

                    case 5:
                        cup5.Image = imageList1.Images[indiceTrofeu];
                        lblConquista5.Text = iConquista.Ano.ToString();
                        break;

                    case 6:
                        cup6.Image = imageList1.Images[indiceTrofeu];
                        lblConquista6.Text = iConquista.Ano.ToString();
                        break;

                    case 7:
                        cup7.Image = imageList1.Images[indiceTrofeu];
                        lblConquista7.Text = iConquista.Ano.ToString();
                        break;

                    case 8:
                        cup8.Image = imageList1.Images[indiceTrofeu];
                        lblConquista8.Text = iConquista.Ano.ToString();
                        break;

                    case 9:
                        cup9.Image = imageList1.Images[indiceTrofeu];
                        lblConquista9.Text = iConquista.Ano.ToString();
                        break;

                    case 10:
                        cup10.Image = imageList1.Images[indiceTrofeu];
                        lblConquista10.Text = iConquista.Ano.ToString();
                        break;

                    case 11:
                        cup11.Image = imageList1.Images[indiceTrofeu];
                        lblConquista11.Text = iConquista.Ano.ToString();
                        break;

                    case 12:
                        cup12.Image = imageList1.Images[indiceTrofeu];
                        lblConquista12.Text = iConquista.Ano.ToString();
                        break;

                    case 13:
                        cup13.Image = imageList1.Images[indiceTrofeu];
                        lblConquista13.Text = iConquista.Ano.ToString();
                        break;

                    case 14:
                        cup14.Image = imageList1.Images[indiceTrofeu];
                        lblConquista14.Text = iConquista.Ano.ToString();
                        break;

                }

            }
            
        }

        private void MontarConfrontos()
        {
            RNEstatistica rn = new RNEstatistica();
            // PROVISORIO
            List<ConfrontoPais> listaInicial = rn.ListaDeConfrontos(gPaisID, Competicao.Masculino);
            foreach(ConfrontoPais iConfronto in listaInicial)
            {
                // Pais
                if(AdversarioEInedito(listaFinalPaises , iConfronto))
                {
                    listaFinalPaises.Add(iConfronto);
                }
                else
                {
                    foreach(ConfrontoPais oConfronto in listaFinalPaises)
                    {
                        if(oConfronto.AdversarioID == iConfronto.AdversarioID)
                        {
                            oConfronto.Derrotas += iConfronto.Derrotas;
                            oConfronto.Empates += iConfronto.Empates;
                            oConfronto.Vitorias += iConfronto.Vitorias;
                            oConfronto.GolsMarcados += iConfronto.GolsMarcados;
                            oConfronto.GolsSofridos += iConfronto.GolsSofridos;
                        }

                    }
                }
            }
            grdConfrontos.DataSource = listaFinalPaises;
        }

        private void MontarConfrontosConfederacoes()
        {
            List<ConfrontoConfederacao> lista;
            RNEstatistica oRN = new RNEstatistica();
            lista = oRN.BuscaConfrontoConfederacao(gPaisID, Competicao.Masculino);
            grdConfederacoes.DataSource = lista;
        }

        private bool AdversarioEInedito(List<ConfrontoPais> listaFinal, ConfrontoPais vConfronto)
        {
            bool inedito = true;
            foreach(ConfrontoPais xConfronto in listaFinal)
            {
                if(xConfronto.AdversarioID == vConfronto.AdversarioID)
                {
                    inedito = false;
                }
            }
            return inedito;
        }

        private bool ConfederacaoEInedita(List<ConfrontoConfederacao> listaFinal, ConfrontoPais vConfronto)
        {
            bool inedito = true;
            foreach(ConfrontoConfederacao xConfronto in listaFinal)
            {
                if(xConfronto.Confederacao == vConfronto.ConfederacaoAdversario)
                {
                    inedito = false;
                }
            }
            return inedito;
        }

        private void grdConfrontos_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(ultimaColunaEscolhida == e.ColumnIndex)
            {
                ordemDecrescente = !ordemDecrescente;
            }
            
            List<ConfrontoPais> ListaOrdenada = null;
            switch (e.ColumnIndex)
            {
                case 0:
                    ListaOrdenada = listaFinalPaises;
                    break;

                case 1:
                    if (ordemDecrescente)
                    {
                        ListaOrdenada = listaFinalPaises.OrderBy(o => o.NomeAdversario).Reverse().ToList();
                    }
                    else
                    {
                        ListaOrdenada = listaFinalPaises.OrderBy(o => o.NomeAdversario).ToList();
                    }                    
                    break;

                case 2:
                    if (ordemDecrescente)
                    {
                        ListaOrdenada = listaFinalPaises.OrderBy(o => o.Vitorias).Reverse().ToList();
                    }
                    else
                    {
                        ListaOrdenada = listaFinalPaises.OrderBy(o => o.Vitorias).ToList();
                    }                        
                    break;

                case 3:
                    if (ordemDecrescente)
                    {
                        ListaOrdenada = listaFinalPaises.OrderBy(o => o.Empates).Reverse().ToList();
                    }
                    else
                    {
                        ListaOrdenada = listaFinalPaises.OrderBy(o => o.Empates).ToList();
                    }                    
                    break;

                case 4:
                    if (ordemDecrescente)
                    {
                        ListaOrdenada = listaFinalPaises.OrderBy(o => o.Derrotas).Reverse().ToList();
                    }
                    else
                    {
                        ListaOrdenada = listaFinalPaises.OrderBy(o => o.Derrotas).ToList();
                    }                        
                    break;

                case 5:
                    if (ordemDecrescente)
                    {
                        ListaOrdenada = listaFinalPaises.OrderBy(o => o.GolsMarcados).Reverse().ToList();
                    }
                    else
                    {
                        ListaOrdenada = listaFinalPaises.OrderBy(o => o.GolsMarcados).ToList();
                    }                        
                    break;

                case 6:
                    if (ordemDecrescente)
                    {
                        ListaOrdenada = listaFinalPaises.OrderBy(o => o.GolsSofridos).Reverse().ToList();
                    }
                    else
                    {
                        ListaOrdenada = listaFinalPaises.OrderBy(o => o.GolsSofridos).ToList();
                    }                        
                    break;

                case 7:
                    if (ordemDecrescente)
                    {
                        ListaOrdenada = listaFinalPaises.OrderBy(o => o.SaldoGols).Reverse().ToList();
                    }
                    else
                    {
                        ListaOrdenada = listaFinalPaises.OrderBy(o => o.SaldoGols).ToList();
                    }                        
                    break;

                case 8:
                    if (ordemDecrescente)
                    {
                        ListaOrdenada = listaFinalPaises.OrderBy(o => o.Partidas).Reverse().ToList();
                    }
                    else
                    {
                        ListaOrdenada = listaFinalPaises.OrderBy(o => o.Partidas).ToList();
                    }                    
                    break;
            }
            ultimaColunaEscolhida = e.ColumnIndex;
            listaFinalPaises = ListaOrdenada;
            grdConfrontos.DataSource = listaFinalPaises;
        }

        private ConfrontoConfederacao ConverteConfronto(ConfrontoPais oConfronto)
        {
            ConfrontoConfederacao oCC = new ConfrontoConfederacao();
            oCC.Confederacao = oConfronto.ConfederacaoAdversario;





            return oCC;
        }

        private Int16 DefineIndiceTaca(Conquista Conquista)
        {
            Int16 retorno = 0;
            switch(Conquista.Competicao)
            {
                case Competicao.Masculino:
                    if (Conquista.Ano < 1971)
                    {
                        //Jules Rimet
                        retorno = 0;
                    }
                    else
                    {
                        //Trofeu Fifa World Cup
                        retorno = 1;
                    }
                    break;

                case Competicao.Feminino:
                    retorno = 2;
                    break;

                case Competicao.Confederacoes:
                    retorno = 3;
                    break;
            }
            return retorno;
        }


        private void RecalcularRankingGeral(Competicao oCompeticao)
        {
            if (RecalculoPossuiDados(oCompeticao))
            {
                this.Cursor = Cursors.WaitCursor;
                lblResultado.Text = "";
                RNRankingGeral rn = new RNRankingGeral();
                rn.RecalculaDadosPais(gPaisID, oCompeticao);
                this.Cursor = Cursors.Default;
                lblResultado.Text = "Ranking geral recalculado para a competição: " + oCompeticao.ToString();
            }
            else
            {
                MessageBox.Show("País não possui partidas na Copa " + oCompeticao.ToString(), "Falta de dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool RecalculoPossuiDados(Competicao oCompeticao)
        {
            RNPartida rn = new RNPartida();
            return rn.PaisPossuiPartidasEmTipoCopa(gPaisID, oCompeticao);
        }


        private void btRecalcularmasculino_Click(object sender, EventArgs e)
        {
            DialogResult oDialogResult = MessageBox.Show("Tem certeza que deseja recalcular o ranking geral deste país para a Copa Masculina?", "Recalcular Ranking Geral", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (oDialogResult == DialogResult.Yes)
            {
                RecalcularRankingGeral(Competicao.Masculino);
            }
                
        }

        private void btRecalcularFeminino_Click(object sender, EventArgs e)
        {
            DialogResult oDialogResult = MessageBox.Show("Tem certeza que deseja recalcular o ranking geral deste país para a Copa Feminina?", "Recalcular Ranking Geral", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (oDialogResult == DialogResult.Yes)
            {
                RecalcularRankingGeral(Competicao.Feminino);
            }           
        }

        private void btRecalcularConfederacoes_Click(object sender, EventArgs e)
        {
            DialogResult oDialogResult = MessageBox.Show("Tem certeza que deseja recalcular o ranking geral deste país para a Copa das Confederações?", "Recalcular Ranking Geral", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (oDialogResult == DialogResult.Yes)
            {
                RecalcularRankingGeral(Competicao.Confederacoes);
            }
        }
    }
}
