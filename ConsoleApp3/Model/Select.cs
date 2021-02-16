using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp3.Model
{
    class Select<T>
    {
        List<T> items;

        public Select(List<T> items)
        {
            this.items = items;
        }
        public bool TrySelect(out int index) {
            ConsoleKeyInfo key;
            index = 0;
            do
            {
                Clear();
                for (int i = 0; i < items.Count; i++)
                {
                    if (i == index)
                    {
                        BackgroundColor = ConsoleColor.White;
                        ForegroundColor = ConsoleColor.Black;
                    }
                    WriteLine(items[i].ToString());
                    if (i == index)
                    {
                        ResetColor();
                    }
                }
                key = ReadKey();
                switch (key.Key)
                {
                    case ConsoleKey.UpArrow:
                        index--;
                        break;
                    case ConsoleKey.DownArrow:
                        index++;
                        break;
                    case ConsoleKey.Escape:
                        return false;
                    case ConsoleKey.Enter:
                        return true;
                }
                if (index >= items.Count)
                {
                    index %= items.Count;
                }
                if (index < 0)
                {
                    index += items.Count;
                }

            } while (true);
        }
    }
}
