using System;
using System.Collections.Generic;
using System.Linq;

namespace Prototype_Kingdom
{
    class Player
    {

        Enemy skeleton = new Enemy("Skeleton");

        string fireBall;
        string enemyName;
        public int hpHero;
        int mpHero;

        public string name;

        Random ran = new Random();

        public Player(string _fireBall)
        {
            fireBall = _fireBall;
            hpHero = 100;
            mpHero = 200;
        }

        public void CastFireBall(int target, string _enemyName)
        {
            enemyName = _enemyName;

            int dmg = ran.Next(50, 99);
            target -= dmg;
            Console.WriteLine(name + " cast" + fireBall + " and hit " + skeleton.enemyName + " deal " + dmg + " dmg");
            Console.WriteLine("Current hp " + skeleton.hpEnemy );
        }

    }

    class Enemy
    {
        
        public string enemyName;
        public int hpEnemy;
        string playerName;

        Random ran = new Random();

        public Enemy(string _name)
        {
            enemyName = _name;
            hpEnemy = 100;
        }

        public void HitPlayer(int target, string _playerName)
        {
            playerName = _playerName;

            int dmg = ran.Next(10, 20);
            target -= dmg;
            Console.WriteLine(enemyName + " hit " +playerName +" " + dmg + " dmg");
            Console.WriteLine(target + " Current HP");
        }


    }

    class GameStart
    {
        static void Main (string[] args)
        {
            int option;

            Player player = new Player("Fire Ball");
            Enemy skeleton = new Enemy("Skeleton");

            Console.WriteLine("Hello hero, what is you name?");
            player.name = Console.ReadLine();


            while(player.hpHero > 0 || skeleton.hpEnemy > 0)
            {
                Console.Write("Press 1 to atack ");

                option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    
                    case 1:
                        player.CastFireBall(skeleton.hpEnemy, skeleton.enemyName);
                        skeleton.HitPlayer(player.hpHero, player.name);
                        break;
                }
            }

            if (player.hpHero > 0)
            {
                Console.WriteLine("You win");
            }
            else Console.WriteLine("You dead");
            

            Console.ReadKey();


        }
    }
}