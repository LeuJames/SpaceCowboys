  
using System;

namespace SpaceNinja.Models
{
    public class Cowboy : Hero
    {
        public override void SayName()
        {
            Console.WriteLine($"Hello My name is {Name}, and I'm a Cowboy.");
        }

        public Cowboy(string name) : base(name)
        {
          Type = "Cowboy";
          Strength = 10;
          health = 100;
        }
    }
}