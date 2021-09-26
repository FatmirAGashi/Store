using Microsoft.EntityFrameworkCore;
using Store.Repository.Abstractions;
using Store.Repository.EntityFramework.Configurations;
using Store.Repository.EntityFramework.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Repository.Repository
{
    public class Repository<T> : IRepository<T> where T : BaseEntity, new()
    {
        private readonly AppDbContext appDbContext;
        private DbSet<T> entities;

        public Repository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
            entities = appDbContext.Set<T>();
        }

        public void Add(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("The entity is null!");
            }
            entities.Add(entity);
            appDbContext.SaveChanges();
        }

        public void Add(IEnumerable<T> entities)
        {
            appDbContext.AddRange(entities);
            appDbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            T entity= entities.SingleOrDefault(s => s.Id == id);

            if (entity == null)
            {
                throw new ArgumentNullException("The entity is null!"); 
            }

            appDbContext.Remove(entity);
        }

        public T Get(int id)
        {
            return entities.SingleOrDefault(s => s.Id == id);
        }

        public IEnumerable<T> GetAll()
        {
            return entities.AsEnumerable();
        }

        public void Save()
        {
            appDbContext.SaveChanges();
        }

        public void Update(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("The entity is null");
            }
            entities.Attach(entity);
            appDbContext.Entry(entity).State = EntityState.Modified;
            appDbContext.SaveChanges();
        }

        public void Update(IEnumerable<T> entities)
        {
            appDbContext.UpdateRange(entities);
            appDbContext.SaveChanges();
        }
    }
}
