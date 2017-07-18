using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpOO
{
    class Relatorio
    {
        public decimal SaldoGeral { get; private set; }

        public void Somar(Conta conta)
        {
            this.SaldoGeral += conta.Saldo;
        }

        public void SomarValor(decimal valor1)
        {
            this.SaldoGeral += valor1;
        }
        public void SomarValor(decimal valor1, decimal valor2)
        {
            this.SaldoGeral += (valor1 + valor2);
        }
    }
}
