using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CounterStrike.ArmyKit
{
    public class ArmyKit
    {
        public int Health { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public int Price { get; set; }
        public ArmyKit(int health, string name, string color, int price)
        {
            Health = health;
            Name = name;
            Color = color;
            Price = price;
        }
    }
}
