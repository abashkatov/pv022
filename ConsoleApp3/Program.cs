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
using ConsoleApp3.Model;
using ConsoleApp3.Command;

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
            
            List<ICommand> commands = new List<ICommand>();
            commands.Add(new HelloWorldCommand());
            //commands.Add("2. Пункт 2");
            //commands.Add("3. Пункт 3");
            //commands.Add("4. Выход");

            Menu menu = new Menu(commands);
            menu.Run();

            //ReadKey();
        }
    }
}
