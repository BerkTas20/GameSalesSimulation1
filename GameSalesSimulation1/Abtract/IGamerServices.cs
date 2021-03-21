using GameSalesSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSalesSimulation.Abstract
{
    public interface IGamerServices
    {
        void Add(Gamer gamer);
        void Update(Gamer gamer);
        void Delete(Gamer gamer);
    }
}
