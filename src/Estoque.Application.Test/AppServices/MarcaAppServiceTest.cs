using Estoque.Application.Interfaces.Application;
using Estoque.Application.Test.Configuration;
using Estoque.Entities.Views;
using Microsoft.Extensions.DependencyInjection;
using System;
using Xunit;

namespace Estoque.Application.Test.AppServices
{
    public class MarcaAppServiceTest : IClassFixture<TestStartup>
    {
        private ServiceProvider _serviceProvide;
        private readonly IMarcaApplication _MarcaApplication;

        public MarcaAppServiceTest(TestStartup configuration)
        {
            _serviceProvide = configuration.ServiceProvider;
            _MarcaApplication = _serviceProvide.GetService<IMarcaApplication>();
        }

        [Fact]
        public void AdicionarTeste()
        {
            MarcaView input = new MarcaView();

            //input.IdMarca = 0;
            input.Descricao = "Bubbles Kids";
            input.Ativo = true;
            input.UsuarioCriacao = "ebenedicto";
            input.DataCriacao = DateTime.Now;
            input.UsuarioAtualizacao = null;
            input.DataAtualizacao = null;

            _MarcaApplication.Inserir(input);
        }
    }
}