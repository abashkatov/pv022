using ConsoleApp3.Entity;
using System;
using System.Collections.Generic;
using static System.Console;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Command
{
    class LoadFromFileCommand : ICommand
    {
        private readonly List<Person> persons;

        public LoadFromFileCommand(List<Person> persons)
        {
            this.persons = persons;
        }

        public string GetTitle()
        {
            return "Загрузить пользователей из файла";
        }

        public void Run()
        {
            /*
             * Запросить имя файла для загрузки
             * Проверить, есть ли такой файл. Если нет, то просим повторить ввод
             * Открыть поток на чтение
             * Десериализация данных
             * Сохраняем 
             * 
             * */

            foreach (Person person in persons)
            {
                WriteLine(person.Name);
            }
            ReadKey();
        }
    }
}
