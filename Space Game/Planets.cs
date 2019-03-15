using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Game
{
    public class Planets
    {
        public string Name { get; set; }
        public string Entrance { get; set; }
        public string ShopOne { get; set; }
        public string ShopTwo { get; set; }
        public string FuelStation { get; set; }
        public List<string> ShopList { get; set; }

        public void Space_Game(string name, string entrance, string shopone, string shoptwo, string fuelstation, List<string> shoplist)
        {
            Name = name;
            Entrance = entrance;
            ShopOne = shopone;
            ShopTwo = shoptwo;
            FuelStation = fuelstation;
            ShopList = shoplist;
        }
    }
}
