using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_Kingdom
{
    class Narrative : Fight
    {
        public void Intro()
        {
            Console.WriteLine("Hello stranger! Welcome to the demo version of \"KINGDOM\"");
            Console.WriteLine("What is your name?");
            player.name = Console.ReadLine();
            Console.WriteLine("Nice to meet you "+player.name +"!");
            Console.WriteLine("Look this Skeleton is already very close go and deal with him");
            Console.Write("Press any button when you're ready.  ");
            Console.ReadKey();
            Console.WriteLine("\nThe battle has begun");
        }

        public void EndSkeletFight()
        {
            if (player.hpEnemy[0] > 0 && enemy.hpHero[0] < 0)
            {
                ColorTheme.ColorString("You dead...", ConsoleColor.Magenta);
            }
            else if (player.hpEnemy[0] < 0 && enemy.hpHero[0] < 0)
            {
                ColorTheme.ColorString("At the cost of your life you dealt with the Skeleton, this is where your journey ends... ", ConsoleColor.Magenta);
            }
            else
            {
                Console.WriteLine("You win");
            }
        }

        public void EndOrcFight()
        {
            if (player.hpEnemy[1] > 0 && enemy.hpHero[0] < 0)
            {
                ColorTheme.ColorString("You dead...", ConsoleColor.Magenta);
            }

            Console.WriteLine("ORC RAGE!");
        }
    }
}
