using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Game
{
    class Character
    {
        public string CharName { get; private set; }
        public string Gender { get; private set; }
        public string BirthPlanet { get; private set; }

        public Character(string charName, string gender, string birthPlanet)
        {
            this.CharName = charName;
            this.Gender = gender;
            this.BirthPlanet = birthPlanet;
        }
        public void CharSelection()
        {
            Console.WriteLine("You selected to explore the galaxy as " + CharName);

            Console.WriteLine("\nYou  " + "Home planet=> {2}",
                BirthPlanet);
        }
        
    }

}
