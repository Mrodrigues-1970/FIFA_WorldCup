using FIFA_WorldCup.Entidades;
using FIFA_WorldCup.RN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIFA_WorldCup.Dal
{
    public class DalConfrontoConfederacao : DalBase 
    {

        public List<ConfrontoConfederacao> BuscaConfrontoConfederacao(Int16 PaisID, Competicao competicao)
        {
            List<ConfrontoConfederacao> lista;
            ConfrontoConfederacao objeto;
            try
            {
                lista = new List<ConfrontoConfederacao>();
                AbrirConexao();
                oDR = LerBanco(SQLConfrontoConfederacoes(PaisID, competicao));
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


        private ConfrontoConfederacao MontaObjeto(System.Data.OleDb.OleDbDataReader oDR)
        {
            ConfrontoConfederacao objeto = new ConfrontoConfederacao();
            objeto.Confederacao = (Confederacao)Convert.ToInt16(oDR["CONFEDERACAO_ID"]);
            objeto.GolsMarcados = Convert.ToInt16(oDR["GOLS_FEITOS"]);
            objeto.GolsSofridos = Convert.ToInt16(oDR["GOLS_TOMADOS"]);
            objeto.Vitorias = Convert.ToInt16(oDR["VITORIAS"]);
            objeto.Empates = Convert.ToInt16(oDR["EMPATES"]);
            objeto.Derrotas = Convert.ToInt16(oDR["DERROTAS"]);
            return objeto;
        }

        private string SQLConfrontoConfederacoes(Int16 PaisID, Competicao competicao)
        {
            oSB.Length = 0;
            oSB.Append("SELECT CONFEDERACAO_ID, ");
            oSB.Append("       SUM(GOLS_PRO) AS GOLS_FEITOS, ");
            oSB.Append("       SUM(GOLS_CONTRA) AS GOLS_TOMADOS, ");
            oSB.Append("       SUM(VENCEU) AS VITORIAS, ");
            oSB.Append("       SUM(EMPATOU) AS EMPATES, ");
            oSB.Append("       SUM(PERDEU) AS DERROTAS ");
            oSB.Append("FROM (");
            oSB.Append("         SELECT PAIS.CONFEDERACAO_ID, ");
            oSB.Append("                PARTIDA.GOLS_A AS GOLS_PRO, ");
            oSB.Append("                PARTIDA.GOLS_B AS GOLS_CONTRA,");
            oSB.Append("                IIf([PARTIDA.GOLS_A] > [PARTIDA.GOLS_B], 1, 0) AS VENCEU,");
            oSB.Append("                IIf([PARTIDA.GOLS_A] = [PARTIDA.GOLS_B], 1, 0) AS EMPATOU,");
            oSB.Append("                IIf([PARTIDA.GOLS_A] < [PARTIDA.GOLS_B], 1, 0) AS PERDEU");
            oSB.Append("         FROM (COPA INNER JOIN GRUPO ON COPA.ID = GRUPO.COPA_ID) INNER JOIN (PAIS INNER JOIN PARTIDA ON PAIS.ID = PARTIDA.SELECAO_B) ON GRUPO.ID = PARTIDA.GRUPO_ID ");
            oSB.Append("         WHERE PARTIDA.SELECAO_A = " + PaisID);
            oSB.Append("           AND COPA.COMPETICAO = " + (int)competicao);
            oSB.Append("           AND COPA.STATUS = " + (int)StatusCopa.Realizada);
            oSB.Append("     UNION ALL ");
            oSB.Append("         SELECT PAIS.CONFEDERACAO_ID, ");
            oSB.Append("                PARTIDA.GOLS_B AS GOLS_PRO, ");
            oSB.Append("                PARTIDA.GOLS_A AS GOLS_CONTRA,");
            oSB.Append("                IIf([PARTIDA.GOLS_A] < [PARTIDA.GOLS_B], 1, 0) AS VENCEU,");
            oSB.Append("                IIf([PARTIDA.GOLS_A] = [PARTIDA.GOLS_B], 1, 0) AS EMPATOU,");
            oSB.Append("                IIf([PARTIDA.GOLS_A] > [PARTIDA.GOLS_B], 1, 0) AS PERDEU ");
            oSB.Append("         FROM (COPA INNER JOIN GRUPO ON COPA.ID = GRUPO.COPA_ID) INNER JOIN (PAIS INNER JOIN PARTIDA ON PAIS.ID = PARTIDA.SELECAO_A) ON GRUPO.ID = PARTIDA.GRUPO_ID ");
            oSB.Append("         WHERE PARTIDA.SELECAO_B = " + PaisID);
            oSB.Append("           AND COPA.COMPETICAO = " + (int)competicao);
            oSB.Append("           AND COPA.STATUS = " + (int)StatusCopa.Realizada + ") AA ");
            oSB.Append("GROUP BY CONFEDERACAO_ID");
            return oSB.ToString();
        }


    }
}
