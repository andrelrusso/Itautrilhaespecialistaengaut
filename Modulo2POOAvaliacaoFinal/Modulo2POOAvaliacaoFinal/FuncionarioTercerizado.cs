using System;
using System.Collections.Generic;
using System.Text;

namespace Modulo2POOAvaliacaoFinal
{
    public class FuncionarioTercerizado:Funcionario
    {
        public string empresaOrigem { get; private set; }
        double taxaServico;
        public FuncionarioTercerizado()
        {

        }
        public FuncionarioTercerizado(string nome, int cargaHoraria, double valorHora, string empresaOrigem, double taxaServico)
            :base(nome,cargaHoraria,valorHora)
        {
            this.empresaOrigem = empresaOrigem;
            this.taxaServico = taxaServico;
        }

        public override double CalcularSalario()
        {
            return base.CalcularSalario() * (1 + taxaServico/100);
        }
    }
}
