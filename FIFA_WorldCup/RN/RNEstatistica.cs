using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FIFA_WorldCup.Entidades;
using FIFA_WorldCup.Dal;

namespace FIFA_WorldCup.RN
{
    public class RNEstatistica
    {
        private DalLigacao dalL = new DalLigacao();
        private DalEstatistica dalE = new DalEstatistica();


        public List<Estatistica> EstatisticasDoPais(Int16 vPaisID)
        {
            List<Competicao> Competicoes = ListaCompeticoes();
            List<Estatistica> listaEstatisticas = new List<Estatistica>();

            foreach(Competicao iCompeticao in Competicoes)
            {
                Estatistica oStat = dalE.EstatisticasDoPais(vPaisID, iCompeticao);
                oStat.Competicao = iCompeticao;
                if (dalL.ExisteLigacao(vPaisID))
                {
                    oStat = ContabilizarLigacoes(oStat, iCompeticao);
                }
                listaEstatisticas.Add(oStat);
            }
            return listaEstatisticas;
        }

        public List<ConfrontoPais> ListaDeConfrontos(Int16 vPaisID, Competicao vCompeticao)
        {
            DalEstatistica oDal = new DalEstatistica();
            List<ConfrontoPais> lista = oDal.ListaDeConfrontos(vPaisID, vCompeticao);
            return lista;
        }


        private Estatistica ContabilizarLigacoes(Estatistica vEstatisticaInicial, Competicao vCompeticao)
        {
            List<Int16> listaRelacionados = dalL.ListaRelacionados(vEstatisticaInicial.PaisID);
            foreach(Int16 iPaisID in listaRelacionados)
            {
                Estatistica oEstatistica = dalE.EstatisticasDoPais(iPaisID, vCompeticao);
                vEstatisticaInicial = SomaEstatistica(vEstatisticaInicial, oEstatistica);
            }
            return vEstatisticaInicial;
        }


        private Estatistica SomaEstatistica(Estatistica vEstatisticaPrincipal, Estatistica vEstatisticaSecundaria)
        {
            vEstatisticaPrincipal.Copas.AddRange(vEstatisticaSecundaria.Copas);
            vEstatisticaPrincipal.Copas.Sort();
            vEstatisticaPrincipal.GolsMarcados += vEstatisticaSecundaria.GolsMarcados;
            vEstatisticaPrincipal.GolsSofridos += vEstatisticaSecundaria.GolsSofridos;
            vEstatisticaPrincipal.NumeroDerrotas += vEstatisticaSecundaria.NumeroDerrotas;
            vEstatisticaPrincipal.NumeroEmpates += vEstatisticaSecundaria.NumeroEmpates;
            vEstatisticaPrincipal.NumeroVitorias += vEstatisticaSecundaria.NumeroVitorias;
            vEstatisticaPrincipal.PontuacaoGeral += vEstatisticaSecundaria.PontuacaoGeral;
            return vEstatisticaPrincipal;
        }

        private string MontaTextoParticipacao(List<Int16> lista)
        {
            string texto = "Participação em Copas: ";
            texto += lista.Count + ": ";
            foreach (Int16 iCopa in lista)
            {
                texto += " " + iCopa + ",";
            }
            return texto;
        }


        private List<Competicao> ListaCompeticoes()
        {
            List<Competicao> lista = new List<Competicao>();
            lista.Add(Competicao.Masculino);
            lista.Add(Competicao.Feminino);
            lista.Add(Competicao.Confederacoes);
            return lista;
        }


        public List<ConfrontoConfederacao> BuscaConfrontoConfederacao(Int16 PaisID, Competicao competicao)
        {
            DalConfrontoConfederacao oDal = new DalConfrontoConfederacao();
            return oDal.BuscaConfrontoConfederacao(PaisID, competicao);
        }

    }
}
