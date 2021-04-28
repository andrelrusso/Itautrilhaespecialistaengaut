using System;
using System.Collections.Generic;
using System.Text;

namespace Modulo2POOExerciciosA1
{
    public class Quadrado
    {
        private double lado;

        public Quadrado()
        {
                
        }
        public Quadrado(double lado)
        {
            this.lado = lado;
        }

        public double CalcularArea()
        {
            return Math.Pow(lado, 2); 
        }
    }
}
