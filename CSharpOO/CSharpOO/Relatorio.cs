using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpOO
{
    class Relatorio
    {
        public decimal SaldoGeral { get; private set; }
        public decimal TributoGeral { get; private set; }

        public void SomarTributos(ITributo conta)
        {
            this.TributoGeral += conta.CalcularTributo(); 
        }

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
