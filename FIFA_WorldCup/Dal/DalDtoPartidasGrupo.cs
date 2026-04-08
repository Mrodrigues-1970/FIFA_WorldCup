using FIFA_WorldCup.Entidades;
using FIFA_WorldCup.Forms;
using FIFA_WorldCup.RN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIFA_WorldCup.Dal
{
    public class DalDtoPartidasGrupo: DalBase
    {


        public List<dtoPartidasGrupo> Sel(Int16 vCopaID, string vGrupo)
        {
            List<dtoPartidasGrupo> lista;
            dtoPartidasGrupo objeto;
            try
            {
                lista = new List<dtoPartidasGrupo>();
                AbrirConexao();
                oDR = LerBanco(SQLSel(vCopaID, vGrupo));
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

        /*
SELECT GRUPO.ID, GRUPO.NOME, PARTIDA.DATA, PAIS.NOME AS PAIS_A, PARTIDA.GOLS_A, PAIS_1.NOME AS PAIS_B, PARTIDA.GOLS_B
FROM PAIS AS PAIS_1 
INNER JOIN (PAIS 
INNER JOIN ((COPA 
INNER JOIN GRUPO ON COPA.ID = GRUPO.COPA_ID) 
INNER JOIN PARTIDA ON GRUPO.ID = PARTIDA.GRUPO_ID) 
ON PAIS.ID = PARTIDA.SELECAO_A) 
ON PAIS_1.ID = PARTIDA.SELECAO_B
WHERE COPA.ID = 1 
AND GRUPO.NOME = 'GRUPO 1'
ORDER BY PARTIDA.DATA
        */
        private string SQLSel(Int16 vCopaID, string vGrupo)
        {
            //TODO incluir local da partida quando a tabela estiver preenchida
            oSB.Length = 0;
            oSB.AppendLine("SELECT GRUPO.ID, GRUPO.NOME, PARTIDA.DATA, PAIS.NOME AS PAIS_A, PARTIDA.GOLS_A, PAIS_1.NOME AS PAIS_B, PARTIDA.GOLS_B, PAIS.ID AS PaisID_A, PAIS_1.ID AS PaisID_B ");
            oSB.AppendLine("FROM PAIS AS PAIS_1 ");
            oSB.AppendLine("INNER JOIN (PAIS ");
            oSB.AppendLine("INNER JOIN ((COPA ");
            oSB.AppendLine("INNER JOIN GRUPO ON COPA.ID = GRUPO.COPA_ID) ");
            oSB.AppendLine("INNER JOIN PARTIDA ON GRUPO.ID = PARTIDA.GRUPO_ID) ");
            oSB.AppendLine("ON PAIS.ID = PARTIDA.SELECAO_A) ");
            oSB.AppendLine("ON PAIS_1.ID = PARTIDA.SELECAO_B ");
            oSB.AppendLine("WHERE COPA.ID = " + vCopaID + " ");
            oSB.AppendLine("AND GRUPO.NOME = '" + vGrupo + "' ");
            oSB.AppendLine("ORDER BY PARTIDA.DATA");
            return oSB.ToString();
        }

        private dtoPartidasGrupo MontaObjeto(System.Data.OleDb.OleDbDataReader oDR)
        {
            dtoPartidasGrupo objeto = new dtoPartidasGrupo();
            objeto.Grupo_ID = Convert.ToInt16(oDR["ID"]);
            objeto.Grupo_Nome = Convert.ToString(oDR["NOME"]);
            objeto.Data = Convert.ToDateTime(oDR["DATA"]);

            objeto.Pais_A = Convert.ToString(oDR["PAIS_A"]);
            objeto.PaisID_A = Convert.ToInt16(oDR["PaisID_A"]);
            objeto.Gols_A = Convert.ToInt16(oDR["GOLS_A"]);
            
            objeto.Pais_B = Convert.ToString(oDR["PAIS_B"]);
            objeto.PaisID_B = Convert.ToInt16(oDR["PaisID_B"]);
            objeto.Gols_B = Convert.ToInt16(oDR["GOLS_B"]);
            return objeto;
        }

    }
}
