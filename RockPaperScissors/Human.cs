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
     

        //constructor 
      

        //member methods 

        public void Choice(int selection)
        {

            if (selection == 1)
            {
                GestureChoice = GestureOptions[0];
            }
            if (selection == 2)
            {
                GestureChoice = GestureOptions[1];
            }
            if (selection == 3)
            {
                GestureChoice = GestureOptions[2];
            }
            if (selection == 4)
            {
                GestureChoice = GestureOptions[3];
            }
            if (selection == 5)
            {
                GestureChoice = GestureOptions[4];
            }
        }
        public override int ChooseGesture()
        {
            int gestureChoice = 0;
            foreach (Gestures gesture in GestureOptions)
            {
                Console.WriteLine("you can choose " + gesture.name);

            }
            string playerChoice = Console.ReadLine();

            bool isValid = false;
            do
            {
                
            
                switch (playerChoice)
                {
                    case "rock":
                        gestureChoice = 0;
                        isValid = true;
                        break;
                    case "paper":
                        gestureChoice = 1;
                        isValid = true;
                        break;
                    case "scissors":
                        gestureChoice = 2;
                        isValid = true;
                        break;
                    case "lizzard":
                        gestureChoice = 3;
                        isValid = true;
                        break;
                    case "spock":
                        gestureChoice = 4;
                        isValid = true;
                        break;
                    default:
                        Console.WriteLine("Please choose an option from the list");
                        break;
                }
                Console.ReadLine();
           
            } while (isValid == false);

            return gestureChoice;

        }

    }   

    
}

