using System.Collections.Generic;

namespace Finan.Domain.Contracts.Repositories
{
    public interface IRepositoryBase<T> where T : class
    {
        IList<T> Get();
        T GetById(int id);
        T Create(T item);
        void Update(T item);
        void Delete(T item);
    }
}