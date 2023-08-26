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
            ((Magician)hero2).Attack(hero1); // Маг2 атакует Мага1
            ((Magician)hero1).Attack(hero4); // Маг1 атакует Друида4
            ((Magician)hero1).Attack(hero4); // Маг1 атакует Друида4
            ((Magician)hero1).Attack(hero4); // Маг1 атакует Друида4

            hero1.GetInfo();
            Console.WriteLine(new string('-', 57));
            hero4.GetInfo();
            Console.WriteLine(new string('-', 57));
            ((IHealer)hero4).Heal(hero1); // Друид4 лечит Мага1
            ((IHealer)hero4).Heal(hero1); // Друид4 лечит Мага1
            ((IHealer)hero4).Heal(hero1); // Друид4 лечит Мага1
            hero4.GetInfo();
            Console.WriteLine(new string('-', 57));
            hero1.GetInfo();
            Console.WriteLine(new string('-', 57));
            hero1.GetDamage(80); // Маг1 бьет сам себя - это проблема из-за того, что метод получения урона в базовом классе - публичный.
                                 // Если его сделать защищенным, тогда нельзя будет каким-то персонажем ударить другого персонажа.
                                 // Точнее можно будет попытаться, но метод получения урона можно будет вызвать только на собственном экземпляре, т.е. ударить самого себя...
                                 
            hero1.GetInfo();
            Console.WriteLine(new string('-', 57));
            hero1.Healed(500); // По аналогии Маг1 лечит сам себя из-за того, что опять же в базовом классе открытый метод получения лечения.
                               // У мага вообще никакого лечения не должно быть, т.к. по нашей логике лечить могут только Друиды.
                               // 
                               // Так вот, как решить эту проблему?
            hero1.GetInfo();
        }
    }
}