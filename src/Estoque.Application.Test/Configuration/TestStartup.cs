using Estoque.Application.AppServices;
using Estoque.Application.Configuration;
using Estoque.Application.Interfaces.Application;
using Estoque.Domain.Interfaces.Repository;
using Estoque.Infraestructure.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Globalization;

namespace Estoque.Application.Test.Configuration
{
    public class TestStartup
    {
        public ServiceProvider ServiceProvider { get; private set; }

        public TestStartup()
        {
            var ContentRootPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            var EnvironmentName = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
            var serviceCollection = new ServiceCollection();

            var configuration = new ConfigurationBuilder()
                .SetBasePath(ContentRootPath)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddJsonFile("appsettings.Test.json", optional: true)
                .AddEnvironmentVariables()
                .Build();

            serviceCollection.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            serviceCollection.AddLogging();

            serviceCollection.AddSingleton(configuration);
            serviceCollection.AddSingleton<IConfiguration>(configuration);

            //Mappings
            serviceCollection.AddSingleton(AutoMapperConfig.RegisterMappings());

            this.RegisterAppServices(serviceCollection);
            this.RegisterRepositories(serviceCollection);

            this.ServiceProvider = serviceCollection.BuildServiceProvider();

            //seta cultura para pt-BR
            var cultureInfo = new CultureInfo("pt-BR");
            cultureInfo.NumberFormat.CurrencySymbol = "R$";

            CultureInfo.DefaultThreadCurrentCulture = cultureInfo;
            CultureInfo.DefaultThreadCurrentUICulture = cultureInfo;
        }

        private void RegisterAppServices(IServiceCollection services)
        {
            services.AddScoped<ICategoriaApplication, CategoriaAppService>();
            services.AddScoped<IClienteApplication, ClienteAppService>();
            services.AddScoped<ICorApplication, CorAppService>();
            services.AddScoped<IFornecedorApplication, FornecedorAppService>();
            services.AddScoped<IGradeProdutoApplication, GradeProdutoAppService>();
            services.AddScoped<IMarcaApplication, MarcaAppService>();
            services.AddScoped<IPedidoApplication, PedidoAppService>();
            services.AddScoped<IPedidoStatusApplication, PedidoStatusAppService>();
            services.AddScoped<IProdutoApplication, ProdutoAppService>();
            services.AddScoped<IProdutoItemApplication, ProdutoItemAppService>();
            services.AddScoped<ISegmentoApplication, SegmentoAppService>();
        }

        private void RegisterRepositories(IServiceCollection services)
        {
            services.AddScoped<ICategoriaRepository, CategoriaRepository>();
            services.AddScoped<IClienteRepository, ClienteRepository>();
            services.AddScoped<ICorRepository, CorRepository>();
            services.AddScoped<IFornecedorRepository, FornecedorRepository>();
            services.AddScoped<IGradeProdutoRepository, GradeProdutoRepository>();
            services.AddScoped<IMarcaRepository, MarcaRepository>();
            services.AddScoped<IPedidoRepository, PedidoRepository>();
            services.AddScoped<IPedidoStatusRepository, PedidoStatusRepository>();
            services.AddScoped<IProdutoRepository, ProdutoRepository>();
            services.AddScoped<IProdutoRepository, ProdutoRepository>();
            services.AddScoped<ISegmentoRepository, SegmentoRepository>();
        }
    }
}