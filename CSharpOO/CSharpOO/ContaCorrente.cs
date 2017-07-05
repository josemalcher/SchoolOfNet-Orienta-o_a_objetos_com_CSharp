using System;

namespace CSharpOO
{
    public class ContaCorrente : Conta
    {
        private decimal taxaMovimento;

        public decimal TaxaMovimento
        {
            get { return taxaMovimento; }
            set { taxaMovimento = value; }
        }

        public ContaCorrente() : base(3000)
        {
            this.TaxaMovimento = 0.1m;
        }

        //public void Sacar(decimal valor)
        //{
        //    //this.Saldo -= valor + (this.TaxaMovimento * valor);
        //    base.Sacar(valor + (this.taxaMovimento * valor));
        //}

        public override void Sacar(decimal valor)
        {
            base.Sacar(valor + (this.taxaMovimento * valor));
        }

        
    }

}