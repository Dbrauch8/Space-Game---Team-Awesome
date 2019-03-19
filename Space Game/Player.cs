using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Game
{
    class Player
    {
        //class Character;

        public void ChooseCharacter()
        {
            Character myChar;
            Character ellenRipley = new Character("Ellen Ripley", "Female", "Earth");
            Character darkHelmet = new Character("Dark Helmet", "Male", "Alpha Cinturi");
            Character groot = new Character("Groot", "Male", "TitanAE");
            Character furiosa = new Character("Furiosa", "Female", "Obicrom Persei 8");

            Console.WriteLine("Choose your character");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");

            Console.WriteLine(" Ellen Ripley. \nEllen is from Earth and spent many years of her life as an intergalactic Soldier, defending mankind from dangerous" +
                "alien invaders. If you choose to be in Ellen's shoes for this adventure, you will begin on planet Earth.");
            Console.WriteLine("************************************************************************************************************************");
            Console.WriteLine("Dark Helmet. \nDark Helmet is a reformed space pirate from planet Alpha Centuri. If you choose to be Dark Helmet you " +
                "will begin the game from Alpha Centuri.");
            Console.WriteLine("************************************************************************************************************************");
            Console.WriteLine("Groot. \nGroot is an alien from TitanAE where the native beings resemble trees. He enjoys sunshine and rainy days. " +
                "If you choose your journey as Groot, you will begin on TitanAE.");
            Console.WriteLine("************************************************************************************************************************");
            Console.WriteLine("Furiosa \nFuriosa is from the dangerous planet of Obicrom Persei 8. She grew up battling bandits around her planet and has navigated " +
                "all around the galaxy. If you choose your journey with this adventurer, you will begin from Obicrom Persei 8");

            Console.ReadLine();

            Console.WriteLine("Make your seletion >> (1) to be Ellen Ripley | (2) to be Dark Helmet | (3) to be Groot | (4) to be Furiosa");
         
            char num = Console.ReadKey().KeyChar;

            switch (num)
            {
                case '1':
                    myChar = ellenRipley;
                    break;
                case '2':
                    myChar = darkHelmet;
                    break;
                case '3':
                    myChar = groot;
                    break;
                case '4':
                    myChar = furiosa;
                    break;
                default:
                    myChar = null;
                    break;
                    Console.Clear();
                    myChar.CharSelection();
            }
        }

        public void ChooseShip()
        {
            SpaceShip myShip;
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
        //GamePlay class method calls...?

        //class GamePlay
        //{
        //    GamePlay NexusOfTheGalaxy
        //}
    }
}
