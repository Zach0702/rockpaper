using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RockPaperScissors
{
    public class RoshamboApp
    {
        public void RunApp()
        {
            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();
            Console.WriteLine("Would you like to play against player 1 or player 2(enter 1 for player 1, 2 for player 2): ");
            int userChoice;
            userChoice = IsValidIntEntered(Console.ReadLine());
            char loopBreaker;
            int userPlayerWins = 0;
            int compPlayerWins = 0;
            

            do
            {
                if (userChoice == 1)
                {
                    Console.WriteLine("Rock, Paper, Scissors: (1 = rock, 2 = paper, 3 = scissors)");
                    string choice = Console.ReadLine();
                    UserPlayer user = new UserPlayer(name, choice);
                    Player1 compPlayer = new Player1();

                    if (user.RoshamboValue == Roshambo.rock)
                    {
                        Console.WriteLine($"{user.Name}: {user.RoshamboValue}");
                        Console.WriteLine($"{compPlayer.Name}: {compPlayer.RoshamboValue}");

                        Console.WriteLine("Neither player wins draw");
                    }
                    else if (user.RoshamboValue == Roshambo.paper)
                    {
                        Console.WriteLine($"{user.Name}: {user.RoshamboValue}");
                        Console.WriteLine($"{compPlayer.Name}: {compPlayer.RoshamboValue}");
                        Console.WriteLine($"{user.Name} wins");
                        userPlayerWins++;
                    }
                    else
                    {
                        Console.WriteLine($"{user.Name}: {user.RoshamboValue}");
                        Console.WriteLine($"{compPlayer.Name}: {compPlayer.RoshamboValue}");
                        Console.WriteLine($"{compPlayer.Name} wins");
                        compPlayerWins++;
                    }

                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Rock, Paper, Scissors: (1 = rock, 2 = paper, 3 = scissors)");
                    string choice = Console.ReadLine();
                    UserPlayer user = new UserPlayer(name, choice);
                    Player2 compPlayer = new Player2();
                    Player3 playerResult = new Player3();
                    compPlayer.RoshamboValue = playerResult.RoshamboChoice(compPlayer);
                    if (user.RoshamboValue == Roshambo.rock)
                    {
                        if (compPlayer.RoshamboValue == Roshambo.rock)
                        {
                            Console.WriteLine($"{user.Name}: {user.RoshamboValue}");
                            Console.WriteLine($"{compPlayer.Name}: {compPlayer.RoshamboValue}");
                            Console.WriteLine("Its a tie!");
                        }
                        else if (compPlayer.RoshamboValue == Roshambo.paper)
                        {
                            Console.WriteLine($"{user.Name}: {user.RoshamboValue}");
                            Console.WriteLine($"{compPlayer.Name}: {compPlayer.RoshamboValue}");
                            Console.WriteLine("Player 2 wins!");
                            compPlayerWins++;
                        }
                        else
                        {
                            Console.WriteLine($"{user.Name}: {user.RoshamboValue}");
                            Console.WriteLine($"{compPlayer.Name}: {compPlayer.RoshamboValue}");
                            Console.WriteLine($"{user.Name} wins!");
                            userPlayerWins++;
                        }
                    }
                    else if (user.RoshamboValue == Roshambo.paper)
                    {
                        if (compPlayer.RoshamboValue == Roshambo.rock)
                        {
                            Console.WriteLine($"{user.Name}: {user.RoshamboValue}");
                            Console.WriteLine($"{compPlayer.Name}: {compPlayer.RoshamboValue}");
                            Console.WriteLine($"{user.Name} wins!");
                            userPlayerWins++;
                        }
                        else if (compPlayer.RoshamboValue == Roshambo.paper)
                        {
                            Console.WriteLine($"{user.Name}: {user.RoshamboValue}");
                            Console.WriteLine($"{compPlayer.Name}: {compPlayer.RoshamboValue}");
                            Console.WriteLine("Its a tie!");
                        }
                        else
                        {
                            Console.WriteLine($"{user.Name}: {user.RoshamboValue}");
                            Console.WriteLine($"{compPlayer.Name}: {compPlayer.RoshamboValue}");
                            Console.WriteLine("Player 2 wins!");
                            compPlayerWins++;
                        }
                    }
                    else
                    {
                        if (compPlayer.RoshamboValue == Roshambo.rock)
                        {
                            Console.WriteLine($"{user.Name}: {user.RoshamboValue}");
                            Console.WriteLine($"{compPlayer.Name}: {compPlayer.RoshamboValue}");
                            Console.WriteLine("Player 2 wins!");
                            compPlayerWins++;
                        }
                        else if (compPlayer.RoshamboValue == Roshambo.paper)
                        {
                            Console.WriteLine($"{user.Name}: {user.RoshamboValue}");
                            Console.WriteLine($"{compPlayer.Name}: {compPlayer.RoshamboValue}");
                            Console.WriteLine($"{user.Name} wins!");
                            userPlayerWins++;
                        }
                        else
                        {
                            Console.WriteLine($"{user.Name}: {user.RoshamboValue}");
                            Console.WriteLine($"{compPlayer.Name}: {compPlayer.RoshamboValue}");
                            Console.WriteLine("Its a tie!");
                        }
                    }
                    
                }
                Console.WriteLine("Do you wish to continue(enter y/n): "); //ask user to if they want to continue
                loopBreaker = IsValidLoopBreaker(Console.ReadLine()); //storing answer and if it's valid input 
                Console.ReadLine();
            } while (loopBreaker == 'y');

            Console.WriteLine($"{name} won {userPlayerWins} games");
            Console.WriteLine($"{name} lost {compPlayerWins} games");


        }
        public static char IsValidLoopBreaker(string testChar)
        {
            bool isInvalidChar = true;

            Regex pattern = new Regex(@"^[y|n]$");

            char validChar = ' ';

            while (isInvalidChar)
            {
                if (pattern.IsMatch(testChar))
                {
                    isInvalidChar = false;
                    validChar = char.Parse(testChar);
                }
                else
                {
                    Console.WriteLine($"ERROR invalid input of {testChar}  entered please try again");
                    Console.WriteLine("Do you wish to continue(enter y/n): ");
                    testChar = Console.ReadLine();
                }
            }
            return validChar;
        }
        public static int IsValidIntEntered(string testInt)
        {
            bool isInvalidInput = true;
            Regex pattern = new Regex(@"^[1|2]$");
            int validInt = 0;

            while (isInvalidInput)
            {
                if (pattern.IsMatch(testInt))
                {
                    isInvalidInput = false;
                    validInt = int.Parse(testInt);
                }
                else
                {
                    Console.WriteLine($"ERROR: invalid input of {testInt}  entered please try again");
                    Console.WriteLine("Would you like to play against player 1 or player 2") ;
                    testInt = Console.ReadLine();

                }

            }
            return validInt;
        }
    }
}
