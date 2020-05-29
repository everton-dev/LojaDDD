using Estoque.Domain.Interfaces.Repository.Base;
using Estoque.Domain.Models;
using System.Collections.Generic;

namespace Estoque.Domain.Interfaces.Repository
{
    public interface IProdutoItemRepository : IRepository<ProdutoItem>
    {
        ProdutoItem Obter(int idMarca, int idCategoria, int idSegmento, int idCor, int idProduto, int idProdutoItem);
        IEnumerable<ProdutoItem> ObterTodos(int? idMarca, int? idCategoria, int? idSegmento, int? idCor, int? idProduto, int? idProdutoItem);
    }
}