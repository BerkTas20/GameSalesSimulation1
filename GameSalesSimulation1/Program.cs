using GameSalesSimulation.Abstract;
using GameSalesSimulation.Concrete;
using GameSalesSimulation.Entities;

using System;

namespace GameSalesSimulation
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseGamerManager customerGamer = new BaseGamerManager();

            Gamer gamer1 = new Gamer()

            {
                Id = 1,
                Name = "John",
                Surname = "Doe",
                DateOfBirth = new DateTime(1990, 1, 9),
                IdentifyNumber = "12345678945"
            };
            customerGamer.Add(gamer1);
            customerGamer.Update(gamer1);
            customerGamer.Delete(gamer1);



            Game game1 = new Game()
            {
                GameId = 1,
                GameName = "Valheim",
                GamePrice = 100

            };
            GameManager gameManager = new GameManager();
            gameManager.Add(game1);
            gameManager.Delete(game1);
            gameManager.Update(game1);





            Campaign campaign1 = new Campaign()
            {
                CampaignId = 1,
                CampaignName = "CoffeeStainStudios are on sale in turkey",
                CampaignDetails = "%50 Discount ! ",
            };
            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign1);
            campaignManager.Update(campaign1);
            campaignManager.Delete(campaign1);


            SalesManager salesManager1 = new SalesManager();
            salesManager1.Sale(gamer1);

            DatabaseLoggerService databaseLoggerService = new DatabaseLoggerService();
            databaseLoggerService.Log(databaseLoggerService);






        }
    }
}
