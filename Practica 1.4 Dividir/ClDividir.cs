using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic_1._4_Dividir
{
    internal class ClDividir
    {
        private double n1;
        private double n2;

        public ClDividir(double n1, double n2)
        {
            this.n1 = n1;
            this.n2 = n2;
        }
        public double dividir()
        {
            return (n1 / n2);

        }
    }
}
