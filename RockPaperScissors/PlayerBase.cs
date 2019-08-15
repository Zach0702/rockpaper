using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissors
{
    public abstract class PlayerBase
    {
        public string Name { get; set; }
        public virtual Roshambo RoshamboValue { get; set; }

        public abstract Roshambo RoshamboChoice(Player2 Player);
    }
}
