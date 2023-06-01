using System;
using System.Text.Json.Nodes;

namespace PrimeiroApp
{
    public class program
    {
        static void Main(string[] args){
            restart:
            List<string> ops = new List<string>() { "rock", "paper", "scissors" };

            Console.WriteLine("Choose between rock, paper or scissors.");

            string? playerChoice = Console.ReadLine()!.ToLower();
            int computerChoice = new Random().Next(0, 3);
            if (null == playerChoice || !(ops.Contains(playerChoice)))
            {
                throw new Exception("Choice is not valid");
            }
            Console.WriteLine("Computer chose {0}", ops.ElementAt(computerChoice).ToString());
            if ((ops.IndexOf(playerChoice) - computerChoice) == (0 - 1) || (ops.IndexOf(playerChoice) - computerChoice) > 1)
            {
                Console.WriteLine("Computer Win!");
                Console.WriteLine("----------------------------------------------------------------------------------");
            }
            else if ((ops.IndexOf(playerChoice) - computerChoice) < (0 - 1) || (ops.IndexOf(playerChoice) - computerChoice) == 1)
            {
                Console.WriteLine("Player Win!");
                Console.WriteLine("----------------------------------------------------------------------------------");
            }
            else
            {
                Console.WriteLine("Draw");
                Console.WriteLine("----------------------------------------------------------------------------------");
            }

            Console.WriteLine("Do you want to play again?(Y or N)");
            string yesOrNo = Console.ReadLine()!.ToLower();

            while (yesOrNo == "y")
            {
                goto restart;
            }
        }
    }
}
