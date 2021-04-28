using System;
using System.Collections.Generic;
using System.Text;

namespace Modulo2POOExerciciosA1
{
    public class Retangulo
    {
        private double @base;
        private double altura;

        public Retangulo()
        {
                
        }
        public Retangulo(double @base, double altura)
        {
            this.@base = @base;
            this.altura = altura;
        }

        public double CalcularArea()
        {
            return @base * altura;
        }
    }
}
