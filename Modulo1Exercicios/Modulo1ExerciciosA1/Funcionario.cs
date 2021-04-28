using System;
using System.Collections.Generic;
using System.Text;

namespace Modulo1ExerciciosA1
{
    public class Funcionario
   
    {
        private double salario { get; set; }
        private int tempo { get; set; }
        public Funcionario(double salario, int tempo)
        {
            this.salario = salario;
            this.tempo = tempo;
        }

        public double exibirSalario()
        {
            if (tempo < 5)
            {
                return salario;
            }
            switch (tempo)
            {
                case 5:
                    return salario * 1.2;

                case 6:
                    return salario * 1.25;

                case 7:
                    return salario * 1.3;

                case 8:
                    return salario * 1.4;

                case 9:
                    return salario * 1.5;

                default:
                    return salario * 1.6;

            }

        }
    }
}
