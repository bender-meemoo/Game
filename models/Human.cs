using System;

namespace Game.models
{
    public class Human
    {


        public string Name;
        public int Strength;
        public int Intelligence;
        public int Dexterity;
        protected int health;
        public int Health
        {
            get { return health; }
        }
        public Human(string charname)
        {
            Name = charname;
            Strength = 3;
            Intelligence = 3;
            Dexterity = 3;
            health = 100;
        }

        public Human(string charname, int str, int intel, int dex, int hp)
        {
            Name = charname;
            Strength = str;
            Intelligence = intel;
            Dexterity = dex;
            health = hp;
        }


        public virtual int Attack(Human target)
        {
            target.health -= Strength * 5;
            return target.health;
        }
        public int TakeDamage(int damage)
        {
            health -= damage;
            return health;
        }
    }

    public class Wizard : Human
    {
        public Wizard(string wiz) : base(wiz)
        {
            health = 50;
            Intelligence = 25;
        }
        public int heal(Human target)
        {
            int heal = Intelligence * 5;
            target.TakeDamage(heal * -1);
            return target.Health;

        }
    }
    public class Ninja : Human
    {
        public Random rand = new Random();
        public Ninja(string name) : base(name)
        {
            Dexterity = 175;
        }
        public override int Attack(Human target)
        {
            int dmg = Dexterity * 5;
            int TwentyPercentChance = rand.Next(1, 11);
            if (TwentyPercentChance <= 2)
            {
                dmg += 10;
                Console.WriteLine("Booyah!");
            }
            target.TakeDamage(dmg);
            Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
            if (target.Health <= 0)
            {
                Console.WriteLine($"{Name} has defeated {target.Name}");
            }
            return target.Health;
        }
        public int Steal(Human target)
        {
            int dmg = 5;
            target.TakeDamage(dmg);
            TakeDamage(-dmg);
            Console.WriteLine($"{Name} has stolen {dmg} health from {target.Name}");
            return target.Health;
        }
    }

    public class Samurai : Human
    {
        public Samurai(string sam) : base (sam)
        {
            health = 200;
        }
    }
        public int meditate(Human target)
            {
                target.TakeDamage(meditate = 200);
                return target.Health;

            }

}