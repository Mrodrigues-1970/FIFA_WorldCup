using FIFA_WorldCup.Entidades;
using FIFA_WorldCup.RN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIFA_WorldCup.Dal
{
    public class DalDtoGrupoCopa : DalBase 
    {

        public List<dtoGrupoCopa> Sel(Int16 vCopaID, Int16 vTipoFase)
        {
            List<dtoGrupoCopa> lista;
            dtoGrupoCopa objeto;
            try
            {
                lista = new List<dtoGrupoCopa>();
                AbrirConexao();
                oDR = LerBanco(SQLSel(vCopaID, vTipoFase));
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

        private string SQLSel(Int16 vCopaID, Int16 vTipoFase)
        {
            oSB.Length = 0;
            oSB.AppendLine("SELECT * FROM (");
            oSB.AppendLine("    SELECT GRUPO.ID AS GRUPO_ID, GRUPO.NOME AS GRUPO, PARTIDA.SELECAO_A AS PAIS_ID, PAIS.NOME AS PAIS, PAIS.RANK ");
            oSB.AppendLine("      FROM PAIS INNER JOIN (GRUPO INNER JOIN PARTIDA ON GRUPO.ID = PARTIDA.GRUPO_ID) ON PAIS.ID = PARTIDA.SELECAO_A ");
            oSB.AppendLine("     WHERE (((GRUPO.COPA_ID)=" + vCopaID + ") AND ((GRUPO.TIPO_FASE_ID) = " + vTipoFase + ")) ");
            oSB.AppendLine("UNION ");
            oSB.AppendLine("    SELECT GRUPO.ID AS GRUPO_ID, GRUPO.NOME AS GRUPO, PARTIDA.SELECAO_B AS PAIS_ID, PAIS.NOME AS PAIS, PAIS.RANK ");
            oSB.AppendLine("      FROM PAIS INNER JOIN (GRUPO INNER JOIN PARTIDA ON GRUPO.ID = PARTIDA.GRUPO_ID) ON PAIS.ID = PARTIDA.SELECAO_B ");
            oSB.AppendLine("     WHERE (((GRUPO.COPA_ID)=" + vCopaID + ") AND ((GRUPO.TIPO_FASE_ID) = " + vTipoFase + ")) ");
            oSB.AppendLine(") AA ");
            oSB.AppendLine("ORDER BY AA.GRUPO, AA.RANK");
            return oSB.ToString();
        }

        /*
         
SELECT * FROM (
	SELECT GRUPO.ID AS GRUPO_ID, GRUPO.NOME AS GRUPO, PARTIDA.SELECAO_A AS PAIS_ID, PAIS.NOME AS PAIS, PAIS.RANK
	FROM PAIS INNER JOIN (GRUPO INNER JOIN PARTIDA ON GRUPO.ID = PARTIDA.GRUPO_ID) ON PAIS.ID = PARTIDA.SELECAO_A
	WHERE (((GRUPO.COPA_ID)=1) AND ((GRUPO.TIPO_FASE_ID)=1))
	UNION
	SELECT GRUPO.ID AS GRUPO_ID, GRUPO.NOME AS GRUPO, PARTIDA.SELECAO_B AS PAIS_ID, PAIS.NOME AS PAIS, PAIS.RANK
	FROM PAIS INNER JOIN (GRUPO INNER JOIN PARTIDA ON GRUPO.ID = PARTIDA.GRUPO_ID) ON PAIS.ID = PARTIDA.SELECAO_B
	WHERE (((GRUPO.COPA_ID)=1) AND ((GRUPO.TIPO_FASE_ID)=1))
) AA
ORDER BY AA.GRUPO, AA.RANK         
         
         */

        private dtoGrupoCopa MontaObjeto(System.Data.OleDb.OleDbDataReader oDR)
        {
            dtoGrupoCopa objeto = new dtoGrupoCopa();
            objeto.Grupo_ID = Convert.ToInt16(oDR["GRUPO_ID"]);
            objeto.Grupo = Convert.ToString(oDR["GRUPO"]);
            objeto.Pais_ID = Convert.ToInt16(oDR["PAIS_ID"]);
            objeto.Pais = Convert.ToString(oDR["PAIS"]);
            objeto.Rank = Convert.ToInt16(oDR["RANK"]);
            return objeto;
        }


    }
}
