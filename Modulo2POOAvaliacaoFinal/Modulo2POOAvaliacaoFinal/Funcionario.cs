using System;
using System.Collections.Generic;
using System.Text;

namespace Modulo2POOAvaliacaoFinal
{
    public class Funcionario
    {
        public string nome;
        public int cargaHoraria { get; private set; }
        public double valorHora { get; private set; }

        public Funcionario()
        {
                
        }
        public Funcionario(string nome, int cargaHoraria, double valorHora)
        {
            this.nome = nome;
            this.cargaHoraria = cargaHoraria;
            this.valorHora = valorHora;
        }

        public string GetNome()
        {
            return nome;
        }
        public virtual double CalcularSalario()
        {
            return valorHora * cargaHoraria;
        }
    }
}
