using System;
using CounterStrike;
using CounterStrike.ArmyKit;
using CounterStrike.Players;
using CounterStrike.Weapons;

namespace GameEntry
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Terrorist t1 = new Terrorist("Mircea", "brown",
                new Pistol("beretta", "black", 12, 10, 800),
                new Armour(30, "level1", "silver", 150),
                new HeavyWeapon("Ak44", "black", 25, 3000, 350));

            Counter_Terrorist ct1 = new Counter_Terrorist("Ion", "white",
                new Pistol("glock", "black", 11, 12, 950),
                new Armour(50, "level2", "white", 200),
                new HeavyWeapon("BullBup", "brown", 30, 3500, 500));

            t1.Attack(ct1);
            ct1.Attack(t1);

            t1.ShowDetails();
            t1.GetArmour().Health = 80;
            t1.ShowDetails();

            Console.ReadKey();
        }
    }
}