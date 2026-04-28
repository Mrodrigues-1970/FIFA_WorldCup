using FIFA_WorldCup.Entidades;
using FIFA_WorldCup.RN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIFA_WorldCup.Dal
{
    public class DalCidade : DalBase
    {

        public List<Cidade> Sel(Cidade vCidade)
        {
            List<Cidade> lstCidade = new List<Cidade>();
            Cidade objeto;
            try
            {
                AbrirConexao();
                oDR = LerBanco(SQLSel(vCidade));
                while (oDR.Read())
                {
                    objeto = MontaObjeto(oDR);
                    lstCidade.Add(objeto);
                }
                oDR.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao obter as cidades: " + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
            return lstCidade;
        }

        public void Ins(Cidade oCidade)
        {
            try
            {
                AbrirConexao();
                ExecutarSQL(SQLIns(oCidade));
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao inserir a cidade: " + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }   

        public void Upd(Cidade oCidade)
        {
            try
            {
                AbrirConexao();
                ExecutarSQL(SQLUpd(oCidade));
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao atualizar a cidade: " + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }


        private string SQLIns(Cidade oCidade)
        {
            oSB.Length = 0;
            oSB.Append("INSERT INTO CIDADE (PAIS_ID, Nome, NOME_INGLES) ");
            oSB.Append("VALUES (");
            oSB.Append(oCidade.PaisID.ToString() + ", ");
            oSB.Append("'" + oCidade.Nome + "', ");
            oSB.Append("'" + oCidade.NomeIngles + "')");
            return oSB.ToString();
        }

        private string SQLUpd(Cidade oCidade)
        {
            oSB.Length = 0;
            oSB.Append("UPDATE CIDADE SET ");
            oSB.Append("PAIS_ID = " + oCidade.PaisID.ToString() + ", ");
            oSB.Append("NOME = '" + oCidade.Nome + "', ");
            oSB.Append("NOME_INGLES = '" + oCidade.NomeIngles + "' ");
            oSB.Append("WHERE ID = " + oCidade.ID.ToString());
            return oSB.ToString();
        }

        private string SQLSel(Cidade oCidade)
        {
            oSB.Length = 0;
            oSB.Append("SELECT ID, PAIS_ID, NOME, NOME_INGLES ");
            oSB.Append("FROM CIDADE ");
            oSB.Append("WHERE 1 = 1 ");
            if (oCidade.ID > 0)
            {
                oSB.Append("AND ID = " + oCidade.ID.ToString() + " ");
            }
            if (oCidade.PaisID > 0)
            {
                oSB.Append("AND PAIS_ID = " + oCidade.PaisID.ToString() + " ");
            }
            oSB.Append("ORDER BY Nome");
            return oSB.ToString();
        }

        private Cidade MontaObjeto(System.Data.OleDb.OleDbDataReader oDR)
        {
            Cidade oCidade = new Cidade();
            oCidade.ID = Convert.ToInt16(oDR["ID"]);
            oCidade.PaisID = Convert.ToInt16(oDR["PAIS_ID"]);
            oCidade.Nome = oDR["Nome"].ToString();
            oCidade.NomeIngles = oDR["NOME_INGLES"].ToString();
            return oCidade;
        }




    }
}
