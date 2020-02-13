using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class AI : Player // will be random
    {
        //member Variables 


        // constructor 


        //member methods
        public override int ChooseGesture() 
        {
            Random random = new Random();
            random.Next(0, 5);
            int x = random.Next(0, 5);
            return x;
        }
        
            
        
    }
}
