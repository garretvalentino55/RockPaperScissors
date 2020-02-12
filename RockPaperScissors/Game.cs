using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Game
    {
        //member variables Has A 
        string player1;
        string player2;
        int score;
        string winningPlayer;
        int runningTotal;
        Gestures gestures;
       
        //Constructor spawner
        public Game()
        {

        }

        //member Methods Can DO

  
        public string GetNumberOfPlayers() 
        {
            Console.WriteLine("Would you Like to Play 1 player or 2 players");
            string numberPlayers = Console.ReadLine();
            return numberPlayers;
        }
        public void SetPlayers(string numberOfPlayers)
        {

            if (numberOfPlayers == "1")
            {
                player1 = new Human();
                player2 = new AI();
            }
            else if (numberOfPlayers == "2") 
            {
                player1 = new Human();
                player2 = new Human();
            }

        }
        public void RunGame()
        {
            string players = GetNumberOfPlayers();
            SetPlayers(players);
            player1.ChooseGestures();
            player2.ChooseGestures();
        }
        public void Settings() 
        {
            GameBoundries();
        }
        public void GameBoundries() 
        {
            bool isValid = false;
            int numberOfWrong = 0;
            do
            {
                Console.WriteLine("Please choose a number on the list to proceed");
                string input = Console.ReadLine();
                int userInput = 0;
                switch (userInput)
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    default:
                        Console.WriteLine("Please choose a number from the list");
                        numberOfWrong++;
                }
            } while (isValid == false && numberOfWrong < 5);

 
        }

    }
}
