using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Game
{
    public class PlanetLayout
    {
        PlanetTitanAE planetMain = new PlanetTitanAE();

        public void DirectionResponse()
        {
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
                    break;
                default:
                    planetMain.MainEntrance();
                    break;
            }
        }

        public static void LeavePlanet()
        {
            LeavePlanet();
        }

        public void TradingDepotOne()
        {
            Console.Clear();
            Console.WriteLine("Gucci Man's Goods");
            Console.WriteLine();
            Console.WriteLine("A very large green alien stands behind a counter.  There goods\n" +
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
                    planetMain.MainEntrance();
                    break;
                case "e":
                    planetMain.MainEntrance();
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

        }

        public void FuelStation()
        {

        }
    }
}
