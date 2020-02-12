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
        Gestures gestures;





        //constructor spawner





        //member methods Can do 

        public abstract void ChooseGesture(Player eachPlayer);
    }
}
