using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RkPprScsrLzrdSpk
{
    class Computer : Player
    {
        public void ComputerInfo()
        {
           
        }
        public void GetName()
        {
            Random random = new Random();
            string[] nameChoices =
            {
                "Brian", "Isabella", "Lori", "Katia", "Katherine", "Greg", "Jon", "Koda", "Olive", "Pig"
            };
            name = nameChoices[random.Next(0, nameChoices.Length)];
            Console.WriteLine(name);
        }
        public override void MakeWeaponChoice()
        {
            Random random = new Random();
            string[] weaponChoices =
            {
                "Rock", "Paper", "Scissors", "Lizard", "Spock"
            };
            weaponChoice = weaponChoices[random.Next(0, weaponChoices.Length)];
            Console.WriteLine(weaponChoice);
        }
    }
}
