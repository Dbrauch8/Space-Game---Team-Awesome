using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


//using Xamarin.Forms;

namespace Space_Game
{
    public class SpaceShip
    {
        public string Name { get; private set; }
        public double MaxFuel { get; private set; }
        public double MaxCargo { get; private set; }
        public double MaxWarpSpeed { get; private set; }
        public double MaxRange { get; private set; }
        public string Cost { get; set; }

        public SpaceShip(string name, double maxFuel, double maxCargo, double maxWarpSpeed, double maxRange, string cost)
        {
            this.Name = name;
            this.MaxFuel = maxFuel;
            this.MaxCargo = maxCargo;
            this.MaxWarpSpeed = maxWarpSpeed;
            this.MaxRange = maxRange;
            this.Cost = cost;
        }

        public void ShipSelection()
        {
            Console.WriteLine("Congratulations!! You selected " + Name);

            Console.WriteLine("\nPerformance parameters for your ship: " + "\nMax Fuel=>  {0} | Max Cargo=>  {1} | Max Warp Speed=> {2}",
                MaxFuel,
                MaxCargo,
                MaxWarpSpeed,
                MaxRange);
            
            Console.ReadLine();
            String imgPath = Console.ReadLine();
            System.Diagnostics.Process.Start(@"C:\Users\dougc\Pictures.\falcon5.jpg", imgPath);

            FuelQuantity();
            //CargoInventory(myShip);
        }
        private void FuelQuantity()
        {
            double distance = 1;
            double time = distance / Math.Pow(MaxWarpSpeed, 3.33333 + (Math.Pow((10.0 - MaxWarpSpeed), 3.67)));
            var speed = Math.Pow(MaxWarpSpeed, 3.33333 + (Math.Pow((12.0 - MaxWarpSpeed), 3.67)));
            //double time = distance / (((myShip.MaxWarpSpeed) * ((10 / 3) + Math.Pow(12.0 - 5.0, (3.67);
            double fuelLevel = MaxFuel - (time * MaxFuel / 365);

            Console.WriteLine("\nIts time to kick the tires and light the fires!");
            Console.WriteLine("Fuel remaining= " + fuelLevel + "\nSpeed = " + speed);
            Console.ReadLine();
        }

        //private static void CargoInventory(SpaceShip myShip)
        //{
        //    //double weight;
        //    double cargoTotal = 80;
        //    double spaceRemaining; // Will be calculated based on items purchases (need variable)
        //    spaceRemaining = myShip.MaxCargo - cargoTotal;
        //    Console.WriteLine("Remaining cargo space= " + spaceRemaining);
        //    Console.WriteLine("Total cargo= " + cargoTotal);
        //    Console.WriteLine();
        //}

    }

}
