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

        public void HitPlayer(string _playerName)
        {
            playerName = _playerName;
            
            int dmg = ran.Next(10, 20);
            hpHero -= dmg;
            Console.WriteLine("\n"+enemyName[0] + " hit " +playerName +" " + dmg + " dmg");
            Console.WriteLine(hpHero + " Current HP");
        }

    }

}
