using DemoFactoryMethod.Domain.Entities;
using DemoFactoryMethod.Domain.Enums;
using DemoFactoryMethod.Domain.Interfaces;
using System;

namespace DemoFactoryMethod
{
    public class ContaFacade
    {
        private readonly IContaFactory _contaFactory;
        private readonly Func<TipoConta, IContaService> _contaServiceFactory;

        public ContaFacade(IContaFactory contaFactory, Func<TipoConta, IContaService> contaServiceFactory)
        {
            this._contaFactory = contaFactory;
            this._contaServiceFactory = contaServiceFactory;
        }

        public void Start()
        {
            try
            {
                Conta contaCorrente = _contaFactory.CreateConta(TipoConta.Corrente, 12121, 3);
                contaCorrente.Creditar(100);
                Console.WriteLine(contaCorrente.SaldoToString);

                Conta contaPoupanca = _contaFactory.CreateConta(TipoConta.Poupanca, 10987, 2);
                contaPoupanca.Creditar(200);
                Console.WriteLine(contaPoupanca.SaldoToString);

                Conta contaEstudantil = _contaFactory.CreateConta(TipoConta.Estudantil, 12121, 3);
                contaEstudantil.Creditar(50);
                Console.WriteLine(contaEstudantil.SaldoToString);


                var contacorrenteService = _contaServiceFactory(TipoConta.Corrente);
                contacorrenteService.Transferencia(contaCorrente, contaPoupanca, contaCorrente.Saldo);
                Console.WriteLine(contaPoupanca.SaldoToString);

                var contaEstudantilService = _contaServiceFactory(TipoConta.Estudantil);
                contaEstudantilService.Transferencia(contaEstudantil, contaPoupanca, contaEstudantil.Saldo);
                Console.WriteLine(contaPoupanca.SaldoToString);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
        }
    }
}
