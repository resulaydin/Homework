using GameManagerSystem.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameManagerSystem.Entities.Concrete
{
    public class Order:IEntity
    {
        public int Id { get; set; }
        public int GamerId { get; set; }
        public int? CampaignId { get; set; }
        public DateTime OrderDate { get; set; }
        public Gamer Gamer { get; set; }
        public Campaign Campaign { get; set; }
        public List<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();


    }
}
