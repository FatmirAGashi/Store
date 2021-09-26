using Store.Repository.EntityFramework.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Repository.Abstractions
{
    public interface IRepository<T> where T : BaseEntity
    {
        IEnumerable<T> GetAll();
        T Get(int id);
        void Update(T entity);
        void Update(IEnumerable<T> entities);
        void Add(T entity);
        void Add(IEnumerable<T> entities);
        void Delete(int id);
        void Save();
    }
}
