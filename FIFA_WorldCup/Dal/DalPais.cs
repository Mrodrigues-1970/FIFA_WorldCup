using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FIFA_WorldCup.Entidades;

namespace FIFA_WorldCup.Dal
{
    public class DalPais : DalBase
    {

        public List<Pais> Sel(Pais vPais)
        {
            List<Pais> lista;
            Pais objeto;
            try
            {
                lista = new List<Pais>();
                AbrirConexao();
                oDR = LerBanco(SQLSel(vPais));
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

        public List<Pais> SelParticipantesDisponiveis(Int16 vCopaID)
        {
            List<Pais> lista;
            Pais objeto;
            try
            {
                lista = new List<Pais>();
                AbrirConexao();
                oDR = LerBanco(SQLSelParticipantesDisponiveis(vCopaID));
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

        public List<Pais> SelParticipantesSelecionados(Int16 vCopaID)
        {
            List<Pais> lista;
            Pais objeto;
            try
            {
                lista = new List<Pais>();
                AbrirConexao();
                oDR = LerBanco(SQLSelParticipantesSelecionados(vCopaID));
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

        public Pais Sel(Int16 vPaisID)
        {
            Pais filtro = new Pais();
            Pais oPais = null;
            filtro.ID = vPaisID;
            List<Pais> lista = Sel(filtro);
            if (lista.Count > 0)
                oPais = lista[0];
            return oPais;
        }

        public void Ins(Pais vPais)
        {
            try
            {
                string comandoSQL = "";
                AbrirConexao();
                comandoSQL = SQLIns(vPais);
                ExecutarSQL(comandoSQL);
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

        public void Upd(Pais vPais)
        {
            try
            {
                string comandoSQL = "";
                AbrirConexao();
                comandoSQL = SQLUpd(vPais);
                ExecutarSQL(comandoSQL);
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

        public List<Pais> MembrosDoGrupo(Int16 vGrupoID)
        {
            List<Pais> lista;
            Pais objeto;
            try
            {
                lista = new List<Pais>();
                AbrirConexao();
                oDR = LerBanco(SQLMembrosDoGrupo(vGrupoID));
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

        private string SQLSel(Pais vPais)
        {
            oSB.Length = 0;
            oSB.AppendLine("SELECT ID, CONFEDERACAO_ID, NOME, NOME_INGLES, ATIVO, RANK ");
            oSB.AppendLine("FROM PAIS WHERE 1=1 ");
            if (vPais.ID > 0)
            {
                oSB.AppendLine(" AND ID = " + vPais.ID.ToString());
            }
            if (vPais.Confederacao > 0)
            {
                oSB.AppendLine(" AND CONFEDERACAO_ID = " + Convert.ToInt16(vPais.Confederacao));
            }
            if (vPais.Ativo.HasValue)
            {
                oSB.AppendLine(" AND ATIVO = " + vPais.Ativo.ToString());
            }
            oSB.AppendLine(" ORDER BY NOME");
            return oSB.ToString();
        }

        private string SQLIns(Pais vPais)
        {
            oSB.Length = 0;
            oSB.AppendLine("INSERT INTO PAIS (");
            oSB.AppendLine(" CONFEDERACAO_ID, NOME, NOME_INGLES, ATIVO, RANK ");
            oSB.AppendLine(") VALUES (");
            oSB.AppendLine((Int16)vPais.Confederacao + ",");
            oSB.AppendLine("'" + vPais.Nome + "',");
            oSB.AppendLine("'" + vPais.Nome_Ingles + "',");
            oSB.AppendLine(" " + BooleanToBooleanString(vPais.Ativo.Value) + ", ");
            oSB.AppendLine(" " + vPais.Rank + " ");
            oSB.AppendLine(")");
            return oSB.ToString();
        }

        private string SQLUpd(Pais vPais)
        {
            oSB.Length = 0;
            oSB.AppendLine("UPDATE PAIS SET ");
            oSB.AppendLine("CONFEDERACAO_ID = " + (Int16)vPais.Confederacao + ",");
            oSB.AppendLine("NOME = '" + vPais.Nome + "',");
            oSB.AppendLine("NOME_INGLES = '" + vPais.Nome_Ingles + "',");
            oSB.AppendLine("ATIVO = " + BooleanToBooleanString(vPais.Ativo.Value) + ",");
            oSB.AppendLine("RANK = " + vPais.Rank.ToString() + " ");
            oSB.AppendLine(" WHERE ID = " + vPais.ID.ToString());
            return oSB.ToString();
        }

        private string SQLSelParticipantesSelecionados(Int16 vCopaID)
        {
            oSB.Length = 0;
            oSB.AppendLine("SELECT ID, CONFEDERACAO_ID, NOME, NOME_INGLES, ATIVO, RANK ");
            oSB.AppendLine(" FROM PAIS P ");
            oSB.AppendLine(" INNER JOIN PARTICIPANTE PT ON P.ID = PT.PAIS ");
            oSB.AppendLine("WHERE PT.COPA_ID = " + vCopaID.ToString() + " ");
            oSB.AppendLine(" ORDER BY P.NOME");
            return oSB.ToString();
        }

        private string SQLSelParticipantesDisponiveis(Int16 vCopaID)
        {
            oSB.Length = 0;
            oSB.AppendLine("SELECT ID, CONFEDERACAO_ID, NOME, NOME_INGLES, ATIVO, RANK ");
            oSB.AppendLine(" FROM PAIS");
            oSB.AppendLine(" WHERE PAIS.ID NOT IN (");
            oSB.AppendLine("              SELECT PARTICIPANTE.PAIS");
            oSB.AppendLine("                FROM PARTICIPANTE ");
            oSB.AppendLine("               WHERE PARTICIPANTE.COPA_ID = " + vCopaID.ToString() + " ");
            oSB.AppendLine(") ");
            oSB.AppendLine("ORDER BY PAIS.NOME ");
            return oSB.ToString();
        }

        private string SQLMembrosDoGrupo(Int16 vGrupoID)
        {
            oSB.Length = 0;
            oSB.AppendLine("SELECT DISTINCT PAIS.ID, PAIS.CONFEDERACAO_ID, PAIS.NOME, PAIS.NOME_INGLES, PAIS.ATIVO, PAIS.RANK ");
            oSB.AppendLine("FROM PAIS INNER JOIN PARTIDA ON PAIS.ID = PARTIDA.SELECAO_A ");
            oSB.AppendLine("WHERE PARTIDA.GRUPO_ID = " + vGrupoID + " ");
            oSB.AppendLine(" UNION ");
            oSB.AppendLine("SELECT DISTINCT PAIS.ID, PAIS.CONFEDERACAO_ID, PAIS.NOME, PAIS.NOME_INGLES, PAIS.ATIVO, PAIS.RANK ");
            oSB.AppendLine("FROM PAIS INNER JOIN PARTIDA ON PAIS.ID = PARTIDA.SELECAO_B ");
            oSB.AppendLine("WHERE PARTIDA.GRUPO_ID = " + vGrupoID + " ");



            //oSB.AppendLine("ORDER BY PAIS.NOME ");
            return oSB.ToString();
        }

        private Pais MontaObjeto(System.Data.OleDb.OleDbDataReader oDR)
        {
            Pais objeto = new Pais();
            objeto.ID = Convert.ToInt16(oDR["ID"]);
            objeto.Confederacao = (Confederacao)Convert.ToInt16(oDR["CONFEDERACAO_ID"]);
            objeto.Nome = Convert.ToString(oDR["NOME"]);
            objeto.Nome_Ingles = Convert.ToString(oDR["NOME_INGLES"]);
            objeto.Ativo = Convert.ToBoolean(oDR["ATIVO"]);
            objeto.Rank = Convert.ToInt16(oDR["RANK"]);
            return objeto;
        }


    }
}
