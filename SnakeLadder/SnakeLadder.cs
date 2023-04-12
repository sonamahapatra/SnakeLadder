﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadder
{
    public class SnakeLadder
    {
        public int playerPosition = 0;
        public const int NO_PLAY = 0, LADDER = 1, SNAKE = 2;
        Random random = new Random();
        public void Game()
        {
            Random random = new Random();
            int DieRoll = random.Next(1, 7);
            playerPosition = DieRoll;
            int Option = random.Next(0, 3);
            switch (Option)
            {
                case 1:
                    Console.WriteLine("No Play : " + playerPosition);
                    break;
                case 2:
                    playerPosition += DieRoll;
                    Console.WriteLine("lader : " + playerPosition);
                    break;
                case 3:
                    playerPosition -= DieRoll;
                    Console.WriteLine("Snake : " + playerPosition);
                    break;
            }
            Console.WriteLine("Player Position is :" + playerPosition);
            Console.ReadLine();
        }
    }
    
}
