using Dapper;
using Estoque.Domain.Interfaces.Repository;
using Estoque.Domain.Models;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace Estoque.Infraestructure.Repository
{
    public class FornecedorRepository : IFornecedorRepository
    {
        private readonly IConfiguration _configuration;
        private readonly SqlConnection _connection;

        public FornecedorRepository(IConfiguration configuration)
        {
            _configuration = configuration;
            _connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection"));
        }

        public void Alterar(Fornecedor input)
        {
            var p = new DynamicParameters();

            p.AddDefault("@IdFornecedor", input.IdFornecedor);
            p.AddDefault("@Cnpj", input.Cnpj);
            p.AddDefault("@RazaoSocial", input.RazaoSocial);
            p.AddDefault("@Telefone", input.Telefone);
            p.AddAtivo(input.Ativo);
            p.AddUsuarioCriacao(input.UsuarioCriacao);
            p.AddDataCriacao(input.DataCriacao);
            p.AddUsuarioAtualizacao(input.UsuarioAtualizacao);
            p.AddDataAtualizacao(input.DataAtualizacao);

            _connection.Execute("PROC_U_FORNECEDOR", p, commandType: System.Data.CommandType.StoredProcedure);
        }

        public void Inserir(Fornecedor input)
        {
            var p = new DynamicParameters();

            p.AddDefault("@Cnpj", input.Cnpj);
            p.AddDefault("@RazaoSocial", input.RazaoSocial);
            p.AddDefault("@Telefone", input.Telefone);
            p.AddAtivo(input.Ativo);
            p.AddUsuarioCriacao(input.UsuarioCriacao);
            p.AddDataCriacao(input.DataCriacao);
            p.AddUsuarioAtualizacao(input.UsuarioAtualizacao);
            p.AddDataAtualizacao(input.DataAtualizacao);

            _connection.Execute("PROC_I_FORNECEDOR", p, commandType: System.Data.CommandType.StoredProcedure);
        }

        public Fornecedor Obter(int id)
        {
            var p = new DynamicParameters();

            p.AddDefault("@IdFornecedor", id);

            var result = _connection.Query<Fornecedor>("PROC_S_FORNECEDOR", p, commandType: System.Data.CommandType.StoredProcedure).AsList();
            return result.FirstOrDefault();
        }

        public IEnumerable<Fornecedor> ObterTodos()
        {
            var result = _connection.Query<Fornecedor>("PROC_S_FORNECEDOR", commandType: System.Data.CommandType.StoredProcedure);
            return result;
        }
    }
}