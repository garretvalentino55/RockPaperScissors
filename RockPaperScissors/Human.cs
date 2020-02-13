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
        public override int ChooseGesture(Player eachPlayer)
        {
            int gestureChoice = 0;
            Console.WriteLine("Your Choices are: ");
            foreach (Gestures gesture in GestureOptions)
            {
                Console.WriteLine(gesture.name);

            }
            string playerChoice = Console.ReadLine();

            bool isValid = false;
            int numberOfWrong = 0;
            do

            {
                switch (playerChoice)
                {
                    case "Rock":
                        gestureChoice = 0;
                        break;
                    case "Paper":
                        gestureChoice = 1;
                        break;
                    case "Scissors":
                        gestureChoice = 2;
                        break;
                    case "Lizard":
                        gestureChoice = 3;
                        break;
                    case "Spock":
                        gestureChoice = 4;
                        break;
                    default:
                        Console.WriteLine("Please choose a number from the list");
                        numberOfWrong++;
                        break;
                }
                Console.ReadLine();
            } while (isValid == false && numberOfWrong < 5);



        }

    }   

    
}

