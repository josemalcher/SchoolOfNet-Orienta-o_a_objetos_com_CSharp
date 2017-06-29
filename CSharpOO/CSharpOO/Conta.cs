using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpOO
{
    class Conta
    {
        public int NumeroConta { get; }
        private decimal saldo;

        private int agencia;

        public int Agencia
        {
            get { return agencia; }
            private set
            {
                agencia = value;
            }
        }

        public void SetAgencia(int agencia)
        {
            this.agencia = agencia;
        }

        public void Sacar(decimal valor)
        {
            if (saldo >= valor)
            {
                saldo -= valor;
            }
            else
            {
                Console.WriteLine("Hello World!");
            }

        }

        public void Depositar(decimal valor)
        {
            saldo += valor;
        }
    }
}
