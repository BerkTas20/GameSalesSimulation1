using GameSalesSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSalesSimulation.Abstract
{
    public interface IGamerControlServices
    {
        bool CheckIfRealPerson(Gamer gamer);
    }
}
