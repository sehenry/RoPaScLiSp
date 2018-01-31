using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RkPprScsrLzrdSpk
{
    public class Human : Player
    {
        public void SetName()
        {
            Console.WriteLine("Enter your name \n");
            name = Console.ReadLine();
          
        }

        public override void MakeWeaponChoice()
        {
            Console.WriteLine("Enter your weapon of choice\n");
            weaponChoice = Console.ReadLine();

            
        }
     
    }
}
