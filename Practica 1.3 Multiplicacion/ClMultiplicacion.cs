﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_1._3_Multiplicacion
{
    internal class ClMultiplicacion
    {
        private int n1;
        private int n2;

        public ClMultiplicacion(int n1, int n2)
        {
            this.n1 = n1;
            this.n2 = n2;
        }
        public int multiplicar()
        {
            return (n1 * n2);

        }
    }
}
