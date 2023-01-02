using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CounterStrike.ArmyKit
{
    public class Armour : ArmyKit
    {
        public Armour(int health, string name, string color, int price) : base(health, name, color, price)
        {

        }

        public string GetDetails()
        {
            return $"Health {Health} , name {Name}, color {Color}, price {Price}";
        }
    }
}
