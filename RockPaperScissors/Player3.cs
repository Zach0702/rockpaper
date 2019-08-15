using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissors
{
    public class Player3 : PlayerBase
    {
        public override Roshambo RoshamboChoice(Player2 Player)
        {
            Random random = new System.Random();
            int value = random.Next(1, 3);

            if (value == 1)
            {
                return Player.RoshamboValue = Roshambo.rock;
            }
            else if (value == 2)
            {
                return Player.RoshamboValue = Roshambo.scissors;
            }
            else
            {
                return Player.RoshamboValue = Roshambo.paper;
            }
        }
    }
}
