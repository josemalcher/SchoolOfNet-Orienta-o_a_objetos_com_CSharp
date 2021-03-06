﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpOO
{
    public abstract class Conta
    {
        public int NumeroConta {
            get { return NumeroConta; }
            private set { saldo = value; }
        }

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

        public decimal Saldo
        {
            get { return saldo; }
            protected set { saldo = value; }
        }

        public void SetAgencia(int agencia)
        {
            this.agencia = agencia;
        }

        public virtual void Sacar(decimal valor)
        {
            if (Saldo >= valor)
            {
                Saldo -= valor;
            }
            else
            {
                Console.WriteLine("Hello World!");
            }

        }

        public abstract void Depositar(decimal valor);

        
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
