using Dapper;
using Estoque.Domain.Interfaces.Repository;
using Estoque.Domain.Models;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace Estoque.Infraestructure.Repository
{
    public class PedidoRepository : IPedidoRepository
    {
        private readonly IConfiguration _configuration;
        private readonly SqlConnection _connection;

        public PedidoRepository(IConfiguration configuration)
        {
            _configuration = configuration;
            _connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection"));
        }

        public void Alterar(Pedido input)
        {
            var p = new DynamicParameters();

            p.AddDefault("@IdPedido", input.IdPedido);
            p.AddDefault("@IdFornecedor", input.IdFornecedor);
            p.AddDefault("@IdPedidoStatus", input.IdPedidoStatus);
            p.AddDefault("@Quantidade", input.Quantidade);
            p.AddDefault("@Custo", input.Custo);
            p.AddDefault("@Desconto", input.Desconto);
            p.AddDefault("@Total", input.Total);
            p.AddAtivo(input.Ativo);
            p.AddUsuarioCriacao(input.UsuarioCriacao);
            p.AddDataCriacao(input.DataCriacao);
            p.AddUsuarioAtualizacao(input.UsuarioAtualizacao);
            p.AddDataAtualizacao(input.DataAtualizacao);

            _connection.Execute("PROC_U_PEDIDO", p, commandType: System.Data.CommandType.StoredProcedure);
        }

        public void Inserir(Pedido input)
        {
            var p = new DynamicParameters();

            p.AddDefault("@IdFornecedor", input.IdFornecedor);
            p.AddDefault("@IdPedidoStatus", input.IdPedidoStatus);
            p.AddDefault("@Quantidade", input.Quantidade);
            p.AddDefault("@Custo", input.Custo);
            p.AddDefault("@Desconto", input.Desconto);
            p.AddDefault("@Total", input.Total);
            p.AddAtivo(input.Ativo);
            p.AddUsuarioCriacao(input.UsuarioCriacao);
            p.AddDataCriacao(input.DataCriacao);
            p.AddUsuarioAtualizacao(input.UsuarioAtualizacao);
            p.AddDataAtualizacao(input.DataAtualizacao);

            _connection.Execute("PROC_I_PEDIDO", p, commandType: System.Data.CommandType.StoredProcedure);
        }

        public Pedido Obter(int id)
        {
            var p = new DynamicParameters();

            p.AddDefault("@IdPedido", id);

            var result = _connection.Query<Pedido>("PROC_S_PEDIDO", p, commandType: System.Data.CommandType.StoredProcedure).AsList();
            return result.FirstOrDefault();
        }

        public IEnumerable<Pedido> ObterTodos()
        {
            var result = _connection.Query<Pedido>("PROC_S_PEDIDO", commandType: System.Data.CommandType.StoredProcedure);
            return result;
        }
    }
}