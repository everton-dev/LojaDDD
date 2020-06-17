using Estoque.Application.Interfaces.Application;
using Estoque.Application.Test.Configuration;
using Estoque.Entities.Views;
using Microsoft.Extensions.DependencyInjection;
using System;
using Xunit;

namespace Estoque.Application.Test.AppServices
{
    public class FornecedorAppServiceTest : IClassFixture<TestStartup>
    {
        private ServiceProvider _serviceProvide;
        private readonly IFornecedorApplication _FornecedorApplication;

        public FornecedorAppServiceTest(TestStartup configuration)
        {
            _serviceProvide = configuration.ServiceProvider;
            _FornecedorApplication = _serviceProvide.GetService<IFornecedorApplication>();
        }

        [Fact]
        public void AdicionarTeste()
        {
            FornecedorView input = new FornecedorView();

            input.Cnpj = "";
            input.RazaoSocial = "";
            input.Telefone = "";
            input.Ativo = true;
            input.UsuarioCriacao = "ebenedicto";
            input.DataCriacao = DateTime.Now;
            input.UsuarioAtualizacao = null;
            input.DataAtualizacao = null;

            _FornecedorApplication.Inserir(input);
        }
    }
}