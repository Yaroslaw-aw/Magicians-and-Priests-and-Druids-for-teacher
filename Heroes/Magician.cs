using Magicians_and_Priests_and_Druids.Interfaces;

namespace Magicians_and_Priests_and_Druids.Heroes
{
    internal class Magician : BaseHero, IAttacker
    {
        int mana;
        int maxMana;

        public Magician() : base(string.Format($"Hero_Magician #{++Magician.number}"))
        {
            this.maxMana = Magician.random.Next(50, 150);
            this.mana = this.maxMana;
        }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.Write($"Mana: {this.mana}\n");
        }

        public void Attack(BaseHero target)
        {
            int damage = Magician.random.Next(20, 30);
            int manaCost = (int)(damage * 0.8);

            if (this.mana - manaCost > 0)
            {
                this.mana = this.mana - manaCost;
                target.GetDamage(damage);
            }
            else
            {
                damage = (int)(this.mana * 1.25);
                this.mana = 0;
                target.GetDamage(damage);
            }
        }
    }
}
