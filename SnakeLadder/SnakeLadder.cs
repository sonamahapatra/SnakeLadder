using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadder
{
    public class SnakeLadder
    {
        public int playerPosition = 0;

        public void Game()
        {
            Random random = new Random();
            int DieRoll = random.Next(1, 7);
            playerPosition = DieRoll;
            Console.WriteLine("Player Position is :" + playerPosition);
            Console.ReadLine();
        }
    }
    
}
