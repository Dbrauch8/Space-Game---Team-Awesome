using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Game
{
    public class PlanetTitanAE
    {
        
        public void MainEntrance()
        {
            Console.Clear();
            Console.WriteLine("Main Trading Port of Titan AE");
            Console.WriteLine();
            Console.WriteLine("You stand in the midst of a bustling trade center.  There are various\n" +
                              "shops and stalls littering the central square. You notice\n" +
                              "one seedy character in particular who seems to be giving you\n" +
                              "the stink eye. There is a fuel station to the north, and\n" +
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
                    MainEntrance();
                    break;
                default:
                    MainEntrance();
                    break;
            }
        }

        public static void LeavePlanet()
        {
            RaiderAttack raiderAttack = new RaiderAttack();
            RiskyRaiderAttack riskyRaiderAttack = new RiskyRaiderAttack();
            PlanetEarth planetEarth = new PlanetEarth();
            Console.Clear();
            Console.WriteLine("As you prepare to depart Titan AE you double check your inventory\n" +
                              "and fuel to make sure you haven't forgot anything. Time to go make\n" +
                              "a profit! Where is your next destination?");
            Console.WriteLine();
            Console.WriteLine("\t1. Planet Earth (300 lite years)");
            Console.WriteLine("\t2. Planet ALpha Centurian (1000 lite years)");
            Console.WriteLine("\t3. Planet Proxima B (500 lite years)");
            Console.WriteLine("\t4. Planet Obicrom Persei 8 (500 lite years)");
            Console.WriteLine();
            Console.Write("Select a destination: ");
            var destination = Console.ReadLine();
            switch(destination)
            {
                case "1":
                    Console.WriteLine();
                    Console.WriteLine("Would you like to take a shortcut? It cuts the distance to\n" +
                                      "100 lite years, but it's risky. Yes or no?");
                    Console.WriteLine();
                    var shortCutResponse = Console.ReadLine();
                    switch(shortCutResponse.ToLower())
                    {
                        case "yes":
                            riskyRaiderAttack.Raiders();
                            planetEarth.MainEntrance();
                            break;
                        case "no":
                            raiderAttack.Raiders();
                            planetEarth.MainEntrance();
                            break;
                        default:
                            LeavePlanet();
                            break;
                    }
                    break;
                    
                case "2":
                    raiderAttack.Raiders();
                    PlanetAlphaCenturian3 planetAlpha = new PlanetAlphaCenturian3();
                    planetAlpha.MainEntrance();
                    break;
                case "3":
                    raiderAttack.Raiders();
                    PlanetProximaB planetProxima = new PlanetProximaB();
                    planetProxima.MainEntrance();
                    break;
                case "4":
                    raiderAttack.Raiders();
                    PlanetObicromPersei8 planetObicrom = new PlanetObicromPersei8();
                    planetObicrom.MainEntrance();
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

        public void SellItem()
        {
            SellItem();
        }

        public void BuyItem()
        {
            BuyItem();
        }

        public  void InventoryList()
        {
            string[] shopItems = { "Gold: 1000 credits", "Diamonds: 500 credit", "Silver: 250 credits" };

            for (int x=0; x<shopItems.Length ; x++)
            {
                Console.WriteLine($"{x+1}: {shopItems[x]}");
            }
            
            Console.WriteLine("(press Enter to continue)");
            Console.ReadLine();
            TradingDepotOne();


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
            Console.Clear();
            Console.WriteLine("Helium 3 Express");
            Console.WriteLine();
            Console.WriteLine("You pull up to the Helium 3 Express.  Thankfully the days\n" +
                              "of fuel grades are gone.  You only have the one choice. Helium 3.\n" +
                              "The price is 50 credits a unit. Time to decide if you fill up\n" +
                              "or put in what you can afford");
            Console.WriteLine();
            Console.WriteLine("Options: (type \"fill up\" or \"enter units\")");
            Console.WriteLine();
            Console.WriteLine("Exits: South");
            var stationInput = Console.ReadLine();

            switch (stationInput.ToLower())
            {
                case "s":
                    MainEntrance();
                    break;
                case "south":
                    MainEntrance();
                    break;
                case "fill up":
                    FillUp();
                    break;
                case "enter units":
                    PutUnitsIn();
                    break;
                default:
                    FuelStation();
                    break;
            }
        }

        private static void PutUnitsIn()
        {
            PutUnitsIn();
        }

        private static void FillUp()
        {
            FillUp();
        }

        public void InventoryListTwo()
        {
            InventoryListTwo();
        }
        public void ShopIems()
        {

            
            
        }
    }

        


}
