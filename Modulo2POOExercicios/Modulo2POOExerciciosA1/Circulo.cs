using System;
using System.Collections.Generic;
using System.Text;

namespace Modulo2POOExerciciosA1
{
    public class Circulo
    {
        private const double pi = 3.14;
        private double raio;
        public Circulo()
        {
                
        }
        public Circulo(double raio)
        {
            this.raio = raio;
        }

        public double CalcularArea()
        {
            return pi * Math.Pow(raio, 2);

        }

    }
}
