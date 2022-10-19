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

        string fireBall = "Fire Ball ";
        string enemyName;
        int [] mpHero = { 200, 300, 400 };


        Random ran = new Random();

        public void CastFireBallSK(string _enemyName)
        {
            enemyName = _enemyName;

            if (mpHero[0] >= 66)
            {
                int mp = -65;
                int dmg = ran.Next(50, 80);

                hpEnemy[0] -= dmg;

                Console.Write($"{name} cast { fireBall} ");
                ColorTheme.ColorText(mp, ConsoleColor.Blue);
                ColorTheme.ColorString(" /300mp)", ConsoleColor.Blue);
                Console.Write ($"at the {_enemyName} and dealt ");
                ColorTheme.ColorText(dmg, ConsoleColor.DarkYellow);
                Console.Write(" dmg. ");

                color.ColorAll(dmg, " Alo ", ConsoleColor.Red);

                Console.Write("Current hp: ");
                ColorTheme.ColorText(hpEnemy[0], ConsoleColor.Green);

                color.ColorAll(hpEnemy[0], " hp ", ConsoleColor.Red);

                mpHero[0] += mp;
            }
            else
            {
                Console.WriteLine("You dont have enough mana! " + mpHero[1]);
                ColorTheme.ColorText(mpHero[0], ConsoleColor.Blue);
            }

        }
        public void LightingStrikeOrc(string _enemyName)
        {
            enemyName = _enemyName;

            if (mpHero[1] >= 76)
            {
                int dmg = ran.Next(25, 35);
                hpEnemy[1] -= dmg;
                Console.Write(name + " cast " + fireBall +" (" +mpHero[1]+ ") " + " at the " + _enemyName + " and dealt ");
                ColorTheme.ColorText(dmg, ConsoleColor.Red);
                ColorTheme.ColorText(mpHero[1], ConsoleColor.Blue);
                Console.Write(" dmg. ");

                Console.Write("Current hp: ");
                ColorTheme.ColorText(hpEnemy[1], ConsoleColor.Green);

                mpHero[1] -= 75;
            }
            else Console.Write("You dont have enough mana! ");
            
        }

    }


}
