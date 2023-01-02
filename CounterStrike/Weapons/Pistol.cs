using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CounterStrike.Weapons
{
    public class Pistol : Weapon
    {
        public Pistol(string name, string color, int bulletNumber, int damage, int price) : base(name, color, bulletNumber, damage, price)
        {

        }

        public string GetDetails()
        {
            return $"Brand {Name} ,color {Color} , bulletNumer {BulletNumber}, damage {Damage} ,price {Price}";
        }
    }
}
