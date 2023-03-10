using GameManagerSystem.DataAccess.Abstract;
using GameManagerSystem.DataAccess.Abstract.Repositories;
using GameManagerSystem.DataAccess.Concrete.Databasess;
using GameManagerSystem.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameManagerSystem.DataAccess.Concrete.EntityFramework
{
    public class EfOrderDetailDal: EfEntityRepositoryBase<OrderDetail, CampDatabaseContext>,IOrderDetailDal
    {
    }
}
