using System;

namespace SpaceNinja.Models
{
    public class Gunslinger : Hero
    {
        public override void SayName()
        {
            Console.WriteLine($"Hello My name is {Name}, and I'm a ninja.");
        }

        public Gunslinger(string name) : base(name){}
    }
}