using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prototype_Kingdom
{
    class Enemy
    {

        public string enemyName;
        public int hpHero = 200;
        string playerName;

        Random ran = new Random();

       /*  public Enemy(int _hp)
        {
            hpEnemy = _hp;
        } */

        public void HitPlayer(int target, string _playerName)
        {
            playerName = _playerName;

            int dmg = ran.Next(10, 20);
            hpHero -= dmg;
            Console.WriteLine(enemyName + " hit " +playerName +" " + dmg + " dmg");
            Console.WriteLine(hpHero + " Current HP");
        }


    }

}
