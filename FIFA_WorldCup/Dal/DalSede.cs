using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FIFA_WorldCup.Entidades;

namespace FIFA_WorldCup.Dal
{
    public class DalSede : DalBase
    {
        public List<Sede> SelTodos()
        {
            List<Sede> lista;
            Sede objeto;
            try
            {
                lista = new List<Sede>();
                AbrirConexao();
                oDR = LerBanco(SQLSel());
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
            List<Sede> ListaNormalizada = NormalizaListaSedes(lista);
            return ListaNormalizada;
        }

        private List<Sede> NormalizaListaSedes(List<Sede> lista)
        {
            List<Sede> NovaLista = new List<Sede>();
            Sede SedeAnterior = null;
            foreach(Sede iSede in lista)
            {
                if ((SedeAnterior != null) && (SedeAnterior.CopaID == iSede.CopaID))
                {
                    SedeAnterior.Nome = SedeAnterior.Nome + " / " + iSede.Nome;
                } else
                {
                    SedeAnterior = iSede;
                    NovaLista.Add(SedeAnterior);
                }
            }
            return NovaLista;
        }

        private Sede MontaObjeto(System.Data.OleDb.OleDbDataReader oDR)
        {
            Sede objeto = new Sede();
            objeto.CopaID = Convert.ToInt16(oDR["COPA_ID"]);
            objeto.Nome = Convert.ToString(oDR["NOME"]);
            objeto.Ano = Convert.ToInt16(oDR["ANO"]);
            objeto.Competicao = (Competicao)Convert.ToInt16(oDR["COMPETICAO"]);
            return objeto;
        }

        private string SQLSel()
        {
            oSB.Length = 0;
            oSB.AppendLine("SELECT SEDE.COPA_ID, PAIS.NOME, COPA.ANO, COPA.COMPETICAO ");
            oSB.AppendLine("FROM COPA INNER JOIN (PAIS INNER JOIN SEDE ON PAIS.ID = SEDE.PAIS) ");
            oSB.AppendLine("ON COPA.ID = SEDE.COPA_ID ");
            oSB.AppendLine("ORDER BY COPA.ANO ");            
            return oSB.ToString();
        }
        
    }
}
