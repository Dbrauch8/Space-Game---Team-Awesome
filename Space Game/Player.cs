using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Game
{
    class Player
    {
        SpaceShip myShip;

        public void ChooseShip()
        {
            SpaceShip falconFive   = new SpaceShip("Falcon 5",     80,  80,  11, 1331, "$50,000");
            SpaceShip spaceBallOne = new SpaceShip("SpaceBall 1", 150, 150, 8.5,  614, "$45,000");
            SpaceShip jupiterTwo   = new SpaceShip("Jupiter 2",   100, 100, 9.5,  857, "$40,000");

            Console.WriteLine("Choose Your Ship");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");

            Console.WriteLine("FALCON 5 \nThe Falcon 5 is your sportscar of the universe. It is the fastest ship in the fleet, able to achieve 'Ludakris speed'." +
                "\nIt is also ver maneuverable. Your limitations are fuel and cargo capacity." +
                " \nIf you need to get there fast and outrun most space pirates, this is your space ship!");
            Console.WriteLine("SPECS: Max Fuel=>  {0} | Max Cargo=>  {1} | Max Warp Speed=>  {2} | Range (LightYears)=> {3} | Cost=> {4}",
                falconFive.MaxFuel, falconFive.MaxCargo, falconFive.MaxWarpSpeed, falconFive.MaxRange, falconFive.Cost);

            Console.WriteLine("************************************************************************************************************************");

            Console.WriteLine("SPACEBALL 1 \n SpaceBall 1 is the ship for those who want to buy in bulk and carry a lot of cargo to the next planet." +
                " \nIf you are that type of intergalactic merchant, SpaceBall 1 is your ride!");
            Console.WriteLine("SPECS: Max Fuel=>  {0} | Max Cargo=>  {1} | Max Warp Speed=>  {2} | Range (LightYears)=> {3} | Cost=> {4}",
                spaceBallOne.MaxFuel, spaceBallOne.MaxCargo, spaceBallOne.MaxWarpSpeed, spaceBallOne.MaxRange, spaceBallOne.Cost);

            Console.WriteLine("************************************************************************************************************************");

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
                    myShip = falconFive;
                    break;
                case '2':
                    myShip = spaceBallOne;
                    break;
                case '3':
                    myShip = jupiterTwo;
                    break;
                default:
                    myShip = null;
                    break;
            }

            Console.Clear();

            myShip.ShipSelection();
        }
    }
}
