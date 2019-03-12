using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Game
{
    class PlanetObicromPersei8
    {
        public void MainEntrance()
        {
            Console.Clear();
            Console.WriteLine("Main Trading Port of Obicrom Persei 8");
            Console.WriteLine();
            Console.WriteLine("You stand in the midst of a bustling trade center.  There are various\n" +
                              "shops and stalls littering the central square. You notice\n" +
                              "one seedy character in particular who seems to be giving you\n" +
                              "the stink eye. You notice a fuel station to the north, and\n" +
                              "shops to the east and the west.");
            Console.WriteLine();
            Console.WriteLine("Seedy Character");
            Console.WriteLine();
            Console.WriteLine("Exits: North, West, East, Leave");
            Console.WriteLine();
            var direction = Console.ReadLine();
            switch (direction.ToLower())
            {
                case "north":
                    FuelStation();
                    break;
                case "n":
                    FuelStation();
                    break;
                case "west":
                    TradingDepotOne();
                    break;
                case "w":
                    TradingDepotOne();
                    break;
                case "east":
                    TradingDepotTwo();
                    break;
                case "e":
                    TradingDepotTwo();
                    break;
                case "leave":
                    LeavePlanet();
                    break;
                case "hi":
                    Console.WriteLine("The seedy character approaches you and whispers,\n" +
                        "\"I wouldn't buy grain here, it's cheaper on Alpha\".");
                    Console.WriteLine("(Press enter to continue)");
                    Console.ReadLine();
                    break;
                default:
                    MainEntrance();
                    break;
            }
        }

        public static void LeavePlanet()
        {
            Console.Clear();
            Console.WriteLine("As you prepare to depart Obicrom Persei 8 you double check your\n" +
                              "inventory and fuel to make sure you haven't forgot anything. Time to \n" +
                              "go make a profit! Where is your next destination?");
            Console.WriteLine();
            Console.WriteLine("\t1. Planet Titan AE (300 lite years)");
            Console.WriteLine("\t2. Planet ALpha Centurian (1000 lite years)");
            Console.WriteLine("\t3. Planet Proxima B (500 lite years)");
            Console.WriteLine("\t4. Planet Earth (500 lite years)");
            Console.WriteLine();
            Console.Write("Select a destination: ");
            var destination = Console.ReadLine();
            switch (destination)
            {
                case "1":
                    PlanetTitanAE planetTitan = new PlanetTitanAE();
                    planetTitan.MainEntrance();
                    break;
                case "2":
                    PlanetAlphaCenturian3 planetAlpha = new PlanetAlphaCenturian3();
                    planetAlpha.MainEntrance();
                    break;
                case "3":
                    PlanetProximaB planetProxima = new PlanetProximaB();
                    planetProxima.MainEntrance();
                    break;
                case "4":
                    PlanetEarth planetEarth = new PlanetEarth();
                    planetEarth.MainEntrance();
                    break;
                default:
                    LeavePlanet();
                    break;
            }
        }

        public void TradingDepotOne()
        {
            Console.Clear();
            Console.WriteLine("Gucci Man's Goods");
            Console.WriteLine();
            Console.WriteLine("A very large green alien stands behind a counter.  There are goods\n" +
                "of all sorts lining shelves along the walls. There is a sign on the wall\n" +
                "listing the most popular goods. You can \"Read Sign\"");
            Console.WriteLine();
            Console.WriteLine("Exits: East");
            var response = Console.ReadLine().ToLower();
            switch (response)
            {
                case "read sign":
                    InventoryList();
                    break;
                case "buy":
                    BuyItem();
                    break;
                case "sell":
                    SellItem();
                    break;
                case "east":
                    MainEntrance();
                    break;
                case "e":
                    MainEntrance();
                    break;
                default:
                    TradingDepotOne();
                    break;
            }
        }

        private static void SellItem()
        {
            SellItem();
        }

        private static void BuyItem()
        {
            BuyItem();
        }

        private static void InventoryList()
        {
            InventoryList();
        }

        public void TradingDepotTwo()
        {
            Console.Clear();
            Console.WriteLine("Big Bertha's Tack Shop");
            Console.WriteLine();
            Console.WriteLine("An interesting creatures stands before you. If you had to guess you would say it \n" +
                "was a female. There are goods of all sorts lining shelves along the walls. There is a sign on the wall\n" +
                "listing the most popular goods. You can \"Read Sign\"");
            Console.WriteLine();
            Console.WriteLine("Exits: West");
            var response = Console.ReadLine().ToLower();
            switch (response)
            {
                case "read sign":
                    InventoryListTwo();
                    break;
                case "buy":
                    BuyItem();
                    break;
                case "sell":
                    SellItem();
                    break;
                case "west":
                    MainEntrance();
                    break;
                case "w":
                    MainEntrance();
                    break;
                default:
                    TradingDepotTwo();
                    break;
            }
        }

        public void FuelStation()
        {

        }

        public void InventoryListTwo()
        {
            InventoryListTwo();
        }
    }
}
