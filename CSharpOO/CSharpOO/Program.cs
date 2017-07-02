using System;

namespace CSharpOO
{
    class Program
    {
        static void Main(string[] args)
        {
            //ContaCorrente cc = new ContaCorrente();
            ////cc.Agencia = 1;
            //cc.SetAgencia(33);
            //Console.WriteLine(cc.Agencia);

            ContaCorrente cc = new ContaCorrente();
            ContaPoupanca cp = new ContaPoupanca();

            Console.WriteLine(cc.TaxaMovimento);
            Console.WriteLine(cc.Limite);
            Console.WriteLine(cp.Limite);

            Console.Read();
        }
    }
}