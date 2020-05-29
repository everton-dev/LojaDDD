using Dapper;
using Estoque.Domain.Interfaces.Repository;
using Estoque.Domain.Models;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace Estoque.Infraestructure.Repository
{
    public class MarcaRepository : IMarcaRepository
    {
        private readonly IConfiguration _configuration;
        private readonly SqlConnection _connection;

        public MarcaRepository(IConfiguration configuration)
        {
            _configuration = configuration;
            _connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection"));
        }

        public void Alterar(Marca input)
        {
            var p = new DynamicParameters();

            p.AddDefault("@IdMarca", input.IdMarca);
            p.AddDefault("@Descricao", input.Descricao);
            p.AddAtivo(input.Ativo);
            p.AddUsuarioCriacao(input.UsuarioCriacao);
            p.AddDataCriacao(input.DataCriacao);
            p.AddUsuarioAtualizacao(input.UsuarioAtualizacao);
            p.AddDataAtualizacao(input.DataAtualizacao);

            _connection.Execute("PROC_U_MARCA", p, commandType: System.Data.CommandType.StoredProcedure);
        }

        public void Inserir(Marca input)
        {
            var p = new DynamicParameters();

            p.AddDefault("@Descricao", input.Descricao);
            p.AddAtivo(input.Ativo);
            p.AddUsuarioCriacao(input.UsuarioCriacao);
            p.AddDataCriacao(input.DataCriacao);
            p.AddUsuarioAtualizacao(input.UsuarioAtualizacao);
            p.AddDataAtualizacao(input.DataAtualizacao);

            _connection.Execute("PROC_I_MARCA", p, commandType: System.Data.CommandType.StoredProcedure);
        }

        public Marca Obter(int id)
        {
            var p = new DynamicParameters();

            p.AddDefault("@IdMarca", id);

            var result = _connection.Query<Marca>("PROC_S_MARCA", p, commandType: System.Data.CommandType.StoredProcedure).AsList();
            return result.FirstOrDefault();
        }

        public IEnumerable<Marca> ObterTodos()
        {
            var result = _connection.Query<Marca>("PROC_S_MARCA", commandType: System.Data.CommandType.StoredProcedure);
            return result;
        }
    }
}