using Estoque.Application.Interfaces.Application;
using Estoque.Application.Test.Configuration;
using Estoque.Entities.Views;
using Microsoft.Extensions.DependencyInjection;
using System;
using Xunit;

namespace Estoque.Application.Test.AppServices
{
    public class ProdutoItemAppServiceTest : IClassFixture<TestStartup>
    {
        private ServiceProvider _serviceProvide;
        private readonly IProdutoItemApplication _ProdutoItemApplication;

        public ProdutoItemAppServiceTest(TestStartup configuration)
        {
            _serviceProvide = configuration.ServiceProvider;
            _ProdutoItemApplication = _serviceProvide.GetService<IProdutoItemApplication>();
        }

        [Fact]
        public void AdicionarTeste()
        {
            ProdutoItemView input = new ProdutoItemView();

            input.IdMarca = 1;
            input.IdCategoria = 1;
            input.IdSegmento = 2;
            input.IdCor = 4;
            input.IdProduto = 4;
            input.Tamanho = "1";
            input.Ativo = true;
            input.UsuarioCriacao = "ebenedicto";
            input.DataCriacao = DateTime.Now;
            input.UsuarioAtualizacao = null;
            input.DataAtualizacao = null;

            _ProdutoItemApplication.Inserir(input);

            input.Tamanho = "2";
            _ProdutoItemApplication.Inserir(input);

            input.Tamanho = "3";
            _ProdutoItemApplication.Inserir(input);

            input.Tamanho = "4";
            _ProdutoItemApplication.Inserir(input);

            input.Tamanho = "5";
            _ProdutoItemApplication.Inserir(input);

            input.Tamanho = "6";
            _ProdutoItemApplication.Inserir(input);

            input.Tamanho = "7";
            _ProdutoItemApplication.Inserir(input);

            input.Tamanho = "8";
            _ProdutoItemApplication.Inserir(input);

            input.Tamanho = "9";
            _ProdutoItemApplication.Inserir(input);

            input.Tamanho = "10";
            _ProdutoItemApplication.Inserir(input);

            input.Tamanho = "11";
            _ProdutoItemApplication.Inserir(input);

            input.Tamanho = "12";
            _ProdutoItemApplication.Inserir(input);
        }
    }
}