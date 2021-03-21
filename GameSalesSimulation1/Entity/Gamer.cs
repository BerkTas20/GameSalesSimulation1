using GameSalesSimulation.Entities;
using System;

namespace GameSalesSimulation.Entities
{
    public class Gamer
    {
        internal object game1;

        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string IdentifyNumber { get; set; }

    }
}
