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

            Battle battle = new Battle();

            string option;

            Console.WriteLine("Hello hero, what is you name?");
            battle.player.name = Console.ReadLine();


            while (battle.player.hpEnemy[0] > 0 && battle.enemy.hpHero > 0)
            {
                Console.Write("\nOptions:\n\t1)Fire Ball\n\t2)Chain Lighting\t3)Regen mp");
                Console.WriteLine();

                int num = 0;

                option = Console.ReadLine();

                while(!int.TryParse(option, out num))
                {
                    Console.WriteLine("Select an available option");
                    option = Console.ReadLine();
                }

                switch (num)
                {
                    case 1:
                        battle.FightSkeletonFB();
                        Console.WriteLine();
                        break;
                    case 2:
                        battle.FightSkeletonCL();
                        Console.WriteLine();
                        break;
                    case 3:
                        battle.RegenManaSkelet();
                        Console.WriteLine();
                        break;
                }
            }

            if (battle.player.hpEnemy[0] > 0 && battle.enemy.hpHero < 0)
            {
                Console.WriteLine("You dead");

            }
            else 
            {
                Console.WriteLine("You win");
            }

            Console.WriteLine("Before you had time to rest, an angry orc jumped out at you!");

            while (battle.player.hpEnemy[1] > 0 && battle.enemy.hpHero > 0)
            {
                Console.Write("\nOptions:\n\t1)Fire Ball\n\t2)Chain Lighting\t3)Regen mp");
                Console.WriteLine();

                int num = 0;

                option = Console.ReadLine();

                while (!int.TryParse(option, out num))
                {
                    Console.WriteLine("Select an available option");
                    option = Console.ReadLine();
                }

                switch (num)
                {
                    case 1:
                        battle.FightOrcFB();
                        Console.WriteLine();
                        break;
                    case 2:
                        battle.FightOrcCL();
                        Console.WriteLine();
                        break;
                }
            }

            if (battle.player.hpEnemy[0] > 0 && battle.enemy.hpHero < 0)
            {
                ColorTheme.ColorString("You dead...", ConsoleColor.Magenta);
            }
            else
            {
                ColorTheme.ColorString("YOU WIN!", ConsoleColor.Magenta);
            }
            Console.WriteLine();
            Console.Write("Thanks for playing! The Kingdom will never forget the Hero by name: " + battle.player.name);

            Console.ReadKey();

        }
    }
  
}
