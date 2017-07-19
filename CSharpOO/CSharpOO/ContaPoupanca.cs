using System;

namespace CSharpOO
{
    public class ContaPoupanca : Conta, ITributo
    {
        public ContaPoupanca() : base(500)
        {
            
        }

        public decimal CalcularTributo()
        {
            return base.Saldo * 0.02m;
        }

        public override void Depositar(decimal valor)
        {
            base.Saldo += valor;
        }


    }
}