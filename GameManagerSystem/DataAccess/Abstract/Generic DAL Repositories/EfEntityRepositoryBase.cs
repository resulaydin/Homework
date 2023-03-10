using GameManagerSystem.Entities.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace GameManagerSystem.DataAccess.Abstract.Repositories
{
    public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
        where TEntity : class, IEntity, new()
        where TContext : DbContext, new()
    {

        public void Add(TEntity entity)
        {
            using (var _context = new TContext())
            {
                _context.Add(entity);
                _context.SaveChanges();
            }
        }

        public void Delete(TEntity entity)
        {
            using (var _context = new TContext())
            {
                _context.Remove(entity);
                _context.SaveChanges();
            }
        }

        public List<TEntity> Get(Expression<Func<TEntity, bool>> filter)
        {
            using (var _context = new TContext())
            {
                return _context.Set<TEntity>().Where(filter).ToList();
            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (var _context = new TContext())
            {
                return filter == null ? _context.Set<TEntity>().ToList() : _context.Set<TEntity>().Where(filter).ToList();
            }
        }

        public TEntity GetById(int entityId)
        {
            using (var _context = new TContext())
            {
                return _context.Set<TEntity>().Find(entityId) ?? new TEntity();
            }
        }

        public void Update(TEntity entity)
        {
            using (var _context = new TContext())
            {
                _context.Update(entity);
                _context.SaveChanges();
            }
        }

    }
}
