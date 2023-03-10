using GameManagerSystem.DataAccess.Abstract.Repositories;
using GameManagerSystem.Entities.Concrete;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace GameManagerSystem.DataAccess.Abstract
{
    public interface ICampaignDal:IEntityRepository<Campaign>
    {
    }
}
