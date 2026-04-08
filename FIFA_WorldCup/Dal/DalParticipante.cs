using FIFA_WorldCup.Entidades;
using FIFA_WorldCup.RN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIFA_WorldCup.Dal
{
    public class DalParticipante : DalBase
    {

        public void Salvar(Int16 vCopaID, List<Pais> vLista)
        {
            try
            {
                AbrirConexao();
                LimparParticipantes(vCopaID);
                foreach(Pais iPais in vLista)
                {
                    ExecutarSQL(SQLInsert(vCopaID, iPais.ID));
                }

            } catch (Exception ex)
            {
                throw ex;
            } finally
            {
                FecharConexao();
            }
        }

        public List<Int16> CopasParticipadas(Int16 PaisID, Competicao oCompeticao)
        {
            List<Int16> lista;
            try
            {
                lista = new List<Int16>();
                AbrirConexao();
                oDR = LerBanco(SQLCopasParticipadas(PaisID, oCompeticao));
                while (oDR.Read())
                {
                    Int16 CopaID = Convert.ToInt16(oDR["COPA_ID"]);
                    lista.Add(CopaID);
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


        private bool LimparParticipantes(Int16 vCopaID)
        {
            bool sucesso = true;
            try
            {
                ExecutarSQL(SQLLimparParticipantes(vCopaID));
            } catch (Exception ex)
            {
                sucesso = false;
            }
            return sucesso;
        }
        
        private bool Existepartida(Int16 vAno)
        {
            bool existencia = Convert.ToBoolean(ObterScalar(SQLExistePartida(vAno)));
            return existencia;
        }

        private string SQLLimparParticipantes(Int16 vCopaID)
        {
            oSB.Length = 0;
            oSB.AppendLine("DELETE FROM PARTICIPANTE ");
            oSB.AppendLine("WHERE COPA_ID = " + vCopaID.ToString() + " ");

            return oSB.ToString();
        }

        /// <summary>
        /// Verifica se existe alguma partida cadastrada de algum dos participantes
        /// </summary>
        /// <param name="vAno"></param>
        /// <returns></returns>
        private string SQLExistePartida(Int16 vAno)
        {
            oSB.Length = 0;
            oSB.AppendLine("SELECT G.ANO, P.ID ");
            oSB.AppendLine("FROM GRUPO G  ");
            oSB.AppendLine("INNER JOIN PARTIDA P ON G.ID = P.GRUPO_ID ");
            oSB.AppendLine("WHERE G.ANO = " + vAno);
            return oSB.ToString();
        }

        private string SQLInsert(Int16 vCopaID, Int16 vPaisID)
        {
            oSB.Length = 0;
            oSB.AppendLine("INSERT INTO PARTICIPANTE ( ");
            oSB.AppendLine("COPA_ID, ");
            oSB.AppendLine("PAIS ");
            oSB.AppendLine(") VALUES ( ");
            oSB.AppendLine(vCopaID.ToString());
            oSB.AppendLine(", " + vPaisID.ToString());
            oSB.AppendLine(") ");
            return oSB.ToString();
        }


        private string SQLCopasParticipadas(Int16 PaisID, Competicao oCompeticao)
        {
            oSB.Length = 0;
            oSB.AppendLine("    SELECT P.COPA_ID");
            oSB.AppendLine("      FROM PARTICIPANTE P ");
            oSB.AppendLine("INNER JOIN COPA C ON C.ID = P.COPA_ID ");
            oSB.AppendLine("     WHERE C.COMPETICAO = " + (short)oCompeticao);
            oSB.AppendLine("       AND P.PAIS = " + PaisID);
            oSB.AppendLine("       AND C.STATUS = " + (int)(StatusCopa.Realizada));
            return oSB.ToString();
        }

    }
}
