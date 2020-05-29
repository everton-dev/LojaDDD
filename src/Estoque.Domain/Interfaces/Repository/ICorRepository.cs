using Estoque.Domain.Interfaces.Repository.Base;
using Estoque.Domain.Models;
using System.Collections.Generic;

namespace Estoque.Domain.Interfaces.Repository
{
    public interface ICorRepository : IRepository<Cor>
    {
        Cor Obter(int idMarca, int idCategoria, int idSegmento, int idCor);
        IEnumerable<Cor> ObterTodos(int? idMarca, int? idCategoria, int? idSegmento, int? idCor);
    }
}