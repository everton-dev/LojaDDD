using Estoque.Application.Interfaces.Application.Base;
using Estoque.Entities.Views;
using System.Collections.Generic;

namespace Estoque.Application.Interfaces.Application
{
    public interface ICategoriaApplication : IApplication<CategoriaView>
    {
        CategoriaView Obter(int idMarca, int idCategoria);
        IEnumerable<CategoriaView> ObterTodos(int? idMarca, int? idCategoria);
    }
}