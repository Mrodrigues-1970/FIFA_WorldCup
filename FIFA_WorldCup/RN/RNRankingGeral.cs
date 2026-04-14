using FIFA_WorldCup.Dal;
using FIFA_WorldCup.Entidades;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FIFA_WorldCup.RN
{
    public class RNRankingGeral
    {


        public void RecalculaDadosPais(Int16 PaisID, Competicao oCompeticao)
        {
            RankingGeral RankingCorrente;
            List<RankingGeral> dadosNaCopa;
            DalParticipante dalP = new DalParticipante();
            List<Int16> listaCopas = dalP.CopasParticipadas(PaisID, oCompeticao);
            foreach (Int16 iCopaID in listaCopas)
            {
                dadosNaCopa = DadosDoPaisNaCopa(iCopaID, PaisID);
                if (dadosNaCopa.Count == 0)
                    continue;
                LimparDados(iCopaID, PaisID);

                foreach (RankingGeral iRanking in dadosNaCopa)
                {
                    CadastraRankingGeral(iRanking, PaisID, iCopaID);
                }
            }
        }

        private void CadastraRankingGeral(RankingGeral oRanking, Int16 PaisID, Int16 CopaID)
        {
            RankingGeral RankingCorrente = new RankingGeral();
            RankingCorrente.CopaID = CopaID;
            RankingCorrente.PaisID = PaisID;
            RankingCorrente.Jogos = 1;
            RankingCorrente.Vitorias = oRanking.Vitorias;
            RankingCorrente.Empates = oRanking.Empates;
            RankingCorrente.Derrotas = oRanking.Derrotas;
            RankingCorrente.GolsPro = oRanking.GolsPro;
            RankingCorrente.GolsContra = oRanking.GolsContra;
            RankingCorrente.Saldo = oRanking.Saldo;
            RankingCorrente.Pontos = oRanking.Pontos;
            RankingCorrente.TipoFase = oRanking.TipoFase;
            Ins(RankingCorrente);
        }

        private void Ins(RankingGeral oRanking)
        {
            DalRankingGeral dal = new DalRankingGeral();
            dal.Ins(oRanking);
        }

        public void RecalcularTodosPaisesTodasCopas(Competicao oCompeticao, ref ProgressBar barraProgresso)
        {
            RNCopa rnC = new RNCopa();
            RNPais rnP = new RNPais();
            List<Pais> listaPaises;
            List<RankingGeral> dadosNaCopa;
            Copa filtro = new Copa();
            int contagemCopas = 0;
            try
            {
                //Deleta todos os registros de RankingGeral deste tipo de competição
                DelTudoPorTipoCopa(oCompeticao);

                //Buscar lista de competições deste tipo
                filtro.Competicao = oCompeticao;
                List<Copa> listaCopas = rnC.Sel(filtro);
                barraProgresso.Maximum = listaCopas.Count;

                //percorrer lista de competições deste tipo, para cada competição
                foreach (Copa iCopa in listaCopas)
                {
                    contagemCopas++;
                    barraProgresso.Value = contagemCopas;
                    // buscar lista de países participantes
                    listaPaises = rnP.SelParticipantesSelecionados(iCopa.ID);
                    foreach (Pais iPais in listaPaises)
                    {
                        //Para cada participantes, recuperar dados do jogo, recalcular e atualizar o ranking geral
                        dadosNaCopa = DadosDoPaisNaCopa(iCopa.ID, iPais.ID);
                        foreach (RankingGeral iRanking in dadosNaCopa)
                        {
                            CadastraRankingGeral(iRanking, iPais.ID, iCopa.ID);
                        }
                    }
                }
                // NÃO alterar o ID de países que fazem parte de alguma herança. A herança deve ser considerada SOMENTE na consulta.
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void LimparDados(Int16 CopaID, Int16 PaisID)
        {
            DalRankingGeral dal = new DalRankingGeral();
            dal.Del(CopaID, PaisID);
        }

        /// <summary>
        /// Busca dados da tabela PARTIDA para que sejam geradas informações para RANKINGGERAL
        /// </summary>
        /// <param name="CopaID"></param>
        /// <param name="PaisID"></param>
        /// <returns></returns>
        private List<RankingGeral> DadosDoPaisNaCopa(Int16 CopaID, Int16 PaisID)
        {
            DalRankingGeral dalR = new DalRankingGeral();
            return dalR.DadosDoJogo(CopaID, PaisID);
        }

        public List<RankingGeral> PerformanceDe1Pais(Int16 Pais_ID, Competicao TipoCopa)
        {
            List<RankingGeral> listaPerformance = ConsultaPerformance(Pais_ID, TipoCopa);
            if (TratamentoHerancaNecessario(Pais_ID))
            {
                listaPerformance = AplicarHeranca(listaPerformance, Pais_ID, TipoCopa);
            }
            return listaPerformance;
        }


        public List<RankingGeral> PerformanceDeGrupo(Int16 TipoFase, Int16 GrupoID, Int16 CopaID)
        {
            DalRankingGeral dalR = new DalRankingGeral();
            return dalR.PerformanceDeGrupo(TipoFase, GrupoID, CopaID);
        }

        private List<RankingGeral> ConsultaPerformance(Int16 Pais_ID, Competicao TipoCopa)
        {
            List<RankingGeral> listaGerada;
            DalRankingGeral dalR = new DalRankingGeral();
            listaGerada = dalR.PerformanceDe1Pais(Pais_ID, TipoCopa);
            return listaGerada;
        }

        private void DelTudoPorTipoCopa(Competicao oCompeticao)
        {
            DalRankingGeral dal = new DalRankingGeral();
            dal.DelTudoPorTipoCopa(oCompeticao);
        }

        public List<RankingGeral> Ranking3Lugar(Int16 Copa_ID) { 
            DalRankingGeral dal = new DalRankingGeral();
            return dal.Ranking3Lugar(Copa_ID);
        }

        /// <summary>
        /// Inclui a performance do pais relacionado ao pais escolhido
        /// </summary>
        /// <param name="lista_Inicial"></param>
        /// <param name="PaisID"></param>
        /// <returns></returns>
        private List<RankingGeral> AplicarHeranca(List<RankingGeral> lista_Inicial, Int16 PaisID, Competicao TipoCopa)
        {

            List<RankingGeral> listaAdicional;
            Int16 PaisAssociado = 0;
            switch (PaisID)
            {
                //Tchequia - Tchecoslovaquia
                case 69:
                    PaisAssociado = 70; break;

                //Sérvia - Iugoslavia
                case 80:
                    PaisAssociado = 35; break;

                //Rússia - União Soviètica
                case 47:
                    PaisAssociado = 34; break;

                //Alemanha - Alemanha Ocidental
                case 11:
                    PaisAssociado = 12; break;

                //Zaire - R.D. Congo
                case 44:
                    PaisAssociado = 43; break;

                default:
                    throw new Exception("Aplicação de Herança somente pode ser realizada nas condições previstas.");
            }
            listaAdicional = ConsultaPerformance(PaisAssociado, TipoCopa);
            lista_Inicial.AddRange(listaAdicional);
            List<RankingGeral> listaOrdenada = lista_Inicial.OrderBy(e => e.Ano).ToList();
            return listaOrdenada;
        }

        /// <summary>
        /// Verifica se o país possui herança, ou seja, se é necessário considerar os dados de outro país para compor o ranking geral.
        /// </summary>
        /// <param name="PaisID"></param>
        /// <returns></returns>
        private bool TratamentoHerancaNecessario(Int16 PaisID)
        {
            bool resposta = false;

            // Tchecoslovaquia ==> Republica Tcheca
            if(PaisID == 69) { resposta = true; }

            // Iugoslávia ==> Sérvia
            if (PaisID == 80) { resposta = true; }

            // Alemanha Ocidental ==> Alemanha
            if (PaisID == 11) { resposta = true; }

            // União Soviética ==> Rússia
            if (PaisID == 47) { resposta = true; }

            // Zaire ==> República Democrática do Congo
            if (PaisID == 44) { resposta = true; }

            return resposta;
        }
    }
}
