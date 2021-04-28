using System;
using System.Collections.Generic;
using System.Text;

namespace Modulo2POOAvaliacaoDiagnostica
{
    public class ContaCorrente
    {
        protected double saldo { get; set; }
        private string nomeCliente { get; set; }

        public ContaCorrente(double saldo, string nomeCliente)
        {
            this.saldo = saldo;
            this.nomeCliente = nomeCliente;
        }

        public double GetSaldo()
        {
            return saldo;
        }

        public string GetNome()
        {
            return nomeCliente;
        }
        public double SetSaldo(double valor)
        {
            return saldo += valor;
        }
        public virtual double Saque(double valor)
        {
            return saldo -= valor;
        }
    }
}
