using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissors
{
    public class Player1  //might not need to inherit
    {
        public string Name { get; set; }

        public Player1()
        {
            Name = "Player 1";
        }
        public Roshambo RoshamboValue => Roshambo.rock;

      
    }
}
