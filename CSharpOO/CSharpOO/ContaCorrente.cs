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

        
    }

}