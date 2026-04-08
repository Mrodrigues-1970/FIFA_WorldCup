using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FIFA_WorldCup.Entidades;

namespace FIFA_WorldCup.Dal
{
    public class DalTipoFase : DalBase
    {


        public List<TipoFase> Sel(TipoFase vTipoFase)
        {
            List<TipoFase> lista;
            TipoFase objeto;
            try
            {
                lista = new List<TipoFase>();
                AbrirConexao();
                oDR = LerBanco(SQLSel(vTipoFase));
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

        public TipoFase Sel(Int16 vTipoFaseID)
        {
            TipoFase filtro = new TipoFase();
            TipoFase oTipo = null;
            filtro.ID = vTipoFaseID;
            List<TipoFase> lista = Sel(filtro);
            if (lista.Count > 0)
                oTipo = lista[0];
            return oTipo;
        }

        public List<TipoFase> SelTodos()
        {
            List<TipoFase> lista = new List<TipoFase>();
            TipoFase objeto;
            try
            {
                AbrirConexao();
                oDR = LerBanco(SQLSelTodos());
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


        private string SQLSel(TipoFase vTipoFase)
        {
            oSB.Length = 0;
            oSB.AppendLine("SELECT ID, NOME, ORDEM ");
            oSB.AppendLine("FROM TIPO_FASE ");
            if (vTipoFase.ID > 0)
            {
                oSB.AppendLine(" WHERE ID = " + vTipoFase.ID.ToString());
            }
            oSB.AppendLine("ORDER BY ORDEM");
            return oSB.ToString();
        }

        private string SQLSelTodos()
        {
            oSB.Length = 0;
            oSB.AppendLine("SELECT ID, NOME, ORDEM ");
            oSB.AppendLine("FROM TIPO_FASE ");
            oSB.AppendLine("ORDER BY ORDEM");
            return oSB.ToString();
        }

        private TipoFase MontaObjeto(System.Data.OleDb.OleDbDataReader oDR)
        {
            TipoFase objeto = new TipoFase();
            objeto.ID = Convert.ToInt16(oDR["ID"]);
            objeto.Nome = Convert.ToString(oDR["NOME"]);
            objeto.Ordem = Convert.ToInt16(oDR["ORDEM"]);
            return objeto;
        }


    }
}
