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

    }
}
