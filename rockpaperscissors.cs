using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            bool playAgain = true;

            while (playAgain)
            {
                int scorePlayer = 0;
                int scoreCPU = 0;

                while (scorePlayer < 3 && scoreCPU < 3)
                {
                    Console.WriteLine("Choose between ROCK, PAPER, or SCISSORS:");
                    string inputPlayer = Console.ReadLine().ToUpper();

                    string[] choices = { "ROCK", "PAPER", "SCISSORS" };
                    Random random = new Random();
                    int randomIndex = random.Next(choices.Length);
                    string inputCPU = choices[randomIndex];

                    Console.WriteLine($"Computer chose: {inputCPU}");

                    if (inputPlayer == inputCPU)
                    {
                        Console.WriteLine("DRAW!!\n");
                    }
                    else if ((inputPlayer == "ROCK" && inputCPU == "SCISSORS") ||
                             (inputPlayer == "PAPER" && inputCPU == "ROCK") ||
                             (inputPlayer == "SCISSORS" && inputCPU == "PAPER"))
                    {
                        Console.WriteLine("PLAYER WINS!!\n");
                        scorePlayer++;
                    }
                    else
                    {
                        Console.WriteLine("CPU WINS!!\n");
                        scoreCPU++;
                    }

                    Console.WriteLine($"SCORES: PLAYER: {scorePlayer}\tCPU: {scoreCPU}\n");
                }

                if (scorePlayer == 3)
                {
                    Console.WriteLine("Player WON!");
                }
                else if (scoreCPU == 3)
                {
                    Console.WriteLine("CPU WON!");
                }

                Console.WriteLine("Do you want to play again? (y/n)");
                string loop = Console.ReadLine();
                playAgain = (loop.ToLower() == "y");

                Console.Clear();
            }
        }
    }
}
