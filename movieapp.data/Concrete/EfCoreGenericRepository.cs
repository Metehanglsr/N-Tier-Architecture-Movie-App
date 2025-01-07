using Microsoft.EntityFrameworkCore;
using movieapp.data.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace movieapp.data.Concrete
{
    public class EfCoreGenericRepository<TEntity, TContext> : IRepository<TEntity> where TEntity : class where TContext : DbContext, new()
    {
        private TContext _context;
        public EfCoreGenericRepository(TContext context)
        {
            _context = context;
        }
        public void Create(TEntity entity)
        {
           _context.Set<TEntity>().Add(entity);
           _context.SaveChanges();
            
        }

        public void Delete(TEntity entity)
        {
            using (var context = new TContext())
            {
                context.Set<TEntity>().Remove(entity);
                context.SaveChanges();
            }
        }

        public List<TEntity> GetAll()
        {
            return _context.Set<TEntity>().ToList();
        }

        public TEntity GetById(int id)
        {
            var entity = _context.Set<TEntity>().Find(id);

            if (entity != null)
            {
                return entity;
            }
            else
            {
                throw new KeyNotFoundException($"ID {id} ile ilişkili varlık bulunamadı.");
            }
        }

        public void Update(TEntity entity)
        {
            using (var context = new TContext())
            {
                context.Entry(entity).State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
