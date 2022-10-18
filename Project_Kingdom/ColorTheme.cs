using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_Kingdom
{
    class ColorTheme
    {
       public static int ColorText(int dmg, ConsoleColor color)
        {
            var oldColor = Console.ForegroundColor;

            Console.ForegroundColor = color;

            Console.Write(dmg);

            Console.ForegroundColor = oldColor;

            return dmg;
        }
    }
}
