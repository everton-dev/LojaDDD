using Estoque.Application.Interfaces.Application.Base;
using Estoque.Entities.Views;
using System.Collections.Generic;

namespace Estoque.Application.Interfaces.Application
{
    public interface ISegmentoApplication : IApplication<SegmentoView>
    {
        SegmentoView Obter(int idMarca, int idCategoria, int idSegmento);
        IEnumerable<SegmentoView> ObterTodos(int? idMarca, int? idCategoria, int? idSegmento);
    }
}