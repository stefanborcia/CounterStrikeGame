using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CounterStrike.Weapons
{
    public class Weapon
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public int  BulletNumber { get; set; }
        public int Damage { get; set; }
        public int Price { get; set; }

        public Weapon(string name, string color, int bulletNumber, int damage, int price)
        {
            Name = name;
            Color = color;
            BulletNumber = bulletNumber;
            Damage = damage;
            Price = price;
        }
    }
}
