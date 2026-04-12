using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FIFA_WorldCup.Entidades;

namespace FIFA_WorldCup.Dal
{
    public class DalPosicaoGrupo : DalBase
    {

        public List<PosicaoGrupo> Sel(Int16 GrupoID)
        {
            List<PosicaoGrupo> lista;
            PosicaoGrupo objeto;
            try
            {
                lista = new List<PosicaoGrupo>();
                AbrirConexao();
                oDR = LerBanco(SQLSel(GrupoID));
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


        public void InserirPosicoes(List<PosicaoGrupo> lista)
        {
            try
            {
                AbrirConexao();
                if (lista.Count > 0)
                {
                    ExecutarSQL(SQLLimpa(lista[0].GrupoID));
                    foreach (PosicaoGrupo oPosicao in lista)
                    {
                        ExecutarSQL(SQLIns(oPosicao));
                    }
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
        }


        private string SQLLimpa(Int16 vGrupoID)
        {
            oSB.Length = 0;
            oSB.Append("DELETE FROM POSICAO_GRUPO ");
            oSB.Append("WHERE GRUPO_ID = " + vGrupoID.ToString());
            return oSB.ToString();
        }

        private string SQLIns(PosicaoGrupo oPosicao)
        {
            oSB.Length = 0;
            oSB.Append("INSERT INTO POSICAO_GRUPO (GRUPO_ID, POSICAO, PAIS_ID) ");
            oSB.Append("VALUES (" + oPosicao.GrupoID.ToString() + ", " + oPosicao.Posicao.ToString() + ", " + oPosicao.PaisID.ToString() + ") ");
            return oSB.ToString();
        }


        private string SQLSel(Int16 GrupoID)
        {
            oSB.Length = 0;
            oSB.Append("SELECT POSICAO_GRUPO.GRUPO_ID, ");
            oSB.Append("       POSICAO_GRUPO.POSICAO, ");
            oSB.Append("       POSICAO_GRUPO.PAIS_ID, ");
            oSB.Append("       PAIS.NOME ");
            oSB.Append("  FROM PAIS INNER JOIN POSICAO_GRUPO ON PAIS.ID = POSICAO_GRUPO.PAIS_ID ");
            oSB.Append(" WHERE POSICAO_GRUPO.GRUPO_ID = " + GrupoID + " ");
            oSB.Append(" ORDER BY POSICAO_GRUPO.POSICAO");
            return oSB.ToString();
        }

        private PosicaoGrupo MontaObjeto(System.Data.OleDb.OleDbDataReader oDR)
        {
            PosicaoGrupo oPosicao = new PosicaoGrupo();
            oPosicao.GrupoID = Convert.ToInt16(oDR["GRUPO_ID"]);
            oPosicao.Posicao = Convert.ToInt16(oDR["POSICAO"]);
            oPosicao.PaisID = Convert.ToInt16(oDR["PAIS_ID"]);
            oPosicao.NomePais = oDR["NOME"].ToString();
            return oPosicao;
        }

    }
}
