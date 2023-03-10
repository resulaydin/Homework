using GameManagerSystem.Business.Abstract;
using GameManagerSystem.DataAccess.Abstract;
using GameManagerSystem.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameManagerSystem.Business.Concrete
{
    public class CampaignManager : EntityServiceBase<ICampaignDal, Campaign>,ICampaignService
    {
        public CampaignManager(ICampaignDal entityDal) : base(entityDal)
        {
        }
    }
}
