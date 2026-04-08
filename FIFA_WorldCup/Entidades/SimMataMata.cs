using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIFA_WorldCup.Entidades
{
    public class SimMataMata
    {
        Pais _SelecaoVencedora = new Pais();

        public Pais Selecao1 { get; set; }
        public Pais Selecao2 { get; set; }
        public bool Selecao1Vencedora
        {
            set
            {
                _SelecaoVencedora = Selecao1;
            }
        }
        public bool Selecao2Vencedora
        {
            set
            {
                _SelecaoVencedora = Selecao2;
            }
        }

        public Pais SelecaoVencedora {
            get { 
                return _SelecaoVencedora;
            }
        }

    }
}
