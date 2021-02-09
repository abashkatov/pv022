using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using static System.Console;

namespace ConsoleApp3
{
    /**
     * 1. Добавить делегат
     * 2. Добавить событие
     * 3. Добавить метод для подписки или использовать существующий
     * 4. Подписаться методом (из п.3) на событие (из п. 2)
     * 5. При изменении имени вызывать событие
     * */
    public class Program
    {
        class Person {
            private string _name;
            public string Name {
                get => _name;
                set {
                    _name = value;
                }
            }

        }
        class Form
        {
            public void Draw(Person person)
            {
                Clear();
                CursorLeft = 0;
                CursorTop = 0;
                WriteLine("Имя: " + person.Name);
            }
            public string AskNewName()
            {
                CursorLeft = 0;
                CursorTop = 3;
                Write("Введите новое имя: ");
                return ReadLine();
            }
        }
            static void Main(string[] args)
        {
            Person person = new Person();
            Form form = new Form();
            string name;
            form.Draw(person);
            do
            {
                name = form.AskNewName();
                person.Name = name;
                //form.Draw(person);
            } while (true);
            ReadKey();
        }
    }
}
