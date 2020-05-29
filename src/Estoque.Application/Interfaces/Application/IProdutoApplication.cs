using Estoque.Application.Interfaces.Application.Base;
using Estoque.Entities.Views;
using System.Collections.Generic;

namespace Estoque.Application.Interfaces.Application
{
    public interface IProdutoApplication : IApplication<ProdutoView>
    {
        ProdutoView Obter(int idMarca, int idCategoria, int idSegmento, int idCor, int idProduto);
        IEnumerable<ProdutoView> ObterTodos(int? idMarca, int? idCategoria, int? idSegmento, int? idCor, int? idProduto);
    }
}