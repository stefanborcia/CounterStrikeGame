using System.Diagnostics.Metrics;
using CounterStrike.ArmyKit;
using CounterStrike.Weapons;

namespace CounterStrike.Players
{
    public class Terrorist : Fighter
    {
        public Terrorist(string userName, string skinColor, Pistol pistol, Armour armour, HeavyWeapon weapon) : base(userName, skinColor, pistol, armour, weapon)
        {

        }

        public Armour GetArmour()
        {
            return Armour;
        }
        public void Attack(Counter_Terrorist enemy)
        {
            // TODO: Creeaza o logica prin care ataca inamicul si scade din viata damage-ul pe care il poate provoca
        }

        public void ShowDetails()
        {
            Console.WriteLine($"My name is {UserName} ,i have the color {SkinColor},with my gun {Pistol.GetDetails()}, and my weapon {Weapon.GetDetails()} and i have armour {Armour.GetDetails()}");
        }
    }
}