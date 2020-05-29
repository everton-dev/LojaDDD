using Estoque.Application.Interfaces.Application.Base;
using Estoque.Entities.Views;
using System.Collections.Generic;

namespace Estoque.Application.Interfaces.Application
{
    public interface ICorApplication : IApplication<CorView>
    {
        CorView Obter(int idMarca, int idCategoria, int idSegmento, int idCor);
        IEnumerable<CorView> ObterTodos(int? idMarca, int? idCategoria, int? idSegmento, int? idCor);
    }
}