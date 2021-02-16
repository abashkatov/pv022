using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using static System.Console;
using System.IO;
using System.Text;
using System.Xml.Serialization;
using System.Text.Json;
using System.Xml;
using System.Text.RegularExpressions;

namespace ConsoleApp3
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*
             * 1. Взаимодействие с пользователем. - Presentation Layer
             * 2. Роутинг - 
             * 3. Бизнес логика. - Domain
             * 4. Организация данных.
             * */
            bool isEnd = false;
            ConsoleKeyInfo key;
            int currentMenuPosition = 0;
            int menuLength = 4;
            List<string> menu = new List<string>();
            menu.Add("1. Пункт 1");
            menu.Add("2. Пункт 2");
            menu.Add("3. Пункт 3");
            menu.Add("4. Выход");
            do {
                Clear();
                WriteLine($"Текущий пунтк меню: {currentMenuPosition+1}");
                for (int i = 0; i < menu.Count; i++) {
                    BackgroundColor = ConsoleColor.White;
                    ForegroundColor = ConsoleColor.Black;
                    //Console.ResetColor
                    WriteLine(menu[i].ToString());
                }
                key = ReadKey();
                switch (key.Key) {
                    case ConsoleKey.UpArrow:
                        currentMenuPosition--;
                        break;
                    case ConsoleKey.DownArrow:
                        currentMenuPosition++;
                        break;
                }
                if (currentMenuPosition >= menuLength) {
                    currentMenuPosition %= menuLength;
                }
                if (currentMenuPosition < 0) {
                    currentMenuPosition += menuLength;
                }

            } while (!isEnd);



            ReadKey();
        }
    }
}
