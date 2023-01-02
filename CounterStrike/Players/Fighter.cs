using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CounterStrike.ArmyKit;
using CounterStrike.Weapons;

namespace CounterStrike.Players
{
    public class Fighter
    {
        public string UserName { get; set; }
        public string SkinColor { get; set; }
        public Pistol Pistol { get; set; }
        public int Health { get; set; }
        public Armour Armour { get; set; }
        public HeavyWeapon Weapon { get; set; }

        public Fighter(string userName, string skinColor, Pistol pistol, Armour armour, HeavyWeapon weapon)
        {
            UserName = userName;
            SkinColor = skinColor;
            Pistol = pistol;
            Armour = armour;
            Weapon = weapon;
            Health = 100;

            Health += Armour.Health;
        }
    }
}
