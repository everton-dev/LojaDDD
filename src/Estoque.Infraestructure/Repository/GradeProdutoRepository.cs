using Dapper;
using Estoque.Domain.Interfaces.Repository;
using Estoque.Domain.Models;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace Estoque.Infraestructure.Repository
{
    public class GradeProdutoRepository : IGradeProdutoRepository
    {
        private readonly IConfiguration _configuration;
        private readonly SqlConnection _connection;

        public GradeProdutoRepository(IConfiguration configuration)
        {
            _configuration = configuration;
            _connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection"));
        }

        public void Alterar(GradeProduto input)
        {
            var p = new DynamicParameters();

            p.AddDefault("@IdMarca", input.IdMarca);
            p.AddDefault("@IdCategoria", input.IdCategoria);
            p.AddDefault("@IdSegmento", input.IdSegmento);
            p.AddDefault("@IdCor", input.IdCor);
            p.AddDefault("@IdProduto", input.IdProduto);
            p.AddDefault("@IdProdutoItem", input.IdProdutoItem);
            p.AddDefault("@IdGradeProduto", input.IdGradeProduto);
            p.AddDefault("@IdGradeProduto", input.IdGradeProduto);
            p.AddDefault("@IdPedido", input.IdPedido);
            p.AddDefault("@Quantidade", input.Quantidade);
            p.AddDefault("@Custo", input.Custo);
            p.AddDefault("@Preco", input.Preco);
            p.AddAtivo(input.Ativo);
            p.AddUsuarioCriacao(input.UsuarioCriacao);
            p.AddDataCriacao(input.DataCriacao);
            p.AddUsuarioAtualizacao(input.UsuarioAtualizacao);
            p.AddDataAtualizacao(input.DataAtualizacao);

            _connection.Execute("PROC_U_GRADE_PRODUTO", p, commandType: System.Data.CommandType.StoredProcedure);
        }

        public void Inserir(GradeProduto input)
        {
            var p = new DynamicParameters();

            p.AddDefault("@IdMarca", input.IdMarca);
            p.AddDefault("@IdCategoria", input.IdCategoria);
            p.AddDefault("@IdSegmento", input.IdSegmento);
            p.AddDefault("@IdCor", input.IdCor);
            p.AddDefault("@IdProduto", input.IdProduto);
            p.AddDefault("@IdProdutoItem", input.IdProdutoItem);
            p.AddDefault("@IdPedido", input.IdPedido);
            p.AddDefault("@Quantidade", input.Quantidade);
            p.AddDefault("@Custo", input.Custo);
            p.AddDefault("@Preco", input.Preco);
            p.AddAtivo(input.Ativo);
            p.AddUsuarioCriacao(input.UsuarioCriacao);
            p.AddDataCriacao(input.DataCriacao);
            p.AddUsuarioAtualizacao(input.UsuarioAtualizacao);
            p.AddDataAtualizacao(input.DataAtualizacao);

            _connection.Execute("PROC_I_GRADE_PRODUTO", p, commandType: System.Data.CommandType.StoredProcedure);
        }

        public GradeProduto Obter(int IdMarca, int IdCategoria, int IdSegmento, int IdCor, int IdProduto, int IdProdutoItem, int IdGradeProduto)
        {
            var p = new DynamicParameters();

            p.AddDefault("@IdMarca", IdMarca);
            p.AddDefault("@IdCategoria", IdCategoria);
            p.AddDefault("@IdSegmento", IdSegmento);
            p.AddDefault("@IdCor", IdCor);
            p.AddDefault("@IdProduto", IdProduto);
            p.AddDefault("@IdProdutoItem", IdProdutoItem);
            p.AddDefault("@IdGradeProduto", IdGradeProduto);

            var result = _connection.Query<GradeProduto>("PROC_S_GRADE_PRODUTO", p, commandType: System.Data.CommandType.StoredProcedure).AsList();
            return result.FirstOrDefault();
        }

        public GradeProduto Obter(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<GradeProduto> ObterTodos()
        {
            var result = _connection.Query<GradeProduto>("PROC_S_GRADE_PRODUTO", commandType: System.Data.CommandType.StoredProcedure);
            return result;
        }

        public IEnumerable<GradeProduto> ObterTodos(int? IdMarca, int? IdCategoria, int? IdSegmento, int? IdCor, int? IdProduto, int? IdProdutoItem, int? IdGradeProduto, int? IdPedido)
        {
            var p = new DynamicParameters();

            p.AddDefault("@IdMarca", IdMarca);
            p.AddDefault("@IdCategoria", IdCategoria);
            p.AddDefault("@IdSegmento", IdSegmento);
            p.AddDefault("@IdCor", IdCor);
            p.AddDefault("@IdProduto", IdProduto);
            p.AddDefault("@IdProdutoItem", IdProdutoItem);
            p.AddDefault("@IdGradeProduto", IdGradeProduto);
            p.AddDefault("@IdPedido", IdPedido);

            var result = _connection.Query<GradeProduto>("PROC_S_GRADE_PRODUTO", p, commandType: System.Data.CommandType.StoredProcedure);
            return result;
        }
    }
}