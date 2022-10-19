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

            int option;

            Console.WriteLine("Hello hero, what is you name?");
            battle.player.name = Console.ReadLine();


            while (battle.player.hpEnemy[0] > 0 && battle.enemy.hpHero > 0)
            {
                Console.Write("Press 1 to atack ");

                option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        battle.FightSkeletonFB();
                        break;
                }
            }

            if (battle.player.hpEnemy[0] > 0 && battle.enemy.hpHero < 0)
            {
                Console.WriteLine("You dead");
                
            }
            else Console.WriteLine("You win");

            Console.ReadKey();

        }
    }
  
}
