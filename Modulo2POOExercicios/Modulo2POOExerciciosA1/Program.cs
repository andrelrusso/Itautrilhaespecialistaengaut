using System;

namespace Modulo2POOExerciciosA1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a letra inicial para o tipo de figura (Quadrado, Retangulo ou Círculo)");
            string tipoFigura = Console.ReadLine().ToUpper();
            switch (tipoFigura)
            {
                case "Q":
                    Console.WriteLine("Digite o valor do lado do quadrado em metros");
                    double lado = double.Parse(Console.ReadLine());
                    Quadrado quadrado = new Quadrado(lado);
                    Console.WriteLine($"A Área do Quadrado é {quadrado.CalcularArea().ToString("F2")} m2");
                    break;
                case "R":
                    Console.WriteLine("Digite o valor da base do retângulo em metros");
                    double @base = double.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o valor da altura do retângulo em metros");
                    double altura = double.Parse(Console.ReadLine());
                    Retangulo retangulo = new Retangulo(@base, altura);
                    Console.WriteLine($"A Área do Retângulo é {retangulo.CalcularArea().ToString("F2")} m2");
                    break;
                case "C":
                    Console.WriteLine("Digite o valor do raio do círculo em metros");
                    double raio = double.Parse(Console.ReadLine());
                    Circulo circulo = new Circulo(raio);
                    Console.WriteLine($"A Área do Quadrado é {circulo.CalcularArea().ToString("F2")} m2");
                    break;
                default:
                    break;

            }

        }
    }
}
