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
        public double FuelLevel { get; private set; }
        public double CargoLevel { get; private set; }
        public double MaxSpeed { get; private set; }

       public void Ship(string ships)
        {
            Console.WriteLine("Choose Your Ship");
            Console.WriteLine("----------------------------------");
            SpaceShip falconFive = new SpaceShip();
            falconFive.FuelLevel = 80;
            falconFive.CargoLevel = 80;
            falconFive.MaxSpeed = 150;

            Console.WriteLine("1) Press 1 to choose Falcon 5");
            Console.WriteLine("Fuel=>  {0} \nMax Cargo=>  {1} \nMax Speed=>  {2}",
                falconFive.FuelLevel,
                falconFive.CargoLevel,
                falconFive.MaxSpeed);

            SpaceShip spaceBallOne = new SpaceShip();
            spaceBallOne.FuelLevel = 150;
            spaceBallOne.CargoLevel = 150;
            spaceBallOne.MaxSpeed = 80;
            Console.WriteLine("\n2) Press 2 to choose SpaceBall One");
            Console.WriteLine("Fuel=>  {0} \nMax Cargo=>  {1} \nMax Speed=>  {2}",
            spaceBallOne.FuelLevel,
            spaceBallOne.CargoLevel,
            spaceBallOne.MaxSpeed);

            SpaceShip jupiterTwo = new SpaceShip();
            jupiterTwo.FuelLevel = 100;
            jupiterTwo.CargoLevel = 100;
            jupiterTwo.MaxSpeed = 100;
            Console.WriteLine("\n3) Press 3 to choose Jupiter 2");
            Console.WriteLine("Fuel=>  {0} \nMax Cargo=>  {1} \nMax Speed=>  {2}",
                jupiterTwo.FuelLevel,
                jupiterTwo.CargoLevel,
                jupiterTwo.MaxSpeed);

            Console.ReadLine();
        }


////Determine unit of measure
////tied to speed, need a formula for fuel consumption related to speed

//        public class SpaceShipAttributes
//        {


//        }
//    }
//    public void Speed()
//    {
//        //tied to fuel level, as speed is increased n% as fuel level decreases/tied to time. 
//        // Warp Speed Formula: 

//        var w;
//        double v;

//        v(W) = W(10 / 3) + Math.Pow(10.0 - 5.0, (3.67)); //Original formula => v(W) = (-11 / 3)= -3.67;
//    }
//    public void CargoLevel()
//    {
//        //Placeholder Array / List of inventory items. 
//        //Maximum quantity level (space and weight)
//    }

//}
//public class ShipTwo
//{
//    public void FuelLevel()
//    {
//        //Determine unit of measure
//        //tied to speed, need a formula for fuel consumption related to speed
//    }
//    public void Speed()
//    {
//        //tied to fuel level, as speed is increased n% as fuel level decreases/tied to time. 
//        // Warp Speed Formula: 

//        var w;
//        double v;

//        v(W) = W(10 / 3) + Math.Pow(10.0 - 5.0, (3.67)); //Original formula => v(W) = (-11 / 3)= -3.67;
//    }
//    public void CargoLevel()
//    {
//        //Placeholder Array / List of inventory items. 
//        //Maximum quantity level (space and weight)
//    }

//}
//public class ShipThree
//{
//    public void FuelLevel()
//    {
//        //Determine unit of measure
//        //tied to speed, need a formula for fuel consumption related to speed
//    }
//    public void Speed()
//    {
//        //tied to fuel level, as speed is increased n% as fuel level decreases/tied to time. 
//        // Warp Speed Formula: 

//        var w;
//        double v;

//        v(W) = W(10 / 3) + Math.Pow(10.0 - 5.0, (3.67)); //Original formula => v(W) = (-11 / 3)= -3.67;
//    }
//    public void CargoLevel()
//    {
//        //Placeholder Array / List of inventory items. 
//        //Maximum quantity level (space and weight)
 }

}
