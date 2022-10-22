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
        }

        public void Intro2()
        {
            Console.WriteLine("Nice to meet you " + player.name + "!");
            Console.WriteLine("Look this Skeleton is already very close, go and deal with him");
            Console.Write("Press any button when you're ready.  ");
            Console.ReadKey();
            Console.WriteLine("\nThe battle has begun");
        }
            
        public void EndSkeletFight()
        {
            if (player.hpEnemy[0] > 0 && enemy.hpHero[0] < 0)
            {
                ColorTheme.ColorString("\nYou died...\n", ConsoleColor.Magenta);
                
                Environment.Exit(0);
            }
            else if (player.hpEnemy[0] < 0 && enemy.hpHero[0] < 0)
            {
                ColorTheme.ColorString("At the cost of your life you dealt with the Skeleton, this is where your journey ends... ", ConsoleColor.Magenta);
            }
            else
            {
                Console.WriteLine("\nYou did it! Skeleton is dead, \"again\"... ");
                Console.ReadKey();
                Console.WriteLine("Congratulations! lvl up, you learned a new skill \"Chain Lighting\", its deal damage to target three times.\nAlso your mana has increased to 300 mp.");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("A fairly strong Orc awaits you ahead, it's time to try out new abilities");
                Console.ReadKey();
            }
        }

        public void EndOrcFight()
        {
            if (player.hpEnemy[1] > 0 && enemy.hpHero[0] < 0)
            {
                ColorTheme.ColorString("\nYou died...\n", ConsoleColor.Magenta);
                Environment.Exit(0);

            }
            else if (player.hpEnemy[1] < 0 && enemy.hpHero[0] < 0)
            {
                ColorTheme.ColorString("\nAt the cost of your life you dealt with the Orc, this is where your journey ends... ", ConsoleColor.Magenta);
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("\nIt was not an easy fight, your deserved victory");
                Console.ReadKey();
                Console.WriteLine("Congratulations! lvl up, your magic has become stronger and health has increased to 300hp.");
                Console.ReadKey();
            }
        }

        public void Intro3()
        {
            Console.Clear();
            Console.WriteLine("It began to rain, which quickly turned into a downpour");
            Console.ReadKey();
            Console.WriteLine("A real dragon appeared from the clouds, you can't believe your eyes. He is heading straight for you");
            Console.ReadKey();
            Console.WriteLine("Get ready!");
        }

        public void EndDragonFight()
        {
            if (player.hpEnemy[2] >= 0 && enemy.hpHero[1] <= 0)
            {
                ColorTheme.ColorString("\nYou died...\n", ConsoleColor.Magenta);
                Environment.Exit(0);

            }
            else if (player.hpEnemy[2] <= 0 && enemy.hpHero[1] <= 0)
            {
                ColorTheme.ColorString("\nAt the cost of your life you dealt with the Dragon, the Kingdom will never forget the Hero by name: " + player.name, ConsoleColor.Magenta);
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("\nIncredible victory, you defeated the dragon, twice!");
                Console.ReadKey();
                Console.WriteLine("Thanks for playing! Greet the new hero of the Kingdom: " + player.name);
                Console.ReadKey();
                Console.WriteLine("Goodbye.");
            }
        }
    }
}
