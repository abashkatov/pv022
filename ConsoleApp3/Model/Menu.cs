using ConsoleApp3.Command;
using System;
using System.Collections.Generic;
using static System.Console;

namespace ConsoleApp3.Model
{
    class Menu
    {
        List<AbstractCommand> menu;

        public Menu(List<AbstractCommand> menu)
        {
            this.menu = menu;
        }

        public void Run() {
            bool isEnd = false;
            int selectedIndex;
            Select<AbstractCommand> select = new Select<AbstractCommand>(menu);
            do
            {
                if (select.TrySelect(out selectedIndex))
                {
                    menu[selectedIndex].Run();
                }
                else {
                    isEnd = true;
                }
            } while (!isEnd);
        }
    }
}
