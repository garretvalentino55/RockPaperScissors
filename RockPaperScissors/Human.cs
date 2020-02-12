using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Human : Player
    {
        //membere vairables 
        string[] gestureChoiceArray;

        //constructor 
        public Human()
        {

        }

            //member methods 

        public void Choices() 
        {
            gestureChoiceArray[0] = "Rock";
            gestureChoiceArray[1] = "Paper";
            gestureChoiceArray[2] = "Scissors";
            gestureChoiceArray[3] = "Lizard";
            gestureChoiceArray[4] = "Spock";
        }
        public override int ChooseGesture()
        {
            
        }

        public override void ChooseGesture(Player eachPlayer)
        {
        
        }

        Console.WriteLine("choose your gesture");
        gestures=Console.Readline();
    }
}
