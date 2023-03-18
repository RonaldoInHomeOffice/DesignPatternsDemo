using DemoFactoryMethod.Domain.Enums;
using System; 

namespace DemoFactoryMethod.Domain.Entities
{
    public class ContaEstudantil : Conta
    {
 
        public ContaEstudantil(TipoConta tipo, int numero, int digito) : base(tipo, numero, digito)
        {
        }

        public override void Creditar(decimal valor)
        {
            //regra de conta estudantil para creditar
            AdicionaValor(valor);
        }

        public override void Debitar(decimal valor)
        {
            //regra de conta estudantil para debitar
            RemoveValor(valor);
        }
    }
}
