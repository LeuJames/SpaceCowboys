using System;

namespace SpaceNinja.Models
{
    public abstract class Hero : IRecoverable
    {
        public string Name {get; set;}
        // public int Dexterity;
        public int Strength {get; set;}

        public int health {get; set;}
        public string Type {get; set;}

        public Hero(string name)
        {
            Name = name;
            // Dexterity = 5;
            // Strength = 5;
            // Speed = 5;
            // health = 100;
        }

        public abstract void SayName();

        public virtual void ShowStats()
        {
            Console.WriteLine("*******************************");
            Console.WriteLine($"Your stats: \n Strength: {Strength}\n Health: {health}");
        }

        public void Recover()
        { 
          health+= 20;
          Console.WriteLine("Player just recovered by 20 health points");
          ShowStats();
        }

        public void Attack(Villian target)
        {
          int dmg = Strength * 3;
          target.health -= dmg;
          Console.WriteLine($"{Type} {Name} attacked {target.Type} {target.Name} and it did {dmg} damage!");
          target.ShowStats();
          if (target.health <= 0)
          {
        
          }
        }
    }
}