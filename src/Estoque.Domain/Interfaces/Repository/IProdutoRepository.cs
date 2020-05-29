using Estoque.Domain.Interfaces.Repository.Base;
using Estoque.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Estoque.Domain.Interfaces.Repository
{
    public interface IProdutoRepository : IRepository<Produto>
    {
        Produto Obter(int idMarca, int idCategoria, int idSegmento, int idCor, int idProduto);
        IEnumerable<Produto> ObterTodos(int? idMarca, int? idCategoria, int? idSegmento, int? idCor, int? idProduto);
    }
}