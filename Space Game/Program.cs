using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            player.ChooseCharacter();
            player.ChooseShip();
           
            

            //GamePlayClass newGame = new GamePlayClass();
            //newGame.NexusOfTheGalaxy();

            //NexusOfTheGalaxy nexusOfTheGalaxy = new NexusOfTheGalaxy();
            //nexusOfTheGalaxy.PlanetaryChoices();
        }
    }
}
