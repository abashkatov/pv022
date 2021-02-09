using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using static System.Console;

namespace ConsoleApp3
{

    /**
     * v 1. Добавить делегат
     * v 2. Добавить событие
     * v 3. Добавить метод для подписки или использовать существующий
     * v 4. Подписаться методом (из п.3) на событие (из п. 2)
     * 5. При изменении имени вызывать событие
     * */
    public class Program
    {
        delegate void ActionWithPerson(Person person);
        class Person {
            public event ActionWithPerson NameChanged;
            private string _name;
            public string Name {
                get => _name;
                set {
                    _name = value;
                    NameChanged?.Invoke(this);
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

            person.NameChanged += form.Draw;

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
