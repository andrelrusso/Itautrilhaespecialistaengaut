using System;

namespace Modulo1AvaliacaoDiagnostica
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com 10 números inteiros, separados por vírgula");
            string srtNumerosDigitados = Console.ReadLine();
            int[] vetorInt = new int[10];
            string[] vetorStr = srtNumerosDigitados.Split(",");
            for (int i = 0; i < 10; i++)
            {
                vetorInt[i] = Convert.ToInt32(vetorStr[i]);
            }
            Console.WriteLine("Digite um número para pesquisa");
            int numeroBusca = int.Parse(Console.ReadLine());
            foreach (var item in vetorInt)
            {
                if (item.Equals(numeroBusca))
                {
                    Console.WriteLine($"O número {numeroBusca} foi encontrado com sucesso!");
                    if (numeroBusca % 2 == 0)
                    {
                        Console.WriteLine($"O número {numeroBusca} é par!");
                    }
                    else
                    {
                        Console.WriteLine($"O número {numeroBusca} é ímpar!");
                    }
                    Console.Read();
                    return;
                }
            }
            Console.WriteLine($"O número {numeroBusca} não foi encontrado!");
            Console.Read();
        }
    }
}
