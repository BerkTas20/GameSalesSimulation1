using GameSalesSimulation.Abstract;
using GameSalesSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSalesSimulation.Concrete
{

    class GamerControlManager : IGamerControlServices
    {
        public bool CheckIfRealPerson(Gamer gamer)
        {
            return true;

        }
    }

}
