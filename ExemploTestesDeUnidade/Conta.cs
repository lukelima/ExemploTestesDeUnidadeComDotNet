using System;

namespace ExemploTestesDeUnidade
{
    public class Conta
    {
        public Conta(string cliente, decimal saldo)
        {
            Cliente = cliente;
            Saldo = saldo;
        }

        public string Cliente { get; private set; }
        public decimal Saldo { get; private set; }

        public decimal Depositar(decimal valor)
        {
            if (valor <= 0)
            {
                throw new InvalidOperationException("Não é possível depositar valores negativos");
            }
            Saldo += valor;
            return Saldo;
        }

        public decimal Sacar(decimal valor)
        {
            if (valor < 0 || valor > Saldo)
            {
                throw new InvalidOperationException("Não foi possível realizar o saque");
            }

            Saldo -= valor;
            return valor;
        }
    }
}
