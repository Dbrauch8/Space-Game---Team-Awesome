﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Game
{
    class PlanetAlphaCenturian3
    {
        public void MainEntrance()
        {
            Console.Clear();
            Console.WriteLine("Main Trading Port of Alpha Centurian 3");
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

            if (direction == "hi")
            {
                    SeedyMansResponse();
            }

            

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
            Console.WriteLine("As you prepare to depart Alpha Centurian 3 you double check your inventory\n" +
                              "and fuel to make sure you haven't forgot anything. Time to go make\n" +
                              "a profit! Where is your next destination?");
            Console.WriteLine();
            Console.WriteLine("\t1. Planet Earth (300 lite years)");
            Console.WriteLine("\t2. Planet Titan AE (1000 lite years)");
            Console.WriteLine("\t3. Planet Proxima B (500 lite years)");
            Console.WriteLine();
            Console.Write("Select a destination: ");
            var destination = Console.ReadLine();
            switch (destination)
            {
                case "1":
                    PlanetEarth planetEarth = new PlanetEarth();
                    planetEarth.MainEntrance();
                    break;
                case "2":
                    RaiderAttack raiderAttack = new RaiderAttack();
                    raiderAttack.Raiders();
                    PlanetTitanAE planetTitan = new PlanetTitanAE();
                    planetTitan.MainEntrance();
                    break;
                case "3":
                    PlanetProximaB planetProxima = new PlanetProximaB();
                    planetProxima.MainEntrance();
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

        public void SeedyMansResponse()
        {
            Console.WriteLine("The seedy character approaches you and whispers,\n" +
                        "\"I wouldn't buy grain here, it's cheaper on Alpha\".");
        }
    }
}
