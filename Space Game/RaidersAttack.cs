using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Game
{
    class RaidersAttack
    {
        public void Raiders()
        {
            Random raiderChance = new Random();
            int raiderTry = raiderChance.Next(1, 4);
            int resistanceTry = raiderChance.Next(0, 5);
            if (raiderTry == 1)
            {
                Console.WriteLine();
                Console.WriteLine("You've been raided!");
                if (resistanceTry < 3)
                {
                    Console.WriteLine();
                    Console.WriteLine("You tried to resistance and lost! They made away\n" +
                                      "with some of your booty!");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("You fought them off and sent them away licking their wounds!");
                    Console.WriteLine();
                }
                Console.WriteLine("(Press enter to continue)");
                Console.ReadLine();
            }
        }
    }
}
