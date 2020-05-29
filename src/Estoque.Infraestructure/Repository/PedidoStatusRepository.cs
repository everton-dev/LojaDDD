using Dapper;
using Estoque.Domain.Interfaces.Repository;
using Estoque.Domain.Models;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace Estoque.Infraestructure.Repository
{
    public class PedidoStatusRepository : IPedidoStatusRepository
    {
        private readonly IConfiguration _configuration;
        private readonly SqlConnection _connection;

        public PedidoStatusRepository(IConfiguration configuration)
        {
            _configuration = configuration;
            _connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection"));
        }

        public void Alterar(PedidoStatus input)
        {
            var p = new DynamicParameters();

            p.AddDefault("@IdPedidoStatus", input.IdPedidoStatus);
            p.AddDefault("@Descricao", input.Descricao);
            p.AddAtivo(input.Ativo);
            p.AddUsuarioCriacao(input.UsuarioCriacao);
            p.AddDataCriacao(input.DataCriacao);
            p.AddUsuarioAtualizacao(input.UsuarioAtualizacao);
            p.AddDataAtualizacao(input.DataAtualizacao);

            _connection.Execute("PROC_U_PEDIDO_STATUS", p, commandType: System.Data.CommandType.StoredProcedure);
        }

        public void Inserir(PedidoStatus input)
        {
            var p = new DynamicParameters();

            p.AddDefault("@Descricao", input.Descricao);
            p.AddAtivo(input.Ativo);
            p.AddUsuarioCriacao(input.UsuarioCriacao);
            p.AddDataCriacao(input.DataCriacao);
            p.AddUsuarioAtualizacao(input.UsuarioAtualizacao);
            p.AddDataAtualizacao(input.DataAtualizacao);

            _connection.Execute("PROC_I_PEDIDO_STATUS", p, commandType: System.Data.CommandType.StoredProcedure);
        }

        public PedidoStatus Obter(int id)
        {
            var p = new DynamicParameters();

            p.AddDefault("@IdPedidoStatus", id);

            var result = _connection.Query<PedidoStatus>("PROC_S_PEDIDO_STATUS", p, commandType: System.Data.CommandType.StoredProcedure).AsList();
            return result.FirstOrDefault();
        }

        public IEnumerable<PedidoStatus> ObterTodos()
        {
            var result = _connection.Query<PedidoStatus>("PROC_S_PEDIDO_STATUS", commandType: System.Data.CommandType.StoredProcedure);
            return result;
        }
    }
}