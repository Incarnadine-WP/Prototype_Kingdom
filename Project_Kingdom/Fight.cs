using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_Kingdom
{
    class Fight : Battle
    {

        protected string option;


        public void SkeletFight()
        {

            while (player.hpEnemy[0] > 0 && enemy.hpHero > 0)
            {
                Console.Write("\nOptions:\n\t1)Fire Ball\t\t4)Heal\n\t2)Chain Lighting\t3)Regen MP");
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
                        FightSkeletonFB();
                        Console.WriteLine();
                        break;
                    case 2:
                        FightSkeletonCL();
                        Console.WriteLine();
                        break;
                    case 3:
                        RegenManaSkelet();
                        Console.WriteLine();
                        break;
                    case 4:
                        HealSkeleton();
                        Console.WriteLine();
                        break;
                }
            }

        }

        public void OrcFight()
        {
            while (player.hpEnemy[1] > 0 && enemy.hpHero > 0)
            {
                Console.Write("\nOptions:\n\t1)Fire Ball\t\t3)Regen MP\n\t2)Chain Lighting\t4)Heal");
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
                        FightOrcFB();
                        Console.WriteLine();
                        break;
                    case 2:
                        FightOrcCL();
                        Console.WriteLine();
                        break;
                    case 3:
                        RegenManaOrc();
                        Console.WriteLine();
                        break;
                    case 4:
                        HealOrc();
                        Console.WriteLine();
                        break;
                }
            }
        }
    }
}
