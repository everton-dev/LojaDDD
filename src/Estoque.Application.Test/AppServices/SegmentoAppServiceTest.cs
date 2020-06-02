using Estoque.Application.Interfaces.Application;
using Estoque.Application.Test.Configuration;
using Estoque.Entities.Views;
using Microsoft.Extensions.DependencyInjection;
using System;
using Xunit;

namespace Estoque.Application.Test.AppServices
{
    public class SegmentoAppServiceTest : IClassFixture<TestStartup>
    {
        private ServiceProvider _serviceProvide;
        private readonly ISegmentoApplication _SegmentoApplication;

        public SegmentoAppServiceTest(TestStartup configuration)
        {
            _serviceProvide = configuration.ServiceProvider;
            _SegmentoApplication = _serviceProvide.GetService<ISegmentoApplication>();
        }

        [Fact]
        public void AdicionarTeste()
        {
            SegmentoView input = new SegmentoView();

            input.IdMarca = 1;
            input.IdCategoria = 1;
            input.Descricao = "Infantil";
            input.Ativo = true;
            input.UsuarioCriacao = "ebenedicto";
            input.DataCriacao = DateTime.Now;
            input.UsuarioAtualizacao = null;
            input.DataAtualizacao = null;

            _SegmentoApplication.Inserir(input);
        }
    }
}