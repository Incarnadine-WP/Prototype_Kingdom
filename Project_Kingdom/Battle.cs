using System;
using System.Collections.Generic;
using System.Linq;

namespace Prototype_Kingdom
{
    class Battle
    {
        public Player player = new Player();

        public Enemy enemy = new Enemy();

        public void FightSkeletonFB()
        {
            player.CastFireBallSK(enemy.enemyName[0]);
            enemy.HitPlayer(player.name);
        }

        public void FightOrcFB()
        {
            player.CastFireBallSK(enemy.enemyName[1]);
            enemy.HitPlayer(player.name);
        }

    }

}