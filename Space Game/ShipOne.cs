using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Space_Game
{

    public class SpaceShip
    {
        public string Name { get; private set; }
        public double MaxFuel { get; private set; }
        public double MaxCargo { get; private set; }
        public double MaxSpeed { get; private set; }
        public string Cost { get; set; }

        public void Ship(string ships)
        {
            Console.WriteLine("Choose Your Ship");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            SpaceShip falconFive = new SpaceShip();
            falconFive.MaxFuel = 80;
            falconFive.MaxCargo = 80;
            falconFive.MaxSpeed = 120;
            falconFive.Cost = "$50,000";

            Console.WriteLine("FALCON 5 \nThe Falcon 5 is your sportscar of the universe. It is fast and maneuverable, " +
                "but is limited on fuel and cargo." +
                " \nIf you need to get there fast and outrun most space pirates, this is your space ship!");
            Console.WriteLine("SPECS: Max Fuel=>  {0} | Max Cargo=>  {1} | Max Speed=>  | {2} Cost=> {3}",
                falconFive.MaxFuel,
                falconFive.MaxCargo,
                falconFive.MaxSpeed,
                falconFive.Cost);
            Console.WriteLine("************************************************************************************************************************");
            SpaceShip spaceBallOne = new SpaceShip();
            spaceBallOne.MaxFuel = 150;
            spaceBallOne.MaxCargo = 150;
            spaceBallOne.MaxSpeed = 80;
            spaceBallOne.Cost = "$45,000";

            Console.WriteLine("SPACEBALL 1 \n SpaceBall 1 is the ship for those who want to buy in bulk and carry a lot of cargo to the next planet." +
                " \nIf you are that type of intergalactic merchant, SpaceBall 1 is your ride!");
            
            Console.WriteLine("SPECS:  Max Fuel=>  {0} | Max Cargo=>  {1} | Max Speed=>  | {2} Cost=> {3}",
            spaceBallOne.MaxFuel,
            spaceBallOne.MaxCargo,
            spaceBallOne.MaxSpeed,
            spaceBallOne.Cost);
            Console.WriteLine("************************************************************************************************************************");

            SpaceShip jupiterTwo = new SpaceShip();
            jupiterTwo.MaxFuel = 100;
            jupiterTwo.MaxCargo = 100;
            jupiterTwo.MaxSpeed = 100;
            jupiterTwo.Cost = "$40,000";
            Console.WriteLine("Jupiter 2 \nAre you looking for the best balance of speed, cargo and comfort? Meet the Jupiter 2." +
                " \nThe Jupiter 2 will get you where you need to go with everything you need in a modest amount of time." +
                " \nIf you like economy of all features, this is your ship!");
            Console.WriteLine(" Max Fuel=>  {0} | Max Cargo=>  {1} | Max Speed=>  | {2} Cost=> {3}",
                jupiterTwo.MaxFuel,
                jupiterTwo.MaxCargo,
                jupiterTwo.MaxSpeed,
                jupiterTwo.Cost);
            Console.WriteLine("************************************************************************************************************************");
            Console.WriteLine("Make your seletion >> (1) for the Falcon 5 | (2) for the SpaceBall 1 | (3) for the Jupiter 2");
            Console.ReadLine();
        }



        //}

        //public void CargoLevel()
        //{
        //    //Placeholder Array / List of inventory items. 
        //    //Maximum quantity level (space and weight)
        //}

        //public void Speed()
        //{
        //    // Warp Speed Formula: 

        //    var w;
        //    double v;

        //    v(W) = W(10 / 3) + Math.Pow(10.0 - 5.0, (3.67)); //Original formula => v(W) = (-11 / 3)= -3.67;
        //}
    }

}
