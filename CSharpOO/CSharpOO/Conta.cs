using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpOO
{
    public class Conta
    {
        public int NumeroConta { get; set; }
        private decimal saldo;

        private int agencia;
        public decimal Limite { get; set; }

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



        public Conta()
        {
            this.Limite = 1000;
        }
        public Conta(decimal limite)
        {
            this.Limite = limite;
        }
    }
}
