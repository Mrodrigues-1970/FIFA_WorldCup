using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FIFA_WorldCup.Entidades;
using FIFA_WorldCup.Dal;

namespace FIFA_WorldCup.RN
{
    public class RNResultado
    {
        private DalLigacao dalL = new DalLigacao();
        private DalResultado oDal = new DalResultado();
        public ResultadoCopa Sel(Int16 vCopaID)
        {
            DalResultado oDal = new DalResultado();
            return oDal.Sel(vCopaID);
        }

        public List<Conquista> SelConquistas(Int16 vPaisID)
        {
            List<Conquista> listaConquistas = oDal.SelConquistas(vPaisID);
            if (dalL.ExisteLigacao(vPaisID))
            {
                listaConquistas = ContabilizarResultados(listaConquistas, vPaisID);
            }
            return listaConquistas;
        }


        public void Salvar(ResultadoCopa vResultado)
        {
            DalResultado oDal = new DalResultado();
            oDal.Salvar(vResultado);
        }


        private List<Conquista> ContabilizarResultados(List<Conquista> listaInicial, Int16 vPaisID)
        {
            List<Int16> listaRelacionados = dalL.ListaRelacionados(vPaisID);

            foreach (Int16 iPaisID in listaRelacionados)
            {
                List<Conquista> resultadosSecundario = oDal.SelConquistas(iPaisID);
                listaInicial.AddRange(resultadosSecundario);
            }
            List<Conquista> novaLista = OrdenaConquistas(listaInicial);
            return novaLista;
        }

        private List<Conquista> OrdenaConquistas(List<Conquista> lista)
        {
            List<Conquista> listaCronologica = lista.OrderBy(x => x.Ano).ToList();
            List<Conquista> novaLista = new List<Conquista>();
            List<Competicao> listaCompeticoes = new List<Competicao>();
            listaCompeticoes.Add(Competicao.Masculino);
            listaCompeticoes.Add(Competicao.Confederacoes);
            listaCompeticoes.Add(Competicao.Feminino);

            foreach(Competicao iCompeticao in listaCompeticoes)
            {
                foreach(Conquista iConquista in listaCronologica)
                {
                    if(iConquista.Competicao == iCompeticao)
                    {
                        novaLista.Add(iConquista);
                    }
                }
            }
            return novaLista;
        }
    }
}
