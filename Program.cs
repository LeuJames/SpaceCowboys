using System;
using SpaceNinja.Models;

namespace SpaceNinja
{
    class Program
    {

      static void ConsoleYellow(string text)
      {
          Console.ForegroundColor = ConsoleColor.Yellow;
          Console.WriteLine(text);
          Console.ResetColor();
      }

      static Hero PlayerSetup()
      {
          Console.WriteLine("What is your name?");

          string name = Console.ReadLine();
          string choice = "0";

          while( choice != "1" && choice != "2" && choice != "3")
          {
              Console.WriteLine("Please type the number of the hero you would ike to be?\n1. Cowboy\n2. Gunslinger\n3. Sheriff");
              choice = Console.ReadLine();
          }

          switch (choice)
          {
              case("1"):
                  Cowboy cowboy = new Cowboy(name);
                  return cowboy;
              case("2"):
                  // Change Ninja to another class of hero.
                  Gunslinger gunslinger = new Gunslinger(name);
                  return gunslinger;
              case("3"):
                  // Change Ninja to another class of hero.
                  Sheriff sheriff = new Sheriff(name);
                  return sheriff;
          }
          return null;
      }

      // static void StartGame(Hero player)
      // {
        
      //   while (player.HP > 0)
      //   {
      //     while()
      //   }
      // }

        static void Main(string[] args)
        {
          ConsoleYellow("********COWBOYS IN SPACE********");

          Hero player = PlayerSetup();
          
          ConsoleYellow($"You, {player.Name}, have been chosen(randomly selected) to join a team of developer ninjas on a space quest!  To seek out new algorithms, new data structures, and go where no else wants to go! DEEP SPACE!!!\n\nHere you will encounter aliens, space monsters, and the unknown to bring back algorithms to benefit all humans. You now must choose your team.\n\nPress Enter to Start");

          ConsoleKey key  = Console.ReadKey(true).Key;
          while(key != ConsoleKey.Enter)
          {
              key  = Console.ReadKey(true).Key;
          }
          Console.WriteLine("BEGIN YOUR ADVENTURE HERE!!!");

          // StartGame(player);

        }
    }
}