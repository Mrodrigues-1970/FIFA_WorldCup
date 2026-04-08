using FIFA_WorldCup.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIFA_WorldCup.RN
{
    public class RNSimulacaoCopa
    {

        public List<Int16> GeraNumeroDeGrupos()
        {
            List<Int16> lista = new List<Int16>();
            for(Int16 i = 1; i < 13; i++)
            {
                lista.Add(i);
            }
            return lista;
        }

        public List<Confederacao> RetornaListaConfederacoes()
        {
            List<Confederacao> lista = new List<Confederacao>();
            lista.Add(Entidades.Confederacao.AFC);
            lista.Add(Entidades.Confederacao.UEFA);
            lista.Add(Entidades.Confederacao.CONMEBOL);
            lista.Add(Entidades.Confederacao.OFC);
            lista.Add(Entidades.Confederacao.CONCACAF);
            lista.Add(Entidades.Confederacao.CAF);
            return lista;
        }


        public Int16 SorteiaNumero(Int16 limite)
        {
            Random rnd = new Random();
            Int16 escolhido = (Int16)rnd.Next(0, limite - 1);
            return escolhido;
        }


    }
}
