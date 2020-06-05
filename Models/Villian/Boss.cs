using System;

namespace SpaceNinja.Models
{
    public class Boss : Villian
    {
        public override void SayName()
        {
            Console.WriteLine($"My name is {Name}, and I'm the {Type} of all the aliens. You seem to be carrying some cargo that is precious to me... Bankrobber Octopus is my most loyal employee. Give him back to me, or prepare to meet your maker!");
        }

        public Boss() : base()
        {
          Name = "Thanos";
          Type = "Boss";
          Strength = 11;
          health = 100;
        }
    }
}