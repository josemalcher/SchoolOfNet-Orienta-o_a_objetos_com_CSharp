﻿using System;

namespace CSharpOO
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente cc = new ContaCorrente();
            ContaPoupanca cp = new ContaPoupanca();

            cc.Depositar(1000);
            cp.Depositar(1000);

            cc.Sacar(200);
            cp.Sacar(200);

            Console.WriteLine(cc.Saldo);
            Console.WriteLine(cp.Saldo);

            Relatorio relatorio = new Relatorio();
            relatorio.Somar(cc);
            relatorio.Somar(cp);

            relatorio.SomarValor(10);
            relatorio.SomarValor(10,10);

            relatorio.SomarTributos(cp);
            
            Console.WriteLine(relatorio.SaldoGeral);
            Console.WriteLine(relatorio.TributoGeral);


            Console.Read();
        }
    }
}