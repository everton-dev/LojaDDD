using Dapper;
using Estoque.Domain.Interfaces.Repository;
using Estoque.Domain.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace Estoque.Infraestructure.Repository
{
    public class SegmentoRepository : ISegmentoRepository
    {
        private readonly IConfiguration _configuration;
        private readonly SqlConnection _connection;

        public SegmentoRepository(IConfiguration configuration)
        {
            _configuration = configuration;
            _connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection"));
        }

        public void Alterar(Segmento input)
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

            _connection.Execute("PROC_U_SEGMENTO", p, commandType: System.Data.CommandType.StoredProcedure);
        }

        public void Inserir(Segmento input)
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

            _connection.Execute("PROC_I_SEGMENTO", p, commandType: System.Data.CommandType.StoredProcedure);
        }

        public Segmento Obter(int idMarca, int idCategoria, int idSegmento)
        {
            var p = new DynamicParameters();

            p.AddDefault("@IdMarca", idMarca);
            p.AddDefault("@IdCategoria", idCategoria);
            p.AddDefault("@IdSegmento", idSegmento);

            var result = _connection.Query<Segmento>("PROC_S_SEGMENTO", p, commandType: System.Data.CommandType.StoredProcedure).AsList();
            return result.FirstOrDefault();
        }

        public Segmento Obter(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Segmento> ObterTodos(int? idMarca, int? idCategoria, int? idSegmento)
        {
            var p = new DynamicParameters();

            if (idMarca.HasValue)
                p.AddDefault("@IdMarca", idMarca);
            if (idCategoria.HasValue)
                p.AddDefault("@IdCategoria", idCategoria);
            if (idSegmento.HasValue)
                p.AddDefault("@IdSegmento", idSegmento);

            var result = _connection.Query<Segmento>("PROC_S_SEGMENTO", p, commandType: System.Data.CommandType.StoredProcedure);
            return result;
        }

        public IEnumerable<Segmento> ObterTodos()
        {
            var result = _connection.Query<Segmento>("PROC_S_SEGMENTO", commandType: System.Data.CommandType.StoredProcedure);
            return result;
        }
    }
}