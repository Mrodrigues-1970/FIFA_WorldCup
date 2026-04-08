using FIFA_WorldCup.Entidades;
using FIFA_WorldCup.RN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIFA_WorldCup.Dal
{
    public class DalVagas : DalBase
    {

        public List<VagaMasculino> SelPorCopa(Int16 Copa_ID)
        {
            List<VagaMasculino> lista;
            VagaMasculino objeto;
            try
            {
                lista = new List<VagaMasculino>();
                AbrirConexao();
                oDR = LerBanco(SQLSelPorCopa(Copa_ID));
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

        public List<Confederacao> ConfederacoesUsadas(Int16 Copa_ID)
        {
            List<Confederacao> lista;
            try
            {
                lista = new List<Confederacao>();
                AbrirConexao();
                oDR = LerBanco(SQLConfederacoesUsadas(Copa_ID));
                while (oDR.Read())
                {
                    lista.Add((Confederacao)Convert.ToInt16(oDR["CONFEDERACAO"]));
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

        public VagaMasculino Sel(Int16 Copa_ID, Confederacao Confederacao)
        {
            VagaMasculino objeto = null;
            try
            {
                AbrirConexao();
                oDR = LerBanco(SQLSel(Copa_ID, Confederacao));
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

        public void Ins(VagaMasculino vVaga)
        {
            try
            {
                AbrirConexao();
                ExecutarSQL(SQLIns(vVaga));
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

        public void Upd(VagaMasculino vVaga)
        {
            try
            {
                AbrirConexao();
                ExecutarSQL(SQLUpd(vVaga));
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

        private string SQLSelPorCopa(Int16 Copa_ID)
        {
            oSB.Length = 0;
            oSB.AppendLine("SELECT COPA_ID, CONFEDERACAO, VAGAS_DIRETAS, VAGAS_REPESCAGEM, TOTAL_CANDIDATOS ");
            oSB.AppendLine("FROM VAGAS ");
            oSB.AppendLine(" WHERE COPA_ID = " + Copa_ID);
            return oSB.ToString();
        }

        private string SQLSel(Int16 CopaID, Confederacao Confederacao)
        {
            oSB.Length = 0;
            oSB.AppendLine("SELECT COPA_ID, CONFEDERACAO, VAGAS_DIRETAS, VAGAS_REPESCAGEM, TOTAL_CANDIDATOS ");
            oSB.AppendLine("FROM VAGAS ");
            oSB.AppendLine(" WHERE COPA_ID = " + CopaID);
            oSB.AppendLine(" AND CONFEDERACAO = " + Convert.ToInt16(Confederacao) );
            return oSB.ToString();
        }

        private string SQLIns(VagaMasculino vVaga)
        {
            oSB.Length = 0;
            oSB.AppendLine("INSERT INTO VAGAS (COPA_ID, CONFEDERACAO, VAGAS_DIRETAS, VAGAS_REPESCAGEM, TOTAL_CANDIDATOS ) ");
            oSB.AppendLine("VALUES (");
            oSB.AppendLine(" " + vVaga.CopaID + ", ");
            oSB.AppendLine(" " + Convert.ToInt16(vVaga.Confederacao) + ", ");
            oSB.AppendLine(" " + vVaga.VagasDiretas + ", ");
            oSB.AppendLine(" " + vVaga.VagasRepescagem + ", ");
            oSB.AppendLine(" " + vVaga.TotalCandidatos + ") ");
            return oSB.ToString();
        }

        private string SQLUpd(VagaMasculino vVaga)
        {
            oSB.Length = 0;
            oSB.AppendLine("UPDATE VAGAS SET ");
            oSB.AppendLine(" CONFEDERACAO = " + Convert.ToInt16(vVaga.Confederacao) + ", ");
            oSB.AppendLine(" VAGAS_DIRETAS = " + vVaga.VagasDiretas + ", ");
            oSB.AppendLine(" VAGAS_REPESCAGEM = " + vVaga.VagasRepescagem + ", ");
            oSB.AppendLine(" TOTAL_CANDIDATOS = " + vVaga.TotalCandidatos + " ");
            oSB.AppendLine("WHERE COPA_ID = " + vVaga.CopaID + " AND CONFEDERACAO = " + Convert.ToInt16(vVaga.Confederacao));
            return oSB.ToString();
        }

        private string SQLConfederacoesUsadas(Int16 vCopa_ID)
        {
            oSB.Length = 0;
            oSB.AppendLine("SELECT CONFEDERACAO ");
            oSB.AppendLine("FROM VAGAS ");
            oSB.AppendLine("WHERE COPA_ID = " + vCopa_ID + " ");
            return oSB.ToString();
        }

        private VagaMasculino MontaObjeto(System.Data.OleDb.OleDbDataReader oDR)
        {
            VagaMasculino objeto = new VagaMasculino();
            objeto.CopaID = Convert.ToInt16(oDR["COPA_ID"]);
            objeto.Confederacao = (Confederacao)Convert.ToInt16(oDR["CONFEDERACAO"]);
            objeto.VagasDiretas = Convert.ToDouble(oDR["VAGAS_DIRETAS"]);
            objeto.VagasRepescagem = Convert.ToDouble(oDR["VAGAS_REPESCAGEM"]);
            objeto.TotalCandidatos = Convert.ToInt16(oDR["TOTAL_CANDIDATOS"]);
            return objeto;
        }

    }
}
