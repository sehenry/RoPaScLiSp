using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RkPprScsrLzrdSpk
{
    class InitialGamePlay
    {
        public void GameRules()
        {
            Console.WriteLine("Let's play, Rock, Paper, Scissors, Lizard, Spock! Now, here's how it works. \n Scissors cuts Paper \n Paper covers Rock \n Rock crushes Lizard \n Lizard poisons Spock \n Spock smashes Scissors \n Scissors decapitate Lizard \n Lizard eats Paper \n Paper disproves Spock \n Spock vaporizes Rock \n And as it always has, Rock Crushes Scissors\n So, do you understand how to play? Are you ready to get started??");
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "yes":
                    PlayerOptions();
                    break;
                case "no":
                    GameRules();
                    break;
                default:
                    Console.WriteLine("Sorry, you must answer 'yes' or 'no' before gameplay continues \n");
                    GameRules();
                    break;


            }
        }
        public void PlayerOptions()
        {
            Console.WriteLine("So you're ready to play! Now you must choose either 1 player or 2. 1 player will allow you to play against the computer.\n");
            string userInput = Console.ReadLine();
            switch (userInput)
            {
                case "1 player":
                    Computer computer = new Computer();
                    computer.GetName();

                    Human player = new Human();
                    player.SetName();


                    PlayGame(player, computer);
                    
                    break;
                case "2 player":
                    Human player1 = new Human();
                    player1.SetName();

                    Human player2 = new Human();
                    player2.SetName();

                    PlayGame(player1, player2);

                    
                    break;
                default:
                    Console.WriteLine("Sorry, you must enter either '1 player' or '2 player'");
                    break;
            }
        }
        public void PlayGame(Player player1, Player player2)
        {
            //for or while loop
            //loop until either player1.gamesWon == 2 or player2.gamesWon == 2
            player1.MakeWeaponChoice();
            player2.MakeWeaponChoice();

            WeaponRules weaponWinner = new WeaponRules();
            weaponWinner.CompareChoices(player1, player2);
        }
    }
}

