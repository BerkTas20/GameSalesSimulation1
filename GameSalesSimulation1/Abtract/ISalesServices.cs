using GameSalesSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSalesSimulation.Abstract
{
    interface ISalesServices
    {
        void Sale(Gamer gamer, Game game);

    }
}
