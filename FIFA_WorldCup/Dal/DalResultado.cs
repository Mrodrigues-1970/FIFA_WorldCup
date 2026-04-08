using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FIFA_WorldCup.Entidades;

namespace FIFA_WorldCup.Dal
{
    public class DalResultado : DalBase
    {


        public ResultadoCopa Sel(Int16 vCopaID)
        {
            ResultadoCopa oResultado = null;
            try
            {
                AbrirConexao();
                oDR = LerBanco(SQLSel(vCopaID));
                oResultado = MontaResultado(oDR);
            } catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                FecharConexao();
            }
            return oResultado;
        }

        public List<Conquista> SelConquistas(Int16 vPaisID)
        {
            List<Conquista> Conquistas = new List<Conquista>();
            try
            {
                AbrirConexao();
                oDR = LerBanco(SQLSelConquistas(vPaisID));
                while (oDR.Read())
                {
                    Conquista oConquista = MontaConquista(oDR);
                    Conquistas.Add(oConquista);
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
            return Conquistas;
        }

        public void Salvar(ResultadoCopa vResultado)
        {
            try
            {
                AbrirConexao();
                //Limpar registros desta copa
                ExecutarSQL(SQLLimpa(vResultado.CopaID));
                //Inserir Campeão
                ExecutarSQL(SQLIns(vResultado.CopaID, PosicaoResultado.Campeao, vResultado.Posicao1_ID));
                //Inserir ViceCampeão
                ExecutarSQL(SQLIns(vResultado.CopaID, PosicaoResultado.ViceCampeao, vResultado.Posicao2_ID));
                //Inserir 3º lugar
                ExecutarSQL(SQLIns(vResultado.CopaID, PosicaoResultado.TerceiroLugar, vResultado.Posicao3_ID));
                //Inserir 4º lugar
                ExecutarSQL(SQLIns(vResultado.CopaID, PosicaoResultado.QuartoLugar, vResultado.Posicao4_ID));
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
            oSB.AppendLine("SELECT RESULTADO.Posicao, RESULTADO.Pais_ID, PAIS.NOME,RESULTADO.COPA_ID ");
            oSB.AppendLine("FROM PAIS INNER JOIN RESULTADO ON PAIS.ID = RESULTADO.Pais_ID ");
            oSB.AppendLine("WHERE RESULTADO.COPA_ID = " + vCopaID + " ");
            oSB.AppendLine("ORDER BY RESULTADO.Posicao ");
            return oSB.ToString();
        }

        private string SQLLimpa(Int16 vCopaID)
        {
            oSB.Length = 0;
            oSB.AppendLine("DELETE FROM RESULTADO WHERE COPA_ID = " + vCopaID);
            return oSB.ToString();
        }

        private string SQLIns(Int16 vCopaID, PosicaoResultado vPosicao, Int16 vPais_ID)
        {
            oSB.Length = 0;
            oSB.AppendLine("INSERT INTO RESULTADO ");
            oSB.AppendLine("(COPA_ID, Posicao, Pais_ID) ");
            oSB.AppendLine(" VALUES (");
            oSB.AppendLine(vCopaID + ", ");
            oSB.AppendLine(Convert.ToInt16(vPosicao) + ", ");
            oSB.AppendLine(vPais_ID + " ");
            oSB.AppendLine(")");
            return oSB.ToString();
        }
        
        private string SQLSelConquistas(Int16 vPais_ID)
        {
            oSB.Length = 0;
            oSB.AppendLine("SELECT COPA.ANO, COPA.COMPETICAO ");
            oSB.AppendLine("FROM COPA INNER JOIN RESULTADO ON COPA.ID = RESULTADO.Copa_ID ");
            oSB.AppendLine("WHERE (((RESULTADO.Pais_ID) = " + vPais_ID + ") AND ((RESULTADO.Posicao) = 1)) ");
            oSB.AppendLine("ORDER BY COPA.COMPETICAO, COPA.ANO ");
            return oSB.ToString();
        }

        private ResultadoCopa MontaResultado(System.Data.OleDb.OleDbDataReader oDR)
        {
            Int16 posicao;
            ResultadoCopa objeto = new ResultadoCopa();
            while (oDR.Read())
            {

                objeto.CopaID = Convert.ToInt16(oDR["COPA_ID"]);

                posicao = Convert.ToInt16( oDR["posicao"] );
                switch (posicao)
                {
                    case 1:
                        objeto.Posicao1_ID = Convert.ToInt16(oDR["Pais_ID"]);
                        objeto.Posicao1_nome = (string)oDR["NOME"];
                        break;

                    case 2:
                        objeto.Posicao2_ID = Convert.ToInt16(oDR["Pais_ID"]);
                        objeto.Posicao2_nome = (string)oDR["NOME"];
                        break;

                    case 3:
                        objeto.Posicao3_ID = Convert.ToInt16(oDR["Pais_ID"]);
                        objeto.Posicao3_nome = (string)oDR["NOME"];
                        break;

                    case 4:
                        objeto.Posicao4_ID = Convert.ToInt16(oDR["Pais_ID"]);
                        objeto.Posicao4_nome = (string)oDR["NOME"];
                        break;
                }

            }
            return objeto;
        }

        private Conquista MontaConquista(System.Data.OleDb.OleDbDataReader oDR)
        {
            Conquista objeto = new Conquista();
            objeto.Ano = Convert.ToInt16(oDR["ANO"]);
            objeto.Competicao = (Competicao)Convert.ToInt16(oDR["COMPETICAO"]);
            return objeto;
        }

    }
}
