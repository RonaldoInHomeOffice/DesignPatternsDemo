using DemoFactoryMethod.Creational.FactoryMethod;
using DemoFactoryMethod.Domain.Entities;
using DemoFactoryMethod.Domain.Enums;
using DemoFactoryMethod.Domain.Interfaces;
using DemoFactoryMethod.Service;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace DemoFactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceProvider = ConfigureServices();
            serviceProvider.GetService<ContaFacade>().Start();
        }

        public static ServiceProvider ConfigureServices()
        {
            ServiceCollection services = new();
            services.AddTransient<ContaFacade>();
            services.AddTransient<ContaCorrenteService>();
            services.AddTransient<ContaPoupancaService>();
            services.AddTransient<ContaEstudantilService>();

            services.AddTransient<IContaFactory, ContaFactory>();
            services.AddTransient<Func<TipoConta, IContaService>>(service => (tipo) =>
            {
                return tipo switch
                {
                    TipoConta.Corrente => service.GetService<ContaCorrenteService>(),
                    TipoConta.Poupanca => service.GetService<ContaPoupancaService>(),
                    TipoConta.Estudantil => service.GetService<ContaEstudantilService>(),
                    _ => throw new ArgumentException($"Invalid value for {nameof(Conta)} enum: {tipo}"),
                };
            });

            return services.BuildServiceProvider();
        }
    }
}
