using Dapper;
using Estoque.Domain.Interfaces.Repository;
using Estoque.Domain.Models;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace Estoque.Infraestructure.Repository
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly IConfiguration _configuration;
        private readonly SqlConnection _connection;

        public ProdutoRepository(IConfiguration configuration)
        {
            _configuration = configuration;
            _connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection"));
        }

        public void Alterar(Produto input)
        {
            var p = new DynamicParameters();

            p.AddDefault("@IdMarca", input.IdMarca);
            p.AddDefault("@IdCategoria", input.IdCategoria);
            p.AddDefault("@IdSegmento", input.IdSegmento);
            p.AddDefault("@IdCor", input.IdCor);
            p.AddDefault("@IdProduto", input.IdProduto);
            p.AddDefault("@Descricao", input.Descricao);
            p.AddAtivo(input.Ativo);
            p.AddUsuarioCriacao(input.UsuarioCriacao);
            p.AddDataCriacao(input.DataCriacao);
            p.AddUsuarioAtualizacao(input.UsuarioAtualizacao);
            p.AddDataAtualizacao(input.DataAtualizacao);

            _connection.Execute("PROC_U_PRODUTO", p, commandType: System.Data.CommandType.StoredProcedure);
        }

        public void Inserir(Produto input)
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

            _connection.Execute("PROC_I_PRODUTO", p, commandType: System.Data.CommandType.StoredProcedure);
        }

        public Produto Obter(int id)
        {
            throw new System.NotImplementedException();
        }

        public Produto Obter(int idMarca, int idCategoria, int idSegmento, int idCor, int idProduto)
        {
            var p = new DynamicParameters();

            p.AddDefault("@IdMarca", idMarca);
            p.AddDefault("@IdCategoria", idCategoria);
            p.AddDefault("@IdSegmento", idSegmento);
            p.AddDefault("@IdCor", idCor);
            p.AddDefault("@IdProduto", idProduto);

            var result = _connection.Query<Produto>("PROC_S_PRODUTO", p, commandType: System.Data.CommandType.StoredProcedure).AsList();
            return result.FirstOrDefault();
        }

        public IEnumerable<Produto> ObterTodos()
        {
            var result = _connection.Query<Produto>("PROC_S_PRODUTO", commandType: System.Data.CommandType.StoredProcedure);
            return result;
        }

        public IEnumerable<Produto> ObterTodos(int? idMarca, int? idCategoria, int? idSegmento, int? idCor, int? idProduto)
        {
            var p = new DynamicParameters();

            p.AddDefault("@IdMarca", idMarca);
            p.AddDefault("@IdCategoria", idCategoria);
            p.AddDefault("@IdSegmento", idSegmento);
            p.AddDefault("@IdCor", idCor);
            p.AddDefault("@IdProduto", idProduto);

            var result = _connection.Query<Produto>("PROC_S_PRODUTO", p, commandType: System.Data.CommandType.StoredProcedure);
            return result;
        }
    }
}