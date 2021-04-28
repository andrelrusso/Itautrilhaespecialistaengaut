using System;

namespace Modulo1ExerciciosA1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Insira o salário do Funcionário {i + 1}");
                double salario = double.Parse(Console.ReadLine());
                Console.WriteLine($"Insira o tempo que Funcionário {i + 1} trabalha na empresa");
                int anosempresa = int.Parse(Console.ReadLine());
                var funcionario = new Funcionario(salario, anosempresa);
                Console.WriteLine($"O Salário do funcionário calculado é {funcionario.exibirSalario().ToString("F")}");
            }
        }
    }
}
