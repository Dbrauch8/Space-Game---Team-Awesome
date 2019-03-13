using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Game
{
    class NexusOfTheGalaxy
    {
        PlanetAlphaCenturian3 planetAlphaCenturian = new PlanetAlphaCenturian3();
        PlanetEarth planetEarth = new PlanetEarth();
        PlanetObicromPersei8 planetObicrom = new PlanetObicromPersei8();
        PlanetTitanAE planetTitan = new PlanetTitanAE();
        PlanetProximaB planetProxima = new PlanetProximaB();
        public void PlanetaryChoices()
        {
            Console.WriteLine("You stand at the nexus of the Galaxy.\n" +
                              "From here you can choose which planet you\n" +
                              "would like to go to");
            Console.WriteLine();
            Console.WriteLine("\t1. Earth");
            Console.WriteLine("\t2. Alpha Centurian 3");
            Console.WriteLine("\t3. Titan AE");
            Console.WriteLine("\t4. Obicrom Persei 8");
            Console.WriteLine("\t5. Proxima B");

            var choice = Console.ReadLine();
            switch(choice)
            {
                case "1":
                    planetEarth.MainEntrance();
                    break;
                case "2":
                    planetAlphaCenturian.MainEntrance();
                    break;
                case "3":
                    planetTitan.MainEntrance();
                    break;
                case "4":
                    planetObicrom.MainEntrance();
                    break;
                case "5":
                    planetProxima.MainEntrance();
                    break;
                default:
                    PlanetaryChoices();
                    break;

            }

        }
    }
}
