using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13RPS

{
    class RoshamboApp
    {
        static void Main(string[] args)
        {
            Rocky rockplayer = new Rocky();
            rockplayer.name = "Geodude";

            Rand randplayer = new Rand();
            randplayer.name = "Charizard";

            Console.WriteLine("Welcome to Rock Paper Scissors!");
            Console.Write("Please enter your name: ");
            string player = Console.ReadLine();
            
            Human humanPlayer = new Human();
            humanPlayer.name = player;
            bool isGeodude = false;
            bool tryAgain = true;

            while (tryAgain)
            {
                Console.WriteLine($"Would you like to play {rockplayer.name} or {randplayer.name}? (G/C)");
                String opponent = Console.ReadLine().ToLower();
                if (opponent == "g")
                {
                    isGeodude = true;
                    tryAgain = false;
                }
                else if (opponent == "c")
                {
                    isGeodude = false;
                    tryAgain = false;
                }
                else
                {
                    Console.WriteLine("Invalid input! Would you like to try again? (Y/N)?:");
                    string invalidEntry = Console.ReadLine().ToLower();
                    if (invalidEntry == "y")
                    {
                        tryAgain = true;
                    }
                    else if (invalidEntry == "n")
                    {
                        tryAgain = false;
                    }
                    else
                    {
                        Console.WriteLine("Invalid Input. Goodbye!");
                        return;
                    }
                } 
            }

            int playerScore = 0;
            int oppScore = 0;
            bool playAgain = true;
            Roshambo oppMove = Roshambo.Paper;
            string oppName = "";
            if (isGeodude)
            {
                oppName = rockplayer.name;
            }
            else
            {
                oppName = randplayer.name;
            }
            while (playAgain)
            {
                Console.WriteLine("Rock, Paper, Scissor? (R/P/S)?");
                string userChoice = Console.ReadLine().ToLower();

                if (isGeodude)
                {
                    oppMove = rockplayer.Roshambo;
                }
                else
                {
                    oppMove = randplayer.Roshambo; 
                }

                switch (userChoice[0])
                {
                    case 'r':
                        if (oppMove == Roshambo.Rock)
                        {
                            Console.WriteLine($"{humanPlayer.name}: rock");
                            Console.WriteLine($"{oppName}: rock");
                            Console.WriteLine("Draw!");
                        }
                        else if (oppMove == Roshambo.Paper) 
                        {
                            oppScore++;
                            Console.WriteLine($"{humanPlayer.name}: rock");
                            Console.WriteLine($"{oppName}: paper");
                            Console.WriteLine($"{oppName} Wins!");
                        }
                        else
                        {
                            playerScore++;
                            Console.WriteLine($"{humanPlayer.name}: rock");
                            Console.WriteLine($"{oppName}: paper");
                            Console.WriteLine($"{humanPlayer} Wins!");
                        }
                        break;
                    case 'p':
                        if (oppMove == Roshambo.Rock)
                        {
                            playerScore++;
                            Console.WriteLine($"{humanPlayer.name}: paper");
                            Console.WriteLine($"{oppName}: rock");
                            Console.WriteLine($"{humanPlayer.name} Wins!");
                        }
                        else if (oppMove == Roshambo.Paper)
                        {
                            Console.WriteLine($"{humanPlayer.name}: paper");
                            Console.WriteLine($"{oppName}: paper");
                            Console.WriteLine($"Draw!");
                        }
                        else
                        {
                            oppScore++;
                            Console.WriteLine($"{humanPlayer.name}: paper");
                            Console.WriteLine($"{oppName}: scissor");
                            Console.WriteLine($"{oppName} Wins!");
                        }
                        break;
                    case 's':
                        if (oppMove == Roshambo.Rock)
                        {
                            oppScore++;
                            Console.WriteLine($"{humanPlayer.name}: scissor");
                            Console.WriteLine($"{oppName}: rock");
                            Console.WriteLine($"{oppName} Wins!");
                        }
                        else if (oppMove == Roshambo.Paper)
                        {
                            playerScore++;
                            Console.WriteLine($"{humanPlayer.name}: scissor");
                            Console.WriteLine($"{oppName}: paper");
                            Console.WriteLine($"{humanPlayer.name} Wins!");
                        }
                        else
                        {
                            Console.WriteLine($"{humanPlayer.name}: scissor");
                            Console.WriteLine($"{oppName}: scissor");
                            Console.WriteLine($"Draw!");
                        }
                        break;

                    default:
                        Console.WriteLine("Invalid input! Goodbye");
                        break;
                }

                Console.WriteLine("Play again? Y/N?");
                string playAgn = Console.ReadLine().ToLower();
                if (playAgn == "n")
                {
                    Console.WriteLine("Final score: ");
                    Console.WriteLine($"{humanPlayer.name} : {playerScore}");
                    Console.WriteLine($"{oppName} : {oppScore}");
                    return;
                }
            }

            
        }


    }
}
