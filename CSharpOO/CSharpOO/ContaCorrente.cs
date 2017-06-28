using System;

namespace CSharpOO
{
    public class ContaCorrente
    {
        private int agencia;
        private int numeroCOnta;
        private decimal saldo;

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