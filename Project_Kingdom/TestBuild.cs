using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_Kingdom
{
    class TestBuild
    {

        static void Main(string[] args)
        {
            Fight fight = new Fight();
            Narrative narrative = new Narrative();

            narrative.Intro();
            fight.SkeletFight();

        }


    }
}
