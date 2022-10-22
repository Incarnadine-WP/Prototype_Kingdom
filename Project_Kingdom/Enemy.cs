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
        public int [] hpHero = { 200, 300 };

        string playerName;

        Random ran = new Random();

        public void SkeletonHit(string _playerName)
        {
            playerName = _playerName;
            
            int dmg = ran.Next(12, 22);
            hpHero[0] -= dmg;
            Console.Write($"\n{enemyName[0]} hit {playerName} for ");
            color.ColorAll(dmg, "dmg. ", ConsoleColor.Red);
            Console.Write("Current hp: ");
            color.ColorAll(hpHero[0], "/200", ConsoleColor.Green);
        }

        public void OrcHit(string _playerName)
        {
            playerName = _playerName;

            int dmg = ran.Next(20, 32);
            hpHero[0] -= dmg;
            Console.Write($"\n{enemyName[1]} hit {playerName} for ");
            color.ColorAll(dmg, "dmg. ", ConsoleColor.Red);
            Console.Write("Current hp: ");
            color.ColorAll(hpHero[0], "/200", ConsoleColor.Green);
        }

        public void OrcHitRage(string _playerName)
        {
            playerName = _playerName;

            int dmg = ran.Next(33, 50);
            hpHero[0] -= dmg;
            Console.Write($"\n{enemyName[1]} hit {playerName} for ");
            color.ColorAll(dmg, "dmg. ", ConsoleColor.Red);
            Console.Write("Current hp: ");
            color.ColorAll(hpHero[0], "/200", ConsoleColor.Green);
        }

        public void DragonLighting(string _playerName)
        {
            playerName = _playerName;

            int randomAction = ran.Next(1, 10);

            int lighting = ran.Next(55, 75);
            

            int dmg = ran.Next(35, 50);

            if (randomAction <= 7)
            {
                hpHero[1] -= dmg;
                Console.Write($"\n{enemyName[2]} hit {playerName} for ");
                color.ColorAll(dmg, "dmg. ", ConsoleColor.Red);
                Console.Write("Current hp: ");
                color.ColorAll(hpHero[1], "/300", ConsoleColor.Green);
            }
            else
            {
                hpHero[1] -= lighting;
                Console.Write($"\n{enemyName[2]} flaps his wings and use Lightning strikes on {playerName} for ");
                color.ColorAll(lighting, " dmg. ", ConsoleColor.Cyan);
                Console.Write("Current hp: ");
                color.ColorAll(hpHero[1], "/300", ConsoleColor.Green);
            }
        }

        public void DragonFireBall(string _playerName)
        {
            playerName = _playerName;

            int randomAction = ran.Next(1, 10);

            int fireBall = ran.Next(70, 90);
            
            int dmg = ran.Next(40, 55);

            if (randomAction <= 7)
            {
                hpHero[1] -= dmg;
                Console.Write($"\n{enemyName[2]} hit {playerName} for ");
                color.ColorAll(dmg, "dmg. ", ConsoleColor.Red);
                Console.Write("Current hp: ");
                color.ColorAll(hpHero[1], "/300", ConsoleColor.Green);
            }
            else
            {
                hpHero[1] -= fireBall;
                Console.Write($"\n{enemyName[2]} takes a breath and then strike with Fire {playerName} for ");
                color.ColorAll(fireBall, "dmg. ", ConsoleColor.DarkYellow);

                Console.Write("Current hp: ");
                color.ColorAll(hpHero[1], "/300", ConsoleColor.Green);
            }
        }


        public int Heal(int hp)
        {
            hpHero[0] = hp;
            int heal = 75;
            hpHero[0] += heal;

            if (hpHero[0] > 200)
            {
                hpHero[0] = 200;
            }

            Console.Write("You healed for: ");

            return ColorTheme.ColorInt(heal, ConsoleColor.Green);
        }

        public int HeallvlTwo(int hp)
        {
            hpHero[1] = hp;
            int heal = 90;
            hpHero[1] += heal;

            if (hpHero[1] > 300)
            {
                hpHero[0] = 300;
            }

            Console.Write("You healed for: ");

            return ColorTheme.ColorInt(heal, ConsoleColor.Green);
        }

    }

}
