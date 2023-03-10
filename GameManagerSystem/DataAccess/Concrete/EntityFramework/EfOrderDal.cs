using GameManagerSystem.DataAccess.Abstract.Repositories;
using GameManagerSystem.DataAccess.Concrete.Databasess;
using GameManagerSystem.Entities.Concrete;
using OrderManagerSystem.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameManagerSystem.DataAccess.Concrete.EntityFramework
{
    internal class EfOrderDal: EfEntityRepositoryBase<Order, CampDatabaseContext>,IOrderDal
    {
    }
}
