using GameSalesSimulation.Abstract;
using GameSalesSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSalesSimulation.Concrete
{
    public class GamerManager : IGamerServices
    {
        public void Add(Gamer gamer)
        {
            Console.WriteLine("Gamer" + gamer.Name + "added.");
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Gamer", gamer.Surname + "deleted");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Gamer Updated");
        }
    }
}
