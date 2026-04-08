using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using FIFA_WorldCup.Dal;
using FIFA_WorldCup.Entidades;
using FIFA_WorldCup.RN;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

/*
  
 ETAPAS

1) Estabelecer vagas por confederações
2) Estabelecer anfitrião(ões)
3) Fornecer p/ usuário Países por confederação
4) Definir Potes 1, 2, 3 e 4
5) Sortear seleções em grupos de acordo com regras
6) Permitir ao usuário selecionar posições classificatórias nos grupos
7) Usar ranking para selecionar posições classificatórias não definidas pelo usuário
8) Os ítens 6 deve incluir a lista de 3º (terceiros) lugares
  
 */

namespace FIFA_WorldCup.Forms
{
    public partial class frmSimCopaMasculina : Form
    {

        #region Objetos Globais
        List<Confederacao> listaDeConfederacoes;
        List<Pais> listaRepescagemOrdenada;
        List<Pais> disponiveis_AFC = new List<Pais>();
        List<Pais> disponiveis_CONCACAF = new List<Pais>();
        List<Pais> disponiveis_UEFA = new List<Pais>();
        List<Pais> disponiveis_OFC = new List<Pais>();
        List<Pais> disponiveis_CONMEBOL = new List<Pais>();
        List<Pais> disponiveis_CAF = new List<Pais>();

        List<Pais> classificados_AFC = new List<Pais>();
        List<Pais> classificados_CONCACAF = new List<Pais>();
        List<Pais> classificados_UEFA = new List<Pais>();
        List<Pais> classificados_OFC = new List<Pais>();
        List<Pais> classificados_CONMEBOL = new List<Pais>();
        List<Pais> classificados_CAF = new List<Pais>();
        List<Pais> listaAnfitrioes = new List<Pais>();

        List<VagaMasculino> ListaVagas = RNVaga.VagasCopaMasculino();

        List<Pais> listaPote1;
        List<Pais> listaPote2;
        List<Pais> listaPote3;
        List<Pais> listaPote4;
        RNSimulacaoCopa RNSim = new RNSimulacaoCopa();
        #endregion

        public frmSimCopaMasculina()
        {
            InitializeComponent();
            CargaInicialDePaises();
            CarregarConfederacoes();
            FormatarControles();
            AlterarEstados4asFinal(false);
            EstadoSemiFinais(false);
        }

        #region Classificados

        protected void CarregarConfederacoes()
        {
            try
            {
                List<Confederacao> lista = RNSim.RetornaListaConfederacoes();
                cboConfederacoes.DataSource = lista;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro na aplicação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargaInicialDePaises()
        {
            RNPais rn = new RNPais();

            listaDeConfederacoes = RNSim.RetornaListaConfederacoes();
            foreach (Confederacao iConfederacao in listaDeConfederacoes) 
            {
                Pais filtro = new Pais();
                filtro.Confederacao = iConfederacao;
                filtro.Ativo = true;
                List<Pais> lista = rn.Sel(filtro);
                switch (iConfederacao)
                {
                    case Confederacao.AFC:
                        disponiveis_AFC = lista;
                        break;

                    case Confederacao.CONCACAF:
                        disponiveis_CONCACAF = lista;
                        break;

                    case Confederacao.CAF:
                        disponiveis_CAF = lista;
                        break;

                    case Confederacao.CONMEBOL:
                        disponiveis_CONMEBOL = lista;
                        break;

                    case Confederacao.OFC:
                        disponiveis_OFC = lista;
                        break;

                    case Confederacao.UEFA:
                        disponiveis_UEFA = lista;
                        break;
                }
            }
        }

        private void cboConfederacoes_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarregarPaisesDisponiveis();
        }

        private void CarregarPaisesDisponiveis()
        {
            try
            {
                listaDisponiveis.DataSource = new List<Pais>();
                listaDisponiveis.DisplayMember = "NomeRank";
                listaDisponiveis.ValueMember = "ID";
                switch ((Confederacao)Convert.ToInt16(cboConfederacoes.SelectedValue)) {

                    case Confederacao.CAF:
                        listaDisponiveis.DataSource = disponiveis_CAF;
                        break;

                    case Confederacao.OFC:
                        listaDisponiveis.DataSource = disponiveis_OFC;
                        break;
                    
                    case Confederacao.CONCACAF:
                        listaDisponiveis.DataSource = disponiveis_CONCACAF;
                        break;
                    
                    case Confederacao.AFC:
                        listaDisponiveis.DataSource = disponiveis_AFC;
                        break;
                    
                    case Confederacao.CONMEBOL:
                        listaDisponiveis.DataSource = disponiveis_CONMEBOL;
                        break;

                    case Confederacao.UEFA:
                        listaDisponiveis.DataSource = disponiveis_UEFA;
                        break;

                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro na aplicação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btClassificar_Click(object sender, EventArgs e)
        {
            btAnfitriao.Enabled = false;
            ClassificarPais();
        }

        private void ChecarCorListaEliminatorias()
        {
            Confederacao ConfederacaoCorrente = (Confederacao)Convert.ToInt16(cboConfederacoes.SelectedValue);

            if (!PossuiVagaDisponivel(ConfederacaoCorrente))
            {
                switch (ConfederacaoCorrente)
                {
                    case Confederacao.OFC:
                        lstClassificadosOFC.BackColor = Color.LightGray; break;

                    case Confederacao.CAF:
                        lstClassificadosCAF.BackColor = Color.LightGray; break;

                    case Confederacao.CONCACAF:
                        lstClassificadosCONCACAF.BackColor = Color.LightGray; break;

                    case Confederacao.CONMEBOL:
                        lstClassificadosCONMEBOL.BackColor = Color.LightGray; break;

                    case Confederacao.AFC:
                        lstClassificadosAFC.BackColor = Color.LightGray; break;

                    case Confederacao.UEFA:
                        lstClassificadosUEFA.BackColor = Color.LightGray; break;
                }
            }
            //TODO Se todas as confederações estiverem sem vagas disponiveis, desabilitar este botão
        }

        private void btAnfitriao_Click(object sender, EventArgs e)
        {
            Pais paisSelecionado = (Pais)listaDisponiveis.SelectedItem;
            listaAnfitrioes.Add(paisSelecionado);
            lstAnfitriao.DataSource = new List<Pais>();
            lstAnfitriao.ValueMember = "ID";
            lstAnfitriao.DisplayMember = "NomeRank";
            lstAnfitriao.DataSource = listaAnfitrioes;
            ClassificarPais();
            btClassificar.Enabled = true;
        }

        private void ClassificarPais()
        {
            if (listaDisponiveis.SelectedItems.Count > 0)
            {
                Confederacao ConfederacaoCorrente = (Confederacao)Convert.ToInt16(cboConfederacoes.SelectedValue);
                Pais paisSelecionado = (Pais)listaDisponiveis.SelectedItem;
                switch (ConfederacaoCorrente)
                {
                    case Confederacao.OFC:
                        if (PossuiVagaDisponivel(ConfederacaoCorrente))
                        {
                            classificados_OFC.Add(paisSelecionado);
                            disponiveis_OFC.Remove(paisSelecionado);
                        }
                        break;

                    case Confederacao.CAF:
                        if (PossuiVagaDisponivel(ConfederacaoCorrente))
                        {
                            classificados_CAF.Add(paisSelecionado);
                            disponiveis_CAF.Remove(paisSelecionado);
                        }
                        break;

                    case Confederacao.CONMEBOL:
                        if (PossuiVagaDisponivel(ConfederacaoCorrente))
                        {
                            classificados_CONMEBOL.Add(paisSelecionado);
                            disponiveis_CONMEBOL.Remove(paisSelecionado);
                        }
                        break;

                    case Confederacao.CONCACAF:
                        if (PossuiVagaDisponivel(ConfederacaoCorrente))
                        {
                            classificados_CONCACAF.Add(paisSelecionado);
                            disponiveis_CONCACAF.Remove(paisSelecionado);
                        }
                        break;

                    case Confederacao.AFC:
                        if (PossuiVagaDisponivel(ConfederacaoCorrente))
                        {
                            classificados_AFC.Add(paisSelecionado);
                            disponiveis_AFC.Remove(paisSelecionado);
                        }
                        break;

                    case Confederacao.UEFA:
                        if (PossuiVagaDisponivel(ConfederacaoCorrente))
                        {
                            classificados_UEFA.Add(paisSelecionado);
                            disponiveis_UEFA.Remove(paisSelecionado);
                        }
                        break;
                }
                ChecarCorListaEliminatorias();
                CarregarClassificados();
                CarregarPaisesDisponiveis();
                if (ClassificacaoDiretaCompleta())
                {
                    PrepararRepescagem();
                }
            }
        }

        private void CarregarClassificados()
        {
            List<Pais> limpeza = new List<Pais>();
            lstClassificadosAFC.DataSource = limpeza;
            lstClassificadosCAF.DataSource = limpeza;
            lstClassificadosCONCACAF.DataSource = limpeza;
            lstClassificadosCONMEBOL.DataSource = limpeza;
            lstClassificadosOFC.DataSource = limpeza;
            lstClassificadosUEFA.DataSource = limpeza;


            lstClassificadosAFC.DataSource = classificados_AFC;
            lstClassificadosCAF.DataSource = classificados_CAF;
            lstClassificadosCONCACAF.DataSource = classificados_CONCACAF;
            lstClassificadosCONMEBOL.DataSource = classificados_CONMEBOL;
            lstClassificadosOFC.DataSource = classificados_OFC;
            lstClassificadosUEFA.DataSource = classificados_UEFA;
        }

        private void FormatarControles()
        {
            lstClassificadosAFC.ValueMember = "ID";
            lstClassificadosAFC.DisplayMember = "NomeRank";

            lstClassificadosCAF.ValueMember = "ID";
            lstClassificadosCAF.DisplayMember = "NomeRank";

            lstClassificadosCONCACAF.ValueMember = "ID";
            lstClassificadosCONCACAF.DisplayMember = "NomeRank";

            lstClassificadosCONMEBOL.ValueMember = "ID";
            lstClassificadosCONMEBOL.DisplayMember = "NomeRank";

            lstClassificadosOFC.ValueMember = "ID";
            lstClassificadosOFC.DisplayMember = "NomeRank";

            lstClassificadosUEFA.ValueMember = "ID";
            lstClassificadosUEFA.DisplayMember = "NomeRank";

        }

        private bool PossuiVagaDisponivel(Confederacao vConfederacao) {

            bool resposta = false;
            VagaMasculino vaga = ListaVagas.First(x => x.Confederacao == vConfederacao);
            int vagasOcupadas = 0;

            switch (vConfederacao)
            {
                case Confederacao.OFC:
                    vagasOcupadas = classificados_OFC.Count();
                    break;

                case Confederacao.AFC:
                    vagasOcupadas = classificados_AFC.Count();
                    break;

                case Confederacao.CONCACAF:
                    vagasOcupadas = classificados_CONCACAF.Count();
                    break;

                case Confederacao.UEFA:
                    vagasOcupadas = classificados_UEFA.Count();
                    break;

                case Confederacao.CONMEBOL:
                    vagasOcupadas = classificados_CONMEBOL.Count();
                    break;

                case Confederacao.CAF:
                    vagasOcupadas = classificados_CAF.Count();
                    break;
            }
            if (vaga.VagasTotais > vagasOcupadas)
            {
                resposta = true;
            }
            return resposta;
        }

        private bool ClassificacaoDiretaCompleta()
        {
            bool resposta = true;
            foreach(Confederacao iConfederacao in listaDeConfederacoes)
            {
                VagaMasculino vagasDaConfederacaoCorrente = ListaVagas.First(x => x.Confederacao == iConfederacao);
                switch (iConfederacao)
                {
                    case Confederacao.CONCACAF:
                        if(classificados_CONCACAF.Count() < vagasDaConfederacaoCorrente.VagasTotais)
                        {
                            resposta = false;
                        }
                        break;

                    case Confederacao.OFC:
                        if (classificados_OFC.Count() < vagasDaConfederacaoCorrente.VagasTotais)
                        {
                            resposta = false;
                        }
                        break;

                    case Confederacao.CAF:
                        if (classificados_CAF.Count() < vagasDaConfederacaoCorrente.VagasTotais)
                        {
                            resposta = false;
                        }
                        break;

                    case Confederacao.AFC:
                        if (classificados_AFC.Count() < vagasDaConfederacaoCorrente.VagasTotais)
                        {
                            resposta = false;
                        }
                        break;

                    case Confederacao.CONMEBOL:
                        if (classificados_CONMEBOL.Count() < vagasDaConfederacaoCorrente.VagasTotais)
                        {
                            resposta = false;
                        }
                        break;

                    case Confederacao.UEFA:
                        if (classificados_UEFA.Count() < vagasDaConfederacaoCorrente.VagasTotais)
                        {
                            resposta = false;
                        }
                        break;
                }
            }
            //Foi definido pelo menos um anfitrião
            if (lstAnfitriao.Items.Count == 0)
            {
                resposta = false;
            }

            return resposta;
        }

        #endregion

        #region Repescagem

        Int16 RepescagemSemiFinalista1A = 0;
        Int16 RepescagemSemiFinalista1B = 0;
        Int16 RepescagemSemiFinalista2A = 0;
        Int16 RepescagemSemiFinalista2B = 0;
        Pais RepescagemFinalistaA;
        Pais RepescagemFinalistaB;
        Pais RepescagemVencedor1;
        Pais RepescagemVencedor2;
        List<Pais> listaFinalParticipantes = new List<Pais>();

        private void PrepararRepescagem()
        {
            grpRespescagem1.Enabled = true;
            grpRespescagem2.Enabled = true;
            List<Pais> listaRepescagem = new List<Pais>();
            foreach(Confederacao iConfederacao in listaDeConfederacoes)
            {
                VagaMasculino vagaCorrente = ListaVagas.First(x => x.Confederacao == iConfederacao);
                double numRepescagem = vagaCorrente.VagasRepescagem;
                int indice = (Int16)vagaCorrente.VagasTotais - 1;
                if(numRepescagem > 0)
                {
                    switch (iConfederacao)
                    {
                        case Confederacao.OFC:
                            listaRepescagem.Add(classificados_OFC[indice]);
                            classificados_OFC.RemoveAt(indice);
                            break;

                        case Confederacao.AFC:
                            listaRepescagem.Add(classificados_AFC[indice]);
                            classificados_AFC.RemoveAt(indice);
                            break;

                        case Confederacao.CONCACAF:
                            listaRepescagem.Add(classificados_CONCACAF[indice]);
                            classificados_CONCACAF.RemoveAt(indice);
                            listaRepescagem.Add(classificados_CONCACAF[indice - 1]);
                            classificados_CONCACAF.RemoveAt(indice - 1);
                            break;

                        case Confederacao.UEFA:
                            //listaRepescagem.Add(classificados_UEFA[indice]);
                            //classificados_UEFA.RemoveAt(indice);
                            break;

                        case Confederacao.CONMEBOL:
                            listaRepescagem.Add(classificados_CONMEBOL[indice]);
                            classificados_CONMEBOL.RemoveAt(indice);
                            break;

                        case Confederacao.CAF:
                            listaRepescagem.Add(classificados_CAF[indice]);
                            classificados_CAF.RemoveAt(indice);
                            break;
                    }
                }
            }

            listaRepescagemOrdenada = listaRepescagem.OrderBy(p => p.Rank).ToList();
            txtFinalRepescagem1B.Text = listaRepescagemOrdenada[0].NomeRank;
            txtFinalRepescagem2B.Text = listaRepescagemOrdenada[1].NomeRank;

            txtSemiFinalRepescagem1A.Text = listaRepescagemOrdenada[2].NomeRank;
            RepescagemSemiFinalista1A = listaRepescagemOrdenada[2].ID;
            txtSemiFinalRepescagem1B.Text = listaRepescagemOrdenada[3].NomeRank;
            RepescagemSemiFinalista1B = listaRepescagemOrdenada[3].ID;

            txtSemiFinalRepescagem2A.Text = listaRepescagemOrdenada[4].NomeRank;
            RepescagemSemiFinalista2A = listaRepescagemOrdenada[4].ID;
            txtSemiFinalRepescagem2B.Text = listaRepescagemOrdenada[5].NomeRank;
            RepescagemSemiFinalista2B = listaRepescagemOrdenada[5].ID;

        }

        private void rbSemiFinal1A_CheckedChanged(object sender, EventArgs e)
        {
            RepescagemFinalistaA = listaRepescagemOrdenada.First(x => x.ID == RepescagemSemiFinalista1A);
            txtFinalRepescagem1A.Text = RepescagemFinalistaA.NomeRank;
        }

        private void rbSemiFinal1B_CheckedChanged(object sender, EventArgs e)
        {
            RepescagemFinalistaA = listaRepescagemOrdenada.First(x => x.ID == RepescagemSemiFinalista1B);
            txtFinalRepescagem1A.Text = RepescagemFinalistaA.NomeRank;
        }

        private void rbSemiFinal2A_CheckedChanged(object sender, EventArgs e)
        {
            RepescagemFinalistaB = listaRepescagemOrdenada.First(x => x.ID == RepescagemSemiFinalista2A);
            txtFinalRepescagem2A.Text = RepescagemFinalistaB.NomeRank;
        }

        private void rbSemiFinal2B_CheckedChanged(object sender, EventArgs e)
        {
            RepescagemFinalistaB = listaRepescagemOrdenada.First(x => x.ID == RepescagemSemiFinalista2B);
            txtFinalRepescagem2A.Text = RepescagemFinalistaB.NomeRank;
        }

        private void btFinalizarRepescagem_Click(object sender, EventArgs e)
        {
            List<Pais> listaProvisoria = new List<Pais>();
            listaProvisoria.AddRange(classificados_AFC);
            listaProvisoria.AddRange(classificados_CAF);
            listaProvisoria.AddRange(classificados_CONCACAF);
            listaProvisoria.AddRange(classificados_CONMEBOL);
            listaProvisoria.AddRange(classificados_OFC);
            listaProvisoria.AddRange(classificados_UEFA);
            listaProvisoria.Add(RepescagemVencedor1);
            listaProvisoria.Add(RepescagemVencedor2);

            //Retirar anfitrioes da lista
            foreach(Pais iPais in listaAnfitrioes)
            {
                listaProvisoria.Remove(iPais);
            }
            //ordenar por Rank
            List<Pais> listaProvisoriaOrdenada = listaProvisoria.OrderBy(x => x.Rank).ToList();
            //Incluir anfitriões no início
            listaFinalParticipantes.AddRange(listaAnfitrioes);
            listaFinalParticipantes.AddRange(listaProvisoriaOrdenada);

            //distribuir paises entre os potes
            Int16 indice = 1;
            listaPote1 = new List<Pais>();
            listaPote2 = new List<Pais>();
            listaPote3 = new List<Pais>();
            listaPote4 = new List<Pais>();
            foreach (Pais iPais in listaFinalParticipantes) { 
                //pote 1
                if(indice <= 12)
                {
                    listaPote1.Add(iPais);
                }
                //pote 2
                if (indice > 12 && indice <= 24)
                {
                    listaPote2.Add(iPais);
                }
                //pote 3
                if (indice > 24 && indice <= 36)
                {
                    listaPote3.Add(iPais);
                }
                //pote 4
                if (indice > 36 && indice <= 48)
                {
                    listaPote4.Add(iPais);
                }
                indice++;
            }
            lstPote1.DisplayMember = "NomeRank";
            lstPote1.ValueMember = "ID";
            lstPote1.DataSource = listaPote1;

            lstPote2.DisplayMember = "NomeRank";
            lstPote2.ValueMember = "ID";
            lstPote2.DataSource = listaPote2;

            lstPote3.DisplayMember = "NomeRank";
            lstPote3.ValueMember = "ID";
            lstPote3.DataSource = listaPote3;

            lstPote4.DisplayMember = "NomeRank";
            lstPote4.ValueMember = "ID";
            lstPote4.DataSource = listaPote4;

            grpSorteioPotes.Enabled = true;
            grpSorteioGrupos.Enabled = true;
            btFinalizarRepescagem.Enabled = false;
        }

        private void rbFinal1A_CheckedChanged(object sender, EventArgs e)
        {
            RepescagemVencedor1 = listaRepescagemOrdenada.First(x => x.NomeRank == txtFinalRepescagem1A.Text);
        }

        private void rbFinal1B_CheckedChanged(object sender, EventArgs e)
        {
            RepescagemVencedor1 = listaRepescagemOrdenada.First(x => x.NomeRank == txtFinalRepescagem1B.Text);
        }

        private void rbFinal2A_CheckedChanged(object sender, EventArgs e)
        {
            RepescagemVencedor2 = listaRepescagemOrdenada.First(x => x.NomeRank == txtFinalRepescagem2A.Text);
        }

        private void rbFinal2B_CheckedChanged(object sender, EventArgs e)
        {
            RepescagemVencedor2 = listaRepescagemOrdenada.First(x => x.NomeRank == txtFinalRepescagem2B.Text);
        }

        #endregion

        #region Sorteio

        List<Pais> listaGrupoA = new List<Pais>();
        List<Pais> listaGrupoB = new List<Pais>();
        List<Pais> listaGrupoC = new List<Pais>();
        List<Pais> listaGrupoD = new List<Pais>();
        List<Pais> listaGrupoE = new List<Pais>();
        List<Pais> listaGrupoF = new List<Pais>();
        List<Pais> listaGrupoG = new List<Pais>();
        List<Pais> listaGrupoH = new List<Pais>();
        List<Pais> listaGrupoI = new List<Pais>();
        List<Pais> listaGrupoJ = new List<Pais>();
        List<Pais> listaGrupoK = new List<Pais>();
        List<Pais> listaGrupoL = new List<Pais>();

        List<string> listaLetraGrupos = new List<string>();
        bool sorteioValido = true;
        Pais selecaoSorteada;
        Int16 tentativasSorteio;
        

        private void btSortearPote1_Click(object sender, EventArgs e)
        {
            Int16 numeroGrupo = 0;
            List<Int16> listaGrupos = RNSim.GeraNumeroDeGrupos();
            //incluir Anfitriões
            foreach (Pais iPais in listaAnfitrioes)
            {
                numeroGrupo++;
                IncluirPaisNoGrupo(iPais, numeroGrupo);
                listaPote1.Remove(iPais);
                listaGrupos.Remove(numeroGrupo);
            }
            //incluir as outras seleções
            while(listaPote1.Count > 0)
            {
                numeroGrupo++;
                Int16 quantidadeRestante = (short)listaPote1.Count();
                Int16 numSelecaoSorteada = RNSim.SorteiaNumero(quantidadeRestante);
                selecaoSorteada = listaPote1[numSelecaoSorteada];
                IncluirPaisNoGrupo(selecaoSorteada, numeroGrupo);
                listaPote1.Remove(selecaoSorteada);
                listaGrupos.Remove(numeroGrupo);
            }
            lstPote1.DataSource = new List<Pais>();
            btSortearPote1.Enabled = false;
            btSortearPote2.Enabled = true;
        }

        private void btSortearPote2_Click(object sender, EventArgs e)
        {
            Int16 numeroGrupo = 0;
            tentativasSorteio = 0;
            List<Int16> listaGrupos = RNSim.GeraNumeroDeGrupos();
            while (listaPote2.Count > 0)
            {
                numeroGrupo++;
                tentativasSorteio++;
                Int16 quantidadeRestante = (short)listaPote2.Count();
                sorteioValido = false;
                while (!sorteioValido)
                {
                    Int16 numSelecaoSorteada;
                    if (quantidadeRestante > 1)
                    {
                        numSelecaoSorteada = RNSim.SorteiaNumero(quantidadeRestante);
                    }
                    else
                    {
                        numSelecaoSorteada = 0;
                    }                    
                    selecaoSorteada = listaPote2[numSelecaoSorteada];
                    if(tentativasSorteio < 4)
                    {
                        sorteioValido = ValidaSorteio(selecaoSorteada, numeroGrupo);
                    }
                    else
                    {
                        sorteioValido = true;
                    }
                    
                }                
                IncluirPaisNoGrupo(selecaoSorteada, numeroGrupo);
                listaPote2.Remove(selecaoSorteada);
                listaGrupos.Remove(numeroGrupo);
            }
            lstPote2.DataSource = new List<Pais>();
            btSortearPote2.Enabled = false;
            btSortearPote3.Enabled = true;
        }

        private void btSortearPote3_Click(object sender, EventArgs e)
        {
            Int16 numeroGrupo = 0;
            tentativasSorteio = 0;
            List<Int16> listaGrupos = RNSim.GeraNumeroDeGrupos();
            while (listaPote3.Count > 0)
            {
                numeroGrupo++;
                tentativasSorteio++;
                Int16 quantidadeRestante = (short)listaPote3.Count();
                sorteioValido = false;
                while (!sorteioValido)
                {
                    Int16 numSelecaoSorteada;
                    if(quantidadeRestante > 1)
                    {
                        numSelecaoSorteada = RNSim.SorteiaNumero(quantidadeRestante);
                    }
                    else
                    {
                        numSelecaoSorteada = 0;
                    }
                    
                    selecaoSorteada = listaPote3[numSelecaoSorteada];
                    if(tentativasSorteio < 4)
                    {
                        sorteioValido = ValidaSorteio(selecaoSorteada, numeroGrupo);
                    }
                    else
                    {
                        sorteioValido = true;
                    }
                    
                }
                IncluirPaisNoGrupo(selecaoSorteada, numeroGrupo);
                listaPote3.Remove(selecaoSorteada);
                listaGrupos.Remove(numeroGrupo);
            }
            lstPote3.DataSource = new List<Pais>();
            btSortearPote3.Enabled = false;
            btSortearPote4.Enabled = true;
        }

        private void btSortearPote4_Click(object sender, EventArgs e)
        {
            Int16 numeroGrupo = 0;
            tentativasSorteio = 0;
            List<Int16> listaGrupos = RNSim.GeraNumeroDeGrupos();
            while (listaPote4.Count > 0)
            {
                numeroGrupo++;
                tentativasSorteio++;
                Int16 quantidadeRestante = (short)listaPote4.Count();
                sorteioValido = false;
                while (!sorteioValido)
                {
                    Int16 numSelecaoSorteada;
                    if (quantidadeRestante > 1)
                    {
                        numSelecaoSorteada = RNSim.SorteiaNumero(quantidadeRestante);
                    }
                    else
                    {
                        numSelecaoSorteada = 0;
                    }
                    selecaoSorteada = listaPote4[numSelecaoSorteada];
                    if (tentativasSorteio < 4)
                    {
                        sorteioValido = ValidaSorteio(selecaoSorteada, numeroGrupo);
                    }
                    else
                    {
                        sorteioValido = true;
                    }                    
                }
                IncluirPaisNoGrupo(selecaoSorteada, numeroGrupo);
                listaPote4.Remove(selecaoSorteada);
                listaGrupos.Remove(numeroGrupo);
            }
            lstPote4.DataSource = new List<Pais>();
            btSortearPote4.Enabled = false;
            CarregarGrupos();
        }

        private void IncluirPaisNoGrupo(Pais oPais, Int16 vGrupo)
        {
            switch (vGrupo) {
                case 1:
                    listaGrupoA.Add(oPais);
                    lstGrupoA.DisplayMember = "NomeRank";
                    lstGrupoA.ValueMember = "ID";
                    lstGrupoA.DataSource = new List<Pais>();
                    lstGrupoA.DataSource = listaGrupoA;
                    break;

                case 2:
                    listaGrupoB.Add(oPais);
                    lstGrupoB.DisplayMember = "NomeRank";
                    lstGrupoB.ValueMember = "ID";
                    lstGrupoB.DataSource = new List<Pais>();
                    lstGrupoB.DataSource = listaGrupoB;
                    break;

                case 3:
                    listaGrupoC.Add(oPais);
                    lstGrupoC.DisplayMember = "NomeRank";
                    lstGrupoC.ValueMember = "ID";
                    lstGrupoC.DataSource = new List<Pais>();
                    lstGrupoC.DataSource = listaGrupoC;
                    break;

                case 4:
                    listaGrupoD.Add(oPais);
                    lstGrupoD.DisplayMember = "NomeRank";
                    lstGrupoD.ValueMember = "ID";
                    lstGrupoD.DataSource = new List<Pais>();
                    lstGrupoD.DataSource = listaGrupoD;
                    break;

                case 5:
                    listaGrupoE.Add(oPais);
                    lstGrupoE.DisplayMember = "NomeRank";
                    lstGrupoE.ValueMember = "ID";
                    lstGrupoE.DataSource = new List<Pais>();
                    lstGrupoE.DataSource = listaGrupoE;

                    break;

                case 6:
                    listaGrupoF.Add(oPais);
                    lstGrupoF.DisplayMember = "NomeRank";
                    lstGrupoF.ValueMember = "ID";
                    lstGrupoF.DataSource = new List<Pais>();
                    lstGrupoF.DataSource = listaGrupoF;
                    break;

                case 7:
                    listaGrupoG.Add(oPais);
                    lstGrupoG.DisplayMember = "NomeRank";
                    lstGrupoG.ValueMember = "ID";
                    lstGrupoG.DataSource = new List<Pais>();
                    lstGrupoG.DataSource = listaGrupoG;
                    break;

                case 8:
                    listaGrupoH.Add(oPais);
                    lstGrupoH.DisplayMember = "NomeRank";
                    lstGrupoH.ValueMember = "ID";
                    lstGrupoH.DataSource = new List<Pais>();
                    lstGrupoH.DataSource = listaGrupoH;
                    break;

                case 9:
                    listaGrupoI.Add(oPais);
                    lstGrupoI.DisplayMember = "NomeRank";
                    lstGrupoI.ValueMember = "ID";
                    lstGrupoI.DataSource = new List<Pais>();
                    lstGrupoI.DataSource = listaGrupoI;
                    break;

                case 10:
                    listaGrupoJ.Add(oPais);
                    lstGrupoJ.DisplayMember = "NomeRank";
                    lstGrupoJ.ValueMember = "ID";
                    lstGrupoJ.DataSource = new List<Pais>();
                    lstGrupoJ.DataSource = listaGrupoJ;
                    break;

                case 11:
                    listaGrupoK.Add(oPais);
                    lstGrupoK.DisplayMember = "NomeRank";
                    lstGrupoK.ValueMember = "ID";
                    lstGrupoK.DataSource = new List<Pais>();
                    lstGrupoK.DataSource = listaGrupoK;
                    break;

                case 12:
                    listaGrupoL.Add(oPais);
                    lstGrupoL.DisplayMember = "NomeRank";
                    lstGrupoL.ValueMember = "ID";
                    lstGrupoL.DataSource = new List<Pais>();
                    lstGrupoL.DataSource = listaGrupoL;
                    break;
            }
        }
        
        private bool ValidaSorteio(Pais PaisSorteado, Int16 NumeroDoGrupo)
        {
            bool resposta = true;
            switch(NumeroDoGrupo)
            {
                case 1:
                    resposta = !(ExistePaisDaMesmaConfederacao(PaisSorteado.Confederacao, listaGrupoA)); break;

                case 2:
                    resposta = !(ExistePaisDaMesmaConfederacao(PaisSorteado.Confederacao, listaGrupoB)); break;

                case 3:
                    resposta = !(ExistePaisDaMesmaConfederacao(PaisSorteado.Confederacao, listaGrupoC)); break;

                case 4:
                    resposta = !(ExistePaisDaMesmaConfederacao(PaisSorteado.Confederacao, listaGrupoD)); break;

                case 5:
                    resposta = !(ExistePaisDaMesmaConfederacao(PaisSorteado.Confederacao, listaGrupoE)); break;

                case 6:
                    resposta = !(ExistePaisDaMesmaConfederacao(PaisSorteado.Confederacao, listaGrupoF)); break;

                case 7:
                    resposta = !(ExistePaisDaMesmaConfederacao(PaisSorteado.Confederacao, listaGrupoG)); break;

                case 8:
                    resposta = !(ExistePaisDaMesmaConfederacao(PaisSorteado.Confederacao, listaGrupoH)); break;

                case 9:
                    resposta = !(ExistePaisDaMesmaConfederacao(PaisSorteado.Confederacao, listaGrupoI)); break;

                case 10:
                    resposta = !(ExistePaisDaMesmaConfederacao(PaisSorteado.Confederacao, listaGrupoJ)); break;

                case 11:
                    resposta = !(ExistePaisDaMesmaConfederacao(PaisSorteado.Confederacao, listaGrupoK)); break;

                case 12:
                    resposta = !(ExistePaisDaMesmaConfederacao(PaisSorteado.Confederacao, listaGrupoL)); break;

            }

            //UEFA é isenta desta restrição
            if (PaisSorteado.Confederacao == Confederacao.UEFA)
            {
                resposta = true;
            }
            //TODO >>> Fazer um algoritmo para (em caso de sorteio inválido) TROCAR com seleções já sorteadas

            return resposta;
        }

        private bool ExistePaisDaMesmaConfederacao(Confederacao ConfederacaoAnalisada, List<Pais> grupo)
        {
            bool existencia = false;
            foreach(Pais iPais in grupo)
            {
                if (iPais.Confederacao == ConfederacaoAnalisada)
                {
                    existencia = true;
                }
            }
            return existencia;
        }

        #endregion

        #region Fase de Grupos

        List<Pais> lista1oLugares = new List<Pais>();
        List<Pais> lista2oLugares = new List<Pais>();
        List<Pais> lista3oLugares = new List<Pais>();

        private void CarregarGrupos()
        {
            GrupoA.DisplayMember = "NomeRank";
            GrupoA.ValueMember = "ID";
            GrupoA.DataSource = listaGrupoA;
            GrupoB.DisplayMember = "NomeRank";
            GrupoB.ValueMember = "ID";
            GrupoB.DataSource = listaGrupoB;
            GrupoC.DisplayMember = "NomeRank";
            GrupoC.ValueMember = "ID";
            GrupoC.DataSource = listaGrupoC;
            GrupoD.DisplayMember = "NomeRank";
            GrupoD.ValueMember = "ID";
            GrupoD.DataSource = listaGrupoD;
            GrupoE.DisplayMember = "NomeRank";
            GrupoE.ValueMember = "ID";
            GrupoE.DataSource = listaGrupoE;
            GrupoF.DisplayMember = "NomeRank";
            GrupoF.ValueMember = "ID";
            GrupoF.DataSource = listaGrupoF;
            GrupoG.DisplayMember = "NomeRank";
            GrupoG.ValueMember = "ID";
            GrupoG.DataSource = listaGrupoG;
            GrupoH.DisplayMember = "NomeRank";
            GrupoH.ValueMember = "ID";
            GrupoH.DataSource = listaGrupoH;
            GrupoI.DisplayMember = "NomeRank";
            GrupoI.ValueMember = "ID";
            GrupoI.DataSource = listaGrupoI;
            GrupoJ.DisplayMember = "NomeRank";
            GrupoJ.ValueMember = "ID";
            GrupoJ.DataSource = listaGrupoJ;
            GrupoK.DisplayMember = "NomeRank";
            GrupoK.ValueMember = "ID";
            GrupoK.DataSource = listaGrupoK;
            GrupoL.DisplayMember = "NomeRank";
            GrupoL.ValueMember = "ID";
            GrupoL.DataSource = listaGrupoL;
        }

        private void btUpGrupoA_Click(object sender, EventArgs e)
        {
            SubirSelecao(ref GrupoA);
        }

        private void btDownGrupoA_Click(object sender, EventArgs e)
        {
            DescerSelecao(ref GrupoA);
        }

        private void btUpGrupoB_Click(object sender, EventArgs e)
        {
            SubirSelecao(ref GrupoB);
        }

        private void btDownGrupoB_Click(object sender, EventArgs e)
        {
            DescerSelecao(ref GrupoB);
        }

        private void btUpGrupoC_Click(object sender, EventArgs e)
        {
            SubirSelecao(ref GrupoC);
        }

        private void btDownGrupoC_Click(object sender, EventArgs e)
        {
            DescerSelecao(ref GrupoC);
        }

        private void btUpGrupoD_Click(object sender, EventArgs e)
        {
            SubirSelecao(ref GrupoD);
        }

        private void btDownGrupoD_Click(object sender, EventArgs e)
        {
            DescerSelecao(ref GrupoD);
        }

        private void btUpGrupoE_Click(object sender, EventArgs e)
        {
            SubirSelecao(ref GrupoE);
        }

        private void btDownGrupoE_Click(object sender, EventArgs e)
        {
            DescerSelecao(ref GrupoE);
        }

        private void btUpGrupoF_Click(object sender, EventArgs e)
        {
            SubirSelecao(ref GrupoF);
        }

        private void btDownGrupoF_Click(object sender, EventArgs e)
        {
            DescerSelecao(ref GrupoF);
        }

        private void btUpGrupoG_Click(object sender, EventArgs e)
        {
            SubirSelecao(ref GrupoG);
        }

        private void btDownGrupoG_Click(object sender, EventArgs e)
        {
            DescerSelecao(ref GrupoG);
        }

        private void btUpGrupoH_Click(object sender, EventArgs e)
        {
            SubirSelecao(ref GrupoH);
        }

        private void btDownGrupoH_Click(object sender, EventArgs e)
        {
            DescerSelecao(ref GrupoH);
        }

        private void btUpGrupoI_Click(object sender, EventArgs e)
        {
            SubirSelecao(ref GrupoI);
        }

        private void btDownGrupoI_Click(object sender, EventArgs e)
        {
            DescerSelecao(ref GrupoI);
        }

        private void btUpGrupoJ_Click(object sender, EventArgs e)
        {
            SubirSelecao(ref GrupoJ);
        }

        private void btDownGrupoJ_Click(object sender, EventArgs e)
        {
            DescerSelecao(ref GrupoJ);
        }

        private void btUpGrupoK_Click(object sender, EventArgs e)
        {
            SubirSelecao(ref GrupoK);
        }

        private void btDownGrupoK_Click(object sender, EventArgs e)
        {
            DescerSelecao(ref GrupoK);
        }

        private void btUpGrupoL_Click(object sender, EventArgs e)
        {
            SubirSelecao(ref GrupoL);
        }

        private void btDownGrupoL_Click(object sender, EventArgs e)
        {
            DescerSelecao(ref GrupoL);
        }

        private void SubirSelecao(ref ListBox listaGrupo)
        {
            Int16 indice = (short)listaGrupo.SelectedIndex;
            if (indice > 0) {
                Pais selecao = listaGrupo.SelectedItem as Pais;
                List<Pais> listaFonte = listaGrupo.DataSource as List<Pais>;
                listaFonte.Remove(selecao);
                listaFonte.Insert(indice - 1, selecao);
                listaGrupo.DataSource = new List<Pais>();
                listaGrupo.DisplayMember = "NomeRank";
                listaGrupo.ValueMember = "ID";
                listaGrupo.DataSource = listaFonte;
                listaGrupo.SelectedIndex = indice - 1;
            }
        }

        private void DescerSelecao(ref ListBox listaGrupo)
        {
            Int16 indice = (short)listaGrupo.SelectedIndex;
            if (indice < 3) {
                Pais selecao = listaGrupo.SelectedItem as Pais;
                List<Pais> listaFonte = listaGrupo.DataSource as List<Pais>;
                listaFonte.Remove(selecao);
                listaFonte.Insert(indice + 1, selecao);
                listaGrupo.DataSource = new List<Pais>();
                listaGrupo.DisplayMember = "NomeRank";
                listaGrupo.ValueMember = "ID";
                listaGrupo.DataSource = listaFonte;
                listaGrupo.SelectedIndex = indice + 1;
            }
        }

        private void btSubir3lugar_Click(object sender, EventArgs e)
        {
            Int16 indice = (short)lista3osLugares.SelectedIndex;
            if (indice > 0)
            {
                Pais selecao = lista3osLugares.SelectedItem as Pais;
                List<Pais> listaFonte = lista3osLugares.DataSource as List<Pais>;
                listaFonte.Remove(selecao);
                listaFonte.Insert(indice - 1, selecao);
                lista3osLugares.DataSource = new List<Pais>();
                lista3osLugares.DisplayMember = "NomeRank";
                lista3osLugares.ValueMember = "ID";
                lista3osLugares.DataSource = listaFonte;
                lista3osLugares.SelectedIndex = indice - 1;
            }
        }

        private void btDescer3lugar_Click(object sender, EventArgs e)
        {
            Int16 indice = (short)lista3osLugares.SelectedIndex;
            if (indice < 11)
            {
                Pais selecao = lista3osLugares.SelectedItem as Pais;
                List<Pais> listaFonte = lista3osLugares.DataSource as List<Pais>;
                listaFonte.Remove(selecao);
                listaFonte.Insert(indice + 1, selecao);
                lista3osLugares.DataSource = new List<Pais>();
                lista3osLugares.DisplayMember = "NomeRank";
                lista3osLugares.ValueMember = "ID";
                lista3osLugares.DataSource = listaFonte;
                lista3osLugares.SelectedIndex = indice + 1;
            }
        }

        private void btFinalizarFaseGrupos_Click(object sender, EventArgs e)
        {
            groupBox3.Enabled = false;
            groupBox4.Enabled = false;
            groupBox5.Enabled = false;
            groupBox8.Enabled = false;
            groupBox14.Enabled = false;
            groupBox13.Enabled = false;
            groupBox12.Enabled = false;
            groupBox11.Enabled = false;
            groupBox18.Enabled = false;
            groupBox17.Enabled = false;
            groupBox16.Enabled = false;
            groupBox15.Enabled = false;

            lista1oLugares.Add(GrupoA.Items[0] as Pais);
            lista2oLugares.Add(GrupoA.Items[1] as Pais);
            lista3oLugares.Add(GrupoA.Items[2] as Pais);

            lista1oLugares.Add(GrupoB.Items[0] as Pais);
            lista2oLugares.Add(GrupoB.Items[1] as Pais);
            lista3oLugares.Add(GrupoB.Items[2] as Pais);

            lista1oLugares.Add(GrupoC.Items[0] as Pais);
            lista2oLugares.Add(GrupoC.Items[1] as Pais);
            lista3oLugares.Add(GrupoC.Items[2] as Pais);

            lista1oLugares.Add(GrupoD.Items[0] as Pais);
            lista2oLugares.Add(GrupoD.Items[1] as Pais);
            lista3oLugares.Add(GrupoD.Items[2] as Pais);

            lista1oLugares.Add(GrupoE.Items[0] as Pais);
            lista2oLugares.Add(GrupoE.Items[1] as Pais);
            lista3oLugares.Add(GrupoE.Items[2] as Pais);

            lista1oLugares.Add(GrupoF.Items[0] as Pais);
            lista2oLugares.Add(GrupoF.Items[1] as Pais);
            lista3oLugares.Add(GrupoF.Items[2] as Pais);

            lista1oLugares.Add(GrupoG.Items[0] as Pais);
            lista2oLugares.Add(GrupoG.Items[1] as Pais);
            lista3oLugares.Add(GrupoG.Items[2] as Pais);

            lista1oLugares.Add(GrupoH.Items[0] as Pais);
            lista2oLugares.Add(GrupoH.Items[1] as Pais);
            lista3oLugares.Add(GrupoH.Items[2] as Pais);

            lista1oLugares.Add(GrupoI.Items[0] as Pais);
            lista2oLugares.Add(GrupoI.Items[1] as Pais);
            lista3oLugares.Add(GrupoI.Items[2] as Pais);

            lista1oLugares.Add(GrupoJ.Items[0] as Pais);
            lista2oLugares.Add(GrupoJ.Items[1] as Pais);
            lista3oLugares.Add(GrupoJ.Items[2] as Pais);

            lista1oLugares.Add(GrupoK.Items[0] as Pais);
            lista2oLugares.Add(GrupoK.Items[1] as Pais);
            lista3oLugares.Add(GrupoK.Items[2] as Pais);

            lista1oLugares.Add(GrupoL.Items[0] as Pais);
            lista2oLugares.Add(GrupoL.Items[1] as Pais);
            lista3oLugares.Add(GrupoL.Items[2] as Pais);

            lista3osLugares.DisplayMember = "NomeRank";
            lista3osLugares.ValueMember = "ID";
            lista3osLugares.DataSource = lista3oLugares;
        }

        private void btFinalizarLista3osLugares_Click(object sender, EventArgs e)
        {
            //A0 B1 C2 D3 E4 F5 G6 H7 I8 J9 K10 L11
            J16_1.Selecao1 = lista1oLugares[4]; //Winner Group E
            J16_1.Selecao2 = lista3oLugares[0]; //3rd 

            J16_2.Selecao1 = lista1oLugares[8]; //Winner Group I
            J16_2.Selecao2 = lista3oLugares[1]; //3rd 

            J16_3.Selecao1 = lista2oLugares[0]; //Runner-up Group A
            J16_3.Selecao2 = lista2oLugares[1]; //Runner-up Group B

            J16_4.Selecao1 = lista1oLugares[5]; //Winner Group F
            J16_4.Selecao2 = lista2oLugares[2]; //Runner-up Group C	

            J16_5.Selecao1 = lista2oLugares[10]; //Runner-up Group K
            J16_5.Selecao2 = lista2oLugares[11]; //Runner-up Group L	

            J16_6.Selecao1 = lista1oLugares[7];  //Winner Group H
            J16_6.Selecao2 = lista2oLugares[9]; //Runner-up Group J

            J16_7.Selecao1 = lista1oLugares[3]; //Winner Group D
            J16_7.Selecao2 = lista3oLugares[2]; //3rd 

            J16_8.Selecao1 = lista1oLugares[6]; //Winner Group G
            J16_8.Selecao2 = lista3oLugares[3]; //3rd

            J16_9.Selecao1 = lista1oLugares[2]; //Winner Group C
            J16_9.Selecao2 = lista2oLugares[5];  //Runner-up Group F

            J16_10.Selecao1 = lista2oLugares[4];  //Runner-up Group E
            J16_10.Selecao2 = lista2oLugares[8];  //Runner-up Group I

            J16_11.Selecao1 = lista1oLugares[0];  //Winner Group A
            J16_11.Selecao2 = lista3oLugares[4];  //3rd 

            J16_12.Selecao1 = lista1oLugares[11];  //Winner Group L
            J16_12.Selecao2 = lista3oLugares[5];  //3rd 

            J16_13.Selecao1 = lista1oLugares[9];  //Winner Group J
            J16_13.Selecao2 = lista2oLugares[7];  //Runner-up Group H

            J16_14.Selecao1 = lista2oLugares[3];  //Runner-up Group D
            J16_14.Selecao2 = lista2oLugares[6];  //Runner-up Group G

            J16_15.Selecao1 = lista1oLugares[1];  //Winner Group B
            J16_15.Selecao2 = lista3oLugares[6];  //3rd 

            J16_16.Selecao1 = lista1oLugares[10];  //Winner Group K
            J16_16.Selecao2 = lista3oLugares[7];  //3rd

            AtualizarNocaute();
            btFinalizarLista3osLugares.Enabled = false;
            btSubir3lugar.Enabled = false;
            btDescer3lugar.Enabled = false;
        }

        #endregion

        #region Fase Nocaute

        SimMataMata J16_1 = new SimMataMata();
        SimMataMata J16_2 = new SimMataMata();
        SimMataMata J16_3 = new SimMataMata();
        SimMataMata J16_4 = new SimMataMata();
        SimMataMata J16_5 = new SimMataMata();
        SimMataMata J16_6 = new SimMataMata();
        SimMataMata J16_7 = new SimMataMata();
        SimMataMata J16_8 = new SimMataMata();
        SimMataMata J16_9 = new SimMataMata();
        SimMataMata J16_10 = new SimMataMata();
        SimMataMata J16_11 = new SimMataMata();
        SimMataMata J16_12 = new SimMataMata();
        SimMataMata J16_13 = new SimMataMata();
        SimMataMata J16_14 = new SimMataMata();
        SimMataMata J16_15 = new SimMataMata();
        SimMataMata J16_16 = new SimMataMata();

        SimMataMata J8_1 = new SimMataMata();
        SimMataMata J8_2 = new SimMataMata();
        SimMataMata J8_3 = new SimMataMata();
        SimMataMata J8_4 = new SimMataMata();
        SimMataMata J8_5 = new SimMataMata();
        SimMataMata J8_6 = new SimMataMata();
        SimMataMata J8_7 = new SimMataMata();
        SimMataMata J8_8 = new SimMataMata();

        SimMataMata J4_1 = new SimMataMata();
        SimMataMata J4_2 = new SimMataMata();
        SimMataMata J4_3 = new SimMataMata();
        SimMataMata J4_4 = new SimMataMata();

        SimMataMata SemiFinal1 = new SimMataMata();
        SimMataMata SemiFinal2 = new SimMataMata();

        private void AtualizarNocaute()
        {
            rb1A.Text = J16_1.Selecao1.NomeRank;
            rb1B.Text = J16_1.Selecao2.NomeRank;
            rb2A.Text = J16_2.Selecao1.NomeRank;
            rb2B.Text = J16_2.Selecao2.NomeRank;
            rb3A.Text = J16_3.Selecao1.NomeRank;
            rb3B.Text = J16_3.Selecao2.NomeRank;
            rb4A.Text = J16_4.Selecao1.NomeRank;
            rb4B.Text = J16_4.Selecao2.NomeRank;
            rb5A.Text = J16_5.Selecao1.NomeRank;
            rb5B.Text = J16_5.Selecao2.NomeRank;
            rb6A.Text = J16_6.Selecao1.NomeRank;
            rb6B.Text = J16_6.Selecao2.NomeRank;
            rb7A.Text = J16_7.Selecao1.NomeRank;
            rb7B.Text = J16_7.Selecao2.NomeRank;
            rb8A.Text = J16_8.Selecao1.NomeRank;
            rb8B.Text = J16_8.Selecao2.NomeRank;
            rb9A.Text = J16_9.Selecao1.NomeRank;
            rb9B.Text = J16_9.Selecao2.NomeRank;
            rb10A.Text = J16_10.Selecao1.NomeRank;
            rb10B.Text = J16_10.Selecao2.NomeRank;
            rb11A.Text = J16_11.Selecao1.NomeRank;
            rb11B.Text = J16_11.Selecao2.NomeRank;
            rb12A.Text = J16_12.Selecao1.NomeRank;
            rb12B.Text = J16_12.Selecao2.NomeRank;
            rb13A.Text = J16_13.Selecao1.NomeRank;
            rb13B.Text = J16_13.Selecao2.NomeRank;
            rb14A.Text = J16_14.Selecao1.NomeRank;
            rb14B.Text = J16_14.Selecao2.NomeRank;
            rb15A.Text = J16_15.Selecao1.NomeRank;
            rb15B.Text = J16_15.Selecao2.NomeRank;
            rb16A.Text = J16_16.Selecao1.NomeRank;
            rb16B.Text = J16_16.Selecao2.NomeRank;

            rb8as_1A.Text = "Vencedor Jogo 1";
            rb8as_1B.Text = "Vencedor Jogo 2";
            rb8as_2A.Text = "Vencedor Jogo 3";
            rb8as_2B.Text = "Vencedor Jogo 4";
            rb8as_3A.Text = "Vencedor Jogo 5";
            rb8as_3B.Text = "Vencedor Jogo 6";
            rb8as_4A.Text = "Vencedor Jogo 7";
            rb8as_4B.Text = "Vencedor Jogo 8";
            rb8as_5A.Text = "Vencedor Jogo 9";
            rb8as_5B.Text = "Vencedor Jogo 10";
            rb8as_6A.Text = "Vencedor Jogo 11";
            rb8as_6B.Text = "Vencedor Jogo 12";
            rb8as_7A.Text = "Vencedor Jogo 13";
            rb8as_7B.Text = "Vencedor Jogo 14";
            rb8as_8A.Text = "Vencedor Jogo 15";
            rb8as_8B.Text = "Vencedor Jogo 16";

        }

        private void Atualiza16s()
        {
            rb8as_1A.Text = J16_1.SelecaoVencedora.NomeRank;
            rb8as_1B.Text = J16_2.SelecaoVencedora.NomeRank;
            rb8as_2A.Text = J16_3.SelecaoVencedora.NomeRank;
            rb8as_2B.Text = J16_4.SelecaoVencedora.NomeRank;
            rb8as_3A.Text = J16_5.SelecaoVencedora.NomeRank;
            rb8as_3B.Text = J16_6.SelecaoVencedora.NomeRank;
            rb8as_4A.Text = J16_7.SelecaoVencedora.NomeRank;
            rb8as_4B.Text = J16_8.SelecaoVencedora.NomeRank;
            rb8as_5A.Text = J16_9.SelecaoVencedora.NomeRank;
            rb8as_5B.Text = J16_10.SelecaoVencedora.NomeRank;
            rb8as_6A.Text = J16_11.SelecaoVencedora.NomeRank;
            rb8as_6B.Text = J16_12.SelecaoVencedora.NomeRank;
            rb8as_7A.Text = J16_13.SelecaoVencedora.NomeRank;
            rb8as_7B.Text = J16_14.SelecaoVencedora.NomeRank;
            rb8as_8A.Text = J16_15.SelecaoVencedora.NomeRank;
            rb8as_8B.Text = J16_16.SelecaoVencedora.NomeRank;

        }

        private void Atualiza8as()
        {
            rb4as_1A.Text = J8_1.SelecaoVencedora.NomeRank;
            rb4as_1B.Text = J8_2.SelecaoVencedora.NomeRank;
            rb4as_2A.Text = J8_3.SelecaoVencedora.NomeRank;
            rb4as_2B.Text = J8_4.SelecaoVencedora.NomeRank;
            rb4as_3A.Text = J8_5.SelecaoVencedora.NomeRank;
            rb4as_3B.Text = J8_6.SelecaoVencedora.NomeRank;
            rb4as_4A.Text = J8_7.SelecaoVencedora.NomeRank;
            rb4as_4B.Text = J8_8.SelecaoVencedora.NomeRank;
        }

        private void Atualiza4as()
        {
            rbSemiFinal_A1.Text = J4_1.SelecaoVencedora.NomeRank;
            rbSemiFinal_A2.Text = J4_2.SelecaoVencedora.NomeRank;
            rbSemiFinal_B1.Text = J4_3.SelecaoVencedora.NomeRank;
            rbSemiFinal_B2.Text = J4_4.SelecaoVencedora.NomeRank;
        }

        private void AtualizaSemiFinais()
        {
            rbFinal1.Text = SemiFinal1.SelecaoVencedora.NomeRank;
            rb3oLugar1.Text = "111111111111";

            rbFinal2.Text = SemiFinal2.SelecaoVencedora.NomeRank;
            rb3oLugar2.Text = "22222222222";
        }

        private void rb1A_CheckedChanged(object sender, EventArgs e)
        {
            J16_1.Selecao1Vencedora = true;
            Atualiza16s();
        }

        private void rb1B_CheckedChanged(object sender, EventArgs e)
        {
            J16_1.Selecao2Vencedora = true;
            Atualiza16s();
        }

        private void rb2A_CheckedChanged(object sender, EventArgs e)
        {
            J16_2.Selecao1Vencedora = true;
            Atualiza16s();
        }

        private void rb2B_CheckedChanged(object sender, EventArgs e)
        {
            J16_2.Selecao2Vencedora = true;
            Atualiza16s();
        }

        private void rb3A_CheckedChanged(object sender, EventArgs e)
        {
            J16_3.Selecao1Vencedora = true;
            Atualiza16s();
        }

        private void rb3B_CheckedChanged(object sender, EventArgs e)
        {
            J16_3.Selecao2Vencedora = true;
            Atualiza16s();
        }

        private void rb4A_CheckedChanged(object sender, EventArgs e)
        {
            J16_4.Selecao1Vencedora = true;
            Atualiza16s();
        }

        private void rb4B_CheckedChanged(object sender, EventArgs e)
        {
            J16_4.Selecao2Vencedora = true;
            Atualiza16s();
        }

        private void rb5A_CheckedChanged(object sender, EventArgs e)
        {
            J16_5.Selecao1Vencedora = true;
            Atualiza16s();
        }

        private void rb5B_CheckedChanged(object sender, EventArgs e)
        {
            J16_5.Selecao2Vencedora = true;
            Atualiza16s();
        }

        private void rb6A_CheckedChanged(object sender, EventArgs e)
        {
            J16_6.Selecao1Vencedora = true;
            Atualiza16s();
        }

        private void rb6B_CheckedChanged(object sender, EventArgs e)
        {
            J16_6.Selecao2Vencedora = true;
            Atualiza16s();
        }

        private void rb7A_CheckedChanged(object sender, EventArgs e)
        {
            J16_7.Selecao1Vencedora = true;
            Atualiza16s();
        }

        private void rb7B_CheckedChanged(object sender, EventArgs e)
        {
            J16_7.Selecao2Vencedora = true;
            Atualiza16s();
        }

        private void rb8A_CheckedChanged(object sender, EventArgs e)
        {
            J16_8.Selecao1Vencedora = true;
            Atualiza16s();
        }

        private void rb8B_CheckedChanged(object sender, EventArgs e)
        {
            J16_8.Selecao2Vencedora = true;
            Atualiza16s();
        }

        private void rb9A_CheckedChanged(object sender, EventArgs e)
        {
            J16_9.Selecao1Vencedora = true;
            Atualiza16s();
        }

        private void rb9B_CheckedChanged(object sender, EventArgs e)
        {
            J16_9.Selecao2Vencedora = true;
            Atualiza16s();
        }

        private void rb10A_CheckedChanged(object sender, EventArgs e)
        {
            J16_10.Selecao1Vencedora = true;
            Atualiza16s();
        }

        private void rb10B_CheckedChanged(object sender, EventArgs e)
        {
            J16_10.Selecao2Vencedora = true;
            Atualiza16s();
        }

        private void rb11A_CheckedChanged(object sender, EventArgs e)
        {
            J16_11.Selecao1Vencedora = true;
            Atualiza16s();
        }

        private void rb11B_CheckedChanged(object sender, EventArgs e)
        {
            J16_11.Selecao2Vencedora = true;
            Atualiza16s();
        }

        private void rb12A_CheckedChanged(object sender, EventArgs e)
        {
            J16_12.Selecao1Vencedora = true;
            Atualiza16s();
        }

        private void rb12B_CheckedChanged(object sender, EventArgs e)
        {
            J16_12.Selecao2Vencedora = true;
            Atualiza16s();
        }

        private void rb13A_CheckedChanged(object sender, EventArgs e)
        {
            J16_13.Selecao1Vencedora = true;
            Atualiza16s();
        }

        private void rb13B_CheckedChanged(object sender, EventArgs e)
        {
            J16_13.Selecao2Vencedora = true;
            Atualiza16s();
        }

        private void rb14A_CheckedChanged(object sender, EventArgs e)
        {
            J16_14.Selecao1Vencedora = true;
            Atualiza16s();
        }

        private void rb14B_CheckedChanged(object sender, EventArgs e)
        {
            J16_14.Selecao2Vencedora = true;
            Atualiza16s();
        }

        private void rb15A_CheckedChanged(object sender, EventArgs e)
        {
            J16_15.Selecao1Vencedora = true;
            Atualiza16s();
        }

        private void rb15B_CheckedChanged(object sender, EventArgs e)
        {
            J16_15.Selecao2Vencedora = true;
            Atualiza16s();
        }

        private void rb16A_CheckedChanged(object sender, EventArgs e)
        {
            J16_16.Selecao1Vencedora = true;
            Atualiza16s();
        }

        private void rb16B_CheckedChanged(object sender, EventArgs e)
        {
            J16_16.Selecao2Vencedora = true;
            Atualiza16s();
        }

        private void rb8as_1A_CheckedChanged(object sender, EventArgs e)
        {
            J8_1.Selecao1Vencedora = true;
            Atualiza8as();
        }

        private void rb8as_1B_CheckedChanged(object sender, EventArgs e)
        {
            J8_1.Selecao2Vencedora = true;
            Atualiza8as();
        }

        private void rb8as_2A_CheckedChanged(object sender, EventArgs e)
        {
            J8_2.Selecao1Vencedora = true;
            Atualiza8as();
        }

        private void rb8as_2B_CheckedChanged(object sender, EventArgs e)
        {
            J8_2.Selecao2Vencedora = true;
            Atualiza8as();
        }

        private void rb8as_3A_CheckedChanged(object sender, EventArgs e)
        {
            J8_3.Selecao1Vencedora = true;
            Atualiza8as();
        }

        private void rb8as_3B_CheckedChanged(object sender, EventArgs e)
        {
            J8_3.Selecao2Vencedora = true;
            Atualiza8as();
        }

        private void rb8as_4A_CheckedChanged(object sender, EventArgs e)
        {
            J8_4.Selecao1Vencedora = true;
            Atualiza8as();
        }

        private void rb8as_4B_CheckedChanged(object sender, EventArgs e)
        {
            J8_4.Selecao2Vencedora = true;
            Atualiza8as();
        }

        private void rb8as_5A_CheckedChanged(object sender, EventArgs e)
        {
            J8_5.Selecao1Vencedora = true;
            Atualiza8as();
        }

        private void rb8as_5B_CheckedChanged(object sender, EventArgs e)
        {
            J8_5.Selecao2Vencedora = true;
            Atualiza8as();
        }

        private void rb8as_6A_CheckedChanged(object sender, EventArgs e)
        {
            J8_6.Selecao1Vencedora = true;
            Atualiza8as();
        }

        private void rb8as_6B_CheckedChanged(object sender, EventArgs e)
        {
            J8_6.Selecao2Vencedora = true;
            Atualiza8as();
        }

        private void rb8as_7A_CheckedChanged(object sender, EventArgs e)
        {
            J8_7.Selecao1Vencedora = true;
            Atualiza8as();
        }

        private void rb8as_7B_CheckedChanged(object sender, EventArgs e)
        {
            J8_7.Selecao2Vencedora = true;
            Atualiza8as();
        }

        private void rb8as_8A_CheckedChanged(object sender, EventArgs e)
        {
            J8_8.Selecao1Vencedora = true;
            Atualiza8as();
        }

        private void rb8as_8B_CheckedChanged(object sender, EventArgs e)
        {
            J8_8.Selecao2Vencedora = true;
            Atualiza8as();
        }

        private void btFinalizar16avos_Click(object sender, EventArgs e)
        {
            J8_1.Selecao1 = J16_1.SelecaoVencedora;
            J8_1.Selecao2 = J16_2.SelecaoVencedora;
            J8_2.Selecao1 = J16_3.SelecaoVencedora;
            J8_2.Selecao2 = J16_4.SelecaoVencedora;
            J8_3.Selecao1 = J16_5.SelecaoVencedora;
            J8_3.Selecao2 = J16_6.SelecaoVencedora;
            J8_4.Selecao1 = J16_7.SelecaoVencedora;
            J8_4.Selecao2 = J16_8.SelecaoVencedora;

            J8_5.Selecao1 = J16_9.SelecaoVencedora;
            J8_5.Selecao2 = J16_10.SelecaoVencedora;
            J8_6.Selecao1 = J16_11.SelecaoVencedora;
            J8_6.Selecao2 = J16_12.SelecaoVencedora;
            J8_7.Selecao1 = J16_13.SelecaoVencedora;
            J8_7.Selecao2 = J16_14.SelecaoVencedora;
            J8_8.Selecao1 = J16_15.SelecaoVencedora;
            J8_8.Selecao2 = J16_16.SelecaoVencedora;

            rb1A.Enabled = false;
            rb1B.Enabled = false;
            rb2A.Enabled = false;
            rb2B.Enabled = false;
            rb3A.Enabled = false;
            rb3B.Enabled = false;
            rb4A.Enabled = false;
            rb4B.Enabled = false;
            rb5A.Enabled = false;
            rb5B.Enabled = false;
            rb6A.Enabled = false;
            rb6B.Enabled = false;
            rb7A.Enabled = false;
            rb7B.Enabled = false;
            rb8A.Enabled = false;
            rb8B.Enabled = false;
            rb9A.Enabled = false;
            rb9B.Enabled = false;
            rb10A.Enabled = false;
            rb10B.Enabled = false;
            rb11A.Enabled = false;
            rb11B.Enabled = false;
            rb12A.Enabled = false;
            rb12B.Enabled = false;
            rb13A.Enabled = false;
            rb13B.Enabled = false;
            rb14A.Enabled = false;
            rb14B.Enabled = false;
            rb15A.Enabled = false;
            rb15B.Enabled = false;
            rb16A.Enabled = false;
            rb16B.Enabled = false;

            AlterarEstado8asFinal(true);

            btFinalizar16avos.Enabled = false;
            btFinalizar8as.Enabled = true;
        }

        private void btFinalizar8as_Click(object sender, EventArgs e)
        {
            btFinalizar8as.Enabled = false;
            AlterarEstado8asFinal(false);
            AlterarEstados4asFinal(true);
            J4_1.Selecao1 = J8_1.SelecaoVencedora;
            J4_1.Selecao2 = J8_2.SelecaoVencedora;
            J4_2.Selecao1 = J8_3.SelecaoVencedora;
            J4_2.Selecao2 = J8_4.SelecaoVencedora;
            J4_3.Selecao1 = J8_5.SelecaoVencedora;
            J4_3.Selecao2 = J8_6.SelecaoVencedora;
            J4_4.Selecao1 = J8_7.SelecaoVencedora;
            J4_4.Selecao2 = J8_8.SelecaoVencedora;
        }

        private void AlterarEstado8asFinal(bool estado)
        {
            rb8as_1A.Enabled = estado;
            rb8as_1B.Enabled = estado;
            rb8as_2A.Enabled = estado;
            rb8as_2B.Enabled = estado;
            rb8as_3A.Enabled = estado;
            rb8as_3B.Enabled = estado;
            rb8as_4A.Enabled = estado;
            rb8as_4B.Enabled = estado;
            rb8as_5A.Enabled = estado;
            rb8as_5B.Enabled = estado;
            rb8as_6A.Enabled = estado;
            rb8as_6B.Enabled = estado;
            rb8as_7A.Enabled = estado;
            rb8as_7B.Enabled = estado;
            rb8as_8A.Enabled = estado;
            rb8as_8B.Enabled = estado;
        }

        private void AlterarEstados4asFinal(bool estado)
        {
            rb4as_1A.Enabled = estado;
            rb4as_1B.Enabled = estado;
            rb4as_2A.Enabled = estado;
            rb4as_2B.Enabled = estado;
            rb4as_3A.Enabled = estado;
            rb4as_3B.Enabled = estado;
            rb4as_4A.Enabled = estado;
            rb4as_4B.Enabled = estado;
        }

        private void rb4as_1A_CheckedChanged(object sender, EventArgs e)
        {
            J4_1.Selecao1Vencedora = true;
            Atualiza4as();
        }

        private void rb4as_1B_CheckedChanged(object sender, EventArgs e)
        {
            J4_1.Selecao2Vencedora = true;
            Atualiza4as();
        }

        private void rb4as_2A_CheckedChanged(object sender, EventArgs e)
        {
            J4_2.Selecao1Vencedora = true;
            Atualiza4as();
        }

        private void rb4as_2B_CheckedChanged(object sender, EventArgs e)
        {
            J4_2.Selecao2Vencedora = true;
            Atualiza4as();
        }

        private void rb4as_3A_CheckedChanged(object sender, EventArgs e)
        {
            J4_3.Selecao1Vencedora = true;
            Atualiza4as();
        }

        private void rb4as_3B_CheckedChanged(object sender, EventArgs e)
        {
            J4_3.Selecao2Vencedora = true;
            Atualiza4as();
        }

        private void rb4as_4A_CheckedChanged(object sender, EventArgs e)
        {
            J4_4.Selecao1Vencedora = true;
            Atualiza4as();
        }

        private void rb4as_4B_CheckedChanged(object sender, EventArgs e)
        {
            J4_4.Selecao2Vencedora = true;
            Atualiza4as();
        }

        private void btFinalizar4as_Click(object sender, EventArgs e)
        {
            btFinalizar4as.Enabled = false;
            AlterarEstados4asFinal(false);
            SemiFinal1.Selecao1 = J4_1.SelecaoVencedora;
            SemiFinal1.Selecao2 = J4_2.SelecaoVencedora;
            SemiFinal2.Selecao1 = J4_3.SelecaoVencedora;
            SemiFinal2.Selecao2 = J4_4.SelecaoVencedora;
            EstadoSemiFinais(true);
        }

        private void btFinalizarSemiFinais_Click(object sender, EventArgs e)
        {

        }

        private void EstadoSemiFinais(bool estado)
        {
            rbSemiFinal_A1.Enabled = estado;
            rbSemiFinal_A2.Enabled = estado;
            rbSemiFinal_B1.Enabled = estado;
            rbSemiFinal_B2.Enabled = estado;
        }

        private void btFinalizar3oLugar_Click(object sender, EventArgs e)
        {
            rbFinal1.Enabled = true;
            rbFinal2.Enabled = true;
        }

        private void rbSemiFinal_A1_CheckedChanged(object sender, EventArgs e)
        {
            SemiFinal1.Selecao1Vencedora = true;
            AtualizaSemiFinais();
        }

        private void rbSemiFinal_A2_CheckedChanged(object sender, EventArgs e)
        {
            SemiFinal1.Selecao1Vencedora = false;
            AtualizaSemiFinais();
        }

        private void rbSemiFinal_B1_CheckedChanged(object sender, EventArgs e)
        {
            SemiFinal2.Selecao1Vencedora = true;
            AtualizaSemiFinais();
        }

        private void rbSemiFinal_B2_CheckedChanged(object sender, EventArgs e)
        {
            SemiFinal2.Selecao1Vencedora = false;
            AtualizaSemiFinais();
        }



        #endregion

        //fim
    }

}


