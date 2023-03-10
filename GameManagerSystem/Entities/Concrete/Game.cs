using GameManagerSystem.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameManagerSystem.Entities.Concrete
{
    public class Game:IEntity
    {
        public int Id { get; set; }
        public string? Description { get; set; }
        public int UnitInStock { get; set; }
        public decimal UnitPrice { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }=new List<OrderDetail>();

    }
}
