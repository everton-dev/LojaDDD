using System.Collections.Generic;

namespace Estoque.Application.Interfaces.Application.Base
{
    public interface IApplication<TEntity>
    {
        void Alterar(TEntity input);
        void Inserir(TEntity input);
        TEntity Obter(int id);
        IEnumerable<TEntity> ObterTodos();
    }
}