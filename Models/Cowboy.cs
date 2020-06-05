  
using System;

namespace SpaceNinja.Models
{
    public class Cowboy : Hero
    {
        public override void SayName()
        {
            Console.WriteLine($"Hello My name is {HeroName}, and I'm a Cowboy.");
        }

        public Cowboy(string name) : base(name){}
    }
}