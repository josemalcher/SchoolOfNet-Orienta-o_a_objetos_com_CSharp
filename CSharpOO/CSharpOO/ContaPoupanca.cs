namespace CSharpOO
{
    public class ContaPoupanca
    {
        private int agencia;
        private int numeroConta;
        private decimal saldo;

        void Sacar(decimal valor)
        {
            if (saldo >= valor)
            {
                saldo -= valor;
            }
            else
            {
                //mensagem
            }

        }

        void Depositar(decimal valor)
        {
            saldo += valor;
        }
    }
}