using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prototype_Kingdom
{
    class Enemy
    {
        ColorTheme color = new ColorTheme();

        public string [] enemyName = {"Skeleton","Orc","Dragon" };
        public int hpHero = 200;
        string playerName;

        Random ran = new Random();

        public void SkeletonHit(string _playerName)
        {
            playerName = _playerName;
            
            int dmg = ran.Next(10, 20);
            hpHero -= dmg;
            Console.Write($"\n{enemyName[0]} hit {playerName} for ");
            color.ColorAll(dmg, "dmg. ", ConsoleColor.Red);
            Console.Write("Current hp: ");
            color.ColorAll(hpHero, "/200", ConsoleColor.Green);
        }

        public void OrcHit(string _playerName)
        {
            playerName = _playerName;

            int dmg = ran.Next(20, 35);
            hpHero -= dmg;
            Console.Write($"\n{enemyName[1]} hit {playerName} for ");
            color.ColorAll(dmg, "dmg. ", ConsoleColor.Red);
            Console.Write("Current hp: ");
            color.ColorAll(hpHero, "/200", ConsoleColor.Green);
        }

    }

}
