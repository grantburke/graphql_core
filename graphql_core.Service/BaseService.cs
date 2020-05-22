using System.Collections.Generic;
using System.Linq;
using graphql_core.Data;
using graphql_core.Data.Models;

namespace graphql_core.Service
{
    public interface IBaseService<T>
        where T : class, TEntity
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
        T Create(T entity);
        T Update(T entity);
        void Delete(int id);
    }

    public class BaseService<T> : IBaseService<T>
        where T : class, TEntity
    {
        private readonly QuotesContext _db;
        public BaseService(QuotesContext db)
        {
            _db = db;
        }

        public IEnumerable<T> GetAll()
        {
            return _db.Set<T>();
        }

        public T GetById(int id)
        {
            return _db.Set<T>()
                .FirstOrDefault(f => f.Id == id);
        }

        public T Create(T entity)
        {
            var newEntity = _db.Set<T>().Add(entity);
            _db.SaveChanges();
            return newEntity.Entity;
        }

        public T Update(T entity)
        {
            var updatedEntity = _db.Set<T>().Update(entity);
            _db.SaveChanges();
            return updatedEntity.Entity;
        }

        public void Delete(int id)
        {
            var entity = _db.Set<T>()
                .FirstOrDefault(f => f.Id == id);
            if (entity == null)
                return;
            _db.Set<T>().Remove(entity);
        }
    }
}