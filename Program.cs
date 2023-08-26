using Magicians_and_Priests_and_Druids.Heroes;
using Magicians_and_Priests_and_Druids.Interfaces;

namespace Magicians_and_Priests_and_Druids
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BaseHero hero1 = new Magician();
            BaseHero hero2 = new Magician();
            BaseHero hero3 = new Priest();
            BaseHero hero4 = new Druid();

            hero4.GetInfo();
            hero1.GetInfo();
            Console.WriteLine(new string('-', 57));
            ((Magician)hero2).Attack(hero1);
            ((Magician)hero1).Attack(hero4);
            ((Magician)hero1).Attack(hero4);
            ((Magician)hero1).Attack(hero4);

            hero1.GetInfo();
            Console.WriteLine(new string('-', 57));
            hero4.GetInfo();
            Console.WriteLine(new string('-', 57));
            ((IHealer)hero4).Heal(hero1);
            ((IHealer)hero4).Heal(hero1);
            ((IHealer)hero4).Heal(hero1);
            hero4.GetInfo();
            Console.WriteLine(new string('-', 57));
            hero1.GetInfo();
            Console.WriteLine(new string('-', 57));
            hero1.GetDamage(80);
            hero1.GetInfo();
            Console.WriteLine(new string('-', 57));
            hero1.Healed(500);
            hero1.GetInfo();
        }
    }
}