using FIFA_WorldCup.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIFA_WorldCup.Dal
{
    public class DalPartidaTreeview : DalBase
    {

        public List<PartidaTreeView> Sel(Int16 vCopaID)
        {
            List<PartidaTreeView> lista;
            PartidaTreeView objeto;
            try
            {
                lista = new List<PartidaTreeView>();
                AbrirConexao();
                oDR = LerBanco(SQLSel(vCopaID));
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

        public List<PartidaTreeView> SelSemiFinaisEFinal(Int16 vCopaID)
        {
            List<PartidaTreeView> lista;
            PartidaTreeView objeto;
            try
            {
                lista = new List<PartidaTreeView>();
                AbrirConexao();
                oDR = LerBanco(SQlSelSemiFinaisEFinal(vCopaID));
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


        private string SQLSel(Int16 CopaID)
        {
            oSB.Length = 0;
            oSB.AppendLine("SELECT G.TIPO_FASE_ID, P.DATA, P.SELECAO_A, PAIS.NOME AS NOMEPAIS1, P.GOLS_A, P.SELECAO_B, PAIS_1.NOME AS NOMEPAIS2, P.GOLS_B, P.ORDEM_TREEVIEW ");
            oSB.AppendLine("FROM PAIS AS PAIS_1  ");
            oSB.AppendLine("INNER JOIN (PAIS  ");
            oSB.AppendLine("INNER JOIN (GRUPO AS G  ");
            oSB.AppendLine("INNER JOIN PARTIDA AS P ON G.ID = P.GRUPO_ID) ON PAIS.ID = P.SELECAO_A) ON PAIS_1.ID = P.SELECAO_B ");
            oSB.AppendLine("WHERE G.TIPO_FASE_ID > 1 AND G.COPA_ID = " + CopaID + " ");
            oSB.AppendLine("ORDER BY G.TIPO_FASE_ID, P.ORDEM_TREEVIEW ");
            return oSB.ToString();
        }

        private string SQlSelSemiFinaisEFinal(Int16 CopaID)
        {
            oSB.Length = 0;
            oSB.AppendLine("SELECT G.TIPO_FASE_ID, P.DATA, P.SELECAO_A, PAIS.NOME AS NOMEPAIS1, P.GOLS_A, P.SELECAO_B, PAIS_1.NOME AS NOMEPAIS2, P.GOLS_B, P.ORDEM_TREEVIEW ");
            oSB.AppendLine("FROM PAIS AS PAIS_1  ");
            oSB.AppendLine("INNER JOIN (PAIS  ");
            oSB.AppendLine("INNER JOIN (GRUPO AS G  ");
            oSB.AppendLine("INNER JOIN PARTIDA AS P ON G.ID = P.GRUPO_ID) ON PAIS.ID = P.SELECAO_A) ON PAIS_1.ID = P.SELECAO_B ");
            oSB.AppendLine("WHERE (G.TIPO_FASE_ID = 4 OR G.TIPO_FASE_ID = 6) AND G.COPA_ID = " + CopaID + " ");
            oSB.AppendLine("ORDER BY G.TIPO_FASE_ID, P.ORDEM_TREEVIEW ");
            return oSB.ToString();
        }


        private PartidaTreeView MontaObjeto(System.Data.OleDb.OleDbDataReader oDR)
        {
            PartidaTreeView objeto = new PartidaTreeView();
            objeto.Tipo_Fase = Convert.ToInt16(oDR["TIPO_FASE_ID"]);
            objeto.SelecaoA = Convert.ToInt16(oDR["SELECAO_A"]);
            objeto.Gols_A = Convert.ToInt16(oDR["GOLS_A"]);
            objeto.NomeSelecaoA = oDR["NOMEPAIS1"].ToString();
            objeto.SelecaoB = Convert.ToInt16(oDR["SELECAO_B"]);
            objeto.Gols_B = Convert.ToInt16(oDR["GOLS_B"]);
            objeto.NomeSelecaoB = oDR["NOMEPAIS2"].ToString();
            if (oDR["ORDEM_TREEVIEW"] != DBNull.Value)
            {
                objeto.Ordem = Convert.ToInt16(oDR["ORDEM_TREEVIEW"]);
            }
            if (oDR["DATA"] != DBNull.Value)
            {
                objeto.DataPartida = Convert.ToDateTime(oDR["DATA"]);
            }
            return objeto;
        }


    }
}
