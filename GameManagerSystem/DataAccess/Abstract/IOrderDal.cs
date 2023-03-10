using GameManagerSystem.DataAccess.Abstract;
using GameManagerSystem.DataAccess.Abstract.Repositories;
using GameManagerSystem.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagerSystem.DataAccess.Abstract
{
    public interface IOrderDal: IEntityRepository<Order>
    {


        #region IEntityRepository<T> Interfacesi oluşturulmadan önceki durum
        // Tabi sonrasında hem entity hemde context yapısına uygun flexible bir yapı olan 
        // ve IEntityRepository<TEntity> interfacesini immplement edecek olan Base EfEntityRepositoryBase<TEntity,TContext>
        // sınıfı oluşturulacaktır.


        //void Add(Order order);
        //void Update(Order order);
        //void Delete(Order order);
        //List<Order> Get(Expression<Func<Order, bool>> filter);
        //Order GetById(int id);
        //List<Order> GetAll(Expression<Func<Order, bool>> filter = null);
        #endregion
    }
}
