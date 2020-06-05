using System;

namespace SpaceNinja.Models
{
    public abstract class Villian
    {
        public string Name;

        public string Type;
        public int Dexterity;
        public int Strength;
        public int Speed;
        public int health;

        public Villian()
        {
            // Name = name;
            // Dexterity = 5;
            // Strength = 5;
            // Speed = 5;
            // health = 100;
        }

        public virtual void SayName()
        {
            Console.WriteLine($"Halt! My name is {Name}, and I'm a {Type} Alien. And I'm gonna beat you up!");
        }


        public virtual void ShowStats()
        {
          Console.WriteLine("*******************************");
          Console.WriteLine($"{Name}'s Stats: \n Strength: {Strength}\n Health: {health}");
        }
        public void Attack( Hero target)
        {
          int dmg = Strength * 2;
          target.health -= dmg;
          Console.WriteLine($"{Type} {Name} attacked {target.Type} {target.Name} and it did {dmg} damage!");
          target.ShowStats();
        }
    }
}
