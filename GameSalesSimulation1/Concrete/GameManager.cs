using GameSalesSimulation.Abstract;
using GameSalesSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSalesSimulation.Concrete
{
    class GameManager : IGameServices
    {


        internal void Add(Game game1)
        {
            Console.WriteLine("Game added: " + game1.GameName);
        }

        internal void Delete(Game game1)
        {
            Console.WriteLine("Game deleted" + game1.GameName);
        }

        internal void Update(Game game1)
        {
            Console.WriteLine("Game updated" + game1.GameName);
        }

        void IGameServices.Add(Game game)
        {
            throw new NotImplementedException();
        }

        void IGameServices.Delete(Game game)
        {
            throw new NotImplementedException();
        }

        void IGameServices.Update(Game game)
        {
            throw new NotImplementedException();
        }
    }
}
