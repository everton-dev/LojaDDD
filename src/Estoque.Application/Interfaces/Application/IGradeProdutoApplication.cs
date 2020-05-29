using Estoque.Application.Interfaces.Application.Base;
using Estoque.Entities.Views;
using System.Collections.Generic;

namespace Estoque.Application.Interfaces.Application
{
    public interface IGradeProdutoApplication : IApplication<GradeProdutoView>
    {
        GradeProdutoView Obter(int IdMarca, int IdCategoria, int IdSegmento, int IdCor, int IdProduto, int IdProdutoItem, int IdGradeProduto);
        IEnumerable<GradeProdutoView> ObterTodos(int? IdMarca, int? IdCategoria, int? IdSegmento, int? IdCor, int? IdProduto, int? IdProdutoItem, int? IdGradeProduto, int? IdPedido);
    }
}