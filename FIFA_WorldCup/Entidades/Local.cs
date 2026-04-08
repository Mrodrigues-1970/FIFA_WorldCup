using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIFA_WorldCup.Entidades
{
    public class Local
    {

        public Int16 ID { get; set; }
        public Int16 CopaID { get; set; }
        public string Estadio { get; set; }
        public string Cidade { get; set; }
        public string Estadio_Cidade
        {
            get { return this.Estadio + " / " + this.Cidade; }
        }

    }
}
