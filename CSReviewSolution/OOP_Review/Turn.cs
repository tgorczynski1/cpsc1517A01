using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Review
{
    public class Turn
    {

        public int Player1 { get; set; }

        public int Player2 { get; set; }

        public Turn ()
        {

        }

        public Turn (int player1, int player2)
        {
            Player1 = player1;
            Player2 = player1;
          
        }


    }
}
