using Magicians_and_Priests_and_Druids.Interfaces;

namespace Magicians_and_Priests_and_Druids.Heroes
{
    internal class Priest : BaseHero, IAttacker
    {
        int elixir;
        int maxElixir;

        public Priest() : base(string.Format($"Hero_Priest #{++Priest.number}"))
        {
            this.maxElixir = Priest.random.Next(50, 150);
            this.elixir = maxElixir;
        }

        public void Attack(BaseHero target)
        {
            int damage = Magician.random.Next(20, 30);
            int elixirCost = (int)(damage * 0.8);

            if (this.elixir - elixirCost >= 0)
            {
                this.elixir = this.elixir - elixirCost;
                target.GetDamage(damage);
            }
            else
            {
                damage = (int)(this.elixir * 1.25);
                this.elixir = 0;
                target.GetDamage(damage);
            }
        }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.Write(string.Format($"Elixir: {this.elixir}\n"));
        }


    }
}
