using Dapper;
using Estoque.Domain.Interfaces.Repository;
using Estoque.Domain.Models;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace Estoque.Infraestructure.Repository
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly IConfiguration _configuration;
        private readonly SqlConnection _connection;

        public ClienteRepository(IConfiguration configuration)
        {
            _configuration = configuration;
            _connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection"));
        }

        public void Alterar(Cliente input)
        {
            var p = new DynamicParameters();

            p.AddDefault("@IdCliente", input.IdCliente);
            p.AddDefault("@Nome", input.Nome);
            p.AddDefault("@Endereco", input.Endereco);
            p.AddDefault("@Telefone", input.Telefone);
            p.AddDefault("@Observacao", input.Observacao);
            p.AddAtivo(input.Ativo);
            p.AddUsuarioCriacao(input.UsuarioCriacao);
            p.AddDataCriacao(input.DataCriacao);
            p.AddUsuarioAtualizacao(input.UsuarioAtualizacao);
            p.AddDataAtualizacao(input.DataAtualizacao);

            _connection.Execute("PROC_U_CLIENTE", p, commandType: System.Data.CommandType.StoredProcedure);
        }

        public void Inserir(Cliente input)
        {
            var p = new DynamicParameters();

            p.AddDefault("@Nome", input.Nome);
            p.AddDefault("@Endereco", input.Endereco);
            p.AddDefault("@Telefone", input.Telefone);
            p.AddDefault("@Observacao", input.Observacao);
            p.AddAtivo(input.Ativo);
            p.AddUsuarioCriacao(input.UsuarioCriacao);
            p.AddDataCriacao(input.DataCriacao);
            p.AddUsuarioAtualizacao(input.UsuarioAtualizacao);
            p.AddDataAtualizacao(input.DataAtualizacao);

            _connection.Execute("PROC_I_CLIENTE", p, commandType: System.Data.CommandType.StoredProcedure);
        }

        public Cliente Obter(int id)
        {
            var p = new DynamicParameters();

            p.AddDefault("@IdCliente", id);

            var result = _connection.Query<Cliente>("PROC_S_CLIENTE", p, commandType: System.Data.CommandType.StoredProcedure).AsList();
            return result.FirstOrDefault();
        }

        public IEnumerable<Cliente> ObterTodos(int? idMarca, int? idCliente)
        {
            var p = new DynamicParameters();

            if (idMarca.HasValue)
                p.AddDefault("@IdMarca", idMarca);
            if (idCliente.HasValue)
                p.AddDefault("@Descricao", idCliente);

            var result = _connection.Query<Cliente>("PROC_S_CLIENTE", p, commandType: System.Data.CommandType.StoredProcedure);
            return result;
        }

        public IEnumerable<Cliente> ObterTodos()
        {
            var result = _connection.Query<Cliente>("PROC_S_CLIENTE", commandType: System.Data.CommandType.StoredProcedure);
            return result;
        }
    }
}