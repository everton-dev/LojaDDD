using Estoque.Application.Interfaces.Application;
using Estoque.Application.Test.Configuration;
using Estoque.Entities.Views;
using Microsoft.Extensions.DependencyInjection;
using System;
using Xunit;

namespace Estoque.Application.Test.AppServices
{
    public class CategoriaAppServiceTest : IClassFixture<TestStartup>
    {
        private ServiceProvider _serviceProvide;
        private readonly ICategoriaApplication _categoriaApplication;

        public CategoriaAppServiceTest(TestStartup configuration)
        {
            _serviceProvide = configuration.ServiceProvider;
            _categoriaApplication = _serviceProvide.GetService<ICategoriaApplication>();
        }

        [Fact]
        public void AdicionarTeste()
        {
            CategoriaView input = new CategoriaView();

            input.IdMarca = 0;
            input.Descricao = "";
            input.Ativo = false;
            input.UsuarioCriacao = "";
            input.DataCriacao = DateTime.Now;
            input.UsuarioAtualizacao = null;
            input.DataAtualizacao = null;

            _categoriaApplication.Inserir(input);
        }
    }
}
