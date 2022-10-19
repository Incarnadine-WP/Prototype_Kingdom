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

        public void FightOrcFB()
        {
            player.CastFireBallOrc(enemy.enemyName[1]);
            enemy.OrcHit(player.name);
            Console.Write(" Current mp: ");
            color.ColorAll(player.mpHero[0], "/200", ConsoleColor.Blue);
        }

        public void FightOrcCL()
        {
            player.LightingStrikeOrc(enemy.enemyName[1]);
            enemy.OrcHit(player.name);
            Console.Write(" Current mp: ");
            color.ColorAll(player.mpHero[0], "/200", ConsoleColor.Blue);
        }

        public void RegenManaSkelet()
        {
            player.RegenMPlvlOne(player.mpHero[0]);
            ColorTheme.ColorString("mp", ConsoleColor.Blue);
            enemy.SkeletonHit(player.name);
            Console.Write(" Current mp: ");
            color.ColorAll(player.mpHero[0], "/200", ConsoleColor.Blue);
        }

    }

}