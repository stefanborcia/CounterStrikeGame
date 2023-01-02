using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CounterStrike.ArmyKit;
using CounterStrike.Weapons;

namespace CounterStrike.Players
{
    public class Counter_Terrorist : Fighter
    {
        public Counter_Terrorist(string userName, string skinColor, Pistol pistol, Armour armour, HeavyWeapon weapon) : base(userName, skinColor, pistol, armour, weapon)
        {

        }

        public void Attack(Terrorist enemy)
        {
            // TODO: Create a logic by which it attacks the enemy and subtracts from the life the damage it can cause

        }
    }
}
