using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CounterStrike.Weapons
{
    public class HeavyWeapon : Weapon
    {
        public HeavyWeapon(string name, string color, int bulletNumber, int damage, int price) : base(name, color, bulletNumber, damage, price)
        {

        }

        public string GetDetails()
        {
            return $"Name {Name}, bullet number {BulletNumber}, damage {Damage}, price {Price}, color {Color}";
        }
    }
}
