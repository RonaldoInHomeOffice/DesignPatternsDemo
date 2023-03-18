using DemoFactoryMethod.Domain.Entities;
using DemoFactoryMethod.Domain.Enums;
using DemoFactoryMethod.Domain.Interfaces;
using System;

namespace DemoFactoryMethod.Creational.FactoryMethod
{
    public class ContaFactory : IContaFactory
    {
        public Conta CreateConta(TipoConta tipo, int numero, int digito)
        {
            return tipo switch
            {
                TipoConta.Corrente => new ContaCorrente(tipo, numero, digito),
                TipoConta.Poupanca => new ContaPoupanca(tipo, numero, digito),
                TipoConta.Estudantil => new ContaEstudantil(tipo, numero, digito),
                _ => throw new ArgumentException($"Invalid value for {nameof(Conta)} enum: {tipo}"),
            };
        }
    }
}
