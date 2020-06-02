using Estoque.Application.Interfaces.Application;
using Estoque.Application.Test.Configuration;
using Estoque.Entities.Views;
using Microsoft.Extensions.DependencyInjection;
using System;
using Xunit;

namespace Estoque.Application.Test.AppServices
{
    public class ProdutoAppServiceTest : IClassFixture<TestStartup>
    {
        private ServiceProvider _serviceProvide;
        private readonly IProdutoApplication _ProdutoApplication;

        public ProdutoAppServiceTest(TestStartup configuration)
        {
            _serviceProvide = configuration.ServiceProvider;
            _ProdutoApplication = _serviceProvide.GetService<IProdutoApplication>();
        }

        [Fact]
        public void AdicionarTeste()
        {
            ProdutoView input = new ProdutoView();

            input.IdMarca = 1;
            input.IdCategoria = 1;
            input.IdSegmento = 1;
            input.IdCor = 2;
            input.Descricao = "BK PJM INF RSA";
            input.Ativo = true;
            input.UsuarioCriacao = "ebenedicto";
            input.DataCriacao = DateTime.Now;
            input.UsuarioAtualizacao = null;
            input.DataAtualizacao = null;

            _ProdutoApplication.Inserir(input);
        }
    }
}