using FIFA_WorldCup.Entidades;
using FIFA_WorldCup.RN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace FIFA_WorldCup.Dal
{
    public class DalPartida : DalBase
    {

        public List<Partida> Sel(Partida vPartida)
        {
            List<Partida> lista;
            Partida objeto;
            try
            {
                lista = new List<Partida>();
                AbrirConexao();
                oDR = LerBanco(SQLSel(vPartida));
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

        public List<Partida> SelPartidasDoPais(Int16 vPaisID)
        {
            List<Partida> lista;
            Partida objeto;
            try
            {
                lista = new List<Partida>();
                AbrirConexao();
                oDR = LerBanco(SQLPartidasDoPais(vPaisID));
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

        public Partida Sel(Int16 vPartidaID)
        {
            Partida filtro = new Partida();
            Partida oPartida = null;
            filtro.ID = vPartidaID;
            List<Partida> lista = Sel(filtro);
            if (lista.Count > 0)
                oPartida = lista[0];
            return oPartida;
        }

        public bool PaisPossuiPartidas(Int16 PaisID, Int16 CopaID)
        {
            bool resposta = false;
            try
            {
                AbrirConexao();
                oDR = LerBanco(SQLPaisPossuiPartidas(PaisID, CopaID));
                if (oDR.Read())
                    resposta = true;
            } catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                FecharConexao();
            }
            return resposta;            
        }

        public bool PaisPossuiPartidasEmTipoCopa(Int16 PaisID, Competicao TipoCopa)
        {
            bool resposta = false;
            try
            {
                AbrirConexao();
                oDR = LerBanco(SQLPaisPossuiPartidasEmTipoCopa(PaisID, TipoCopa));
                if (oDR.Read())
                    resposta = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                FecharConexao();
            }
            return resposta;
        }


        public void Salvar(Partida vPartida)
        {
            bool Inclusao = false;
            try
            {
                string comandoSQL = "";
                AbrirConexao();
                // Partida
                if (vPartida.ID > 0)
                {
                    comandoSQL = SQLUpd(vPartida);
                }
                else
                {
                    comandoSQL = SQLIns(vPartida);
                    Inclusao = true;
                }
                ExecutarSQL(comandoSQL);

                // Desempate
                if (vPartida.Desempate != null)
                {
                    if (Inclusao)
                    {
                        //pega ID da ultima partida
                        Int16 iDUltimaPartida = UltimoID();
                        vPartida.ID = iDUltimaPartida;
                        vPartida.Desempate.Partida = iDUltimaPartida;
                    }

                    DalDesempate dDal = new DalDesempate();
                    dDal.Salvar(vPartida.Desempate);
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

        }

        public Int16 UltimoID()
        {
            Int16 Ultimo_ID = 0;
            try
            {
                AbrirConexao();
                object obj = ObterScalar(SQLUltimoID());
                Ultimo_ID = Convert.ToInt16(obj);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                FecharConexao();
            }
            return Ultimo_ID;
        }

        public Partida SelFinal(Int16 vCopaID)
        {
            Partida objeto = null;
            try
            {
                AbrirConexao();
                oDR = LerBanco(SQLSelFinal(vCopaID));
                while (oDR.Read())
                {
                    objeto = MontaObjeto(oDR);
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
            return objeto;
        }

        private string SQLSel(Partida vPartida)
        {
            oSB.Length = 0;
            oSB.AppendLine("SELECT P.ID ");
            oSB.AppendLine(",P.DATA ");
            oSB.AppendLine(",P.LOCAL_ID ");
            oSB.AppendLine(",P.GRUPO_ID ");
            oSB.AppendLine(",P.SELECAO_A ");
            oSB.AppendLine(",P.GOLS_A ");
            oSB.AppendLine(",P.SELECAO_B ");
            oSB.AppendLine(",P.GOLS_B ");
            oSB.AppendLine(",D.ID AS DESEMPATE_ID ");
            oSB.AppendLine(",E.ESTADIO ");
            oSB.AppendLine(",P1.NOME AS SELECAO1 ");
            oSB.AppendLine(",P1.CONFEDERACAO_ID AS CONFEDERACAO1 ");
            oSB.AppendLine(",P2.NOME AS SELECAO2 ");
            oSB.AppendLine(",P2.CONFEDERACAO_ID AS CONFEDERACAO2 ");
            oSB.AppendLine(",P.ORDEM_TREEVIEW  ");
            oSB.AppendLine("      FROM PAIS AS P2 ");
            oSB.AppendLine("INNER JOIN (PAIS P1 ");
            oSB.AppendLine("INNER JOIN (ESTADIO E ");
            oSB.AppendLine("INNER JOIN (PARTIDA P ");
            oSB.AppendLine(" LEFT JOIN DESEMPATE D ON P.ID = D.PARTIDA)  ");
            oSB.AppendLine("			ON E.ID = P.LOCAL_ID)  ");
            oSB.AppendLine("				ON P1.ID = P.SELECAO_A)  ");
            oSB.AppendLine("					ON P2.ID = P.SELECAO_B ");
            oSB.AppendLine(" WHERE 1=1 ");
            if (vPartida.ID > 0)
            {
                oSB.AppendLine(" AND P.ID = " + vPartida.ID.ToString());
            }
            if (vPartida.GrupoID > 0)
            {
                oSB.AppendLine(" AND P.GRUPO_ID = " + vPartida.GrupoID.ToString());
            }
            oSB.AppendLine(" ORDER BY P.DATA");
            return oSB.ToString();
        }

        private string SQLIns(Partida vPartida)
        {
            oSB.Length = 0;
            oSB.AppendLine("INSERT INTO PARTIDA (");
            oSB.AppendLine(" DATA, LOCAL_ID, GRUPO_ID, SELECAO_A, GOLS_A, SELECAO_B, GOLS_B ");
            oSB.AppendLine(") VALUES (");
            oSB.AppendLine("'" + vPartida.Data.ToString("MM/dd/yyyy HH:mm:ss") + "'");
            oSB.AppendLine("," + vPartida.Local);
            oSB.AppendLine("," + vPartida.GrupoID);
            oSB.AppendLine("," + vPartida.SelecaoID_A);
            oSB.AppendLine("," + vPartida.Gols_A);
            oSB.AppendLine("," + vPartida.SelecaoID_B);
            oSB.AppendLine("," + vPartida.Gols_B);
            oSB.AppendLine(")");
            return oSB.ToString();
        }

        private string SQLUpd(Partida vPartida)
        {
            oSB.Length = 0;
            oSB.AppendLine("UPDATE PARTIDA SET ");
            oSB.AppendLine("DATA = '" + vPartida.Data.ToString("MM/dd/yyyy HH:mm:ss") + "'");
            oSB.AppendLine(",LOCAL_ID = " + vPartida.Local);
            oSB.AppendLine(",GRUPO_ID = " + vPartida.GrupoID);
            oSB.AppendLine(",SELECAO_A = " + vPartida.SelecaoID_A);
            oSB.AppendLine(",GOLS_A = " + vPartida.Gols_A);
            oSB.AppendLine(",SELECAO_B = " + vPartida.SelecaoID_B);
            oSB.AppendLine(",GOLS_B = " + vPartida.Gols_B);
            oSB.AppendLine(" WHERE ID = " + vPartida.ID.ToString());
            return oSB.ToString();
        }

        private string SQLUltimoID()
        {
            oSB.Length = 0;
            oSB.AppendLine("SELECT Max(PARTIDA.ID) AS ULTIMO ");
            oSB.AppendLine("FROM PARTIDA");
            return oSB.ToString();
        }

        private string SQLPartidasDoPais(Int16 vPais_ID)
        {
            oSB.Length = 0;
            oSB.AppendLine("SELECT PARTIDA.ID, ");
            oSB.Append("PARTIDA.DATA,  ");
            oSB.Append("PARTIDA.LOCAL_ID, ");
            oSB.Append("PARTIDA.GRUPO_ID,  ");
            oSB.Append("PARTIDA.SELECAO_A,  ");
            oSB.Append("PARTIDA.SELECAO_B,  ");
            oSB.Append("PARTIDA.GOLS_A,  ");
            oSB.Append("PARTIDA.GOLS_B, 'estadio' AS ESTADIO,  ");
            oSB.Append("PAIS.NOME AS SELECAO1,  ");
            oSB.Append("PAIS_1.NOME AS SELECAO2,  ");
            oSB.Append("NULL as DESEMPATE_ID, ");
            oSB.Append("ORDEM_TREEVIEW  ");
            oSB.AppendLine("FROM PAIS AS PAIS_1 INNER JOIN (PAIS INNER JOIN PARTIDA ON PAIS.ID = PARTIDA.SELECAO_A) ON PAIS_1.ID = PARTIDA.SELECAO_B ");
            oSB.AppendLine("WHERE PARTIDA.SELECAO_A = " + vPais_ID + " ");
            oSB.AppendLine("   OR PARTIDA.SELECAO_B = " + vPais_ID + " ");
            return oSB.ToString();
        }

        private string SQLSelFinal(Int16 vCopaID)
        {
            oSB.Length = 0;
            oSB.AppendLine("     SELECT PARTIDA.ID, ");
            oSB.AppendLine("            PARTIDA.DATA, ");
            oSB.AppendLine("            PARTIDA.LOCAL_ID,");
            oSB.AppendLine("            ESTADIO.ESTADIO,");
            oSB.AppendLine("            ESTADIO.CIDADE,");
            oSB.AppendLine("            PARTIDA.GRUPO_ID,");
            oSB.AppendLine("            PARTIDA.SELECAO_A,");
            oSB.AppendLine("            PAIS.NOME AS SELECAO1,");
            oSB.AppendLine("            PARTIDA.GOLS_A,");
            oSB.AppendLine("            PAIS.CONFEDERACAO_ID AS CONFEDERACAO1,");
            oSB.AppendLine("            PARTIDA.SELECAO_B,");
            oSB.AppendLine("            PAIS_1.NOME AS SELECAO2,");
            oSB.AppendLine("            PARTIDA.GOLS_B,");
            oSB.AppendLine("            PAIS_1.CONFEDERACAO_ID AS CONFEDERACAO2,");
            oSB.AppendLine("            PARTIDA.ORDEM_TREEVIEW");
            oSB.AppendLine("            ,0 AS DESEMPATE_ID ");
            oSB.AppendLine("       FROM ESTADIO ");
            oSB.AppendLine(" INNER JOIN (PAIS AS PAIS_1  ");
            oSB.AppendLine(" INNER JOIN (PAIS ");
            oSB.AppendLine(" INNER JOIN (GRUPO ");
            oSB.AppendLine(" INNER JOIN PARTIDA ON GRUPO.ID = PARTIDA.GRUPO_ID) ");
            oSB.AppendLine("                    ON PAIS.ID = PARTIDA.SELECAO_A) ");
            oSB.AppendLine("                    ON PAIS_1.ID = PARTIDA.SELECAO_B)  ");
            oSB.AppendLine("                    ON ESTADIO.ID = PARTIDA.LOCAL_ID ");
            oSB.AppendLine("      WHERE GRUPO.COPA_ID = " + vCopaID + " ");
            oSB.AppendLine("        AND GRUPO.TIPO_FASE_ID = 6");
            return oSB.ToString();
        }

        private string SQLPaisPossuiPartidas(Int16 PaisID, Int16 CopaID)
        {
            oSB.Length = 0;
            oSB.Append("SELECT P.ID ");
            oSB.Append("FROM GRUPO G INNER JOIN PARTIDA P ON G.ID = P.GRUPO_ID ");
            oSB.Append("WHERE G.COPA_ID = " + CopaID + " ");
            oSB.Append("AND (P.SELECAO_A = " + PaisID + " OR P.SELECAO_B = " + PaisID + ")");
            return oSB.ToString();
        }

        private string SQLPaisPossuiPartidasEmTipoCopa(Int16 PaisID, Competicao TipoCopa)
        {
            oSB.Length = 0;
            oSB.Append("SELECT PARTIDA.ID ");
            oSB.Append("FROM COPA INNER JOIN (GRUPO INNER JOIN PARTIDA ON GRUPO.ID = PARTIDA.GRUPO_ID) ON COPA.ID = GRUPO.COPA_ID ");
            oSB.Append("WHERE COPA.COMPETICAO = " + (short)TipoCopa);
            oSB.Append("AND (PARTIDA.SELECAO_A = " + PaisID + " OR PARTIDA.SELECAO_B = " + PaisID + ")");
            return oSB.ToString();
        }

        private Partida MontaObjeto(System.Data.OleDb.OleDbDataReader oDR)
        {
            Partida obj = new Partida();
            obj.ID = Convert.ToInt16(oDR["ID"]);
            obj.Data = Convert.ToDateTime(oDR["DATA"]);
            obj.Estadio = (string)oDR["ESTADIO"];
            obj.Gols_A = Convert.ToInt16(oDR["GOLS_A"]);
            obj.Gols_B = Convert.ToInt16(oDR["GOLS_B"]);
            obj.GrupoID = Convert.ToInt16(oDR["GRUPO_ID"]);
            obj.Local = Convert.ToInt16(oDR["LOCAL_ID"]);
            obj.NomePaisA = (string)oDR["SELECAO1"];
            obj.ConfederacaoA = (Confederacao)oDR["CONFEDERACAO1"];
            obj.NomePaisB = (string)oDR["SELECAO2"];
            obj.ConfederacaoB = (Confederacao)oDR["CONFEDERACAO2"];
            obj.SelecaoID_A = Convert.ToInt16(oDR["SELECAO_A"]);
            obj.SelecaoID_B = Convert.ToInt16(oDR["SELECAO_B"]);
            //Se houver algum tipo de desempate
            if (! (oDR["DESEMPATE_ID"] is DBNull))
            {
                Int16 DesempateID = Convert.ToInt16(oDR["DESEMPATE_ID"]);
                DalDesempate dDal = new DalDesempate();
                Desempate oDesempate = dDal.Sel(DesempateID);
                obj.Desempate = oDesempate;
            }
            if (!(oDR["ORDEM_TREEVIEW"] is DBNull))
            {
                obj.Ordem_Treeview = Convert.ToInt16(oDR["ORDEM_TREEVIEW"]);
            }
            return obj;
        }

        //public List<Partida> SelParticipantesDisponiveis(Int16 vAno)
        //{
        //    List<Partida> lista;
        //    Partida objeto;
        //    try
        //    {
        //        lista = new List<Partida>();
        //        AbrirConexao();
        //        oDR = LerBanco(SQLSelParticipantesDisponiveis(vAno));
        //        while (oDR.Read())
        //        {
        //            objeto = MontaObjeto(oDR);
        //            lista.Add(objeto);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //    finally
        //    {
        //        FecharConexao();
        //    }
        //    return lista;
        //}

        //public List<Partida> SelParticipantesSelecionados(Int16 vAno)
        //{
        //    List<Partida> lista;
        //    Partida objeto;
        //    try
        //    {
        //        lista = new List<Partida>();
        //        AbrirConexao();
        //        oDR = LerBanco(SQLSelParticipantesSelecionados(vAno));
        //        while (oDR.Read())
        //        {
        //            objeto = MontaObjeto(oDR);
        //            lista.Add(objeto);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //    finally
        //    {
        //        FecharConexao();
        //    }
        //    return lista;
        //}


    }
}
