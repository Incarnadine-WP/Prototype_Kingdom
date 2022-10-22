using System;
using System.Collections.Generic;
using System.Linq;

namespace Prototype_Kingdom
{
    class Battle
    {
        public Player player = new Player();
        public Enemy enemy = new Enemy();
        public ColorTheme color = new ColorTheme();


        public void FightSkeletonFB()
        {
            player.CastFireBallSK(enemy.enemyName[0]);
            enemy.SkeletonHit(player.name);
            Console.Write(" Current mp: ");
            color.ColorAll(player.mpHero[0], "/200", ConsoleColor.Blue);
        }

        public void FightSkeletonCL()
        {
            player.LightingStrikeSK(enemy.enemyName[0]);
            enemy.SkeletonHit(player.name);
            Console.Write(" Current mp: ");
            color.ColorAll(player.mpHero[0], "/200", ConsoleColor.Blue);
        }

        public void HealSkeleton()
        {
            if (player.mpHero[0] >= 35)
            {
                int mp = -35;
                player.mpHero[0] += mp;
                Console.Write($"{player.name} cast {player.spell[3]} ");
                color.ColorAll(mp, "mp ", ConsoleColor.Blue);

                enemy.Heal(enemy.hpHero[0]);
                ColorTheme.ColorString("hp", ConsoleColor.Green);
                enemy.SkeletonHit(player.name);
                Console.Write(" Current mp: ");
                color.ColorAll(player.mpHero[0], "/200", ConsoleColor.Blue);
            }
            else
            {
                Console.Write("You dont have enough mana! ");
                color.ColorAll(player.mpHero[0], "/200", ConsoleColor.Blue);
            }
        }

        public void RegenManaSkelet()
        {
            player.RegenMPlvlOne(player.mpHero[0]);
            ColorTheme.ColorString("mp", ConsoleColor.Blue);
            enemy.SkeletonHit(player.name);
            Console.Write(" Current mp: ");
            color.ColorAll(player.mpHero[0], "/200", ConsoleColor.Blue);
        }


        public void HealOrc()
        {
            if (player.mpHero[1] >= 35)
            {
                int mp = -35;
                player.mpHero[1] += mp;
                Console.Write($"{player.name} cast {player.spell[3]} ");
                color.ColorAll(mp, "mp ", ConsoleColor.Blue);

                enemy.Heal(enemy.hpHero[0]);
                ColorTheme.ColorString("hp", ConsoleColor.Green);
                enemy.OrcHit(player.name);
                Console.Write(" Current mp: ");
                color.ColorAll(player.mpHero[1], "/300", ConsoleColor.Blue);
            }
            else
            {
                Console.Write("You dont have enough mana! ");
                color.ColorAll(player.mpHero[1], "/300", ConsoleColor.Blue);
            }

        }

        public void HealOrcRage()
        {
            if (player.mpHero[1] >= 35)
            {
                int mp = -35;
                player.mpHero[1] += mp;
                Console.Write($"{player.name} cast {player.spell[3]} ");
                color.ColorAll(mp, "mp ", ConsoleColor.Blue);

                enemy.Heal(enemy.hpHero[0]);
                ColorTheme.ColorString("hp", ConsoleColor.Green);
                enemy.OrcHitRage(player.name);
                Console.Write(" Current mp: ");
                color.ColorAll(player.mpHero[1], "/300", ConsoleColor.Blue);
            }
            else
            {
                Console.Write("You dont have enough mana! ");
                color.ColorAll(player.mpHero[1], "/300", ConsoleColor.Blue);
            }

        }

        public void FightOrcFB()
        {
            player.CastFireBallOrc(enemy.enemyName[1]);
            enemy.OrcHit(player.name);
            Console.Write(" Current mp: ");
            color.ColorAll(player.mpHero[1], "/300", ConsoleColor.Blue);
        }

        public void FightOrcCL()
        {
            player.LightingStrikeOrc(enemy.enemyName[1]);
            enemy.OrcHit(player.name);
            Console.Write(" Current mp: ");
            color.ColorAll(player.mpHero[1], "/300", ConsoleColor.Blue);
        }

        public void OrcRageFB()
        {
            player.CastFireBallOrc(enemy.enemyName[1]);
            enemy.OrcHitRage(player.name);
            Console.Write(" Current mp: ");
            color.ColorAll(player.mpHero[1], "/200", ConsoleColor.Blue);
        }

        public void OrcRageCL()
        {
            player.LightingStrikeOrc(enemy.enemyName[1]);
            enemy.OrcHitRage(player.name);
            Console.Write(" Current mp: ");
            color.ColorAll(player.mpHero[1], "/200", ConsoleColor.Blue);
        }

        public void RegenManaOrc()
        {
            player.RegenMPlvlTwo(player.mpHero[1]);
            ColorTheme.ColorString("mp", ConsoleColor.Blue);
            enemy.OrcHit(player.name);
            Console.Write(" Current mp: ");
            color.ColorAll(player.mpHero[1], "/300", ConsoleColor.Blue);
        }

        public void RegenManaOrcRage()
        {
            player.RegenMPlvlTwo(player.mpHero[1]);
            ColorTheme.ColorString("mp", ConsoleColor.Blue);
            enemy.OrcHitRage(player.name);
            Console.Write(" Current mp: ");
            color.ColorAll(player.mpHero[1], "/300", ConsoleColor.Blue);
        }

        
        public void RegenManaDragonOne()
        {
            player.RegenMPlvlTwo(player.mpHero[1]);
            ColorTheme.ColorString("mp", ConsoleColor.Blue);
            enemy.DragonLighting(player.name);
            Console.Write(" Current mp: ");
            color.ColorAll(player.mpHero[1], "/300", ConsoleColor.Blue);
        }

        public void RegenManaDragonTwo()
        {
            player.RegenMPlvlTwo(player.mpHero[1]);
            ColorTheme.ColorString("mp", ConsoleColor.Blue);
            enemy.DragonFireBall(player.name);
            Console.Write(" Current mp: ");
            color.ColorAll(player.mpHero[1], "/300", ConsoleColor.Blue);
        }

        public void FightDragonFB()
        {
            player.CastFireBallDragon(enemy.enemyName[2]);
            enemy.DragonLighting(player.name);
            Console.Write(" Current mp: ");
            color.ColorAll(player.mpHero[1], "/300", ConsoleColor.Blue);
        }

        public void FightDragonFBLOW()
        {
            player.CastFireBallDragonLOW(enemy.enemyName[2]);
            enemy.DragonFireBall(player.name);
            Console.Write(" Current mp: ");
            color.ColorAll(player.mpHero[1], "/300", ConsoleColor.Blue);
        }

        public void FightDragonCL()
        {
            player.LightingStrikeDragon(enemy.enemyName[2]);
            enemy.DragonFireBall(player.name);
            Console.Write(" Current mp: ");
            color.ColorAll(player.mpHero[1], "/300", ConsoleColor.Blue);
        }

        public void FightDragonCLLOW()
        {
            player.LightingStrikeDragonLOW(enemy.enemyName[2]);
            enemy.DragonLighting(player.name);
            Console.Write(" Current mp: ");
            color.ColorAll(player.mpHero[1], "/300", ConsoleColor.Blue);
        }

        public void HealDragonLighting()
        {
            if (player.mpHero[1] >= 45)
            {
                int mp = -45;
                player.mpHero[1] += mp;
                Console.Write($"{player.name} cast {player.spell[3]} ");
                color.ColorAll(mp, "mp ", ConsoleColor.Blue);

                enemy.HeallvlTwo(enemy.hpHero[1]);
                ColorTheme.ColorString("hp", ConsoleColor.Green);
                enemy.DragonLighting(player.name);
                Console.Write(" Current mp: ");
                color.ColorAll(player.mpHero[1], "/300", ConsoleColor.Blue);
            }
            else
            {
                Console.Write("You dont have enough mana! ");
                color.ColorAll(player.mpHero[1], "/300", ConsoleColor.Blue);
            }

        }

        public void HealDragonFire()
        {
            if (player.mpHero[1] >= 45)
            {
                int mp = -45;
                player.mpHero[1] += mp;
                Console.Write($"{player.name} cast {player.spell[3]} ");
                color.ColorAll(mp, "mp ", ConsoleColor.Blue);

                enemy.HeallvlTwo(enemy.hpHero[1]);
                ColorTheme.ColorString("hp", ConsoleColor.Green);
                enemy.DragonFireBall(player.name);
                Console.Write(" Current mp: ");
                color.ColorAll(player.mpHero[1], "/300", ConsoleColor.Blue);
            }
            else
            {
                Console.Write("You dont have enough mana! ");
                color.ColorAll(player.mpHero[1], "/300", ConsoleColor.Blue);
            }

        }

    }

}