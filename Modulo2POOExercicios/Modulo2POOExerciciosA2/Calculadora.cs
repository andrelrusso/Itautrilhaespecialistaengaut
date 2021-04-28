using System;
using System.Collections.Generic;
using System.Text;

namespace Modulo2POOExerciciosA2
{
    public class Calculadora
    {
        public Calculadora()
        {
                
        }

        public double Somar(double valor1, double valor2)
        {
            return valor1 + valor2;
        }

        public double Subtrair(double valor1, double valor2)
        {
            return valor1 - valor2;
        }
        public double Dividir(double valor1, double valor2)
        {
            return valor1 / valor2;
        }

        public double Multiplicar(double valor1, double valor2)
        {
            return valor1 * valor2;
        }
    }
}
