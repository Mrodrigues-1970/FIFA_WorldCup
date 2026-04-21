using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FIFA_WorldCup.Entidades;
using FIFA_WorldCup.Dal;

namespace FIFA_WorldCup.RN
{
    public class RNCopa
    {

        public List<Copa> Sel(Copa vCopa)
        {
            DalCopa oDal = new DalCopa();
            return oDal.Sel(vCopa);
        }

        public Copa Sel(Int16 vCopaID)
        {
            DalCopa oDal = new DalCopa();
            Copa oCopa = oDal.Sel(vCopaID);
            return oCopa;
        }

        public string RetornaAnoCopa(Int16 vCopaID)
        {
            Copa oCopa = Sel(vCopaID);
            return oCopa.Ano.ToString();
        }

        public string RetornaNomeCopa(Int16 vCopaID)
        {
            Copa oCopa = Sel(vCopaID);
            return oCopa.Nome;
        }

        public Competicao RetornaTipoCompeticao(Int16 CopaID)
        {
            Copa oCopa = Sel(CopaID);
            return oCopa.Competicao;
        }

        /// <summary>
        /// Verifica se a Copa possui fase nocaute, ou seja, se tem fase de mata-mata.
        /// </summary>
        /// <param name="vCopaID"></param>
        /// <returns></returns>
        public NocauteDisponivel NocauteCopa(Int16 vCopaID)
        {
            NocauteDisponivel resposta = NocauteDisponivel.Nenhum;
            Copa oCopa = Sel(vCopaID);
            switch (oCopa.Competicao)
            {
                //Copa Masculina
                case Competicao.Masculino:
                    switch (oCopa.Ano)
                    {
                        case 1930:
                        case 1950:
                        case 1974:
                        case 1978:
                        case 1982:
                            resposta = NocauteDisponivel.Nenhum;
                            break;

                        case 1934:
                        case 1938:
                        case 1986:
                        case 1990:
                        case 1994:
                        case 1998:
                        case 2002:
                        case 2006:
                        case 2010:
                        case 2014:
                        case 2018:
                        case 2022:
                            resposta = NocauteDisponivel.Oitavas;
                            break;

                        case 2026:
                        case 2030:
                        case 2034:
                        case 2038:
                        case 2042:
                            resposta = NocauteDisponivel.Hexavas;
                            break;

                        case 1954:
                        case 1958:
                        case 1962:
                        case 1966:
                        case 1970:
                            resposta = NocauteDisponivel.Quartas;
                            break;
                    }
                    break;

                //Copa Feminina
                case Competicao.Feminino:
                    switch (oCopa.Ano)
                    {
                        case 1991:
                        case 1995:
                        case 1999:
                        case 2003:
                        case 2007:
                        case 2011:
                            resposta = NocauteDisponivel.Quartas;
                            break;

                        case 2015:
                        case 2019:
                        case 2023:
                        case 2027:
                        case 2031:
                        case 2035:
                        default:
                            resposta = NocauteDisponivel.Oitavas;
                            break;
                    }

                    break;

                //Copa das Confederações
                case Competicao.Confederacoes:
                    resposta = NocauteDisponivel.Nenhum;
                    break;
            }
            return resposta;
        }


        public List<PartidaTreeView> FAKEload()
        {
            List<PartidaTreeView> lista = new List<PartidaTreeView>();
            PartidaTreeView oPartida;
            //preenche a lista com valores nulos
            for (int i = 1; i < 63; i++)
            {
                oPartida = new PartidaTreeView();
                oPartida.SelecaoA = 0;
                oPartida.SelecaoB = 0;
                oPartida.Tipo_Fase = 0;
                oPartida.Ordem = (short)i;
                lista.Add(oPartida);
            }

            #region 16avos

            //jogo 1
            oPartida = lista.ElementAt(0);
            oPartida.SelecaoA = 19;
            oPartida.SelecaoB = 38;
            //jogo 2
            oPartida = lista.ElementAt(1);
            oPartida.SelecaoA = 51;
            oPartida.SelecaoB = 30;
            //jogo 3
            oPartida = lista.ElementAt(2);
            oPartida.SelecaoA = 57;
            oPartida.SelecaoB = 36;
            //jogo 4
            oPartida = lista.ElementAt(3);
            oPartida.SelecaoA = 48;
            oPartida.SelecaoB = 5;
            //jogo 5
            oPartida = lista.ElementAt(4);
            oPartida.SelecaoA = 24;
            oPartida.SelecaoB = 39;
            //jogo 6
            oPartida = lista.ElementAt(5);
            oPartida.SelecaoA = 68;
            oPartida.SelecaoB = 65;
            //jogo 7
            oPartida = lista.ElementAt(6);
            oPartida.SelecaoA = 1;
            oPartida.SelecaoB = 37;
            //jogo 8
            oPartida = lista.ElementAt(7);
            oPartida.SelecaoA = 10;
            oPartida.SelecaoB = 80;
            //jogo 9
            oPartida = lista.ElementAt(8);
            oPartida.SelecaoA = 9;
            oPartida.SelecaoB = 17;
            //jogo 10
            oPartida = lista.ElementAt(9);
            oPartida.SelecaoA = 8;
            oPartida.SelecaoB = 41;
            //jogo 11
            oPartida = lista.ElementAt(10);
            oPartida.SelecaoA = 3;
            oPartida.SelecaoB = 60;
            //jogo 12
            oPartida = lista.ElementAt(11);
            oPartida.SelecaoA = 11;
            oPartida.SelecaoB = 28;
            //jogo 13
            oPartida = lista.ElementAt(12);
            oPartida.SelecaoA = 40;
            oPartida.SelecaoB = 26;
            //jogo 14
            oPartida = lista.ElementAt(13);
            oPartida.SelecaoA = 6;
            oPartida.SelecaoB = 29;
            //jogo 15
            oPartida = lista.ElementAt(14);
            oPartida.SelecaoA = 4;
            oPartida.SelecaoB = 31;
            //jogo 16
            oPartida = lista.ElementAt(15);
            oPartida.SelecaoA = 2;
            oPartida.SelecaoB = 53;

            #endregion

            #region Oitavas

            //jogo 17
            oPartida = lista.ElementAt(16);
            oPartida.SelecaoA = 19;
            oPartida.SelecaoB = 51;
            //jogo 18
            oPartida = lista.ElementAt(17);
            oPartida.SelecaoA = 36;
            oPartida.SelecaoB = 48;
            //jogo 19
            oPartida = lista.ElementAt(18);
            oPartida.SelecaoA = 24;
            oPartida.SelecaoB = 68;
            //jogo 20
            oPartida = lista.ElementAt(19);
            oPartida.SelecaoA = 1;
            oPartida.SelecaoB = 10;
            //jogo 21
            oPartida = lista.ElementAt(20);
            oPartida.SelecaoA = 9;
            oPartida.SelecaoB = 8;
            //jogo 22
            oPartida = lista.ElementAt(21);
            oPartida.SelecaoA = 3;
            oPartida.SelecaoB = 11;
            //jogo 23
            oPartida = lista.ElementAt(22);
            oPartida.SelecaoA = 40;
            oPartida.SelecaoB = 6;
            //jogo 24
            oPartida = lista.ElementAt(23);
            oPartida.SelecaoA = 4;
            oPartida.SelecaoB = 2;

            #endregion

            #region Quartas

            //jogo 25
            oPartida = lista.ElementAt(24);
            oPartida.SelecaoA = 19;
            oPartida.SelecaoB = 48;
            //jogo 26
            oPartida = lista.ElementAt(25);
            oPartida.SelecaoA = 68;
            oPartida.SelecaoB = 1;
            //jogo 27
            oPartida = lista.ElementAt(26);
            oPartida.SelecaoA = 8;
            oPartida.SelecaoB = 11;
            //jogo 28
            oPartida = lista.ElementAt(27);
            oPartida.SelecaoA = 6;
            oPartida.SelecaoB = 2;

            #endregion

            #region Semifinais

            //jogo 29
            oPartida = lista.ElementAt(28);
            oPartida.SelecaoA = 48;
            oPartida.SelecaoB = 1;
            //jogo 30
            oPartida = lista.ElementAt(29);
            oPartida.SelecaoA = 8;
            oPartida.SelecaoB = 2;

            #endregion

            #region Final

            //jogo 31
            oPartida = lista.ElementAt(30);
            oPartida.SelecaoA = 1;
            oPartida.SelecaoB = 8;

            #endregion 

            return lista;
        }

        public List<PartidaTreeView> LoadTreeview(Int16 vCopaID)
        {
            List<PartidaTreeView> lista = new List<PartidaTreeView>();
            PartidaTreeView oPartida;
            //preenche a lista com valores nulos
            for (int i = 1; i < 32; i++)
            {
                oPartida = new PartidaTreeView();
                oPartida.SelecaoA = 0;
                oPartida.SelecaoB = 0;
                oPartida.Tipo_Fase = 0;
                oPartida.Ordem = (short)i;
                lista.Add(oPartida);
            }
            RNPartidaTreeView RN = new RNPartidaTreeView();
            // Para que a apicação funcione DURANTE a Copa, será necessário comparar a data da partido com a data de hoje
            List<PartidaTreeView> listaDoBanco = RN.Sel(vCopaID);

            for (int i = 0; i <= 32; i++)
            {
                if (listaDoBanco.Count > i && listaDoBanco.ElementAt(i).DataPartida < DateTime.Today)
                {
                    lista.ElementAt(i).SelecaoA = listaDoBanco.ElementAt(i).SelecaoA;
                    lista.ElementAt(i).SelecaoB = listaDoBanco.ElementAt(i).SelecaoB;
                }

            }


            
            //#region 16avos (0 - 15)

            //if (listaDoBanco.Count > 0 && listaDoBanco.ElementAt(0).DataPartida > DateTime.Today)
            //{
            //    lista.ElementAt(0).SelecaoA = listaDoBanco.ElementAt(0).SelecaoA;
            //    lista.ElementAt(0).SelecaoB = listaDoBanco.ElementAt(0).SelecaoB;
            //}
            //if (listaDoBanco.Count > 1 && listaDoBanco.ElementAt(1).DataPartida > DateTime.Today)
            //{
            //    lista.ElementAt(1).SelecaoA = listaDoBanco.ElementAt(1).SelecaoA;
            //    lista.ElementAt(1).SelecaoB = listaDoBanco.ElementAt(1).SelecaoB;
            //}
            //if (listaDoBanco.Count > 2 && listaDoBanco.ElementAt(2).DataPartida > DateTime.Today)
            //{
            //    lista.ElementAt(2).SelecaoA = listaDoBanco.ElementAt(2).SelecaoA;
            //    lista.ElementAt(2).SelecaoB = listaDoBanco.ElementAt(2).SelecaoB;
            //}
            //if (listaDoBanco.Count > 3 && listaDoBanco.ElementAt(3).DataPartida > DateTime.Today)
            //{
            //    lista.ElementAt(3).SelecaoA = listaDoBanco.ElementAt(3).SelecaoA;
            //    lista.ElementAt(3).SelecaoB = listaDoBanco.ElementAt(3).SelecaoB;
            //}
            //if (listaDoBanco.Count > 4 && listaDoBanco.ElementAt(4).DataPartida > DateTime.Today)
            //{
            //    lista.ElementAt(4).SelecaoA = listaDoBanco.ElementAt(4).SelecaoA;
            //    lista.ElementAt(4).SelecaoB = listaDoBanco.ElementAt(4).SelecaoB;
            //}
            //if (listaDoBanco.Count > 5 && listaDoBanco.ElementAt(5).DataPartida > DateTime.Today)
            //{
            //    lista.ElementAt(5).SelecaoA = listaDoBanco.ElementAt(5).SelecaoA;
            //    lista.ElementAt(5).SelecaoB = listaDoBanco.ElementAt(5).SelecaoB;
            //}
            //if (listaDoBanco.Count > 6 && listaDoBanco.ElementAt(6).DataPartida > DateTime.Today)
            //{
            //    lista.ElementAt(6).SelecaoA = listaDoBanco.ElementAt(6).SelecaoA;
            //    lista.ElementAt(6).SelecaoB = listaDoBanco.ElementAt(6).SelecaoB;
            //}
            //if (listaDoBanco.Count > 7 && listaDoBanco.ElementAt(7).DataPartida > DateTime.Today)
            //{
            //    lista.ElementAt(7).SelecaoA = listaDoBanco.ElementAt(7).SelecaoA;
            //    lista.ElementAt(7).SelecaoB = listaDoBanco.ElementAt(7).SelecaoB;
            //}
            //if (listaDoBanco.Count > 8 && listaDoBanco.ElementAt(8).DataPartida > DateTime.Today)
            //{
            //    lista.ElementAt(8).SelecaoA = listaDoBanco.ElementAt(8).SelecaoA;
            //    lista.ElementAt(8).SelecaoB = listaDoBanco.ElementAt(8).SelecaoB;
            //}
            //if (listaDoBanco.Count > 9 && listaDoBanco.ElementAt(9).DataPartida > DateTime.Today)
            //{
            //    lista.ElementAt(9).SelecaoA = listaDoBanco.ElementAt(9).SelecaoA;
            //    lista.ElementAt(9).SelecaoB = listaDoBanco.ElementAt(9).SelecaoB;
            //}
            //if (listaDoBanco.Count > 10 && listaDoBanco.ElementAt(10).DataPartida > DateTime.Today)
            //{
            //    lista.ElementAt(10).SelecaoA = listaDoBanco.ElementAt(10).SelecaoA;
            //    lista.ElementAt(10).SelecaoB = listaDoBanco.ElementAt(10).SelecaoB;
            //}
            //if (listaDoBanco.Count > 11 && listaDoBanco.ElementAt(11).DataPartida > DateTime.Today)
            //{
            //    lista.ElementAt(11).SelecaoA = listaDoBanco.ElementAt(11).SelecaoA;
            //    lista.ElementAt(11).SelecaoB = listaDoBanco.ElementAt(11).SelecaoB;
            //}
            //if (listaDoBanco.Count > 12 && listaDoBanco.ElementAt(12).DataPartida > DateTime.Today)
            //{
            //    lista.ElementAt(12).SelecaoA = listaDoBanco.ElementAt(12).SelecaoA;
            //    lista.ElementAt(12).SelecaoB = listaDoBanco.ElementAt(12).SelecaoB;
            //}
            //if (listaDoBanco.Count > 13 && listaDoBanco.ElementAt(13).DataPartida > DateTime.Today)
            //{
            //    lista.ElementAt(13).SelecaoA = listaDoBanco.ElementAt(13).SelecaoA;
            //    lista.ElementAt(13).SelecaoB = listaDoBanco.ElementAt(13).SelecaoB;
            //}
            //if (listaDoBanco.Count > 14 && listaDoBanco.ElementAt(14).DataPartida > DateTime.Today)
            //{
            //    lista.ElementAt(14).SelecaoA = listaDoBanco.ElementAt(14).SelecaoA;
            //    lista.ElementAt(14).SelecaoB = listaDoBanco.ElementAt(14).SelecaoB;
            //}
            //if (listaDoBanco.Count > 15 && listaDoBanco.ElementAt(15).DataPartida > DateTime.Today)
            //{
            //    lista.ElementAt(15).SelecaoA = listaDoBanco.ElementAt(15).SelecaoA;
            //    lista.ElementAt(15).SelecaoB = listaDoBanco.ElementAt(15).SelecaoB;
            //}
            //#endregion

            //#region 8vas (16 - 23)
            //if (listaDoBanco.Count > 16 && listaDoBanco.ElementAt(16).DataPartida > DateTime.Today)
            //{
            //    lista.ElementAt(16).SelecaoA = listaDoBanco.ElementAt(16).SelecaoA;
            //    lista.ElementAt(16).SelecaoB = listaDoBanco.ElementAt(16).SelecaoB;
            //}
            //if (listaDoBanco.Count > 17 && listaDoBanco.ElementAt(17).DataPartida > DateTime.Today)
            //{
            //    lista.ElementAt(17).SelecaoA = listaDoBanco.ElementAt(17).SelecaoA;
            //    lista.ElementAt(17).SelecaoB = listaDoBanco.ElementAt(17).SelecaoB;
            //}
            //if (listaDoBanco.Count > 18 && listaDoBanco.ElementAt(18).DataPartida > DateTime.Today)
            //{
            //    lista.ElementAt(18).SelecaoA = listaDoBanco.ElementAt(18).SelecaoA;
            //    lista.ElementAt(18).SelecaoB = listaDoBanco.ElementAt(18).SelecaoB;
            //}
            //if (listaDoBanco.Count > 19 && listaDoBanco.ElementAt(19).DataPartida > DateTime.Today)
            //{
            //    lista.ElementAt(19).SelecaoA = listaDoBanco.ElementAt(19).SelecaoA;
            //    lista.ElementAt(19).SelecaoB = listaDoBanco.ElementAt(19).SelecaoB;
            //}
            //if (listaDoBanco.Count > 20 && listaDoBanco.ElementAt(20).DataPartida > DateTime.Today)
            //{
            //    lista.ElementAt(20).SelecaoA = listaDoBanco.ElementAt(20).SelecaoA;
            //    lista.ElementAt(20).SelecaoB = listaDoBanco.ElementAt(20).SelecaoB;
            //}
            //if (listaDoBanco.Count > 21 && listaDoBanco.ElementAt(21).DataPartida > DateTime.Today)
            //{
            //    lista.ElementAt(21).SelecaoA = listaDoBanco.ElementAt(21).SelecaoA;
            //    lista.ElementAt(21).SelecaoB = listaDoBanco.ElementAt(21).SelecaoB;
            //}
            //if (listaDoBanco.Count > 22 && listaDoBanco.ElementAt(22).DataPartida > DateTime.Today)
            //{
            //    lista.ElementAt(22).SelecaoA = listaDoBanco.ElementAt(22).SelecaoA;
            //    lista.ElementAt(22).SelecaoB = listaDoBanco.ElementAt(22).SelecaoB;
            //}
            //if (listaDoBanco.Count > 23 && listaDoBanco.ElementAt(23).DataPartida > DateTime.Today)
            //{
            //    lista.ElementAt(23).SelecaoA = listaDoBanco.ElementAt(23).SelecaoA;
            //    lista.ElementAt(23).SelecaoB = listaDoBanco.ElementAt(23).SelecaoB;
            //}
            //#endregion

            //#region 4as (24 - 27)
            //if (listaDoBanco.Count > 24 && listaDoBanco.ElementAt(24).DataPartida > DateTime.Today)
            //{
            //    lista.ElementAt(24).SelecaoA = listaDoBanco.ElementAt(24).SelecaoA;
            //    lista.ElementAt(24).SelecaoB = listaDoBanco.ElementAt(24).SelecaoB;
            //}
            //if (listaDoBanco.Count > 25 && listaDoBanco.ElementAt(25).DataPartida > DateTime.Today)
            //{
            //    lista.ElementAt(25).SelecaoA = listaDoBanco.ElementAt(25).SelecaoA;
            //    lista.ElementAt(25).SelecaoB = listaDoBanco.ElementAt(25).SelecaoB;
            //}
            //if (listaDoBanco.Count > 26 && listaDoBanco.ElementAt(26).DataPartida > DateTime.Today)
            //{
            //    lista.ElementAt(26).SelecaoA = listaDoBanco.ElementAt(26).SelecaoA;
            //    lista.ElementAt(26).SelecaoB = listaDoBanco.ElementAt(26).SelecaoB;
            //}
            //if (listaDoBanco.Count > 27 && listaDoBanco.ElementAt(27).DataPartida > DateTime.Today)
            //{
            //    lista.ElementAt(27).SelecaoA = listaDoBanco.ElementAt(27).SelecaoA;
            //    lista.ElementAt(27).SelecaoB = listaDoBanco.ElementAt(27).SelecaoB;
            //}
            //#endregion

            //#region semis (28 - 29)
            //if (listaDoBanco.Count > 28 && listaDoBanco.ElementAt(28).DataPartida > DateTime.Today)
            //{
            //    lista.ElementAt(28).SelecaoA = listaDoBanco.ElementAt(28).SelecaoA;
            //    lista.ElementAt(28).SelecaoB = listaDoBanco.ElementAt(28).SelecaoB;
            //}
            //if (listaDoBanco.Count > 29 && listaDoBanco.ElementAt(29).DataPartida > DateTime.Today)
            //{
            //    lista.ElementAt(29).SelecaoA = listaDoBanco.ElementAt(29).SelecaoA;
            //    lista.ElementAt(29).SelecaoB = listaDoBanco.ElementAt(29).SelecaoB;
            //}
            //#endregion

            //#region finais (30 - 31)
            //if (listaDoBanco.Count > 30 && listaDoBanco.ElementAt(30).DataPartida > DateTime.Today)
            //{
            //    lista.ElementAt(30).SelecaoA = listaDoBanco.ElementAt(30).SelecaoA;
            //    lista.ElementAt(30).SelecaoB = listaDoBanco.ElementAt(30).SelecaoB;
            //}
            //if (listaDoBanco.Count > 31 && listaDoBanco.ElementAt(31).DataPartida > DateTime.Today)
            //{
            //    lista.ElementAt(31).SelecaoA = listaDoBanco.ElementAt(31).SelecaoA;
            //    lista.ElementAt(31).SelecaoB = listaDoBanco.ElementAt(31).SelecaoB;
            //}

            //#endregion



            return lista;
        }

        public Int16 SelIDporAno(Int16 vAno, Competicao TipoCopa)
        {
            DalCopa oDal = new DalCopa();
            return oDal.SelIDporAno(vAno, TipoCopa);
        }

    }
}
