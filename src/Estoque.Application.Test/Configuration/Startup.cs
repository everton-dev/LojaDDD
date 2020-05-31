using Estoque.Application.AppServices;
using Estoque.Application.Interfaces.Application;
using Estoque.Domain.Interfaces.Repository;
using Estoque.Infraestructure.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace Estoque.Application.Test.Configuration
{
    public class Startup
    {
        public ServiceProvider ServiceProvider { get; private set; }

        public Startup()
        {
            var serviceCollection = new ServiceCollection();

            this.ConfigureServices(serviceCollection);
            this.ServiceProvider = serviceCollection.BuildServiceProvider();
        }

        protected void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<ICategoriaApplication, CategoriaAppService>();
            services.AddTransient<IClienteApplication, ClienteAppService>();
            services.AddTransient<ICorApplication, CorAppService>();
            services.AddTransient<IFornecedorApplication, FornecedorAppService>();
            services.AddTransient<IGradeProdutoApplication, GradeProdutoAppService>();
            services.AddTransient<IMarcaApplication, MarcaAppService>();
            services.AddTransient<IPedidoApplication, PedidoAppService>();
            services.AddTransient<IPedidoStatusApplication, PedidoStatusAppService>();
            services.AddTransient<IProdutoApplication, ProdutoAppService>();
            services.AddTransient<IProdutoItemApplication, ProdutoItemAppService>();
            services.AddTransient<ISegmentoApplication, SegmentoAppService>();

            services.AddTransient<ICategoriaRepository, CategoriaRepository>();
            services.AddTransient<IClienteRepository, ClienteRepository>();
            services.AddTransient<ICorRepository, CorRepository>();
            services.AddTransient<IFornecedorRepository, FornecedorRepository>();
            services.AddTransient<IGradeProdutoRepository, GradeProdutoRepository>();
            services.AddTransient<IMarcaRepository, MarcaRepository>();
            services.AddTransient<IPedidoRepository, PedidoRepository>();
            services.AddTransient<IPedidoStatusRepository, PedidoStatusRepository>();
            services.AddTransient<IProdutoRepository, ProdutoRepository>();
            services.AddTransient<IProdutoRepository, ProdutoRepository>();
            services.AddTransient<ISegmentoRepository, SegmentoRepository>();
        }
    }
}
