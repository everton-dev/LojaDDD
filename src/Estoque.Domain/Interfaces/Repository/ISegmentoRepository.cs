using Estoque.Domain.Interfaces.Repository.Base;
using Estoque.Domain.Models;
using System.Collections.Generic;

namespace Estoque.Domain.Interfaces.Repository
{
    public interface ISegmentoRepository : IRepository<Segmento>
    {
        Segmento Obter(int idMarca, int idCategoria, int idSegmento);
        IEnumerable<Segmento> ObterTodos(int? idMarca, int? idCategoria, int? idSegmento);
    }
}