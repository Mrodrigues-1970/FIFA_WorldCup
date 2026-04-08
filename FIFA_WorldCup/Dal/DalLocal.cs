using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FIFA_WorldCup.Entidades;

namespace FIFA_WorldCup.Dal
{
    public class DalLocal : DalBase
    {

        public List<Local> Sel(Int16 vCopaID)
        {
            List<Local> lista;
            Local objeto;
            try
            {
                lista = new List<Local>();
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

        public Local SelPorID(Int16 vLocalID)
        {
            Local objeto = null;
            try
            {
                
                AbrirConexao();
                oDR = LerBanco(SQLSelPorID(vLocalID));
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

        public void Salvar(Local vLocal)
        {
            try
            {
                string comandoSQL = "";
                AbrirConexao();
                if (vLocal.ID > 0)
                {
                    comandoSQL = SQLUpd(vLocal);
                }
                else
                {
                    comandoSQL = SQLIns(vLocal);
                }
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

        private string SQLSel(Int16 vCopaID)
        {
            oSB.Length = 0;
            oSB.AppendLine("SELECT ID, COPA_ID, ESTADIO, CIDADE ");
            oSB.AppendLine("FROM ESTADIO ");
            oSB.AppendLine("WHERE COPA_ID = " + vCopaID );
            oSB.AppendLine(" ORDER BY ESTADIO");
            return oSB.ToString();
        }

        private string SQLSelPorID(Int16 vLocalID)
        {
            oSB.Length = 0;
            oSB.AppendLine("SELECT ID, COPA_ID, ESTADIO, CIDADE ");
            oSB.AppendLine("FROM ESTADIO ");
            oSB.AppendLine("WHERE ID = " + vLocalID);
            return oSB.ToString();
        }

        private string SQLIns(Local vLocal)
        {
            oSB.Length = 0;
            oSB.AppendLine("INSERT INTO ESTADIO (");
            oSB.AppendLine(" COPA_ID, ESTADIO, CIDADE ");
            oSB.AppendLine(") VALUES (");
            oSB.AppendLine(vLocal.CopaID + ",");
            oSB.AppendLine("'" + vLocal.Estadio + "',");
            oSB.AppendLine("'" + vLocal.Cidade + "'");
            oSB.AppendLine(")");
            return oSB.ToString();
        }

        private string SQLUpd(Local vLocal)
        {
            oSB.Length = 0;
            oSB.AppendLine("UPDATE ESTADIO SET ");
            oSB.AppendLine("COPA_ID = " + vLocal.CopaID + ",");
            oSB.AppendLine("ESTADIO = '" + vLocal.Estadio + "',");
            oSB.AppendLine("CIDADE = '" + vLocal.Cidade + "'");
            oSB.AppendLine(" WHERE ID = " + vLocal.ID.ToString());
            return oSB.ToString();
        }

        private Local MontaObjeto(System.Data.OleDb.OleDbDataReader oDR)
        {
            Local objeto = new Local();
            objeto.ID = Convert.ToInt16(oDR["ID"]);
            objeto.CopaID = Convert.ToInt16(oDR["COPA_ID"]);
            objeto.Estadio = Convert.ToString(oDR["ESTADIO"]);
            objeto.Cidade = Convert.ToString(oDR["CIDADE"]);
            return objeto;
        }

    }
}
