using DemoFactoryMethod.Domain.Enums;
using System; 

namespace DemoFactoryMethod.Domain.Entities
{
    public class ContaPoupanca : Conta
    {
 
        public ContaPoupanca(TipoConta tipo, int numero, int digito) : base(tipo, numero, digito)
        {
        }

        public override void Creditar(decimal valor)
        {
            //regra de conta poupança para creditar
            AdicionaValor(valor);
        }

        public override void Debitar(decimal valor)
        {
            //regra de conta poupança para debitar
            RemoveValor(valor);
        }
    }
}
