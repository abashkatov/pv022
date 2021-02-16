using ConsoleApp3.Command;
using System;
using System.Collections.Generic;
using static System.Console;

namespace ConsoleApp3.Model
{
    class Menu
    {
        List<ICommand> menu;

        public Menu(List<ICommand> menu)
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
                    WriteLine(menu[i].GetTitle());
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
                    case ConsoleKey.Enter:
                        menu[currentMenuPosition].Run();
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
