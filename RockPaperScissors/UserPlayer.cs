using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissors
{
   public class UserPlayer 
    {
        public string Name { get; set; }
        public Roshambo RoshamboValue;
        public UserPlayer(string name, string choice)
        {
            Name = name;
            bool isInvalidInput = true;
            while (isInvalidInput)
            {
                if (Enum.TryParse<Roshambo>(choice, out Roshambo validEnum))
                {
                    RoshamboValue = validEnum;
                    isInvalidInput = false;
                }
                else
                {
                    Console.WriteLine("ERROR: invalid choice entered");
                    Console.WriteLine("Rock, Paper, Scissors: (1 = rock, 2 = paper, 3 = scissors)");
                    choice = Console.ReadLine();
                }
            }
        }
    }
}
