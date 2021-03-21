using GameSalesSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSalesSimulation.Abstract
{
    class BaseGamerManager
    {
        public virtual void Add(Gamer gamer)
        {
            Console.WriteLine("Added to: " + gamer.Name);
        }

        public virtual void Delete(Gamer gamer)
        {
            Console.WriteLine("Deleted to: " + gamer.Name);
        }

        public virtual void Update(Gamer gamer)
        {
            Console.WriteLine("Updated to: " + gamer.Name);
        }
    }
}
