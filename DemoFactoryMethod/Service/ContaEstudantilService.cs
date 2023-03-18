using DemoFactoryMethod.Domain.Entities;
using DemoFactoryMethod.Domain.Interfaces;
using System; 

namespace DemoFactoryMethod.Service
{
    public class ContaEstudantilService : IContaService
    {
        public void Transferencia(Conta contaOrigem, Conta contaDestino, decimal valor)
        {
            //adicionar regras de transferencia da conta estudantil.
            Console.WriteLine($"Transferindo R${valor} da conta {contaOrigem.Tipo} para {contaDestino.Tipo}.");
            contaOrigem.Debitar(valor);
            contaDestino.Creditar(valor);
        }
    }
}
