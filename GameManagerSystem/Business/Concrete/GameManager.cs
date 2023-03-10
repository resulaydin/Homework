using GameManagerSystem.Business.Abstract;
using GameManagerSystem.DataAccess.Abstract;
using GameManagerSystem.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace GameManagerSystem.Business.Concrete
{
    public class GameManager : EntityServiceBase<IGameDal, Game>, IGameService
    {
        public GameManager(IGameDal entityDal) : base(entityDal)
        {
        }
    }
}
