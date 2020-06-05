using System;

namespace SpaceNinja.Models
{
    public class Reptile : Villian
    {

        public Reptile() : base()
        {
          Name = "Bandit";
          Type = "Reptile";
          Strength = 5;
          health = 25;
        }
    }
}