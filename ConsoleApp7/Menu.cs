using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Menu
    {
        enum Keys
        {
            Backspace = -1,
            D = -2,
        }
        public static int Show(int max)
        {
            ConsoleKeyInfo key;
            int pos = 0;
            do
            {

                Console.SetCursorPosition(0, pos);
                Console.WriteLine("->");
                key = Console.ReadKey();
                Console.SetCursorPosition(0, pos);
                Console.WriteLine("  ");

                if (key.Key == ConsoleKey.DownArrow && pos < max - 1)
                {
                    pos++;
                }
                if (key.Key == ConsoleKey.UpArrow && pos > 0)
                {
                    pos--;
                }
            } while (key.Key != ConsoleKey.Enter && key.Key != ConsoleKey.Escape && key.Key != ConsoleKey.D && key.Key != ConsoleKey.Backspace);
            if (key.Key == ConsoleKey.Enter)
            {
                return pos;
            }
            else if (key.Key == ConsoleKey.D)
            {
                return (int)Keys.D;
            }
            else if (key.Key == ConsoleKey.Backspace)
            {
                return (int)Keys.Backspace;
            }
            else
            {
                return -1;
            }
        }
    }
}
