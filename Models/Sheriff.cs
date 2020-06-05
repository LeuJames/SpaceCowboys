using System;

namespace SpaceNinja.Models
{
    public class Sheriff : Hero
    {
        public override void SayName()
        {
            Console.WriteLine($"Hello My name is {HeroName}, and I'm a ninja.");
        }

        public Sheriff(string name) : base(name){}
    }
}