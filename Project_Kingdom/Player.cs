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
        public int hpEnemy = 200;

        string fireBall = "Fire Ball";
        string enemyName;
        int mpHero = 200;

        Random ran = new Random();

        public void CastFireBall(int target, string _enemyName)
        {
            enemyName = _enemyName;

            if(mpHero >= 100)
            {
                int dmg = ran.Next(50, 99);
                hpEnemy -= dmg;
                Console.Write(name + " cast " + fireBall + " and hit " + _enemyName + " deal ");
                ColorTheme.ColorText(dmg, ConsoleColor.Red);
                Console.Write(" dmg. ");

                Console.Write("Current hp: ");
                ColorTheme.ColorText(hpEnemy, ConsoleColor.Green);
                mpHero -= 100;
            }
            else Console.WriteLine("You dont have enough mana!");
        }

    }


}
