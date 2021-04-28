using System;

namespace Modulo2POOAvaliacaoDiagnostica
{
    class Program
    {
        static void Main(string[] args)
        {
            double saldo;
            string nomeCliente;
            double valorSaque;
            double valorDeposito;
            Console.WriteLine("Insira o nome para a Conta Corrente");
            nomeCliente = Console.ReadLine();
            Console.WriteLine("Insira o saldo da Conta Corrente");
            saldo = double.Parse(Console.ReadLine());
            ContaCorrente contaCorrente = new ContaCorrente(saldo, nomeCliente);
            Console.WriteLine($"Insira um valor para saque da Conta Corrente de {contaCorrente.GetNome()}");
            valorSaque = double.Parse(Console.ReadLine());
            contaCorrente.Saque(valorSaque);
            Console.WriteLine($"O saldo atualizado da Conta Corrente de {contaCorrente.GetNome()} após saque é {contaCorrente.GetSaldo().ToString("F")}");

            Console.WriteLine("Insira o nome para a Conta Poupança");
            nomeCliente = Console.ReadLine();
            Console.WriteLine("Insira o saldo da Conta Poupança");
            saldo = double.Parse(Console.ReadLine());
            ContaPoupanca contaPoupanca = new ContaPoupanca(saldo, nomeCliente);
            Console.WriteLine($"Insira um valor para saque da Conta Poupança de {contaPoupanca.GetNome()}");
            valorSaque = double.Parse(Console.ReadLine());
            contaPoupanca.Saque(valorSaque);
            Console.WriteLine($"O saldo atualizado da Conta Poupança de {contaPoupanca.GetNome()} após saque é {contaPoupanca.GetSaldo().ToString("F")}");

            Console.WriteLine("Insira um valor para deposito da Conta Poupança");
            valorDeposito = double.Parse(Console.ReadLine());
            contaPoupanca.DepositoPoupanca(valorDeposito);
            Console.WriteLine($"O saldo atualizado da Conta Poupança de {contaPoupanca.GetNome()} após saque é {contaPoupanca.GetSaldo().ToString("F")}");
            Console.ReadLine();
        }
    }
}
