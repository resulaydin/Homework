using GameManagerSystem.DataAccess.Abstract;
using GameManagerSystem.DataAccess.Abstract.Repositories;
using GameManagerSystem.Entities.Concrete;
using System.Linq.Expressions;

namespace GamerManagerSystem.DataAccess.Abstract
{
    public interface IGamerDal:IEntityRepository<Gamer>
    {



        #region IEntityRepository<T> Interfacesi oluşturulmadan önceki durum
        // Tabi sonrasında hem entity hemde context yapısına uygun flexible bir yapı olan 
        // ve IEntityRepository<TEntity> interfacesini immplement edecek olan Base EfEntityRepositoryBase<TEntity,TContext>
        // sınıfı oluşturulacaktır.

        //void Add(Gamer gamer);
        //void Update(Gamer gamer);
        //void Delete(Gamer gamer);
        //List<Gamer> Get(Expression<Func<Gamer, bool>> filter);
        //Gamer GetById(int id);
        //List<Gamer> GetAll(Expression<Func<Gamer, bool>> filter = null); 
        #endregion
    }
}
