using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FIFA_WorldCup.Entidades;

namespace FIFA_WorldCup.Dal
{
    public class DalDesempate : DalBase
    {

        public Desempate Sel(Int16 vDesempateID)
        {
            Desempate objeto = null;
            try
            {
                AbrirConexao();
                oDR = LerBanco(SQLSel(vDesempateID));
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

        public void Salvar(Desempate vDesempate)
        {
            try
            {
                string comandoSQL = "";
                AbrirConexao();
                if (vDesempate.ID > 0)
                {
                    comandoSQL = SQLUpd(vDesempate);
                }
                else
                {
                    comandoSQL = SQLIns(vDesempate);
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

        private string SQLSel(Int16 vDesempateID)
        {
            oSB.Length = 0;
            oSB.AppendLine("SELECT ID, PARTIDA, TIPO, GOLS_A, GOLS_B ");
            oSB.AppendLine("FROM DESEMPATE ");
            oSB.AppendLine("WHERE ID = " + vDesempateID);
            return oSB.ToString();
        }

        private string SQLIns(Desempate vDesempate)
        {
            oSB.Length = 0;
            oSB.AppendLine("INSERT INTO DESEMPATE ( ");
            oSB.AppendLine("PARTIDA, TIPO, GOLS_A, GOLS_B ");
            oSB.AppendLine(") VALUES (");
            oSB.AppendLine(vDesempate.Partida.ToString());
            oSB.AppendLine("," + (Int16)vDesempate.Tipo);
            oSB.AppendLine("," + vDesempate.Gols_A);
            oSB.AppendLine("," + vDesempate.Gols_B);
            oSB.AppendLine(")");
            return oSB.ToString();
        }

        private string SQLUpd(Desempate vDesempate)
        {
            oSB.Length = 0;
            oSB.AppendLine("UPDATE DESEMPATE SET ");
            oSB.AppendLine("PARTIDA = " + vDesempate.Partida);
            oSB.AppendLine(",TIPO = " + (Int16)vDesempate.Tipo);
            oSB.AppendLine(",GOLS_A = " + vDesempate.Gols_A);
            oSB.AppendLine(",GOLS_B = " + vDesempate.Gols_B);
            oSB.AppendLine(" WHERE ID = " + vDesempate.ID);
            return oSB.ToString();
        }

        private Desempate MontaObjeto(System.Data.OleDb.OleDbDataReader oDR)
        {
            Desempate oDesempate = new Desempate();
            oDesempate.ID = Convert.ToInt16(oDR["ID"]);
            oDesempate.Partida = Convert.ToInt16(oDR["PARTIDA"]);
            oDesempate.Tipo = (TipoDesempate)Convert.ToInt16(oDR["TIPO"]);
            oDesempate.Gols_A = Convert.ToInt16(oDR["GOLS_A"]);
            oDesempate.Gols_B = Convert.ToInt16(oDR["GOLS_B"]);
            return oDesempate;
        }


    }
}
