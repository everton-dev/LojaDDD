using System.Collections.Generic;

namespace Estoque.Domain.Interfaces.Repository.Base
{
    public interface IRepository<TEntity>
    {
        void Alterar(TEntity input);
        void Inserir(TEntity input);
        TEntity Obter(int id);
        IEnumerable<TEntity> ObterTodos();
    }
}