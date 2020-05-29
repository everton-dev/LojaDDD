using Estoque.Application.Interfaces.Application.Base;
using Estoque.Entities.Views;
using System.Collections.Generic;

namespace Estoque.Application.Interfaces.Application
{
    public interface IProdutoItemApplication : IApplication<ProdutoItemView>
    {
        ProdutoItemView Obter(int idMarca, int idCategoria, int idSegmento, int idCor, int idProduto, int idProdutoItem);
        IEnumerable<ProdutoItemView> ObterTodos(int? idMarca, int? idCategoria, int? idSegmento, int? idCor, int? idProduto, int? idProdutoItem);
    }
}