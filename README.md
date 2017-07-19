# Orientação a objetos com C#

Resumo do curso:

https://www.schoolofnet.com/curso-orientacao-objetos-com-c/


---

## <a name="indice">Índice</a>

- [Introdução](#parte1)
- [Cenário Classes](#parte2)
- [Encapsulamento 1](#parte3)
- [Encapsulamento 2](#parte4)
- [Herança Conceito](#parte5)
- [Herança GenerEspec](#parte6)
- [Herança Construtor](#parte7)
- [Métodos Virtuais](#parte8)
- [Polimorf Herança](#parte9)
- [Polimorf Método](#parte10)
- [Classe Abstrata](#parte11)
- [Métodos Abstratos](#parte12)
- [Interface Conceito](#parte13)
- [Interface Aplicação](#parte14)
- [Exceção Introdução](#parte15)
- [Exceção Tratamento](#parte16)
- [Exceção Níveis](#parte17)
- [Exceção Finally](#parte18)
- [Exceção Custom](#parte19)
- [Debugging Break](#parte20)
- [Debugging Watch](#parte21)

---

## <a name="parte1">Introdução</a>

Material de Referência: (Apostila Caelum c#)[https://www.caelum.com.br/apostila-csharp-orientacao-objetos/]





[Voltar ao Índice](#indice)

---

## <a name="parte2">Cenário Classes</a>

ContaCorrente.cs
```csharp
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
                //mesagem
            }
            
        }

        public void Depositar(decimal valor)
        {
            saldo += valor;
        }
    }
}
```

Programa.cc
```csharp
using System;

namespace CSharpOO
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente cc = new ContaCorrente();
            cc.Depositar(100);
        }
    }
}
```

[Voltar ao Índice](#indice)

---

## <a name="parte3">Encapsulamento 1</a>

[Voltar ao Índice](#indice)

---

## <a name="parte4">Encapsulamento 2</a>

```csharp
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

```

```csharp
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
```

(Encapsulamento e Modificadores de Acesso)[https://www.caelum.com.br/apostila-csharp-orientacao-objetos/encapsulamento-e-modificadores-de-acesso/]

A partir do C# 3.0, temos as propriedades que são implementadas automaticamente pelo compilador, as auto-implemented properties. Para declararmos uma auto-implemented property para expor o número da conta, utilizamos o seguinte código:

```csharp
class Conta
{
    // outras propriedades
    
    // get é público e pode ser acessado por qualquer classe
    // set é privado e por isso só pode ser usado pela conta.
    public double Saldo { get; private set; }
    
    // resto do código da classe.
}
```
 podemos deixar a classe AtualizadorDeContas ou o método Atualiza com visibilidade internal:

 ```csharp
 // internal é a visibilidade padrão para a classe,
// portanto a palavra internal é opcional
internal class AtualizadorDeContas
{
    // implementação da classe
}
```

(Construtores)[https://www.caelum.com.br/apostila-csharp-orientacao-objetos/construtores/]

```csharp
class Cliente 
{
    public string Nome { get; set; }
    
    public int Idade { get; set; }
    
    // construtor que só recebe o nome
    public Cliente (string nome)
    {
        this.Nome = nome;
    }
    // construtor que recebe o nome e a idade
    public Cliente (string nome, int idade)
    {
        this.Nome = nome;
        this.Idade = idade;
    }
}
```

### Initializer

Para evitar essa repetição, podemos utilizar os initializers do C#. O Initializer é um bloco de código que serve para inicializar as propriedades públicas do objeto.

```csharp
Cliente cliente = new Cliente ("Victor Harada")
{
    // bloco de inicialização
    Cpf = "123.456.789-01",
    Rg = "21.345.987-x",
    Idade = 25
};
```




[Voltar ao Índice](#indice)

---

## <a name="parte5">Herança Conceito</a>

[Herança](https://www.caelum.com.br/apostila-csharp-orientacao-objetos/heranca/)

```csharp
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpOO
{
    class Conta
    {
        public int NumeroConta { get; }
        private decimal saldo;

        private int agencia;

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

```

```csharp
using System;

namespace CSharpOO
{
    public class ContaCorrente : Conta
    {
        private decimal taxaMovimento;
    }
}
```

```csharp
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


            cc.SetAgencia(1234);
            cp.Depositar(100);

            Console.Read();
        }
    }
}
```


[Voltar ao Índice](#indice)

---

## <a name="parte6">Herança GenerEspec</a>

[Voltar ao Índice](#indice)

---

## <a name="parte7">Herança Construtor</a>

Conta.cs
```csharp
     public Conta()
        {
            this.Limite = 1000;
        }
        public Conta(decimal limite)
        {
            this.Limite = limite;
        }
```

ContaCorrente.cs

```csharp
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
```
ContaPoupanca.cs
```csharp
namespace CSharpOO
{
    public class ContaPoupanca : Conta
    {
        public ContaPoupanca() : base(500)
        {
            
        }
    }
}
```

Program.cs

```csharp
using System;

namespace CSharpOO
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente cc = new ContaCorrente();
            ContaPoupanca cp = new ContaPoupanca();

           //Console.WriteLine(cc.TaxaMovimento);
            Console.WriteLine(cc.Limite);
            Console.WriteLine(cp.Limite);

            Console.Read();
        }
    }
}
```


[Voltar ao Índice](#indice)

---

## <a name="parte8">Métodos Virtuais</a>

Conta.cs
```csharp

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

```
ContaCorrente.cs

```csharp
 //public void Sacar(decimal valor)
        //{
        //    //this.Saldo -= valor + (this.TaxaMovimento * valor);
        //    base.Sacar(valor + (this.taxaMovimento * valor));
        //}

        public override void Sacar(decimal valor)
        {
            base.Sacar(valor + (this.taxaMovimento * valor));
        }
```

program.cs

```csharp
ContaCorrente cc = new ContaCorrente();
            ContaPoupanca cp = new ContaPoupanca();

            cc.Saldo = 1000;
            cp.Saldo = 1000;

            cc.Sacar(200);
            cp.Sacar(200);

            Console.WriteLine(cc.Saldo);
            Console.WriteLine(cp.Saldo);

            Console.Read();
```


[Voltar ao Índice](#indice)

---

## <a name="parte9">Polimorf Herança</a>

```csharp
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpOO
{
    class Relatorio
    {
        public decimal SaldoGeral { get; private set; }

        public void Somar(Conta conta)
        {
            this.SaldoGeral += conta.Saldo;
        }

    }
}

```

```csharp
using System;

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
            Console.WriteLine(relatorio.SaldoGeral);

            Console.Read();
        }
    }
}
```

[Voltar ao Índice](#indice)

---

## <a name="parte10">Polimorf Método</a>

```csharp
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpOO
{
    class Relatorio
    {
        public decimal SaldoGeral { get; private set; }

        public void Somar(Conta conta)
        {
            this.SaldoGeral += conta.Saldo;
        }

        public void SomarValor(decimal valor1)
        {
            this.SaldoGeral += valor1;
        }
        public void SomarValor(decimal valor1, decimal valor2)
        {
            this.SaldoGeral += (valor1 + valor2);
        }
    }
}

```
Program.cs
```csharp
            relatorio.SomarValor(10);
            relatorio.SomarValor(10,10);
```

[Voltar ao Índice](#indice)

---

## <a name="parte11">Classe Abstrata</a>

```csharp
namespace CSharpOO
{
    public abstract class Conta
    {
        public int NumeroConta {
            get { return NumeroConta; }
            private set { saldo = value; }
        }
```



[Voltar ao Índice](#indice)

---

## <a name="parte12">Métodos Abstratos</a>

```csharp
      public abstract void Depositar(decimal valor);
```

ContaCorrente.cs e em ContaPoupanca.cs
```csharp
       public override void Depositar(decimal valor)
        {
            this.Saldo += valor;
        }
```` 

```csharp

````


[Voltar ao Índice](#indice)

---

## <a name="parte13">Interface Conceito</a>

```csharp
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpOO
{
    public interface ITributo
    {
        decimal SomarTributo();
    }
}

```

[Voltar ao Índice](#indice)

---

## <a name="parte14">Interface Aplicação</a>

```csharp
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpOO
{
    public interface ITributo
    {
        decimal CalcularTributo();
    }
}

```

ContaPoupanca.cs

```csharp
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
```

Relatorio.cs

```csharp
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpOO
{
    class Relatorio
    {
        public decimal SaldoGeral { get; private set; }
        public decimal TributoGeral { get; private set; }

        public void SomarTributos(ITributo conta)
        {
            this.TributoGeral += conta.CalcularTributo(); 
        }

        public void Somar(Conta conta)
        {
            this.SaldoGeral += conta.Saldo;
        }

        public void SomarValor(decimal valor1)
        {
            this.SaldoGeral += valor1;
        }
        public void SomarValor(decimal valor1, decimal valor2)
        {
            this.SaldoGeral += (valor1 + valor2);
        }
    }
}

```
Program.cs
```csharp
    relatorio.SomarTributos(cp);
    Console.WriteLine(relatorio.TributoGeral);
```


[Voltar ao Índice](#indice)

---

## <a name="parte15">Exceção Introdução</a>

[Voltar ao Índice](#indice)

---

## <a name="parte16">Exceção Tratamento</a>

[Voltar ao Índice](#indice)

---

## <a name="parte17">Exceção Níveis</a>

[Voltar ao Índice](#indice)

---

## <a name="parte18">Exceção Finally</a>

[Voltar ao Índice](#indice)

---

## <a name="parte19">Exceção Custom</a>

[Voltar ao Índice](#indice)

---

## <a name="parte20">Debugging Break</a>

[Voltar ao Índice](#indice)

---

## <a name="parte21">Debugging Watch</a>

[Voltar ao Índice](#indice)

---