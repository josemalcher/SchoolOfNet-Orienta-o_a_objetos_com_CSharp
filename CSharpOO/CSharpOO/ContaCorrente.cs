using System;

namespace CSharpOO
{
    public class ContaCorrente
    {
        private int numeroConta;
        private decimal saldo;


        private int agencia;
        public ContaCorrente()
        {
            agencia = 44512;
        }

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