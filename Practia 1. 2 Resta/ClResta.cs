﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practi_1._2_Resta
{
    internal class ClResta
    {
        private int n1;
        private int n2;
        public ClResta(int n1, int n2)
        {
            this.n1 = n1;
            this.n2 = n2;
        }
        public int resta()
        {
            return (n1 - n2);

        }
    }
}
