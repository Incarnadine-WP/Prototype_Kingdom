using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_Kingdom
{
    class ColorTheme
    {
       public static int ColorText(int _value, ConsoleColor color)
        {
            var oldColor = Console.ForegroundColor;

            Console.ForegroundColor = color;

            Console.Write(_value);

            Console.ForegroundColor = oldColor;

            return _value;
        }

        public static string ColorString(string _text, ConsoleColor color)
        {
            var oldColor = Console.ForegroundColor;

            Console.ForegroundColor = color;

            Console.Write(_text);

            Console.ForegroundColor = oldColor;

            return _text; 
        }

        public void ColorAll(int v, string t, ConsoleColor color)
        {
            var oldColor = Console.ForegroundColor;

            Console.ForegroundColor = color;

            Console.Write(v);
            Console.Write(t);

            Console.ForegroundColor = oldColor;

        }
    }
}
