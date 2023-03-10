using GameManagerSystem.Business.Abstract;
using GameManagerSystem.DataAccess.Abstract;
using GameManagerSystem.DataAccess.Concrete.EntityFramework;
using GameManagerSystem.Entities.Concrete;
using OrderManagerSystem.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameManagerSystem.Business.Concrete
{
    public class OrderDetailManager : EntityServiceBase<IOrderDetailDal, OrderDetail>, IOrderDetailService
    {
        public OrderDetailManager(IOrderDetailDal entityDal) : base(entityDal)
        {
        }


        public void SellingProcess(Game game,Order order,Campaign campaign)
        {
            OrderDetail orderDetail=new OrderDetail();

            if (campaign.StartDate < order.OrderDate &&
               order.OrderDate < campaign.EndDate)
            {
                orderDetail.Discount = campaign.DiscountPercentage;
            }
            orderDetail.UnitPrice =game.UnitPrice -
                                    (game.UnitPrice * orderDetail.Discount/100);
            orderDetail.OrderId = order.Id;
            orderDetail.GameId = game.Id;

            base.Add(orderDetail);
        }
    }
}
