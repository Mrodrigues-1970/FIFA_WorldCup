using FIFA_WorldCup.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIFA_WorldCup.RN
{
    /// <summary>
    /// Simulacao atual das vagas para a Copa do Mundo 
    /// </summary>
    public static class RNVaga
    {

        public static List<VagaMasculino> VagasCopaMasculino()
        {
            List<VagaMasculino> lista = new List<VagaMasculino>();

            VagaMasculino vaga1 = new VagaMasculino();
            vaga1.Confederacao = Confederacao.CONMEBOL;
            vaga1.VagasDiretas = 6;
            vaga1.VagasRepescagem = 1;
            lista.Add(vaga1);

            VagaMasculino vaga2 = new VagaMasculino();
            vaga2.Confederacao = Confederacao.UEFA;
            vaga2.VagasDiretas = 16;
            vaga2.VagasRepescagem = 0;
            lista.Add(vaga2);

            VagaMasculino vaga3 = new VagaMasculino();
            vaga3.Confederacao = Confederacao.CONCACAF;
            vaga3.VagasDiretas = 6;
            vaga3.VagasRepescagem = 2;
            lista.Add(vaga3);

            VagaMasculino vaga4 = new VagaMasculino();
            vaga4.Confederacao = Confederacao.CAF;
            vaga4.VagasDiretas = 9;
            vaga4.VagasRepescagem = 1;
            lista.Add(vaga4);

            VagaMasculino vaga5 = new VagaMasculino();
            vaga5.Confederacao = Confederacao.AFC;
            vaga5.VagasDiretas = 8;
            vaga5.VagasRepescagem = 1;
            lista.Add(vaga5);

            VagaMasculino vaga6 = new VagaMasculino();
            vaga6.Confederacao = Confederacao.OFC;
            vaga6.VagasDiretas = 1;
            vaga6.VagasRepescagem = 1;
            lista.Add(vaga6);

            return lista;
        }


    }
}
