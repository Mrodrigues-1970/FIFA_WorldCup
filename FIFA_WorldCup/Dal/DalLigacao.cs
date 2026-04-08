using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FIFA_WorldCup.Entidades;

namespace FIFA_WorldCup.Dal
{
    public class DalLigacao : DalBase
    {

        public List<Ligacao> SelLista(Int16 vPaisID)
        {
            List<Ligacao> lista;
            Ligacao objeto;
            try
            {
                lista = new List<Ligacao>();
                AbrirConexao();
                oDR = LerBanco(SQLSelLista(vPaisID));
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

        public Ligacao Sel(Int16 vPais1ID)
        {
            Ligacao objeto = null;
            try
            {
                AbrirConexao();
                oDR = LerBanco(SQLSelLista(vPais1ID));
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

        public void Ins(Ligacao vLigacao)
        {
            try
            {
                AbrirConexao();
                string comandoSQL = SQLIns(vLigacao);
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

        public void Del(Int16 vLigacaoID)
        {
            try
            {
                AbrirConexao();
                ExecutarSQL(SQLDel(vLigacaoID));
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                FecharConexao();
            }
        }

        public bool ExisteLigacao(Int16 vPaisID)
        {
            bool existe = false;
            try
            {
                AbrirConexao();
                oDR = LerBanco(SQLExisteLigacao(vPaisID));
                while (oDR.Read())
                {
                    Int16 total = Convert.ToInt16(oDR["TOTAL"]);
                    if(total > 0)
                    {
                        existe = true;
                    }
                }
            }
            catch(Exception ex)
            {
                FecharConexao();
            }
            return existe;
        }

        public List<Int16> ListaRelacionados(Int16 vPaisID)
        {
            List<Int16> listaFinal = new List<short>();
            List<Ligacao> listaLigacoes = SelLista(vPaisID);
            foreach(Ligacao iLigacao in listaLigacoes)
            {
                if(vPaisID == iLigacao.PaisID1)
                {
                    listaFinal = IncluiRelacionado(listaFinal, iLigacao.PaisID2);
                }
                else
                {
                    listaFinal = IncluiRelacionado(listaFinal, iLigacao.PaisID1);
                }
            }
            return listaFinal;
        }

        private string SQLSelLista(Int16 vPais1ID)
        {
            oSB.Length = 0;
            oSB.AppendLine("SELECT LIGACAO.ID, PAIS.ID AS ID1");
            oSB.AppendLine(", PAIS.NOME AS NOME1");
            oSB.AppendLine(", LIGACAO.TIPO");
            oSB.AppendLine(", PAIS_1.ID AS ID2");
            oSB.AppendLine(", PAIS_1.NOME AS NOME2 ");
            oSB.AppendLine(" FROM (PAIS INNER JOIN LIGACAO ON PAIS.ID = LIGACAO.PAIS_1)");
            oSB.AppendLine("         INNER JOIN PAIS AS PAIS_1 ON LIGACAO.PAIS_2 = PAIS_1.ID");
            oSB.AppendLine( "WHERE (PAIS.ID = " + vPais1ID);
            oSB.AppendLine(" OR PAIS_1.ID =  " + vPais1ID + ") ");
            oSB.AppendLine(" ORDER BY LIGACAO.ORDEM");
            return oSB.ToString();
        }

        private string SQLSelProximos(Int16 vPaisID)
        {
            oSB.Length = 0;
            oSB.AppendLine("");
            oSB.AppendLine("");
            oSB.AppendLine("");
            oSB.AppendLine("");
            return oSB.ToString();
        }

        private string SQLIns(Ligacao vLigacao)
        {
            oSB.Length = 0;
            oSB.AppendLine("INSERT INTO LIGACAO (");
            oSB.AppendLine("PAIS_1");
            oSB.AppendLine(",PAIS_2");
            oSB.AppendLine(",TIPO");
            oSB.AppendLine(") VALUES (");
            oSB.AppendLine(vLigacao.PaisID1.ToString());
            oSB.AppendLine("," + vLigacao.PaisID2.ToString());
            oSB.AppendLine("," + (Int16)vLigacao.Tipo);
            oSB.AppendLine(")");
            return oSB.ToString();
        }

        private string SQLDel(Int16 vLigacaoID)
        {
            oSB.Length = 0;
            oSB.AppendLine("DELETE FROM LIGACAO ");
            oSB.AppendLine("WHERE ID = " + vLigacaoID);
            return oSB.ToString();
        }

        private string SQLExisteLigacao(Int16 vPaisID)
        {
            oSB.Length = 0;
            oSB.AppendLine("SELECT COUNT(ID) AS TOTAL ");
            oSB.AppendLine("FROM LIGACAO ");
            oSB.AppendLine("WHERE PAIS_1 = " + vPaisID.ToString() + " ");
            oSB.AppendLine("   OR PAIS_2 = " + vPaisID.ToString() + " ");
            return oSB.ToString();
        }

        private Ligacao MontaObjeto(System.Data.OleDb.OleDbDataReader oDR)
        {
            Ligacao objeto = new Ligacao();
            objeto.ID = Convert.ToInt16(oDR["ID"]);
            objeto.PaisID1 = Convert.ToInt16(oDR["ID1"]);
            objeto.Nome1 = Convert.ToString(oDR["NOME1"]);
            objeto.PaisID2 = Convert.ToInt16(oDR["ID2"]);
            objeto.Nome2 = Convert.ToString(oDR["NOME2"]);
            objeto.Tipo = (TipoLigacao)Convert.ToInt16(oDR["TIPO"]);
            return objeto;
        }

        private List<Int16> IncluiRelacionado(List<Int16> vListaRelacionados, Int16 vPaisID)
        {
            if (!(vListaRelacionados.Contains(vPaisID)))
            {
                vListaRelacionados.Add(vPaisID);
            }
            return vListaRelacionados;
        }

    }
}
