using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    abstract class Gestures
    {
        //Member Variables 
        public string name;


        //constructor 

        //member methods 

        public abstract int CompareGestures(Gestures otherGesture);
    }
}
