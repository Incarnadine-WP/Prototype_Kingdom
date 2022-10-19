using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_Kingdom
{

    class Player 
    {
        ColorTheme color = new ColorTheme();

        public string name;
        public int [] hpEnemy = { 200, 700, 1000 };

        string [] spell = { "Fire Ball", "Chain Lighting" };
        string enemyName;
        public int [] mpHero = { 200, 300 };


        Random ran = new Random();

        public void CastFireBallSK(string _enemyName)
        {
            enemyName = _enemyName;

            if (mpHero[0] >= 66)
            {
                int mp = -65;
                int dmg = ran.Next(55, 80);

                hpEnemy[0] -= dmg;

                Console.Write($"{name} cast {spell[0]} ");
                color.ColorAll(mp, "mp ", ConsoleColor.Blue);
                Console.Write ($"at the {_enemyName} and dealt ");
                color.ColorAll(dmg, "dmg. ", ConsoleColor.DarkYellow);
                Console.Write("Current hp: ");
                color.ColorAll(hpEnemy[0], "/200", ConsoleColor.Green);

                mpHero[0] += mp;
            }
            else
            {
                Console.Write("You dont have enough mana! ");
                color.ColorAll(mpHero[0], "/200", ConsoleColor.Blue);
            }

        }

        public void LightingStrikeSK(string _enemyName)
        {
            enemyName = _enemyName;


            if (mpHero[0] >= 76)
            {
                int dmg = ran.Next(25, 35);
                int dmg2 = ran.Next(25, 35);
                int dmg3 = ran.Next(25, 35);

                int mp = -75;

                hpEnemy[0] -= dmg + dmg +dmg;

                Console.Write($"{name} cast {spell[1]} ");
                color.ColorAll(mp, "mp ", ConsoleColor.Blue);
                Console.Write($"at the {_enemyName} and dealt ");
                color.ColorAll(dmg, " + ", ConsoleColor.Cyan);
                color.ColorAll(dmg2, " + ", ConsoleColor.Cyan);
                color.ColorAll(dmg3, " dmg. ", ConsoleColor.Cyan);

                Console.Write("Current hp: ");
                color.ColorAll(hpEnemy[0], "/200", ConsoleColor.Green);

                mpHero[0] += mp;
            }
            else 
            {
                Console.Write("You dont have enough mana! ");
                color.ColorAll(mpHero[0], "/200", ConsoleColor.Blue);
            }

        }

        public void CastFireBallOrc(string _enemyName)
        {
            enemyName = _enemyName;

            if (mpHero[0] >= 66)
            {
                int mp = -65;
                int dmg = ran.Next(50, 80);

                hpEnemy[1] -= dmg;

                Console.Write($"{name} cast {spell[0]} ");
                color.ColorAll(mp, "mp ", ConsoleColor.Blue);
                Console.Write($"at the {_enemyName} and dealt ");
                color.ColorAll(dmg, "dmg. ", ConsoleColor.DarkYellow);
                Console.Write("Current hp: ");
                color.ColorAll(hpEnemy[1], "/200", ConsoleColor.Green);

                mpHero[0] += mp;
            }
            else
            {
                Console.Write("You dont have enough mana! ");
                color.ColorAll(mpHero[0], "/200", ConsoleColor.Blue);
            }

        }

        public void LightingStrikeOrc(string _enemyName)
        {
            enemyName = _enemyName;


            if (mpHero[0] >= 76)
            {
                int dmg = ran.Next(25, 35);
                int dmg2 = ran.Next(25, 35);
                int dmg3 = ran.Next(25, 35);

                int mp = -75;

                hpEnemy[1] -= dmg + dmg + dmg;

                Console.Write($"{name} cast {spell[1]} ");
                color.ColorAll(mp, "mp ", ConsoleColor.Blue);
                Console.Write($"at the {_enemyName} and dealt ");
                color.ColorAll(dmg, " + ", ConsoleColor.Cyan);
                color.ColorAll(dmg2, " + ", ConsoleColor.Cyan);
                color.ColorAll(dmg3, " dmg. ", ConsoleColor.Cyan);

                Console.Write("Current hp: ");
                color.ColorAll(hpEnemy[1], "/200", ConsoleColor.Green);

                mpHero[0] += mp;
            }
            else
            {
                Console.Write("You dont have enough mana! ");
                color.ColorAll(mpHero[0], "/200", ConsoleColor.Blue);
            }

        }

        public int RegenMPlvlOne(int mp)
        {
             mpHero[0] = mp;
             int regenMP = 200 - mp;
             mpHero[0] += regenMP;

             Console.Write("You regen: ");

             return ColorTheme.ColorInt(regenMP, ConsoleColor.Blue);

        }

        public int RegenMPlvlTwo(int mp)
        {
            mpHero[1] = mp;
            int regenMP = 200 - mp;
            mpHero[1] += regenMP;

            Console.Write("You regen: ");

            return ColorTheme.ColorInt(regenMP, ConsoleColor.Blue);

        }

    }


}
