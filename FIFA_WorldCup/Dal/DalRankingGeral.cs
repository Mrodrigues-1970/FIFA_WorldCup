using FIFA_WorldCup.Entidades;
using FIFA_WorldCup.RN;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIFA_WorldCup.Dal
{
    public class DalRankingGeral : DalBase
    {        
        /// <summary>
        /// Recupera dados dos jogos de um pais em uma copa
        /// </summary>
        /// <param name="Copa_ID"></param>
        /// <param name="Pais_ID"></param>
        /// <returns></returns>
        public List<RankingGeral> DadosDoJogo(Int16 Copa_ID, Int16 Pais_ID)
        {
            List<RankingGeral> lista;
            RankingGeral objeto;
            try
            {
                lista = new List<RankingGeral>();
                AbrirConexao();
                oDR = LerBanco(SQLDadosJogo(Copa_ID, Pais_ID));
                while (oDR.Read())
                {
                    objeto = MontaDadosDasPartidas(oDR);
                    lista.Add(objeto);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                FecharConexao();
            }
            return lista;
        }

        public List<RankingGeral> PerformanceDe1Pais(Int16 Pais_ID, Competicao TipoCopa)
        {
            List<RankingGeral> lista;
            RankingGeral objeto;
            try
            {
                lista = new List<RankingGeral>();
                AbrirConexao();
                oDR = LerBanco(SQLPerformanceDe1Pais(Pais_ID, TipoCopa));
                while (oDR.Read())
                {
                    objeto = MontaObjeto(oDR);
                    lista.Add(objeto);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                FecharConexao();
            }
            return lista;
        }

        public void Ins(RankingGeral oRanking)
        {
            try
            {
                AbrirConexao();
                ExecutarSQL(SQLIns(oRanking));
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                FecharConexao();
            }

        }

        public void Del(Int16 Copa_ID, Int16 Pais_ID)
        {
            try
            {
                AbrirConexao();
                ExecutarSQL(SQLDel(Copa_ID, Pais_ID));
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                FecharConexao();
            }
        }

        public void DelTudoPorTipoCopa(Competicao oCompeticao)
        {
            try
            {
                AbrirConexao();
                ExecutarSQL(SQLDelTudoPorTipoCopa(oCompeticao));
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                FecharConexao();
            }
        }

        public List<RankingGeral> PerformanceDeGrupo(Int16 TipoFase, Int16 GrupoID, Int16 CopaID)
        {
            List<RankingGeral> lista;
            RankingGeral objeto;
            try
            {
                lista = new List<RankingGeral>();
                AbrirConexao();
                oDR = LerBanco(SQLPerformanceDeGrupo(TipoFase, GrupoID, CopaID));
                while (oDR.Read())
                {
                    objeto = MontaObjeto(oDR);
                    lista.Add(objeto);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                FecharConexao();
            }
            return lista;
        }

        public List<RankingGeral> Ranking3Lugar(Int16 Copa_ID)
        {
            List<RankingGeral> lista;
            RankingGeral objeto;
            try
            {
                lista = new List<RankingGeral>();
                AbrirConexao();
                oDR = LerBanco(SQLRanking3Lugar(Copa_ID));
                while (oDR.Read())
                {
                    objeto = MontaObjeto(oDR);
                    lista.Add(objeto);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                FecharConexao();
            }
            return lista;
        }

        private string SQLDadosJogo(Int16 Copa_ID, Int16 Pais_ID)
        {
            oSB.Length = 0;
            oSB.Append("SELECT GRUPO.COPA_ID, PARTIDA.SELECAO_A, PARTIDA.GOLS_A, PARTIDA.SELECAO_B, PARTIDA.GOLS_B, " + Pais_ID + " AS PAIS_ID, GRUPO.TIPO_FASE_ID AS TIPO_FASE ");
            oSB.Append("FROM GRUPO INNER JOIN PARTIDA ON GRUPO.ID = PARTIDA.GRUPO_ID ");
            oSB.Append("WHERE GRUPO.COPA_ID  = " + Copa_ID + " ");
            oSB.Append("AND (PARTIDA.SELECAO_A = " + Pais_ID + " OR PARTIDA.SELECAO_B  = " + Pais_ID + ")");
            return oSB.ToString();
        }

        private string SQLIns(RankingGeral oRanking)
        {
            oSB.Length = 0;
            oSB.Append("INSERT INTO RANKING_GERAL (COPA_ID, PAIS_ID, JOGOS, VITORIAS, EMPATES, DERROTAS, GOLS_PRO, GOLS_CONTRA, SALDO, PONTOS, TIPO_FASE) ");
            oSB.Append("VALUES (");
            oSB.Append(oRanking.CopaID + ", ");            
            oSB.Append(oRanking.PaisID + ", ");
            oSB.Append(oRanking.Jogos + ", ");
            oSB.Append(oRanking.Vitorias + ", ");
            oSB.Append(oRanking.Empates + ", ");
            oSB.Append(oRanking.Derrotas + ", ");
            oSB.Append(oRanking.GolsPro + ", ");
            oSB.Append(oRanking.GolsContra + ", ");
            oSB.Append(oRanking.Saldo + ", ");
            oSB.Append(oRanking.Pontos + ", ");
            oSB.Append(oRanking.TipoFase + ")");
            return oSB.ToString();
        }

        private string SQLDel(Int16 Copa_ID, Int16 Pais_ID)
        {
            oSB.Length = 0;
            oSB.Append("DELETE FROM RANKING_GERAL ");
            oSB.Append("WHERE COPA_ID = " + Copa_ID + " AND PAIS_ID = " + Pais_ID);
            return oSB.ToString();
        }

        private string SQLDelTudoPorTipoCopa(Competicao oCompeticao)
        {
            oSB.Length = 0;
            oSB.Append("DELETE FROM RANKING_GERAL ");
            oSB.Append("WHERE COPA_ID IN (SELECT ID FROM COPA WHERE COMPETICAO = " + (int)oCompeticao + ")");
            return oSB.ToString();
        }

        private string SQLPerformanceDe1Pais(Int16 Pais_ID, Competicao TipoCopa)
        {
            oSB.Length = 0;
            oSB.Append("SELECT COPA.ANO, ");
            oSB.Append("     SUM(RANKING_GERAL.JOGOS) AS JOGOS, ");
            oSB.Append("     SUM(RANKING_GERAL.VITORIAS) AS VITORIAS, ");
            oSB.Append("     SUM(RANKING_GERAL.EMPATES) AS EMPATES, ");
            oSB.Append("     SUM(RANKING_GERAL.DERROTAS) AS DERROTAS, ");
            oSB.Append("     SUM(RANKING_GERAL.GOLS_PRO) AS GOLS_PRO, ");
            oSB.Append("     SUM(RANKING_GERAL.GOLS_CONTRA) AS GOLS_CONTRA, ");
            oSB.Append("     SUM(RANKING_GERAL.SALDO) AS SALDO, ");
            oSB.Append("     SUM(RANKING_GERAL.PONTOS) AS PONTOS ");
            oSB.Append("     '' AS NOME_PAIS");
            oSB.Append("    FROM COPA INNER JOIN RANKING_GERAL ON COPA.ID = RANKING_GERAL.COPA_ID ");
            oSB.Append("GROUP BY COPA.ANO, COPA.COMPETICAO, RANKING_GERAL.COPA_ID, RANKING_GERAL.PAIS_ID ");
            oSB.Append("HAVING COPA.COMPETICAO = " + (int)TipoCopa + " ");
            oSB.Append("     AND RANKING_GERAL.PAIS_ID = " + Pais_ID);
            return oSB.ToString();
        }

        private string SQLPerformanceDeGrupo(Int16 TipoFase, Int16 GrupoID, Int16 CopaID)
        {
            oSB.Length = 0;
            oSB.Append("SELECT DISTINCT P.SELECAO_A, ");
            oSB.Append("                PA.NOME AS NOME_PAIS, ");
            oSB.Append("                RG.JOGOS, ");
            oSB.Append("                RG.VITORIAS, ");
            oSB.Append("                RG.EMPATES, ");
            oSB.Append("                RG.DERROTAS, ");
            oSB.Append("                RG.GOLS_PRO, ");
            oSB.Append("                RG.GOLS_CONTRA, ");
            oSB.Append("                RG.SALDO, ");
            oSB.Append("                RG.PONTOS, ");
            oSB.Append("                RG.TIPO_FASE ");
            oSB.Append("FROM (PAIS PA INNER JOIN PARTIDA P ON PA.ID = P.SELECAO_A) INNER JOIN RANKING_GERAL RG ON PA.ID = RG.PAIS_ID ");
            oSB.Append("WHERE RG.TIPO_FASE = " + TipoFase + " ");
            oSB.Append("  AND P.GRUPO_ID = " + GrupoID  + " ");
            oSB.Append("  AND RG.COPA_ID = " + CopaID);
            return oSB.ToString();
        }

        private string SQLRanking3Lugar(Int16 Copa_ID)
        {
            string FaseGrupos = "1";
            string TerceiroLugar = "3";
            oSB.Length = 0;
            oSB.Append("  SELECT GRUPO.NOME, ");
            oSB.Append("         GRUPO.TIPO_FASE_ID, ");
            oSB.Append("         PAIS.NOME AS NOME_PAIS, ");
            oSB.Append("         SUM(RANKING_GERAL.PONTOS) AS PONTOS, ");
            oSB.Append("         SUM(RANKING_GERAL.SALDO) AS SALDO, ");
            oSB.Append("         SUM(RANKING_GERAL.JOGOS) AS JOGOS, ");
            oSB.Append("         SUM(RANKING_GERAL.VITORIAS) AS VITORIAS, ");
            oSB.Append("         SUM(RANKING_GERAL.EMPATES) AS EMPATES, ");
            oSB.Append("         SUM(RANKING_GERAL.DERROTAS) AS DERROTAS, ");
            oSB.Append("         SUM(RANKING_GERAL.GOLS_PRO) AS GOLS_PRO, ");
            oSB.Append("         SUM(RANKING_GERAL.GOLS_CONTRA) AS GOLS_CONTRA,");
            oSB.Append("         0 AS ANO ");
            oSB.Append("    FROM (COPA INNER JOIN (PAIS INNER JOIN (GRUPO INNER JOIN POSICAO_GRUPO ON GRUPO.ID = POSICAO_GRUPO.Grupo_ID) ON PAIS.ID = POSICAO_GRUPO.PAIS_ID) ON COPA.ID = GRUPO.COPA_ID) INNER JOIN RANKING_GERAL ON (COPA.ID = RANKING_GERAL.COPA_ID) AND (PAIS.ID = RANKING_GERAL.PAIS_ID) ");
            oSB.Append("   WHERE RANKING_GERAL.TIPO_FASE = " + FaseGrupos + " ");
            oSB.Append("     AND COPA.ID = " + Copa_ID + " ");
            oSB.Append("     AND POSICAO_GRUPO.POSICAO = " + TerceiroLugar + " ");
            oSB.Append("GROUP BY GRUPO.NOME, GRUPO.TIPO_FASE_ID, PAIS.NOME, RANKING_GERAL.TIPO_FASE, COPA.ID, POSICAO_GRUPO.POSICAO ");
            oSB.Append("ORDER BY SUM(RANKING_GERAL.PONTOS) DESC , SUM(RANKING_GERAL.SALDO) DESC");
            return oSB.ToString();
        }

        /// <summary>
        /// Objeto montado com dados das partidas
        /// </summary>
        /// <param name="oDR"></param>
        /// <returns></returns>
        private RankingGeral MontaDadosDasPartidas(System.Data.OleDb.OleDbDataReader oDR)
        {
            RankingGeral objeto = new RankingGeral();
            objeto.CopaID = Convert.ToInt16(oDR["COPA_ID"]);
            objeto.PaisID = Convert.ToInt16(oDR["PAIS_ID"]);
            if (Convert.ToInt16(oDR["SELECAO_A"]) == objeto.PaisID)
            {
                objeto.GolsPro = Convert.ToInt16(oDR["GOLS_A"]);
                objeto.GolsContra = Convert.ToInt16(oDR["GOLS_B"]);
            }
            else
            {
                objeto.GolsPro = Convert.ToInt16(oDR["GOLS_B"]);
                objeto.GolsContra = Convert.ToInt16(oDR["GOLS_A"]);
            }
            //Vitoria
            if (objeto.GolsPro > objeto.GolsContra) {
                objeto.Vitorias = 1;
                objeto.Pontos = 3;
            }
            //Derrota
            if (objeto.GolsPro < objeto.GolsContra) {
                objeto.Derrotas = 1;
            }
            //Empate
            if (objeto.GolsPro == objeto.GolsContra)
            {
                objeto.Empates = 1;
                objeto.Pontos = 1;
            }
            objeto.Saldo = (short)(objeto.GolsPro - objeto.GolsContra);

            return objeto;
        }


        /// <summary>
        /// Objeto vinda da tabela Ranking_Geral
        /// </summary>
        /// <param name="oDR"></param>
        /// <returns></returns>
        private RankingGeral MontaObjeto(System.Data.OleDb.OleDbDataReader oDR)
        {
            RankingGeral objeto = new RankingGeral();
            objeto.Ano = Convert.ToInt16(oDR["ANO"]);
            objeto.Jogos = Convert.ToInt16(oDR["JOGOS"]);
            objeto.Vitorias = Convert.ToInt16(oDR["VITORIAS"]);
            objeto.Empates = Convert.ToInt16(oDR["EMPATES"]);
            objeto.Derrotas = Convert.ToInt16(oDR["DERROTAS"]);
            objeto.GolsPro = Convert.ToInt16(oDR["GOLS_PRO"]);
            objeto.GolsContra = Convert.ToInt16(oDR["GOLS_CONTRA"]);
            objeto.Saldo = Convert.ToInt16(oDR["SALDO"]);
            objeto.Pontos = Convert.ToInt16(oDR["PONTOS"]);
            objeto.NomePais = Convert.ToString(oDR["NOME_PAIS"]);
            //objeto.TipoFase = Convert.ToInt16(oDR["TIPO_FASE"]);
            return objeto;
        }

    }
}
