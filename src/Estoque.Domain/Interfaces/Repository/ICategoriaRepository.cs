using Estoque.Domain.Interfaces.Repository.Base;
using Estoque.Domain.Models;
using System.Collections.Generic;

namespace Estoque.Domain.Interfaces.Repository
{
    public interface ICategoriaRepository : IRepository<Categoria>
    {
        Categoria Obter(int idMarca, int idCategoria);
        IEnumerable<Categoria> ObterTodos(int? idMarca, int? idCategoria);
    }
}