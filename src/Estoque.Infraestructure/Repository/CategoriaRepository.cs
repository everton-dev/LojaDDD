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
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly IConfiguration _configuration;
        private readonly SqlConnection _connection;

        public CategoriaRepository(IConfiguration configuration)
        {
            _configuration = configuration;
            _connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection"));
        }

        public void Alterar(Categoria input)
        {
            var p = new DynamicParameters();

            p.AddDefault("@IdCategoria", input.IdCategoria);
            p.AddDefault("@IdMarca", input.IdMarca);
            p.AddDefault("@Descricao", input.Descricao);
            p.AddAtivo(input.Ativo);
            p.AddUsuarioCriacao(input.UsuarioCriacao);
            p.AddDataCriacao(input.DataCriacao);
            p.AddUsuarioAtualizacao(input.UsuarioAtualizacao);
            p.AddDataAtualizacao(input.DataAtualizacao);

            _connection.Execute("PROC_U_CATEGORIA", p, commandType: System.Data.CommandType.StoredProcedure);
        }

        public void Inserir(Categoria input)
        {
            var p = new DynamicParameters();

            p.AddDefault("@IdMarca", input.IdMarca);
            p.AddDefault("@Descricao", input.Descricao);
            p.AddAtivo(input.Ativo);
            p.AddUsuarioCriacao(input.UsuarioCriacao);
            p.AddDataCriacao(input.DataCriacao);
            p.AddUsuarioAtualizacao(input.UsuarioAtualizacao);
            p.AddDataAtualizacao(input.DataAtualizacao);

            _connection.Execute("PROC_I_CATEGORIA", p, commandType: System.Data.CommandType.StoredProcedure);
        }

        public Categoria Obter(int idMarca, int idCategoria)
        {
            var p = new DynamicParameters();

            p.AddDefault("@IdMarca", idMarca);
            p.AddDefault("@Descricao", idCategoria);

            var result = _connection.Query<Categoria>("PROC_S_CATEGORIA", p, commandType: System.Data.CommandType.StoredProcedure).AsList();
            return result.FirstOrDefault();
        }

        public Categoria Obter(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Categoria> ObterTodos(int? idMarca, int? idCategoria)
        {
            var p = new DynamicParameters();

            if(idMarca.HasValue)
                p.AddDefault("@IdMarca", idMarca);
            if(idCategoria.HasValue)
                p.AddDefault("@Descricao", idCategoria);

            var result = _connection.Query<Categoria>("PROC_S_CATEGORIA", p, commandType: System.Data.CommandType.StoredProcedure);
            return result;
        }

        public IEnumerable<Categoria> ObterTodos()
        {
            var result = _connection.Query<Categoria>("PROC_S_CATEGORIA", commandType: System.Data.CommandType.StoredProcedure);
            return result;
        }
    }
}