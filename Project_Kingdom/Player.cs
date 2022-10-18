using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_Kingdom
{

    class Player
    {

        public string name;
        public int hpEnemy=100;

        string fireBall;
        string enemyName;
        int mpHero;


        Random ran = new Random();

       /* public Player(int _hp)
         {
             hpHero = _hp;
             mpHero = 200;
         }*/

        public void CastFireBall(int target, string _enemyName)
        {
            enemyName = _enemyName;

            int dmg = ran.Next(50, 99);
            hpEnemy -= dmg;
            Console.WriteLine(name + " cast" + fireBall + " and hit " + _enemyName + " deal " + dmg + " dmg");
            Console.WriteLine("Current hp " + hpEnemy);
        }

    }


}
