using DemoFactoryMethod.Domain.Entities;

namespace DemoFactoryMethod.Domain.Interfaces
{
    public interface IContaService 
    {
        public void Transferencia(Conta contaOrigem, Conta contaDestino,decimal valor);
    }
}
