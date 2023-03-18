using DemoFactoryMethod.Domain.Entities;
using DemoFactoryMethod.Domain.Interfaces;
using System;

namespace DemoFactoryMethod.Service
{
    public class ContaCorrenteService : IContaService
    {
        public void Transferencia(Conta contaOrigem, Conta contaDestino, decimal valor)
        {
            //adcionar regras de transferencia da conta corrente.
            Console.WriteLine($"Transferindo R${valor} da conta {contaOrigem.Tipo} para {contaDestino.Tipo}.");
            contaOrigem.Debitar(valor);
            contaDestino.Creditar(valor);
        }
    }
}
