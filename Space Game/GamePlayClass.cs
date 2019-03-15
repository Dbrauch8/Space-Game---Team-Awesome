using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Game
{
    class GamePlayClass
    {
        GalaxyClass galaxyClass = new GalaxyClass();
        Planets planets = new Planets();
        string input;

        public void NexusOfTheGalaxy()
        {
            Console.WriteLine("Welcome to the Nexus of the Galaxy.\n\n" +
                              "Where would you like to go?\n\n" +
                              "\t1. Earth\n" +
                              "\t2. Alpha Centuri\n" +
                              "\t3. Titan AE\n" +
                              "\t4. Obicrom Persei 8");

            PlanetSelection();
        }
        public void PlanetSelection()
        {
            input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    galaxyClass.PlanetEarth();
                    break;
                case "2":
                    galaxyClass.AlphaCenturi();
                    break;
                case "3":
                    galaxyClass.PlanetTitanAE();
                    break;
                case "4":
                    galaxyClass.PlantetObicromPersei8();
                    break;
                default:
                    PlanetSelection();
                    break;
            }
        }
    }
}
