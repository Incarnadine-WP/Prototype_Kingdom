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
        public int [] hpEnemy = { 200, 500, 700 };

        public string [] spell = { "Fire Ball", "Chain Lighting","Regen MP","Heal" };
        string enemyName;
        public int [] mpHero = { 200, 300 };


        Random ran = new Random();

        public void CastFireBallSK(string _enemyName)
        {
            enemyName = _enemyName;

            if (mpHero[0] >= 65)
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


            if (mpHero[0] >= 75)
            {
                int dmg = ran.Next(25, 35);
                int dmg2 = ran.Next(25, 35);
                int dmg3 = ran.Next(25, 35);

                int mp = -75;

                hpEnemy[0] -= dmg + dmg2 +dmg3;

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

            if (mpHero[1] >= 65)
            {
                int mp = -65;
                int dmg = ran.Next(50, 80);

                hpEnemy[1] -= dmg;

                Console.Write($"{name} cast {spell[0]} ");
                color.ColorAll(mp, "mp ", ConsoleColor.Blue);
                Console.Write($"at the {_enemyName} and dealt ");
                color.ColorAll(dmg, "dmg. ", ConsoleColor.DarkYellow);
                Console.Write("Current hp: ");
                color.ColorAll(hpEnemy[1], "/500", ConsoleColor.Green);

                mpHero[1] += mp;
            }
            else
            {
                Console.Write("You dont have enough mana! ");
                color.ColorAll(mpHero[1], "/300", ConsoleColor.Blue);
            }

        }

        public void LightingStrikeOrc(string _enemyName)
        {
            enemyName = _enemyName;

            if (mpHero[1] >= 75)
            {
                int dmg = ran.Next(25, 35);
                int dmg2 = ran.Next(25, 35);
                int dmg3 = ran.Next(25, 35);

                int mp = -75;

                hpEnemy[1] -= dmg + dmg2 + dmg3;

                Console.Write($"{name} cast {spell[1]} ");
                color.ColorAll(mp, "mp ", ConsoleColor.Blue);
                Console.Write($"at the {_enemyName} and dealt ");
                color.ColorAll(dmg, " + ", ConsoleColor.Cyan);
                color.ColorAll(dmg2, " + ", ConsoleColor.Cyan);
                color.ColorAll(dmg3, " dmg. ", ConsoleColor.Cyan);

                Console.Write("Current hp: ");
                color.ColorAll(hpEnemy[1], "/500", ConsoleColor.Green);

                mpHero[1] += mp;
            }
            else
            {
                Console.Write("You dont have enough mana! ");
                color.ColorAll(mpHero[1], "/300", ConsoleColor.Blue);
            }

        }

        public void LightingStrikeDragon(string _enemyName)
        {
            enemyName = _enemyName;

            if (mpHero[1] >= 75)
            {
                int dmg = ran.Next(37, 48);
                int dmg2 = ran.Next(37, 48);
                int dmg3 = ran.Next(37, 48);

                int mp = -75;

                hpEnemy[2] -= dmg + dmg2 + dmg3;

                Console.Write($"{name} cast {spell[1]} ");
                color.ColorAll(mp, "mp ", ConsoleColor.Blue);
                Console.Write($"at the {_enemyName} and dealt ");
                color.ColorAll(dmg, " + ", ConsoleColor.Cyan);
                color.ColorAll(dmg2, " + ", ConsoleColor.Cyan);
                color.ColorAll(dmg3, " dmg. ", ConsoleColor.Cyan);

                Console.Write("Current hp: ");
                color.ColorAll(hpEnemy[2], "/700", ConsoleColor.Green);

                mpHero[1] += mp;
            }
            else
            {
                Console.Write("You dont have enough mana! ");
                color.ColorAll(mpHero[1], "/300", ConsoleColor.Blue);
            }

        }

        public void LightingStrikeDragonLOW(string _enemyName)
        {
            enemyName = _enemyName;

            if (mpHero[1] >= 75)
            {
                int dmg = ran.Next(7, 15);
                int dmg2 = ran.Next(7, 15);
                int dmg3 = ran.Next(7, 15);

                int mp = -75;

                hpEnemy[2] -= dmg + dmg2 + dmg3;

                Console.Write($"{name} cast {spell[1]} ");
                color.ColorAll(mp, "mp ", ConsoleColor.Blue);
                Console.Write($"at the {_enemyName} and dealt ");
                color.ColorAll(dmg, " + ", ConsoleColor.Cyan);
                color.ColorAll(dmg2, " + ", ConsoleColor.Cyan);
                color.ColorAll(dmg3, " dmg. ", ConsoleColor.Cyan);
                Console.Write("\nIt looks like the dragon has resistance to this magic. ");
                Console.Write("Current hp: ");
                color.ColorAll(hpEnemy[2], "/700", ConsoleColor.Green);

                mpHero[1] += mp;
            }
            else
            {
                Console.Write("You dont have enough mana! ");
                color.ColorAll(mpHero[1], "/300", ConsoleColor.Blue);
            }

        }

        public void CastFireBallDragon(string _enemyName)
        {
            enemyName = _enemyName;

            if (mpHero[1] >= 65)
            {
                int mp = -65;
                int dmg = ran.Next(80, 125);

                hpEnemy[2] -= dmg;

                Console.Write($"{name} cast {spell[0]} ");
                color.ColorAll(mp, "mp ", ConsoleColor.Blue);
                Console.Write($"at the {_enemyName} and dealt ");
                color.ColorAll(dmg, "dmg. ", ConsoleColor.DarkYellow);
                Console.Write("Current hp: ");
                color.ColorAll(hpEnemy[2], "/700", ConsoleColor.Green);

                mpHero[1] += mp;
            }
            else
            {
                Console.Write("You dont have enough mana! ");
                color.ColorAll(mpHero[1], "/300", ConsoleColor.Blue);
            }

        }

        public void CastFireBallDragonLOW(string _enemyName)
        {
            enemyName = _enemyName;

            if (mpHero[1] >= 65)
            {
                int mp = -65;
                int dmg = ran.Next(15, 30);

                hpEnemy[2] -= dmg;

                Console.Write($"{name} cast {spell[0]} ");
                color.ColorAll(mp, "mp ", ConsoleColor.Blue);
                Console.Write($"at the {_enemyName} and dealt ");
                color.ColorAll(dmg, "dmg. ", ConsoleColor.DarkYellow);
                Console.Write("\nIt looks like the dragon has resistance to this magic. ");
                Console.Write("Current hp: ");
                color.ColorAll(hpEnemy[2], "/700", ConsoleColor.Green);

                mpHero[1] += mp;
            }
            else
            {
                Console.Write("You dont have enough mana! ");
                color.ColorAll(mpHero[1], "/300", ConsoleColor.Blue);
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
            int regenMP = 300 - mp;
            mpHero[1] += regenMP;

            Console.Write("You regen: ");

            return ColorTheme.ColorInt(regenMP, ConsoleColor.Blue);
        }

    }


}
