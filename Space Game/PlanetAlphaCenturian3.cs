using System;
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
            Console.WriteLine("Exits: North, West, East, Northwest, Leave");
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
                case "northwest":
                    AlleyWay();
                    break;
                case "nw":
                    AlleyWay();
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

        public void AlleyWay()
        {
            Console.Clear();
            Console.WriteLine("Dark Alley");
            Console.WriteLine();
            Console.WriteLine("You've wondered into a dark alley.  There is trash\n" +
                              "everywhere. It smells horrible.  Surprisingly you see\n" +
                              "a very affluent looking man standing in a doorway.");
            Console.WriteLine();
            Console.WriteLine("Affluent Looking Man");
            Console.WriteLine();
            Console.WriteLine("Exits: Southeast");
            var darkAlley = Console.ReadLine();
            switch(darkAlley.ToLower())
            {
                case "hi":
                    Console.WriteLine("The affluent looking man approaches you. He casts\n" +
                                      "a furtive glance then speaks, \"If you can find me\n" +
                                      "a micro transponder from planet Earth you will be\n" +
                                      "smartly compensated\"");
                    Console.WriteLine("(press enter to continue)");
                    Console.ReadLine();
                    AlleyWay();
                    break;
                case "southeast":
                    MainEntrance();
                    break;
                case "se":
                    MainEntrance();
                    break;
                default:
                    AlleyWay();
                    break;
            }

        }

        public void LeavePlanet()
        {
            RaiderAttack raiderAttack = new RaiderAttack();
            Console.Clear();
            Console.WriteLine("As you prepare to depart Alpha Centurian 3 you double check your inventory\n" +
                              "and fuel to make sure you haven't forgot anything. Time to go make\n" +
                              "a profit! Where is your next destination?");
            Console.WriteLine();
            Console.WriteLine("\t1. Planet Earth\t\t\t(300 lite years)");
            Console.WriteLine("\t2. Planet Titan AE\t\t(1000 lite years)");
            Console.WriteLine("\t3. Planet Proxima B\t\t(500 lite years)");
            Console.WriteLine("\t4. Planet Obicrom Persei 8\t(2000 lite years)");
            Console.WriteLine();
            Console.Write("Select a destination: ");
            var destination = Console.ReadLine();
            switch (destination)
            {
                case "1":
                    raiderAttack.Raiders();
                    PlanetEarth planetEarth = new PlanetEarth();
                    planetEarth.MainEntrance();
                    break;
                case "2":
                    raiderAttack.Raiders();
                    PlanetTitanAE planetTitan = new PlanetTitanAE();
                    planetTitan.MainEntrance();
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

        public void InventoryList()
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
            Console.Clear();
            Console.WriteLine("Helium 3 Express");
            Console.WriteLine();
            Console.WriteLine("You pull up to the Helium 3 Express.  Thankfully the days\n" +
                              "of fuel grades are gone.  You only have the one choice. Helium 3.\n" +
                              "The price is 50 credits a unit. Time to decide if you fill up\n" +
                              "or put in what you can afford");
            Console.WriteLine();
            Console.WriteLine("Options: \"Fill up\" or enter the number of units you'd like to buy.\n" +
                              "(i.e. If you enter 50, you will purchase 50 units.");
            Console.WriteLine();
            Console.WriteLine("Exits: South");
            var stationInput = Console.ReadLine();
            
            switch(stationInput.ToLower())
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

        public void PutUnitsIn()
        {
            PutUnitsIn();
        }

        public void FillUp()
        {
            FillUp();
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
