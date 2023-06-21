using System.Collections.Generic;

namespace ProjectKasir.Repository
{
    public interface IRepository<T>
    {
        IEnumerable<T> GetAll();

        T GetById(string id);

        void Insert(T entity);

        void Update(T entity);

        void Delete(string id);
    }
}
