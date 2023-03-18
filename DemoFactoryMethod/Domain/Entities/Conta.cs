
using DemoFactoryMethod.Domain.Enums;
using System;

namespace DemoFactoryMethod.Domain.Entities
{
    public abstract class Conta
    {
        public decimal Saldo { get; private set; }
        public int Numero { get; private set; }
        public int Digito { get; private set; }
        public TipoConta  Tipo { get; private set; }

        protected void AdicionaValor(decimal valor)
        {
            this.Saldo += valor;
        }
        protected void RemoveValor(decimal valor)
        {
            this.Saldo -= valor;
        }
        public string SaldoToString => $"O saldo da conta {Tipo} é R${Saldo}.";

        public Conta(TipoConta tipo, int numero,int digito)
        {
            Tipo = tipo;
            Numero = numero;
            Digito = digito;
        }
        public abstract void Debitar(decimal valor);
        public abstract void Creditar(decimal valor);
    }
}
