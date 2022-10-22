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

        int round = 1;

        public void SkeletFight()
        {
            while (player.hpEnemy[0] > 0 && enemy.hpHero[0] > 0)
            {
                Console.WriteLine("\n==================== ROUND: " + round + " ====================\n");
                Console.Write("Cast:\n\t1)Fire Ball\t\t3)Heal\n\t2)Regen MP");
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
                        RegenManaSkelet();
                        Console.WriteLine();
                        break;
                    case 3:
                        HealSkeleton();
                        Console.WriteLine();
                        break;
                    default:
                        if(num > 3)
                        Console.WriteLine("Select an available option");
                        round--;
                        break;
                }
                round++;
            }

        }

        public void OrcFight()
        {
            while (player.hpEnemy[1] > 250 && enemy.hpHero[0] > 0)
            {
                Console.Write("Cast:\n\t1)Fire Ball\t\t4)Heal\n\t2)Chain Lighting\t3)Regen MP");
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
                    default:
                        if (num > 4)
                            Console.WriteLine("Select an available option");
                        round--;
                        break;
                }
            }
        }

        public void OrcFightRage()
        {
            while (player.hpEnemy[1] > 0 && enemy.hpHero[0] > 0)
            {
                Console.Write("Cast:\n\t1)Fire Ball\t\t3)Regen MP\n\t2)Chain Lighting\t4)Heal");
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
                        OrcRageFB();
                        Console.WriteLine();
                        break;
                    case 2:
                        OrcRageCL();
                        Console.WriteLine();
                        break;
                    case 3:
                        RegenManaOrcRage();
                        Console.WriteLine();
                        break;
                    case 4:
                        HealOrcRage();
                        Console.WriteLine();
                        break;
                    default:
                        if (num > 4)
                            Console.WriteLine("Select an available option");
                        round--;
                        break;
                }
            }
        }

        public void DragonFightOne()
        {
            while (player.hpEnemy[2] > 0 && enemy.hpHero[1] > 0)
            {
                Console.Write("Cast:\n\t1)Fire Ball\t\t3)Regen MP\n\t2)Chain Lighting\t4)Heal");
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
                        FightDragonFB();
                        Console.WriteLine();
                        break;
                    case 2:
                        FightDragonCLLOW();
                        Console.WriteLine();
                        break;
                    case 3:
                        RegenManaDragonOne();
                        Console.WriteLine();
                        break;
                    case 4:
                        HealDragonLighting();
                        Console.WriteLine();
                        break;
                    default:
                        if (num > 4)
                            Console.WriteLine("Select an available option");
                        round--;
                        break;
                }
            }
        }

        public void DragonFightTwo()
        {
            while (player.hpEnemy[2] > 0 && enemy.hpHero[1] > 0)
            {
                Console.Write("Cast:\n\t1)Fire Ball\t\t3)Regen MP\n\t2)Chain Lighting\t4)Heal");
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
                        FightDragonFBLOW();
                        Console.WriteLine();
                        break;
                    case 2:
                        FightDragonCL();
                        Console.WriteLine();
                        break;
                    case 3:
                        RegenManaDragonTwo();
                        Console.WriteLine();
                        break;
                    case 4:
                        HealDragonFire();
                        Console.WriteLine();
                        break;
                    default:
                        if (num > 4)
                            Console.WriteLine("Select an available option");
                        round--;
                        break;
                }
            }
        }

    }

}
