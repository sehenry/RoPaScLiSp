using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RkPprScsrLzrdSpk
{ 
    public abstract class Player
    {
        public string name;
        public string weaponChoice;
        public int gamesWon;

        public abstract void MakeWeaponChoice();
    }

}
