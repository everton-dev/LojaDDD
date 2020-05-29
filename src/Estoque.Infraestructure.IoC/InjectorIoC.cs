using Estoque.Domain.Interfaces.Repository;
using Estoque.Infraestructure.Repository;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Estoque.Infraestructure.IoC
{
    public static class InjectorIoC
    {
        public static void RegisterServices(IServiceCollection services, IConfiguration configuration)
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
            services.AddScoped<IProdutoItemRepository, ProdutoItemRepository>();
            services.AddScoped<ISegmentoRepository, SegmentoRepository>();
        }
    }
}