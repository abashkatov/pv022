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
using ConsoleApp3.Entity;

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
             * 
             * Задача:
             * 1. Добавить команду вывода всех персон из справочника
             * - добавить класс реализующий интерфейс ICommand
             * - добавить конструктор, принять через него коллекцию персон и сохранить в приватное поле
             * - реализовать метод GetTitle -> возвращает "Полный список"
             * - реализовать метод Run:
             *  - обойти коллекцию персон
             *  - выводим каждую персону
             *  - добавить ожидание ввыод пользователя - ReadKey()
             *  
             * 2. Добавление в справочник новых персон
             * - добавить класс реализующий интерфейс ICommand
             * - добавить конструктор, принять через него коллекцию персон и сохранить в приватное поле
             * - реализовать метод GetTitle -> возвращает "Добавить персону"
             * - реализовать метод Run:
             *  - Запросить у пользователя ввод имени и получить
             *  - Запросить у пользователя ввод возраста и получить
             *  - Создать новую персону, передав в конструктор введённые имя и возраст
             *  - Добавить новую персону в коллекцию
             * */

            List<Person> persons = new List<Person>();
            persons.Add(new Person("Name 1", 20));

            List<ICommand> commands = new List<ICommand>();
            commands.Add(new HelloWorldCommand());

            Menu menu = new Menu(commands);
            menu.Run();

            //ReadKey();
        }
    }
}
