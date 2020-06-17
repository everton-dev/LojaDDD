using Estoque.Application.Interfaces.Application;
using Estoque.Application.Test.Configuration;
using Estoque.Entities.Views;
using Microsoft.Extensions.DependencyInjection;
using System;
using Xunit;

namespace Estoque.Application.Test.AppServices
{
    public class ClienteAppServiceTest : IClassFixture<TestStartup>
    {
        private ServiceProvider _serviceProvide;
        private readonly IClienteApplication _ClienteApplication;

        public ClienteAppServiceTest(TestStartup configuration)
        {
            _serviceProvide = configuration.ServiceProvider;
            _ClienteApplication = _serviceProvide.GetService<IClienteApplication>();
        }

        [Fact]
        public void AdicionarTeste()
        {
            ClienteView input = new ClienteView();


            input.Nome = "";
            input.Endereco = "";
            input.Telefone = "";
            input.Observacao = "";
            input.Ativo = true;
            input.UsuarioCriacao = "ebenedicto";
            input.DataCriacao = DateTime.Now;
            input.UsuarioAtualizacao = null;
            input.DataAtualizacao = null;

            _ClienteApplication.Inserir(input);
        }
    }
}