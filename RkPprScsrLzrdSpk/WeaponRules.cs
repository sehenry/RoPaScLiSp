using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RkPprScsrLzrdSpk
{
    class WeaponRules
    {
        public void CompareChoices(Player player1, Player player2)
        { 
       

            if (player1.weaponChoice == "rock" && player2.weaponChoice == "scissors" || player2.weaponChoice == "lizard")
            {
                Console.WriteLine("Player 1 wins the round!\n");
            }

            else if (player1.weaponChoice == "rock" && player2.weaponChoice == "paper" || player2.weaponChoice == "spock")
            {
                Console.WriteLine("Player 2 wins the round!\n");
            }

            else if (player1.weaponChoice == "rock" && player2.weaponChoice == "rock")
            {
                Console.WriteLine("You both picked 'rock', it's a tie! Go again.");
            }

            

            if (player1.weaponChoice == "paper" && player2.weaponChoice == "rock" || player2.weaponChoice == "spock")
            {
                Console.WriteLine("Player 1 wins the round!\n");
            }

            else if (player1.weaponChoice == "paper" && player2.weaponChoice == "scissors" || player2.weaponChoice == "lizard")
            {
                Console.WriteLine("Player 2 wins the round!\n");
            }

            else if (player1.weaponChoice == "paper" && player2.weaponChoice == "paper")
            {
                Console.WriteLine("You both picked 'paper', it's a tie! Go again.");
            }

          

            if (player1.weaponChoice == "scissors" && player2.weaponChoice == "paper" || player2.weaponChoice == "lizard")
            {
                Console.WriteLine("Player 1 wins the round!\n");
            }

            else if (player1.weaponChoice == "scissors" && player2.weaponChoice == "rock" || player2.weaponChoice == "spock")
            {
                Console.WriteLine("Player 2 wins the round!\n");
            }

            else if (player1.weaponChoice == "scissors" && player2.weaponChoice == "scissors")
            {
                Console.WriteLine("You both picked 'scissors', it's a tie! Go again.");
            }
 

            if (player1.weaponChoice == "lizard" && player2.weaponChoice == "paper" || player2.weaponChoice == "spock")
            {
                Console.WriteLine("Player 1 wins the round!\n");
            }

            else if (player1.weaponChoice == "lizard" && player2.weaponChoice == "rock" || player2.weaponChoice == "scissors")
            {
                Console.WriteLine("Player 2 wins the round!\n");
            }

            else if (player1.weaponChoice == "lizard" && player2.weaponChoice == "lizard")
            {
                Console.WriteLine("You both picked 'lizard', it's a tie! Go again.");
            }

    

            if (player1.weaponChoice == "spock" && player2.weaponChoice == "rock" || player2.weaponChoice == "scissors")
            {
                Console.WriteLine("Player 1 wins the round!\n");
            }

            else if (player1.weaponChoice == "spock" && player2.weaponChoice == "paper" || player2.weaponChoice == "lizard")
            {
                Console.WriteLine("Player 2 wins the round!\n");
            }

            else if (player1.weaponChoice == "spock" && player2.weaponChoice == "spock")
            {
                Console.WriteLine("You both picked 'spock', it's a tie! Go again.");
            }

            }
         }
    }

