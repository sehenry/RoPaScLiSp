using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RkPprScsrLzrdSpk
{
    class Program
    {
        static void Main(string[] args)
        {
            InitialGamePlay gamerules = new InitialGamePlay();
            gamerules.GameRules();
            Console.ReadLine();
        }
    }
}
