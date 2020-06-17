using Estoque.Application.Interfaces.Application;
using Estoque.Application.Test.Configuration;
using Estoque.Entities.Views;
using Microsoft.Extensions.DependencyInjection;
using System;
using Xunit;

namespace Estoque.Application.Test.AppServices
{
    public class GradeProdutoAppServiceTest : IClassFixture<TestStartup>
    {
        private ServiceProvider _serviceProvide;
        private readonly IGradeProdutoApplication _GradeProdutoApplication;

        public GradeProdutoAppServiceTest(TestStartup configuration)
        {
            _serviceProvide = configuration.ServiceProvider;
            _GradeProdutoApplication = _serviceProvide.GetService<IGradeProdutoApplication>();
        }


        [Fact]
        public void AdicionarTeste()
        {
            GradeProdutoView input = new GradeProdutoView();

            input.IdMarca = 1;
            input.IdCategoria = 1;
            input.IdSegmento = 2;
            input.IdCor = 4;
            input.IdProduto = 4;
            input.IdProdutoItem = 1;
            input.IdPedido = 0;
            input.Quantidade = 0;
            input.Custo = 0;
            input.Preco = 0;
            input.Ativo = true;
            input.UsuarioCriacao = "ebenedicto";
            input.DataCriacao = DateTime.Now;
            input.UsuarioAtualizacao = null;
            input.DataAtualizacao = null;

            _GradeProdutoApplication.Inserir(input);
        }
    }
}