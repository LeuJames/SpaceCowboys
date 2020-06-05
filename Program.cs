using System;
using System.Collections.Generic;
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

      public static void Continue()
      {
        ConsoleYellow("Press Enter to continue...");
        ConsoleKey key  = Console.ReadKey(true).Key;
        while(key != ConsoleKey.Enter)
        {
            key  = Console.ReadKey(true).Key;
        }
      }


      static void StartGame(Hero player)
      {
        List<Villian> BadGuys = new List<Villian>(){};
        Reptile r1 = new Reptile();
        Octopus o1 = new Octopus();
        Boss b1 = new Boss();
        BadGuys.Add(r1);
        BadGuys.Add(o1);
        BadGuys.Add(b1);

        while (player.health > 0)
        {
          // Level 1
          Console.WriteLine("You are traveling in your spaceship (the giddeeyup 5000) when you see you are running low on fuel \n\nYou decide to stop at the nearest planet... lets hope its a friendly one...");
          Continue();
          Console.WriteLine("Uh oh, the fuel station is guarded by a thug alien... lets checkout who it is:");
          Continue();
          BadGuys[0].SayName();
          BadGuys[0].ShowStats();
          while (BadGuys[0].health > 0)
          {
            ConsoleYellow("What would you like to do? \n 1) Attack? \n 2}Recover?");
            string choice1 = Console.ReadLine();
            if (choice1 == "1")
            {
              player.Attack(BadGuys[0]);
              if(BadGuys[0].health <= 0)
              {
                break;
              }
            }
            else if (choice1 == "2")
            {
              player.Recover();
            }
            else{
              Console.WriteLine("Please choose either 1 or 2");
            }
            BadGuys[0].Attack(player);
          }
          ConsoleYellow("You have defeated the Reptile. You were able to refuel and are able to keep going on your journey!");
          Continue();

          // Level 2
          Console.WriteLine("After a narrow escape from the last planet you are happily on your way... \n\nAll of the sudden, you get a case of the munchies!!! \nYou see a nearby planet that you've heard has a great moon pie so you decide to pull over!");
          Continue();
          Console.WriteLine("As you're coming into the planet you get into a fender bender with another spacecraft.The other driver looks exactly like an infamous bankrobber you saw on the news. You decide to try and bring him to justice. Let's see what happens:");
          Continue();
          BadGuys[1].SayName();
          BadGuys[1].ShowStats();
          while (BadGuys[1].health > 0)
          {
            ConsoleYellow("What would you like to do? \n 1) Attack? \n 2}Recover?");
            string choice2 = Console.ReadLine();
            if (choice2 == "1")
            {
              player.Attack(BadGuys[1]);
              if(BadGuys[1].health <= 0)
              {
                break;
              }
            }
            else if (choice2 == "2")
            {
              player.Recover();
            }
            else{
              Console.WriteLine("Please choose either 1 or 2");
            }
            BadGuys[1].Attack(player);
          }
          ConsoleYellow("You have defeated the BankRobber Octopus. You have a full spacecraft with your newly acquired space snacks and the cargohold where you stored the BankRobber. Now for a quick pitstop to the Intergalactic Police to turn him in.");
          Continue();

          // Level 3
          Console.WriteLine("You get halfway to the police planet when something huge comes up on your radar. It moves quickly and next thing you know its taking up your entire radar screen. \n\n After a few minutes of trying to mess with the display, you look up and your ship has been sucked into the hull of a massive space cruiser. What could be going on???");
          Continue();
          Console.WriteLine("You decide to exit your craft to see what's outside. You're met by a massive figure that looks like he means business. Let's see what he has to say:");
          Continue();
          BadGuys[2].SayName();
          BadGuys[2].ShowStats();
          while (BadGuys[2].health > 0)
          {
            ConsoleYellow("What would you like to do? \n 1) Attack? \n 2}Recover?");
            string choice2 = Console.ReadLine();
            if (choice2 == "1")
            {
              player.Attack(BadGuys[2]);
              if(BadGuys[2].health <= 0)
              {
                break;
              }
            }
            else if (choice2 == "2")
            {
              player.Recover();
            }
            else{
              Console.WriteLine("Please choose either 1 or 2");
            }
            BadGuys[2].Attack(player);
          }
          ConsoleYellow("You have defeated the Boss Thanos. You call the intergalactice police and they come pickup Thanos & the bankrobber and put them in jail for life. You make it to your sweetheart's ranch safely. You win!");
        }
        ConsoleYellow("You lost! Try again next time!");
      }

        static void Main(string[] args)
        {
          ConsoleYellow("********COWBOYS IN SPACE********");

          Hero player = PlayerSetup();
          
          ConsoleYellow($"You, {player.Name}, a {player.Type} that is on a trip throughout the nearby xarplon 14 galaxy. You are on your way to meet up with your lover who lives on a ranch on a faraway planet across the galaxy. This galaxy is known for it's outlaws, so you have to be careful. Are you up to the challenge??\n\nPress Enter to Start");

          ConsoleKey key  = Console.ReadKey(true).Key;
          while(key != ConsoleKey.Enter)
          {
              key  = Console.ReadKey(true).Key;
          }

          StartGame(player);
      
        }
    }
}