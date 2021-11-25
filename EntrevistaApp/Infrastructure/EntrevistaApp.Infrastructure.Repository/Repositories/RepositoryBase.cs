using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntrevistaApp.Infrastructure.Repository.Repositories
{
    public abstract class RepositoryBase<TEntity> where TEntity : class
    {
        protected DbContext _context;
        public RepositoryBase(DbContext context)
        {
            _context = context;
        }

        public IEnumerable<TEntity> List()
        {
            return _context.Set<TEntity>();
        }
        public void Add(TEntity entity)
        {
            _context.Set<TEntity>().Add(entity);
            _context.SaveChanges();
        }
        public void Update(int id, TEntity entity)
        {
            _context.Update(entity);
            _context.SaveChanges();
        }
        public void Delete(int id)
        {
            var entityToDelete = _context.Set<TEntity>().Find(id);
            if (entityToDelete != null)
            {
                _context.Set<TEntity>().Remove(entityToDelete);
            }
            _context.SaveChanges();
        }
    }
}
