using DemoFactoryMethod.Domain.Enums;
using System; 

namespace DemoFactoryMethod.Domain.Entities
{
    public class ContaCorrente : Conta
    {
        const int horarioLimiteDeposito = 23;
        const decimal limiteSaque = 10000;

 
        public ContaCorrente(TipoConta tipo, int numero, int digito) : base(tipo, numero, digito)
        {
        }

        public override void Creditar(decimal valor)
        {
            //regra de conta corrente para creditar
            if (DateTime.Now.Hour > horarioLimiteDeposito)
                throw new Exception("Horário limite de depósito atingido. O crédito será efetuado no próximo dia útil.");

            AdicionaValor(valor);
        }

        public override void Debitar(decimal valor)
        {
            //regra de conta corrente para debitar
            if (Saldo < valor)
                throw new Exception("Saldo menor que valor a ser debitado.");

            if (valor > limiteSaque)
                throw new Exception("Limite de saque atingido.");

            RemoveValor(valor);
        }
    }
}
