﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Rock : Gestures
    {
        //member variables 

        // constructor 
        public Rock()
        {
            name = "Rock";
        }
        // member methods 
        public override int CompareGestures(Gestures otherGesture)
        {
            int x = -1;
            int y = 1;
            int z = 0;

            if (otherGesture.name == "Paper"|| otherGesture.name == "Spock")
            {
                Console.WriteLine("You lose");
                return x;

            }

            else if (otherGesture.name == "Lizard" || otherGesture.name == "Scissors")
            {
                Console.WriteLine("You win");
                return y;
            }
            else
            {
                Console.WriteLine("Tie");
                return z;
            }
        }
    }
}
