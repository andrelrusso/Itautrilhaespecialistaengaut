using System;
using System.Collections.Generic;
using System.Text;

namespace Modulo2POOAvaliacaoDiagnostica
{
    public class ContaPoupanca : ContaCorrente
    {
        public ContaPoupanca(double saldo, string nomeCliente) : base(saldo, nomeCliente)
        {
        }

        public override double Saque(double valor)
        {
            saldo -= (valor + 0.5);

            return saldo;
        }

        public double DepositoPoupanca(double valor)
        {
            saldo += valor;

            return saldo;
        }
    }
}
