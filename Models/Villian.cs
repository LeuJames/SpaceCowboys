// using System;

// namespace SpaceNinja.Models
// {
//     public abstract class Villian
//     {
//         public string Name;
//         public int Dexterity;
//         public int Strength;
//         public int Speed;
//         protected int health;

//         public Villian(string name)
//         {
//             Name = name;
//             Dexterity = 5;
//             Strength = 5;
//             Speed = 5;
//             health = 100;
//         }

//         public abstract void SayName();

//         public virtual void ShowStats()
//         {
//             Console.WriteLine($"Name: {Name}\nDexterity: {Dexterity}\nStrength: {Strength}\nSpeed: {Speed}\nHealth: {health}");
//         }



//         public Villian(string name)
//         {
//             Name = name;
//             Dexterity = 5;
//             Strength = 5;
//             Speed = 5;
//             health = 100;
//         }

//         public abstract void SayName();

//         public virtual void ShowStats()
//         {
//             Console.WriteLine($"Name: {Name}\nDexterity: {Dexterity}\nStrength: {Strength}\nSpeed: {Speed}\nHealth: {health}");
//         }



//         public Character(string name)
//         {
//             Name = name;
//             Dexterity = 5;
//             Strength = 5;
//             Speed = 5;
//             health = 100;
//         }

//         public abstract void SayName();

//         public virtual void ShowStats()
//         {
//             Console.WriteLine($"Name: {Name}\nDexterity: {Dexterity}\nStrength: {Strength}\nSpeed: {Speed}\nHealth: {health}");
//         }



//     }
// }    public class Villian : Character
//     {
//         public override void SayName()
//         {
//             Console.WriteLine($"Hello My name is {Name}, and I'm a ninja.");
//         }

//         public Ninja(string name) : base(name){}
