using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Scissors : Gestures
    {
        //member variables 

        // constructor 

        // member methods 
        public override int Compare(Gestures otherGesture)
        {
            int x = -1;
            int y = 1;
            int z = 0;

            if (otherGesture.name == "Spock" || otherGesture.name == "Rock")
            {
                Console.WriteLine("You lose");
                return x;

            }
            else if (otherGesture.name == "Lizard" || otherGesture.name == "Paper")
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
