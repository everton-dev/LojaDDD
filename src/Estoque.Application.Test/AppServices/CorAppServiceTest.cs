using Estoque.Application.Interfaces.Application;
using Estoque.Application.Test.Configuration;
using Estoque.Entities.Views;
using Microsoft.Extensions.DependencyInjection;
using System;
using Xunit;

namespace Estoque.Application.Test.AppServices
{
    public class CorAppServiceTest : IClassFixture<TestStartup>
    {
        private ServiceProvider _serviceProvide;
        private readonly ICorApplication _CorApplication;

        public CorAppServiceTest(TestStartup configuration)
        {
            _serviceProvide = configuration.ServiceProvider;
            _CorApplication = _serviceProvide.GetService<ICorApplication>();
        }

        [Fact]
        public void AdicionarTeste()
        {
            CorView input = new CorView();

            input.IdMarca = 1;
            input.IdCategoria = 1;
            input.IdSegmento = 2;
            input.Descricao = "Rosa";
            input.Ativo = true;
            input.UsuarioCriacao = "ebenedicto";
            input.DataCriacao = DateTime.Now;
            input.UsuarioAtualizacao = null;
            input.DataAtualizacao = null;

            _CorApplication.Inserir(input);
        }
    }
}