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
        Player player1;
        Player player2;
        int score;
        string winningPlayer;
        int runningTotal;
        Gestures gestures;
        string players;
       
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
            if (numberOfPlayers == "2")
            {
                player1 = new Human();
                player2 = new Human();
            }
        }
        public void SelectGameMode(int playernumber)
        {
            int players = 0;
            switch (playernumber)
             {
                case 1:
                players = 1;
                break;
              case 2:
                players = 2;
                break;
              default:
                break;
                        
             }
              Console.ReadLine();
        }
       // public string GetGestures() 
        //{
            


       // }





        public void RunGame()
        {
            string playerOption = GetNumberOfPlayers();
            SetPlayers(playerOption);
            int players = Convert.ToInt32(playerOption);
            SelectGameMode(players);
            player1.GestureChoice = player1.GestureOptions[player1.ChooseGesture()];
            player2.GestureChoice = player2.GestureOptions[player2.ChooseGesture()];
            
        }
        
      
    }
}
