using Dapper;
using Estoque.Domain.Interfaces.Repository;
using Estoque.Domain.Models;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace Estoque.Infraestructure.Repository
{
    public class CorRepository : ICorRepository
    {
        private readonly IConfiguration _configuration;
        private readonly SqlConnection _connection;

        public CorRepository(IConfiguration configuration)
        {
            _configuration = configuration;
            _connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection"));
        }

        public void Alterar(Cor input)
        {
            var p = new DynamicParameters();

            p.AddDefault("@IdMarca", input.IdMarca);
            p.AddDefault("@IdCategoria", input.IdCategoria);
            p.AddDefault("@IdSegmento", input.IdSegmento);
            p.AddDefault("@IdCor", input.IdCor);
            p.AddDefault("@Descricao", input.Descricao);
            p.AddAtivo(input.Ativo);
            p.AddUsuarioCriacao(input.UsuarioCriacao);
            p.AddDataCriacao(input.DataCriacao);
            p.AddUsuarioAtualizacao(input.UsuarioAtualizacao);
            p.AddDataAtualizacao(input.DataAtualizacao);

            _connection.Execute("PROC_U_COR", p, commandType: System.Data.CommandType.StoredProcedure);
        }

        public void Inserir(Cor input)
        {
            var p = new DynamicParameters();

            p.AddDefault("@IdMarca", input.IdMarca);
            p.AddDefault("@IdCategoria", input.IdCategoria);
            p.AddDefault("@IdSegmento", input.IdSegmento);
            p.AddDefault("@Descricao", input.Descricao);
            p.AddAtivo(input.Ativo);
            p.AddUsuarioCriacao(input.UsuarioCriacao);
            p.AddDataCriacao(input.DataCriacao);
            p.AddUsuarioAtualizacao(input.UsuarioAtualizacao);
            p.AddDataAtualizacao(input.DataAtualizacao);

            _connection.Execute("PROC_I_COR", p, commandType: System.Data.CommandType.StoredProcedure);
        }

        public Cor Obter(int id)
        {
            var p = new DynamicParameters();

            p.AddDefault("@IdCor", id);

            var result = _connection.Query<Cor>("PROC_S_COR", p, commandType: System.Data.CommandType.StoredProcedure).AsList();
            return result.FirstOrDefault();
        }

        public Cor Obter(int idMarca, int idCategoria, int idSegmento, int idCor)
        {
            var p = new DynamicParameters();

            p.AddDefault("@IdMarca", idMarca);
            p.AddDefault("@IdCategoria", idCategoria);
            p.AddDefault("@IdSegmento", idSegmento);
            p.AddDefault("@IdCor", idCor);

            var result = _connection.Query<Cor>("PROC_S_COR", p, commandType: System.Data.CommandType.StoredProcedure).AsList();
            return result.FirstOrDefault();
        }

        public IEnumerable<Cor> ObterTodos()
        {
            var result = _connection.Query<Cor>("PROC_S_COR", commandType: System.Data.CommandType.StoredProcedure);
            return result;
        }

        public IEnumerable<Cor> ObterTodos(int? idMarca, int? idCategoria, int? idSegmento, int? idCor)
        {
            var p = new DynamicParameters();

            p.AddDefault("@IdMarca", idMarca);
            p.AddDefault("@IdCategoria", idCategoria);
            p.AddDefault("@IdSegmento", idSegmento);
            p.AddDefault("@IdCor", idCor);

            var result = _connection.Query<Cor>("PROC_S_COR", p, commandType: System.Data.CommandType.StoredProcedure);
            return result;
        }
    }
}