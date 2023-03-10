using GameManagerSystem.Business.Abstract;
using GameManagerSystem.Entities.Concrete;
using OrderManagerSystem.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameManagerSystem.Business.Concrete
{
    public class OrderManager : EntityServiceBase<IOrderDal, Order>, IOrderService
    {

        public OrderManager(IOrderDal entityDal) : base(entityDal)
        {
        }

        public void OrderProcess(Gamer gamer, Campaign campaign)
        {
            base.Add(new Order()
            {
                 CampaignId= campaign.Id,
                GamerId = gamer.Id,
                OrderDate = DateTime.Now
            });
        }
    }
}
