using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Game
{
    class GalaxyClass
    {
        public RaidersAttack raidersAttack = new RaidersAttack();
        Planets planets = new Planets();
        public List<string> earthShopOneInv = new List<string>() { "Gold\t1000cr", "Silver\t500cr", "Iron\t100cr" };
        public List<string> titanShopOneInv = new List<string>() { "Tin\t1000cr", "Silver\t500cr", "Iron\t100cr" };




        public void PlanetEarth()
        {
            Console.Clear();
            planets.Name = "Earth";
            planets.Entrance = "\nMain Square of Earth\n\nYou stand in the midst of a bustling trade center.  There are various\n" +
                              "shops and stalls littering the central square. You notice\n" +
                              "one seedy character in particular who seems to be giving you\n" +
                              "the stink eye. You notice a fuel station to the north, and\n" +
                              "shops to the east and the west.\n\n" +
                              "Exits: Leave, North, West, East";
            planets.ShopOne = "\nGucci Man's Goods\n\nA very large green alien stands behind a counter.  There are goods\n" +
                              "of all sorts lining shelves along the walls. There is a sign on the wall\n" +
                              "listing the most popular goods. You can \"Read Sign\"\n\n" +
                              "Exits: East";
            planets.ShopTwo = "\nBig Bertha's Tack Shop\n\nAn interesting creatures stands before you. If you had to guess you would say it \n" +
                              "was a female. There are goods of all sorts lining shelves along the walls. There is a sign on the wall\n" +
                              "listing the most popular goods. You can \"Read Sign\"\n\nExits: West";
            planets.FuelStation = "\nHelium 3 Express\n\nYou pull up to the Helium 3 Express.  Thankfully the days\n" +
                                  "of fuel grades are gone.  You only have the one choice. Helium 3.\n" +
                                  "The price is 50 credits a unit. Time to decide if you fill up\n" +
                                  "or put in what you can afford\n\nExits: South";
            planets.ShopList = new List<string>() { "Gold", "Statue", "Sword" };
            Console.WriteLine($"{planets.Name}\n\n{planets.Entrance}");
            bool test = true;
            while (test)
            {
                var input = Console.ReadLine();
                switch (input)
                {
                    case "shop":
                        for (int x = 0; x < planets.ShopList.Count; x++)
                        {
                            Console.WriteLine($"{x + 1}: {planets.ShopList[x]}");
                        }
                        break;
                    default:
                        PlanetEarth();
                        break;
                }
            }
            

            //PlanetNavigation();

        }

        public void PlanetTitanAE()
        {
            planets.Name = "Titan AE";
            planets.Entrance = "\nMain Square of Titan\n\nYou stand in the midst of a bustling trade center.  There are various\n" +
                             "shops and stalls littering the central square. You notice\n" +
                             "one seedy character in particular who seems to be giving you\n" +
                             "the stink eye. You notice a fuel station to the north, and\n" +
                             "shops to the east and the west.\n\n" +
                             "Exits: Leave, North, West, East";
            planets.ShopOne = "\nLeapin Lary's Emporium\n\nA very large green alien stands behind a counter.  There are goods\n" +
                              "of all sorts lining shelves along the walls. There is a sign on the wall\n" +
                              "listing the most popular goods. You can \"Read Sign\"\n\n" +
                              "Exits: East";
            planets.ShopTwo = "\nBig WaWa's Food Market\n\nAn interesting creatures stands before you. If you had to guess you would say it \n" +
                              "was a female. There are goods of all sorts lining shelves along the walls. There is a sign on the wall\n" +
                              "listing the most popular goods. You can \"Read Sign\\n\nExits: West";
            planets.FuelStation = "\nHelium 3 Express\n\nYou pull up to the Helium 3 Express.  Thankfully the days\n" +
                                  "of fuel grades are gone.  You only have the one choice. Helium 3.\n" +
                                  "The price is 50 credits a unit. Time to decide if you fill up\n" +
                                  "or put in what you can afford\n\nExits: South";
            Console.WriteLine($"{planets.Name}\n\n{planets.Entrance}");
            PlanetNavigation();

        }

        public void PlantetObicromPersei8()
        {
            planets.Name = "Planet Obicrom Persei 8";
            planets.Entrance = "\nMain Square of Persei 8\n\nYou stand in the midst of a bustling trade center.  There are various\n" +
                               "shops and stalls littering the central square. You notice\n" +
                               "one seedy character in particular who seems to be giving you\n" +
                               "the stink eye. You notice a fuel station to the north, and\n" +
                               "shops to the east and the west.\n\n" +
                               "Exits: Leave, North, West, East";
            planets.ShopOne = "\nSuper Highspeed Ranger Rick's Trade\n\nA very large green alien stands behind a counter.  There are goods\n" +
                              "of all sorts lining shelves along the walls. There is a sign on the wall\n" +
                              "listing the most popular goods. You can \"Read Sign\"\n\n" +
                              "Exits: East";
            planets.ShopTwo = "\nShady Crankster's Bits\n\nAn interesting creatures stands before you. If you had to guess you would say it \n" +
                              "was a female. There are goods of all sorts lining shelves along the walls. There is a sign on the wall\n" +
                              "listing the most popular goods. You can \"Read Sign\"\n\nExits: West";
            planets.FuelStation = "\nHelium 3 Express\n\nYou pull up to the Helium 3 Express.  Thankfully the days\n" +
                                  "of fuel grades are gone.  You only have the one choice. Helium 3.\n" +
                                  "The price is 50 credits a unit. Time to decide if you fill up\n" +
                                  "or put in what you can afford\n\nExits: South";
            Console.WriteLine($"{planets.Name}\n\n{planets.Entrance}");
            PlanetNavigation();
        }

        public void AlphaCenturi()
        {
            planets.Name = "Alpha Centuri";
            planets.Entrance = "\nMain Square of Alpha\n\nYou stand in the midst of a bustling trade center.  There are various\n" +
                               "shops and stalls littering the central square. You notice\n" +
                               "one seedy character in particular who seems to be giving you\n" +
                               "the stink eye. You notice a fuel station to the north, and\n" +
                               "shops to the east and the west.\n\n" +
                               "Exits: Leave, North, West, East";
            planets.ShopOne = "\nBizzy Bones Bizzar\n\nA very large green alien stands behind a counter.  There are goods\n" +
                              "of all sorts lining shelves along the walls. There is a sign on the wall\n" +
                              "listing the most popular goods. You can \"Read Sign\"\n\n" +
                              "Exits: East";
            planets.ShopTwo = "\nCrazy Joe's Tack Shop\n\nAn interesting creatures stands before you. If you had to guess you would say it \n" +
                              "was a female. There are goods of all sorts lining shelves along the walls. There is a sign on the wall\n" +
                              "listing the most popular goods. You can \"Read Sign\"\n\nExits: West";
            planets.FuelStation = "\nHelium 3 Express\n\nYou pull up to the Helium 3 Express.  Thankfully the days\n" +
                                  "of fuel grades are gone.  You only have the one choice. Helium 3.\n" +
                                  "The price is 50 credits a unit. Time to decide if you fill up\n" +
                                  "or put in what you can afford\n\nExits: South";
            planets.ShopList = earthShopOneInv;
            Console.WriteLine($"{planets.Name}\n\n{planets.Entrance}");
            PlanetNavigation();
        }

        public void PlanetNavigation()
        {
            bool test = true;
            while (test)
            {
                var input = Console.ReadLine();

                switch (input)
                {
                    case "n":
                        Console.WriteLine(planets.FuelStation);
                        FuelStationNavigation();
                        break;
                    case "w":
                        Console.WriteLine(planets.ShopOne);
                        ShopOneNavigation();
                        break;
                    case "e":
                        Console.WriteLine(planets.ShopTwo);
                        ShopOTwoNavigation();
                        break;
                    case "leave":
                        Console.WriteLine("\nYou enter a swirling vortex of chaos.  You are blinded\n" +
                                          "by the light. When your vision returns you see several portals.");
                        Console.WriteLine("\nWhich planet would you like to travel to?\n" +
                                          "\t1. Planet Earth\n" +
                                          "\t2. Planet Obicrom Persei 8\n" +
                                          "\t3. Planet Alpha Centuri\n" +
                                          "\t4. Planet Titan AE\n");
                        var travel = Console.ReadLine();
                        switch (travel)
                        {
                            case "1":
                                raidersAttack.Raiders();
                                PlanetEarth();
                                break;
                            case "2":
                                raidersAttack.Raiders();
                                PlantetObicromPersei8();
                                break;
                            case "3":
                                raidersAttack.Raiders();
                                AlphaCenturi();
                                break;
                            case "4":
                                raidersAttack.Raiders();
                                PlanetTitanAE();
                                break;
                        }
                        break;
                    default:
                        Console.WriteLine(planets.Entrance);
                        break;
                }
            }
        }

        public void FuelStationNavigation()
        {
            bool test = true;
            while (test)
            {
                var input = Console.ReadLine();

                switch (input)
                {
                    case "s":
                        Console.WriteLine(planets.Entrance);
                        test = false;
                        break;
                    default:
                        Console.WriteLine(planets.FuelStation);
                        break;
                }
            }
        }

        public void ShopOneNavigation()
        {
            /*List<string> shopInv = new List<string>();
            shopInv.Add("Gold: 400 cr");
            shopInv.Add("Silver: 200 cr");
            shopInv.Add("Iron Ore: 20 cr");*/

            bool test = true;
            while (test)
            {
                var input = Console.ReadLine();
                switch (input)
                {
                    case "e":
                        Console.WriteLine(planets.Entrance);
                        test = false;
                        break;
                    case "list":
                        for (int x = 0; x < earthShopOneInv.Count; x++)
                        {
                            Console.WriteLine($"{x + 1}: {earthShopOneInv[x]}");
                        }
                        break;
                    case "buy 1":
                        //inventoryClass.GetList().Add(shopInv[0]);
                        break;
                    case "sell 1":
                        //inventoryClass.GetList().RemoveAt(1);
                        break;

                    case "inv":
                        //for (int x =0;x< inventoryClass.GetList().Count;x++)
                        {
                            //Console.WriteLine($"{x+1}: {inventoryClass.GetList()[x]}");
                        }
                        break;
                    default:
                        Console.WriteLine(planets.ShopOne); ;
                        break;
                }
            }
        }

        public void ShopOTwoNavigation()
        {
            bool test = true;
            while (test)
            {
                var input = Console.ReadLine();
                switch (input)
                {
                    case "w":
                        Console.WriteLine(planets.Entrance);
                        test = false;
                        break;
                    case "list":
                        //for (int x = 0; x < inventoryClass.GetList2().Count; x++)
                        {
                           // Console.WriteLine($"{x + 1}: {inventoryClass.GetList2()[x]}");
                        }
                        break;
                    case "buy 1":
                        //inventoryClass.GetList().Add(inventoryClass.GetList2()[0]);
                        break;
                    case "sell 1":
                        //inventoryClass.GetList().RemoveAt(1);
                        break;

                    case "inv":
                        //for (int x = 0; x < inventoryClass.GetList().Count; x++)
                        {
                            //Console.WriteLine($"{x + 1}: {inventoryClass.GetList()[x]}");
                        }
                        break;
                    default:
                        Console.WriteLine(planets.ShopTwo); ;
                        break;
                }
            }
        }
    }
}
