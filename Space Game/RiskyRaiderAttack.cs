using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Game
{
    class RiskyRaiderAttack
    {
        public void Raiders()
        {
            Random raiderChance = new Random();
            int raiderTry = raiderChance.Next(0, 2);
            int resistanceTry = raiderChance.Next(0, 6);
            if (raiderTry < 1)
            {
                Console.WriteLine();
                Console.WriteLine("You've been raided!");
                if (resistanceTry < 5)
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
