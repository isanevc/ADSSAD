using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_Propiedades
{
    internal class Operaciones
    {
        private double n1;
        private double n2;

        //Constructor (siempre se llama igual que la clase)
        public Operaciones(double n1, double n2)
        {
            this.N1 = n1;
            this.N2 = n2;
        }

        //Propiedades get y set
        public double N1 { get => n1; set => n1 = value; }
        public double N2 { get => n2; set => n2 = value; }

        //Constructor vacío
        public Operaciones()
        {

        }

        //Método, acción, lo que hace
        public double sumar()
        {
            return (N1 + N2);
        }
        public double restar()
        {
            return (N1 - N2);
        }
        public double multiplicar()
        {
            return (N1 * N2);
        }
        public double dividir()
        {
            return (N1 / N2);
        }
    }
}
