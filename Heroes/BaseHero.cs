namespace Magicians_and_Priests_and_Druids.Heroes
{
    internal abstract class BaseHero
    {
        protected static int number;
        protected static Random random;

        protected string name;
        protected int hp;
        protected int maxHp;

        static BaseHero()
        {
            number = 0;
            random = new Random();
        }

        public BaseHero(string name, int hp)
        {
            this.name = name;
            this.hp = hp;
            this.maxHp = hp;
        }

        public BaseHero(string name)
            : this(name, BaseHero.random.Next(100, 200))
        {

        }

        public BaseHero()
        : this("") { }

        protected internal void Healed(int Hp)
        {
            this.hp = Hp + this.hp > maxHp ? maxHp : Hp + this.hp;
        }

         protected internal void GetDamage(int damage)
        {
            if (this.hp - damage > 0)
            {
                this.hp -= damage;
            }
            // else { die; }
        }

        ConsoleColor Colored(int hp)
        {
            if (this.maxHp * 0.8 < this.hp && this.hp < this.maxHp)
                return ConsoleColor.Green;
            else if (this.maxHp * 0.5 < this.hp && this.hp < this.maxHp * 0.8)
                return ConsoleColor.Yellow;
            else if (this.maxHp * 0.2 < this.hp && this.hp < this.maxHp * 0.5)
                return ConsoleColor.Red;
            else if (0 < this.hp && this.hp < this.maxHp * 0.2)
                return ConsoleColor.DarkRed;
            else
                return ConsoleColor.Gray;
        }

        public virtual void GetInfo()
        {
            ConsoleColor color = Colored(this.hp);
            Console.Write($"Name: {this.name}");
            Console.ForegroundColor = color;
            Console.Write($"  Hp: {this.hp}");
            Console.ResetColor();
            Console.Write($"  Type: {this.GetType().Name}  ");
        }

       
    }
}
