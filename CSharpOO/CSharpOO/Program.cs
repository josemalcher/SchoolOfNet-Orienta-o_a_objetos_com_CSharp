using System;

namespace CSharpOO
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente cc = new ContaCorrente();
            ContaPoupanca cp = new ContaPoupanca();

            cc.Saldo = 1000;
            cp.Saldo = 1000;

            cc.Sacar(200);
            cp.Sacar(200);

            Console.WriteLine(cc.Saldo);
            Console.WriteLine(cp.Saldo);

            Console.Read();
        }
    }
}