using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    abstract class Player
    {
        //member variables Has A
        string name;
        int score;
        public Gestures GestureChoice;
        public List<Gestures> GestureOptions = new List<Gestures>();





        //constructor spawner


        public Player()
        {
            GestureOptions.Add(new Rock());
            GestureOptions.Add(new Paper());
            GestureOptions.Add(new Scissors());
            GestureOptions.Add(new Lizard());
            GestureOptions.Add(new Spock());
            
        }


        //member methods Can do 

        public abstract int ChooseGesture();
    }
}
