using DemoFactoryMethod.Domain.Entities;
using DemoFactoryMethod.Domain.Enums;
 
namespace DemoFactoryMethod.Domain.Interfaces
{
    public interface IContaFactory
    {
        Conta CreateConta(TipoConta tipo, int numero, int digito);
    }
}
