using GameSalesSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSalesSimulation.Abstract
{
    interface IGameServices
    {
        void Add(Game game);

        void Delete(Game game);

        void Update(Game game);
    }
}
