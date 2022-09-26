using System;
using System.Collections.Generic;
using System.Text;

namespace GameSalesSimulation.Entities
{
    public class Game
    {
        public int GameId { get; set; }
        public string GameName { get; set; }
        public double Price { get; set; }
        public string CategoryOfGame { get; set; }
    }
}
