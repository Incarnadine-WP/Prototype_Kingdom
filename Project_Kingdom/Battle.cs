using System;
using System.Collections.Generic;
using System.Linq;

namespace Prototype_Kingdom
{
    class Battle
    {
        public Player player = new Player();

        public Enemy enemy = new Enemy();



        public void Fight()
        {
            player.CastFireBall(enemy.hpHero, enemy.enemyName[0]);
            enemy.HitPlayer(player.hpEnemy, player.name);
        }
    }

}