using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FIFA_WorldCup.Entidades;

namespace FIFA_WorldCup.Dal
{
    public class DalGrupo : DalBase
    {

        public List<Grupo> Sel(Grupo vGrupo)
        {
            List<Grupo> lista;
            Grupo objeto;
            try
            {
                lista = new List<Grupo>();
                AbrirConexao();
                oDR = LerBanco(SQLSel(vGrupo));
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

        public Grupo Sel(Int16 vID)
        {
            Grupo filtro = new Grupo();
            Grupo oPais = null;
            filtro.ID = vID;
            List<Grupo> lista = Sel(filtro);
            if (lista.Count > 0)
                oPais = lista[0];
            return oPais;
        }

        public void Salvar(Grupo vGrupo)
        {
            try
            {
                string comandoSQL = "";
                AbrirConexao();
                if (vGrupo.ID > 0)
                {
                    comandoSQL = SQLUpd(vGrupo);
                }
                else
                {
                    comandoSQL = SQLIns(vGrupo);
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


        private string SQLSel(Grupo vGrupo)
        {
            oSB.Length = 0;
            oSB.AppendLine("    SELECT G.ID, G.NOME, G.TIPO_FASE_ID, G.COPA_ID ");
            oSB.AppendLine("      FROM GRUPO G ");
            oSB.AppendLine("INNER JOIN TIPO_FASE T ON T.ID = G.TIPO_FASE_ID ");
            oSB.AppendLine("     WHERE 1 = 1 ");
            if (vGrupo.ID > 0)
            {
                oSB.AppendLine(" AND G.ID = " + vGrupo.ID.ToString());
            }
            if (vGrupo.CopaID > 0)
            {
                oSB.AppendLine(" AND G.COPA_ID = " + vGrupo.CopaID.ToString());
            }
            if (vGrupo.TipoFaseID > 0)
            {
                oSB.AppendLine(" AND G.TIPO_FASE_ID = " + vGrupo.TipoFaseID.ToString());
            }
            oSB.AppendLine(" ORDER BY T.ORDEM, G.NOME");
            return oSB.ToString();
        }
        
        private string SQLIns(Grupo vGrupo)
        {
            oSB.Length = 0;
            oSB.AppendLine("INSERT INTO GRUPO (");
            oSB.AppendLine("NOME,");
            oSB.AppendLine("TIPO_FASE_ID,");
            oSB.AppendLine("COPA_ID");
            oSB.AppendLine(") VALUES (");
            oSB.AppendLine("'" + vGrupo.Nome + "',");
            oSB.AppendLine(vGrupo.TipoFaseID.ToString() + "," );
            oSB.AppendLine(vGrupo.CopaID.ToString());
            oSB.AppendLine(")");
            return oSB.ToString();
        }

        private string SQLUpd(Grupo vGrupo)
        {
            oSB.Length = 0;
            oSB.AppendLine("UPDATE GRUPO SET ");
            oSB.AppendLine("NOME = '" + vGrupo.Nome + "'");
            oSB.AppendLine(",TIPO_FASE_ID = " + vGrupo.TipoFaseID);
            oSB.AppendLine(",COPA_ID = " + vGrupo.CopaID);
            oSB.AppendLine(" WHERE ID = " + vGrupo.ID);
            return oSB.ToString();
        }

        private Grupo MontaObjeto(System.Data.OleDb.OleDbDataReader oDR)
        {
            Grupo objeto = new Grupo();
            objeto.ID = Convert.ToInt16(oDR["ID"]);
            objeto.Nome = Convert.ToString(oDR["NOME"]);
            objeto.TipoFaseID = Convert.ToInt16(oDR["TIPO_FASE_ID"]);
            objeto.CopaID = Convert.ToInt16(oDR["COPA_ID"]);
            return objeto;
        }

    }
}
