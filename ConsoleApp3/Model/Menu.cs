using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp3.Model
{
    class Menu
    {
        List<string> menu;

        public Menu(List<string> menu)
        {
            this.menu = menu;
        }

        public void Run() {
            bool isEnd = false;
            ConsoleKeyInfo key;
            int currentMenuPosition = 0;
            
            do
            {
                Clear();
                for (int i = 0; i < menu.Count; i++)
                {
                    if (i == currentMenuPosition)
                    {
                        BackgroundColor = ConsoleColor.White;
                        ForegroundColor = ConsoleColor.Black;
                    }
                    WriteLine(menu[i].ToString());
                    if (i == currentMenuPosition)
                    {
                        ResetColor();
                    }
                }
                key = ReadKey();
                switch (key.Key)
                {
                    case ConsoleKey.UpArrow:
                        currentMenuPosition--;
                        break;
                    case ConsoleKey.DownArrow:
                        currentMenuPosition++;
                        break;
                    case ConsoleKey.Escape:
                        isEnd = true;
                        break;
                }
                if (currentMenuPosition >= menu.Count)
                {
                    currentMenuPosition %= menu.Count;
                }
                if (currentMenuPosition < 0)
                {
                    currentMenuPosition += menu.Count;
                }

            } while (!isEnd);

        }
    }
}
