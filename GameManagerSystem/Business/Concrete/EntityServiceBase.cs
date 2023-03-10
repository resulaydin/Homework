using GameManagerSystem.DataAccess.Abstract.Repositories;
using GameManagerSystem.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace GameManagerSystem.Business.Concrete
{
    public class EntityServiceBase<TIEntityDal,TEntity> : IEntityRepository<TEntity>
        where TEntity : class, IEntity, new()
        where TIEntityDal : class, IEntityRepository<TEntity>
    {
        TIEntityDal _entityDal;
        public EntityServiceBase(TIEntityDal entityDal) {
            _entityDal=entityDal;
        }

        public virtual void Add(TEntity entity)
        {
            _entityDal.Add(entity);
        }

        public void Delete(TEntity entity)
        {
            _entityDal.Delete(entity);
        }

        public List<TEntity> Get(Expression<Func<TEntity, bool>> filter)
        {
            return _entityDal.Get(filter);
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            return _entityDal.GetAll(filter);
        }

        public TEntity GetById(int entityId)
        {
            return _entityDal.GetById(entityId);
        }

        public virtual void Update(TEntity entity)
        {
            _entityDal.Update(entity);
        }
    }
}
