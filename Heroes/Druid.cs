using Magicians_and_Priests_and_Druids.Interfaces;

namespace Magicians_and_Priests_and_Druids.Heroes
{
    internal class Druid : BaseHero, IHealer
    {
        int harmony;
        int maxHarmony;

        public Druid() : base(string.Format($"Hero_Druid #{++Druid.number}"))
        {
            this.maxHarmony = Druid.random.Next(50, 150);
            this.harmony = maxHarmony;
        }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.Write(string.Format($"Harmony: {this.harmony}\n"));
        }

        public void Heal(BaseHero target)
        {
            int heal = Druid.random.Next(5, 15);
            int harmonyCost = (int)(heal * 0.8);

            if (this.harmony - harmonyCost >= 0)
            {
                target.Healed(heal);
                this.harmony -= harmonyCost;
            }
            else
            {
                heal = (int)(this.harmony * 1.25);
                target.Healed(heal);
                this.harmony = 0;
            }
        }
    }
}
