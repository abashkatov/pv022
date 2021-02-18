using ConsoleApp3.Entity;
using System;
using System.Collections.Generic;
using static System.Console;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace ConsoleApp3.Command
{
    class SaveToFileCommand : ICommand
    {
        private readonly List<Person> persons;

        public SaveToFileCommand(List<Person> persons)
        {
            this.persons = persons;
        }

        public string GetTitle()
        {
            return "Сохранить пользователей в файл";
        }

        public void Run()
        {
            /*
             * 1. Запросить у пользователя имя файла
             * 2. Если файла нет, то создать
             * 3. Открыть поток на запись в файл
             * 4. Сериализовать коллекцию пользователей
             * 5. Записать данные в файл
             * */

            string fileName;
            Write("Введите имя файла для записи данных (data.xml):");
            fileName = ReadLine();
            if (fileName == "")
            {
                fileName = "data.xml";
            }
            if (!fileName.EndsWith(".xml"))
            {
                fileName += ".xml";
            }
            XmlSerializer xmlSerializer = new XmlSerializer(persons.GetType());

            using (TextWriter textWriter = new StreamWriter(fileName, false))
            {
                xmlSerializer.Serialize(textWriter, persons);
            }
            WriteLine($"Данные успешно сохранены в файл {fileName}");

            ReadKey();
        }
    }
}
