using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIFA_WorldCup.Entidades
{
    public class VagaMasculino
    {
        public Int16 CopaID { get; set; }
        public Confederacao Confederacao { get; set; }
        public double VagasDiretas { get; set; }
        public double VagasRepescagem { get; set; }
        public Int16 TotalCandidatos { get; set; }


        #region Campos Calculados

        public double VagasTotais
        {
            get { return (double)(VagasDiretas + VagasRepescagem); }
        }

        public double CandidatosPorVaga
        {
            get { return (double)(VagasDiretas / TotalCandidatos); }
        }

        #endregion


    }

}
