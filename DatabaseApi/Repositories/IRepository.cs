using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseApi.Repositories
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        int GetCount();
        T GetById(int id);
        T Add(T entity);
        void AddRange(IEnumerable<T> entities);
        void Update(T entity);
        void Delete(T entity);
        void SaveChanges();
        T Normalize(T entity);
        bool Validate(T entity);
    }
}
