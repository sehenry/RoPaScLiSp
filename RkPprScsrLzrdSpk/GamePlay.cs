using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RkPprScsrLzrdSpk
{
    class GamePlay
    {
        public void GameWinner(Player player1, Player player2)
        {
            WeaponRules weaponWinner = new WeaponRules();
            weaponWinner.CompareChoices(player1, player2);
            Console.WriteLine();
        }
    }
}
