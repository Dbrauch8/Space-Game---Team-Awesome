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

        public void Ship(string ships)
        {
            Console.WriteLine("Choose Your Ship");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            SpaceShip falconFive = new SpaceShip();
            falconFive.MaxFuel = 80;
            falconFive.MaxCargo = 80;
            falconFive.MaxWarpSpeed = 11;
            falconFive.MaxRange = 1331;
            falconFive.Cost = "$50,000";
            falconFive.Name = "Falcon 5";
            Console.WriteLine("FALCON 5 \nThe Falcon 5 is your sportscar of the universe. It is the fastest ship in the fleet, able to achieve 'Ludakris speed'." +
                "\nIt is also ver maneuverable. Your limitations are fuel and cargo capacity." +
                " \nIf you need to get there fast and outrun most space pirates, this is your space ship!");
            Console.WriteLine("SPECS: Max Fuel=>  {0} | Max Cargo=>  {1} | Max Warp Speed=>  {2} | Range (LightYears)=> {3} | Cost=> {4}",
                falconFive.MaxFuel, falconFive.MaxCargo, falconFive.MaxWarpSpeed, falconFive.MaxRange, falconFive.Cost);

            Console.WriteLine("************************************************************************************************************************");
            SpaceShip spaceBallOne = new SpaceShip();
            spaceBallOne.MaxFuel = 150;
            spaceBallOne.MaxCargo = 150;
            spaceBallOne.MaxWarpSpeed = 8.5;
            spaceBallOne.MaxRange = 614;
            spaceBallOne.Cost = "$45,000";
            spaceBallOne.Name = "SpaceBall 1";
            Console.WriteLine("SPACEBALL 1 \n SpaceBall 1 is the ship for those who want to buy in bulk and carry a lot of cargo to the next planet." +
                " \nIf you are that type of intergalactic merchant, SpaceBall 1 is your ride!");
            Console.WriteLine("SPECS: Max Fuel=>  {0} | Max Cargo=>  {1} | Max Warp Speed=>  {2} | Range (LightYears)=> {3} | Cost=> {4}",
            spaceBallOne.MaxFuel, spaceBallOne.MaxCargo, spaceBallOne.MaxWarpSpeed, spaceBallOne.MaxRange, spaceBallOne.Cost);
            Console.WriteLine("************************************************************************************************************************");

            SpaceShip jupiterTwo = new SpaceShip();
            jupiterTwo.MaxFuel = 100;
            jupiterTwo.MaxCargo = 100;
            jupiterTwo.MaxWarpSpeed = 9.5;
            jupiterTwo.MaxRange = 857;
            jupiterTwo.Cost = "$40,000";
            jupiterTwo.Name = "Jupiter 2";
            Console.WriteLine("Jupiter 2 \nAre you looking for the best balance of speed, cargo and comfort? Meet the Jupiter 2." +
                " \nThe Jupiter 2 will get you where you need to go with everything you need in a modest amount of time." +
                " \nIf you like economy of all features, this is your ship!");
            Console.WriteLine("SPECS: Max Fuel=>  {0} | Max Cargo=>  {1} | Max Warp Speed=>  {2} | Range (LightYears)=> {3} | Cost=> {4}",
            jupiterTwo.MaxFuel, jupiterTwo.MaxCargo, jupiterTwo.MaxWarpSpeed, jupiterTwo.MaxRange, jupiterTwo.Cost);
            Console.WriteLine("************************************************************************************************************************");

            Console.WriteLine("Make your seletion >> (1) for the Falcon 5 | (2) for the SpaceBall 1 | (3) for the Jupiter 2");
            //int choice = int.Parse(Console.ReadLine());
            char choice = Console.ReadKey().KeyChar;

            switch (choice)
            {
                case '1':
                    Console.Clear();
                    //Console.WriteLine("\nCongratulations!!!! You selected the Falcon 5.");
                    var myShip = falconFive;
                    ShipSelection(falconFive);
                    break;
                case '2':
                    Console.Clear();
                    //Console.WriteLine("\nCongratulations!!!! You selected the SpaceBall 1.");
                    myShip = spaceBallOne;
                    ShipSelection(spaceBallOne);
                    break;
                case '3':
                    Console.Clear();
                    myShip = jupiterTwo;
                    //Console.WriteLine("\nCongratulations!!!! You selected the Jupiter 2.");
                    ShipSelection(jupiterTwo);
                    break;
            }
        }
        private void ShipSelection(SpaceShip myShip)
        {
            Console.WriteLine("Congratulations!! You selected " + myShip.Name);

            Console.WriteLine("\nPerformance parameters for your ship: " + "\nMax Fuel=>  {0} | Max Cargo=>  {1} | Max Warp Speed=> {2}",
                myShip.MaxFuel,
                myShip.MaxCargo,
                myShip.MaxWarpSpeed,
                myShip.MaxRange);

            
            double distance = 10;
            double time = distance / myShip.MaxWarpSpeed;
            double fuelLevel = time * 3.65;

            Console.WriteLine("\nIts time to kick the tires and light the fires!");
            Console.WriteLine("Fuel remaining= " + fuelLevel);
            Console.ReadLine();
        }
        /*
        public void CargoInventory()
        {
            //double weight;
            double space;

            //Placeholder Array / List of inventory items. 
            //Maximum quantity level (space and weight)
        }

        //public void Speed()
        //{
        //    // Warp Speed Formula: 

        //    var w;
        //    double v;

        //    v(W) = W(10 / 3) + Math.Pow(10.0 - 5.0, (3.67)); //Original formula => v(W) = (-11 / 3)= -3.67;
        //}*/
    }

    }
