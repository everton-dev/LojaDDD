using Dapper;
using Estoque.Domain.Interfaces.Repository;
using Estoque.Domain.Models;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace Estoque.Infraestructure.Repository
{
    public class ProdutoItemRepository : IProdutoItemRepository
    {
        private readonly IConfiguration _configuration;
        private readonly SqlConnection _connection;

        public ProdutoItemRepository(IConfiguration configuration)
        {
            _configuration = configuration;
            _connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection"));
        }

        public void Alterar(ProdutoItem input)
        {
            var p = new DynamicParameters();

            p.AddDefault("@IdMarca", input.IdMarca);
            p.AddDefault("@IdCategoria", input.IdCategoria);
            p.AddDefault("@IdSegmento", input.IdSegmento);
            p.AddDefault("@IdCor", input.IdCor);
            p.AddDefault("@IdProduto", input.IdProduto);
            p.AddDefault("@IdProdutoItem", input.IdProdutoItem);
            p.AddDefault("@Tamanho", input.Tamanho);
            p.AddAtivo(input.Ativo);
            p.AddUsuarioCriacao(input.UsuarioCriacao);
            p.AddDataCriacao(input.DataCriacao);
            p.AddUsuarioAtualizacao(input.UsuarioAtualizacao);
            p.AddDataAtualizacao(input.DataAtualizacao);

            _connection.Execute("PROC_U_PRODUTO_ITEM", p, commandType: System.Data.CommandType.StoredProcedure);
        }

        public void Inserir(ProdutoItem input)
        {
            var p = new DynamicParameters();

            p.AddDefault("@IdMarca", input.IdMarca);
            p.AddDefault("@IdCategoria", input.IdCategoria);
            p.AddDefault("@IdSegmento", input.IdSegmento);
            p.AddDefault("@IdCor", input.IdCor);
            p.AddDefault("@IdProduto", input.IdProduto);
            p.AddDefault("@Tamanho", input.Tamanho);
            p.AddAtivo(input.Ativo);
            p.AddUsuarioCriacao(input.UsuarioCriacao);
            p.AddDataCriacao(input.DataCriacao);
            p.AddUsuarioAtualizacao(input.UsuarioAtualizacao);
            p.AddDataAtualizacao(input.DataAtualizacao);

            _connection.Execute("PROC_I_PRODUTO_ITEM", p, commandType: System.Data.CommandType.StoredProcedure);
        }

        public ProdutoItem Obter(int id)
        {
            throw new System.NotImplementedException();
        }

        public ProdutoItem Obter(int idMarca, int idCategoria, int idSegmento, int idCor, int idProduto, int idProdutoItem)
        {
            var p = new DynamicParameters();

            p.AddDefault("@IdMarca", idMarca);
            p.AddDefault("@IdCategoria", idCategoria);
            p.AddDefault("@IdSegmento", idSegmento);
            p.AddDefault("@IdCor", idCor);
            p.AddDefault("@IdProduto", idProduto);
            p.AddDefault("@IdProdutoItem", idProdutoItem);

            var result = _connection.Query<ProdutoItem>("PROC_S_PRODUTO_ITEM", p, commandType: System.Data.CommandType.StoredProcedure).AsList();
            return result.FirstOrDefault();
        }

        public IEnumerable<ProdutoItem> ObterTodos()
        {
            var result = _connection.Query<ProdutoItem>("PROC_S_PRODUTO_ITEM", commandType: System.Data.CommandType.StoredProcedure);
            return result;
        }

        public IEnumerable<ProdutoItem> ObterTodos(int? idMarca, int? idCategoria, int? idSegmento, int? idCor, int? idProduto, int? idProdutoItem)
        {
            var p = new DynamicParameters();

            p.AddDefault("@IdMarca", idMarca);
            p.AddDefault("@IdCategoria", idCategoria);
            p.AddDefault("@IdSegmento", idSegmento);
            p.AddDefault("@IdCor", idCor);
            p.AddDefault("@IdProduto", idProduto);
            p.AddDefault("@IdProdutoItem", idProdutoItem);

            var result = _connection.Query<ProdutoItem>("PROC_S_PRODUTO_ITEM", p, commandType: System.Data.CommandType.StoredProcedure);
            return result;
        }
    }
}