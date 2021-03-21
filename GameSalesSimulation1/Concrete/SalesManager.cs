using GameSalesSimulation.Abstract;
using GameSalesSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSalesSimulation.Concrete
{
    class SalesManager : ISalesServices
    {
        public void Sale(Gamer gamer, Game game)
        {

            Console.WriteLine("Oyun, " + gamer.Name + " " + gamer.Surname + " to the player named " + game.GamePrice + " Sold !");

        }

        internal void Sale(Gamer gamer)
        {
            Console.WriteLine("Game, " + gamer.Name + " " + gamer.Surname + " Sold to player !");
        }
    }
}
