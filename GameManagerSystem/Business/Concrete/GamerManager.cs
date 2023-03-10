using GameManagerSystem.Business.Abstract;
using GameManagerSystem.DataAccess.Abstract;
using GameManagerSystem.Entities.Concrete;
using GamerManagerSystem.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameManagerSystem.Business.Concrete
{
    //public class GamerManager : EntityServiceBase<IGameDal, Game>
    public class GamerManager : EntityServiceBase<IGamerDal, Gamer>, IGamerService
    {
        IGamerCheckService _gamerCheckService;
        public GamerManager(IGamerDal entityDal,IGamerCheckService gamerCheckService) : base(entityDal)
        {
            _gamerCheckService = gamerCheckService;
        }

        public override void Add(Gamer gamer)
        {
            if (_gamerCheckService.CheckIsRealPerson(gamer)){base.Add(gamer); }
            else{ Console.WriteLine("Kullanıcı Bulunamadı. Kayıt başarısız.");}

        }        
        public override void Update(Gamer gamer)
        {
            if (_gamerCheckService.CheckIsRealPerson(gamer)){base.Update(gamer); }
            else{ Console.WriteLine("Güncelleme başarısız.");}

        }
    }
}
