using System.Collections.Generic;
using ProjectKasir.Model;

namespace ProjectKasir.Repository
{
    public abstract class RepositoryBase<T> : IRepository<T> where T : class
    {
        protected readonly DatabaseContext _context;

        public RepositoryBase(DatabaseContext context)
        {
            _context = context;
        }

        public abstract IEnumerable<T> GetAll();

        public abstract T GetById(string id);

        public abstract void Insert(T entity);

        public abstract void Update(T entity);

        public abstract void Delete(string id);
    }
}
