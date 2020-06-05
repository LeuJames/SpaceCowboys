  
using System;

namespace SpaceNinja.Models
{
    public class Sheriff : Hero
    {
        public override void SayName()
        {
            Console.WriteLine($"Hello My name is {Name}, and I'm a Cowboy.");
        }

        public Sheriff(string name) : base(name)
        {
          Type = "Gunslinger";
          Strength = 50;
          health = 50;
        }
    }
}