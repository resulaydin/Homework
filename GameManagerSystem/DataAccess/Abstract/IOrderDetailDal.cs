using GameManagerSystem.DataAccess.Abstract.Repositories;
using GameManagerSystem.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameManagerSystem.DataAccess.Abstract
{
    public interface IOrderDetailDal: IEntityRepository<OrderDetail>
    {
    }
}
