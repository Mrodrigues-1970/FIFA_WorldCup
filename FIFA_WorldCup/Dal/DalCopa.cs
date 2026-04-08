using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FIFA_WorldCup.Entidades;

namespace FIFA_WorldCup.Dal
{
    public class DalCopa : DalBase
    {

        public List<Copa> Sel(Copa vCopa)
        {
            List<Copa> lista;
            Copa objeto;
            try
            {
                lista = new List<Copa>();
                AbrirConexao();
                oDR = LerBanco(SQLSel(vCopa));
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

        public Copa Sel(Int16 vCopaID)
        {
            Copa filtro = new Copa();
            Copa oPais = null;
            filtro.ID = vCopaID;
            List<Copa> lista = Sel(filtro);
            if (lista.Count > 0)
                oPais = lista[0];
            return oPais;
        }

        private string SQLSel(Copa vCopa)
        {
            oSB.Length = 0;
            oSB.AppendLine("SELECT ID, NOME, ANO, MASCOTE, STATUS, COMPETICAO, DATA_INICIAL, DATA_FINAL ");
            oSB.AppendLine("FROM COPA ");
            oSB.AppendLine(" WHERE 1 = 1 ");
            if (vCopa.ID == 0)
            {
                oSB.AppendLine(" AND COMPETICAO = " + Convert.ToInt16(vCopa.Competicao));
            }
            else
            {
                oSB.AppendLine(" AND ID = " + vCopa.ID.ToString());
            }
            oSB.AppendLine("ORDER BY ANO");
            return oSB.ToString();
        }

        private Copa MontaObjeto(System.Data.OleDb.OleDbDataReader oDR)
        {
            Copa objeto = new Copa();
            objeto.ID = Convert.ToInt16(oDR["ID"]);
            objeto.Ano = Convert.ToInt16(oDR["ANO"]);
            objeto.Nome = Convert.ToString(oDR["NOME"]);
            objeto.Mascote = Convert.ToString(oDR["MASCOTE"]);
            objeto.Status = (StatusCopa)Convert.ToInt16(oDR["STATUS"]);
            objeto.Competicao = (Competicao)Convert.ToInt16(oDR["COMPETICAO"]);
            objeto.Data_Inicial = Convert.ToDateTime(oDR["DATA_INICIAL"]);
            objeto.Data_Final = Convert.ToDateTime(oDR["DATA_FINAL"]);
            return objeto;
        }

    }
}
