using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prototype_Kingdom
{

   class GameStart
    {

        static void Main(string[] args)
        {
            Narrative narrative = new Narrative();

            narrative.Intro();
            narrative.player.name = Console.ReadLine();
            narrative.Intro2();
            narrative.SkeletFight();
            narrative.EndSkeletFight();
            narrative.round = 1;
            narrative.OrcFight();
            narrative.EndOrcFight();
            narrative.round = 1;
            narrative.Intro3();
            narrative.DragonFightOne();
            narrative.EndDragonFight();

        }
    }
  
}
