using GameSalesSimulation.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSalesSimulation.Concrete
{
    class DatabaseLoggerService : ILoggerService
    {
        public void Log(DatabaseLoggerService databaseLoggerService)
        {
            Console.WriteLine("Logged To Database !");
        }

        public void Log()
        {
            Console.WriteLine("Logged To Database !");
        }
    }
}
