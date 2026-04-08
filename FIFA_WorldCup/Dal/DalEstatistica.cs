using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FIFA_WorldCup.Entidades;

namespace FIFA_WorldCup.Dal
{
    public class DalEstatistica : DalBase
    {
        public Estatistica EstatisticasDoPais(Int16 vPaisID, Competicao vCompeticao)
        {
            Estatistica oStat = new Estatistica();
            oStat.PaisID = vPaisID;
            List<Int16> listaCopas = new List<Int16>();
            
            List<Partida> lista = BuscaListaPartidas(vPaisID, vCompeticao);
            //percorre as partidas
            foreach (Partida iPartida in lista)
            {
                oStat.NumeroPartidas += 1;

                Int16 Ano = (Int16)iPartida.Data.Year;
                if (!(listaCopas.Contains(Ano)))
                {
                    listaCopas.Add(Ano);
                }

                //Número de Empates
                if (iPartida.Gols_A == iPartida.Gols_B)
                {
                    oStat.NumeroEmpates += 1;
                }

                //Pais é time A
                if (iPartida.SelecaoID_A == vPaisID)
                {
                    oStat.GolsMarcados += iPartida.Gols_A;
                    oStat.GolsSofridos += iPartida.Gols_B;
                    //foi vitória?
                    if (iPartida.Gols_A > iPartida.Gols_B)
                    {
                        oStat.NumeroVitorias += 1;
                    }
                    //foi derrota?
                    if (iPartida.Gols_A < iPartida.Gols_B)
                    {
                        oStat.NumeroDerrotas += 1;
                    }
                }
                else //ou é time B
                {
                    oStat.GolsMarcados += iPartida.Gols_B;
                    oStat.GolsSofridos += iPartida.Gols_A;
                    //foi vitória?
                    if (iPartida.Gols_A < iPartida.Gols_B)
                    {
                        oStat.NumeroVitorias += 1;
                    }
                    //foi derrota?
                    if (iPartida.Gols_A > iPartida.Gols_B)
                    {
                        oStat.NumeroDerrotas += 1;
                    }
                }
            }

            //cálculos pós loop
            oStat.PontuacaoGeral = Convert.ToInt16((oStat.NumeroVitorias * 3) + oStat.NumeroEmpates);
            oStat.Copas = listaCopas;
            return oStat;
        }

        public List<ConfrontoPais> ListaDeConfrontos(Int16 vPaisID, Competicao vCompeticao)
        {
            List<ConfrontoPais> listaConfrontos = new List<ConfrontoPais>();
            try
            {
                List<Partida> listaPartida = BuscaListaPartidas(vPaisID, vCompeticao);
                //percorre as partidas
                foreach (Partida iPartida in listaPartida)
                {
                    ConfrontoPais oConfronto = new ConfrontoPais();
                    oConfronto.Competicao = vCompeticao;
                    if (iPartida.SelecaoID_A == vPaisID)
                    {
                        //Pais é seleção A                        
                        oConfronto.AdversarioID = iPartida.SelecaoID_B;
                        oConfronto.NomeAdversario = iPartida.NomePaisB;
                        oConfronto.GolsMarcados = iPartida.Gols_A;
                        oConfronto.GolsSofridos = iPartida.Gols_B;
                        oConfronto.ConfederacaoAdversario = iPartida.ConfederacaoB;

                        if (iPartida.Gols_A == iPartida.Gols_B)
                        {
                            oConfronto.Empates += 1;
                        }
                        else
                        {
                            if (iPartida.Gols_A > iPartida.Gols_B)
                            {
                                oConfronto.Vitorias += 1;
                            }
                            else
                            {
                                oConfronto.Derrotas += 1;
                            }
                        }
                    }
                    else
                    {
                        //Pais é seleção B
                        oConfronto.AdversarioID = iPartida.SelecaoID_A;
                        oConfronto.NomeAdversario = iPartida.NomePaisA;
                        oConfronto.GolsMarcados = iPartida.Gols_B;
                        oConfronto.GolsSofridos = iPartida.Gols_A;
                        oConfronto.ConfederacaoAdversario = iPartida.ConfederacaoA;

                        if (iPartida.Gols_A == iPartida.Gols_B)
                        {
                            oConfronto.Empates += 1;
                        }
                        else
                        {
                            if (iPartida.Gols_A < iPartida.Gols_B)
                            {
                                oConfronto.Vitorias += 1;
                            }
                            else
                            {
                                oConfronto.Derrotas += 1;
                            }
                        }
                    }
                    listaConfrontos.Add(oConfronto);                    
                }                
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return listaConfrontos;
        }

        private List<Partida> BuscaListaPartidas(Int16 vPaisID, Competicao vCompeticao)
        {
            List<Partida> lista;
            Partida objeto;
            try
            {
                lista = new List<Partida>();
                AbrirConexao();
                oDR = LerBanco(SQLPartidasDoPais(vPaisID, vCompeticao));
                while (oDR.Read())
                {
                    objeto = MontaPartida(oDR);
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

        private string SQLPartidasDoPais(Int16 vPais_ID, Competicao vCompeticao)
        {
            oSB.Length = 0;            
            oSB.AppendLine("SELECT COPA.COMPETICAO, ");
            oSB.AppendLine("COPA.ID AS COPA_ID, ");
            oSB.AppendLine("COPA.NOME AS COPA_NOME, ");
            oSB.AppendLine("PARTIDA.ID AS PARTIDA_ID, ");
            oSB.AppendLine("PARTIDA.DATA, ");
            oSB.AppendLine("PARTIDA.GRUPO_ID, ");
            oSB.AppendLine("PARTIDA.SELECAO_A, ");
            oSB.AppendLine("PAIS.CONFEDERACAO_ID AS CONFEDERACAO_A, ");
            oSB.AppendLine("PARTIDA.SELECAO_B, ");
            oSB.AppendLine("PAIS_1.CONFEDERACAO_ID AS CONFEDERACAO_B, ");
            oSB.AppendLine("PARTIDA.GOLS_A, ");
            oSB.AppendLine("PARTIDA.GOLS_B, ");
            oSB.AppendLine("PAIS.NOME AS SELECAO1, ");
            oSB.AppendLine("PAIS_1.NOME AS SELECAO2 ");
            oSB.AppendLine("FROM COPA ");
            oSB.AppendLine("        INNER JOIN (GRUPO ");
            oSB.AppendLine("                        INNER JOIN (PAIS AS PAIS_1 ");
            oSB.AppendLine("                                                  INNER JOIN (PAIS ");
            oSB.AppendLine("                                                                  INNER JOIN PARTIDA ON PAIS.ID = PARTIDA.SELECAO_A) ");
            oSB.AppendLine("                                                  ON PAIS_1.ID = PARTIDA.SELECAO_B) ");
            oSB.AppendLine("                        ON GRUPO.ID = PARTIDA.GRUPO_ID) ");
            oSB.AppendLine("        ON COPA.ID = GRUPO.COPA_ID");
            oSB.AppendLine(" WHERE (  (((PARTIDA.SELECAO_A) = " + vPais_ID + ")) ");
            oSB.AppendLine("          OR ");
            oSB.AppendLine("       (((PARTIDA.SELECAO_B) = " + vPais_ID + "))      ) ");
            oSB.AppendLine("AND  COPA.COMPETICAO = " + Convert.ToInt16(vCompeticao) + " ");
            oSB.AppendLine("AND PARTIDA.DATA < Date() + 1 ");
            oSB.AppendLine("ORDER BY COPA.COMPETICAO, COPA.ID");
            return oSB.ToString();
        }

        private Partida MontaPartida(System.Data.OleDb.OleDbDataReader oDR)
        {
            Partida obj = new Partida();
            obj.ID = Convert.ToInt16(oDR["PARTIDA_ID"]);
            obj.CopaID = Convert.ToInt16(oDR["COPA_ID"]);
            obj.CopaNome = (string)oDR["COPA_NOME"];
            obj.Competicao = (Competicao)Convert.ToInt16(oDR["COMPETICAO"]);
            obj.Data = Convert.ToDateTime(oDR["DATA"]);
            obj.Gols_A = Convert.ToInt16(oDR["GOLS_A"]);
            obj.Gols_B = Convert.ToInt16(oDR["GOLS_B"]);
            obj.GrupoID = Convert.ToInt16(oDR["GRUPO_ID"]);
            obj.NomePaisA = (string)oDR["SELECAO1"];
            obj.ConfederacaoA = (Confederacao)oDR["CONFEDERACAO_A"];
            obj.NomePaisB = (string)oDR["SELECAO2"];
            obj.ConfederacaoB = (Confederacao)oDR["CONFEDERACAO_B"];
            obj.SelecaoID_A = Convert.ToInt16(oDR["SELECAO_A"]);
            obj.SelecaoID_B = Convert.ToInt16(oDR["SELECAO_B"]);
            return obj;
        }


        private bool AdversarioEInedito(List<ConfrontoPais> listaConfronto, Int16 AdversarioID)
        {
            bool adversarioEInedito = true;
            foreach(ConfrontoPais iConfronto in listaConfronto)
            {
                if(iConfronto.AdversarioID == AdversarioID)
                {
                    adversarioEInedito = false;
                }
            }

            return adversarioEInedito;
        }



    }
}
