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

        public int round = 1;

        public void SkeletFight()
        {
            while (player.hpEnemy[0] > 0 && enemy.hpHero[0] > 0)
            {
                Console.WriteLine("\n==================== ROUND: " + round + " ====================\n");
                Console.Write("Cast:\n\t1)Fire Ball(65mp)\t\t3)Heal(35mp)\n\t2)Regen MP");
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
                Console.WriteLine("\n==================== ROUND: " + round + " ====================\n");
                Console.Write("Cast:\n\t1)Fire Ball(65mp)\t\t3)Regen MP\n\t2)Chain Lighting(75mp)\t\t4)Heal(35mp)");
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
                round++;
            }
            if (player.hpEnemy[1] >= 0 && enemy.hpHero[0] <= 0)
            {
                ColorTheme.ColorString("\nYou died...\n", ConsoleColor.Magenta);

                Environment.Exit(0);

            }

            OrcFightRage();
        }

        public void OrcFightRage()
        {
            ColorTheme.ColorString("\nORC GOING TO RAGE!", ConsoleColor.Red);
            Console.WriteLine(" Be careful his damage increased.");
            Console.ReadKey();

            while (player.hpEnemy[1] > 0 && enemy.hpHero[0] > 0)
            {
                Console.WriteLine("\n==================== ROUND: " + round + " ====================\n");
                Console.Write("Cast:\n\t1)Fire Ball(65mp)\t\t3)Regen MP\n\t2)Chain Lighting(75mp)\t\t4)Heal(35mp)");
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
                round++;
            }
            
        }

        public void DragonFightOne()
        {
            while (player.hpEnemy[2] > 1 && enemy.hpHero[1] > 0)
            {
                Console.WriteLine("\n==================== ROUND: " + round + " ====================\n");
                Console.Write("Cast:\n\t1)Fire Ball(65mp)\t\t3)Regen MP\n\t2)Chain Lighting(75mp)\t\t4)Heal(45mp)");
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

                round++;
            }

            if (player.hpEnemy[2] > 0 && enemy.hpHero[1] <= 0)
            {
                ColorTheme.ColorString("\nYou died...\n", ConsoleColor.Magenta);

                Environment.Exit(0);
            }
            else if(player.hpEnemy[2] <= 1 && enemy.hpHero[1] > 0)
            {
                player.hpEnemy[2] = 700;
            }

            DragonFightTwo();
        }

        public void DragonFightTwo()
        {
            Console.WriteLine("\nGreat! you dealt the death blow to the dragon");
            Console.ReadKey();
            Console.WriteLine("But something went wrong");
            Console.ReadKey();
            Console.WriteLine("The dragon fell to the ground and then arise like a Phoenix");
            Console.ReadKey();
            Console.WriteLine("The battle is not over yet!");
            Console.ReadKey();

            while (player.hpEnemy[2] > 0 && enemy.hpHero[1] > 0)
            {
                Console.WriteLine("\n==================== ROUND: " + round + " ====================\n");
                Console.Write("Cast:\n\t1)Fire Ball(65mp)\t\t3)Regen MP\n\t2)Chain Lighting(75mp)\t\t4)Heal(45mp)");
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
                round++;
            }
        }

    }

}
