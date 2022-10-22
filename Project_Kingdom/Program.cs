using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prototype_Kingdom
{

   class GameStart
    {

        static void Main(string[] args)
        {
            Console.Title = "Kingdom";

            Fight fight = new Fight();
            Narrative narrative = new Narrative();

           // Console.WriteLine("Hello hero, what is you name?");
           // fight.player.name = Console.ReadLine();
            
            fight.SkeletFight();

            narrative.EndSkeletFight();
      
            Console.WriteLine("Before you had time to rest, an angry orc jumped out at you!");

            fight.OrcFight();

            if (fight.player.hpEnemy[1] > 0 && fight.enemy.hpHero[0] < 0)
            {
                ColorTheme.ColorString("You dead...", ConsoleColor.Magenta);
            }
            
            Console.WriteLine("ORC RAGE!");

            fight.OrcFightRage();

            if (fight.player.hpEnemy[1] > 0 && fight.enemy.hpHero[0] < 0)
            {
                ColorTheme.ColorString("You dead...", ConsoleColor.Magenta);
            }
            else if(fight.player.hpEnemy[1] < 0 && fight.enemy.hpHero[0] < 0)
            {
                ColorTheme.ColorString("At the cost of your life you dealt with the Orc, this is where your journey ends... ", ConsoleColor.Magenta);
            }
            else
            {
                ColorTheme.ColorString("YOU WIN!", ConsoleColor.Magenta);
            }
            Console.WriteLine();
            Console.Write("Thanks for playing! The Kingdom will never forget the Hero by name: " + fight.player.name);

            Console.ReadKey();
            
        }
    }
  
}
