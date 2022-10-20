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
            
            int dmg = ran.Next(12, 22);
            hpHero -= dmg;
            Console.Write($"\n{enemyName[0]} hit {playerName} for ");
            color.ColorAll(dmg, "dmg. ", ConsoleColor.Red);
            Console.Write("Current hp: ");
            color.ColorAll(hpHero, "/200", ConsoleColor.Green);
        }

        public void OrcHit(string _playerName)
        {
            playerName = _playerName;

            int dmg = ran.Next(20, 32);
            hpHero -= dmg;
            Console.Write($"\n{enemyName[1]} hit {playerName} for ");
            color.ColorAll(dmg, "dmg. ", ConsoleColor.Red);
            Console.Write("Current hp: ");
            color.ColorAll(hpHero, "/200", ConsoleColor.Green);
        }

        public void OrcHitRage(string _playerName)
        {
            playerName = _playerName;

            int dmg = ran.Next(33, 50);
            hpHero -= dmg;
            Console.Write($"\n{enemyName[1]} hit {playerName} for ");
            color.ColorAll(dmg, "dmg. ", ConsoleColor.Red);
            Console.Write("Current hp: ");
            color.ColorAll(hpHero, "/200", ConsoleColor.Green);
        }

        public int Heal(int hp)
        {
            hpHero = hp;
            int heal = 75;
            hpHero += heal;

            if (hpHero > 200)
            {
                hpHero = 200;
            }

            Console.Write("You healed for: ");

            return ColorTheme.ColorInt(heal, ConsoleColor.Green);
        }

    }

}
