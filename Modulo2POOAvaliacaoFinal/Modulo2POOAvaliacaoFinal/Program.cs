using System;

namespace Modulo2POOAvaliacaoFinal
{
    class Program
    {
        static void Main(string[] args)
        {
            string empresaOrigem;
            string nome;
            int cargaHoraria;
            double valorHora, taxaServico;
            bool terceirizado = false;
            string srtTerceirizado = string.Empty;

            for (int i = 1; i < 3; i++)
            {
                if (i == 1)
                {
                    Console.WriteLine($"Funcionário {i} é terceirizado (S/N)?");
                    terceirizado = Console.ReadLine().ToUpper() == "S" ? true : false;
                }
                srtTerceirizado = terceirizado ? "Terceirizado" : String.Empty;
                Console.WriteLine($"Digite o nome do Funcionário {i} {srtTerceirizado}");
                nome = Console.ReadLine();
                Console.WriteLine($"Digite a carga horária do Funcionário {i}");
                cargaHoraria = int.Parse(Console.ReadLine());
                Console.WriteLine($"Digite o valor/hora do Funcionário {i}");
                valorHora = double.Parse(Console.ReadLine());
                if (!terceirizado)
                {
                    Funcionario func = new Funcionario(nome, cargaHoraria, valorHora);
                    Console.WriteLine($"Nome: {func.GetNome()}\nSalário R$ {func.CalcularSalario().ToString("F2")}");
                }
                else
                {
                    Console.WriteLine("Digite a empresa de origem do Funcionário");
                    empresaOrigem = Console.ReadLine();
                    Console.WriteLine("Digite a taxa de serviço do Funcionário em %");
                    taxaServico = double.Parse(Console.ReadLine());
                    Funcionario func = new FuncionarioTercerizado(nome, cargaHoraria, valorHora, empresaOrigem, taxaServico);
                    Console.WriteLine(
                        $"Nome: {func.GetNome()}\n" +
                        $"Empresa Origem: {empresaOrigem}\n" + //não utilizei func.empresaOrigem 
                                                               //para poder atender a primeira regra
                                                               //ambas as classes devem ser do tipo Funcionario
                                                               //senao a classe teria que ser do tipo FuncionarioTerceirizado
                        $"Salário R$ {func.CalcularSalario().ToString("F2")}");
                }
                terceirizado = !terceirizado;
            }
            Console.ReadLine();
        }
    }
}
