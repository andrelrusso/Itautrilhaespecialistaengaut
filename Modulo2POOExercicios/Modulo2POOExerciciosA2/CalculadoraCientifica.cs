using System;
using System.Collections.Generic;
using System.Text;

namespace Modulo2POOExerciciosA2
{
    public class CalculadoraCientifica:Calculadora
    {
        public CalculadoraCientifica()
        {
                
        }

        public double RaizQuadrada(double valor)
        {
            return Math.Sqrt(valor);
        }
    }
}
