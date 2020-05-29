using Estoque.Domain.Interfaces.Repository.Base;
using Estoque.Domain.Models;
using System.Collections.Generic;

namespace Estoque.Domain.Interfaces.Repository
{
    public interface IGradeProdutoRepository : IRepository<GradeProduto>
    {
        GradeProduto Obter(int IdMarca, int IdCategoria, int IdSegmento, int IdCor, int IdProduto, int IdProdutoItem, int IdGradeProduto);
        IEnumerable<GradeProduto> ObterTodos(int? IdMarca, int? IdCategoria, int? IdSegmento, int? IdCor, int? IdProduto, int? IdProdutoItem, int? IdGradeProduto, int? IdPedido);
    }
}