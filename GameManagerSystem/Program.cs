using GameManagerSystem.Adapter;
using GameManagerSystem.Business.Concrete;
using GameManagerSystem.DataAccess.Concrete.Databasess;
using GameManagerSystem.DataAccess.Concrete.EntityFramework;
using GameManagerSystem.Entities.Abstract;
using GameManagerSystem.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using static Azure.Core.HttpHeader;

namespace GameManagerSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {


            #region CRUD on Game Object

            //GameManager gameManager = new GameManager(new EfGameDal());
            //var game = new Game() { Description = "Bowling", UnitInStock = 20, UnitPrice = 10 };

            ////Game Add
            //gameManager.Add(game);

            ////Game Update
            //var gameFromDB = gameManager.GetById(game.Id);
            //gameFromDB.UnitPrice = 500;
            //gameManager.Update(gameFromDB);

            ////Game Delete
            //gameManager.Delete(game);

            #endregion

            #region CRUD on Gamer Object

            //GamerManager gamerManager = new GamerManager(new EfGamerDal(), new MernisCheckServiceAdapter());
            //var gamer = new Gamer()
            //{
            //    FirstName = "Tenacious",
            //    LastName = "Human",
            //    NationalityId = "1111111",
            //    DateOfBirth = new DateTime(1999, month: 9, day: 19),
            //    City = "World"
            //};

            //// Gamer Add
            //gamerManager.Add(gamer);

            //// Gamer Update
            //var gamerFromDb = gamerManager.GetAll().Last();
            //gamerFromDb.FirstName = "Resul";
            //gamerManager.Update(gamerFromDb);

            //// Gamer Delete
            //gamerManager.Delete(gamerFromDb);
            #endregion

            #region CRUD on Campaign Object
            //CampaignManager campaignManager = new CampaignManager(new EfCampaignDal());
            //Campaign campaign = new Campaign()
            //{
            //    Name = "Efsane Mart Kampanyası",
            //    Description = "Mart ayının 9-20 tarihleri arasında geçerlidir.",
            //    DiscountPercentage = 20,
            //    StartDate = new DateTime(2023, month: 03, day: 09),
            //    EndDate = new DateTime(2023, month: 03, day: 20)
            //};

            //campaignManager.Add(campaign);


            //var campaignFromDB = campaignManager.GetAll().First();
            //campaignFromDB.Description = "Mart ayının 9-20 tarihleri arasında geçerlidir. Sonra süre uzatılabilir.";
            //campaignManager.Update(campaignFromDB);
            ////Delete
            //campaignManager.Delete(campaignFromDB); 
            #endregion


            #region CRUD on OrderManager Object
            //OrderManager orderManager =new OrderManager(new EfOrderDal());
            //orderManager.OrderProcess(gamer,campaign);
            //var orderFromDB = orderManager.GetAll().Last();
            #endregion


            #region CRUD on OrderDetailManager Object
            //OrderDetailManager orderDetailManager = new OrderDetailManager(new EfOrderDetailDal());
            //orderDetailManager.SellingProcess(gameFromDB, orderFromDB,campaign);
            #endregion
        }
    }
}