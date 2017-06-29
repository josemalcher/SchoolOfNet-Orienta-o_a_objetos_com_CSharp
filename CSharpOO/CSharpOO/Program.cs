using System;

namespace CSharpOO
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente cc = new ContaCorrente();
            //cc.Agencia = 1;
            cc.SetAgencia(33);
            Console.WriteLine(cc.Agencia);

            Console.Read();
        }
    }
}