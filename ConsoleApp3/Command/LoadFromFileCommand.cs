using ConsoleApp3.Entity;
using System;
using System.Collections.Generic;
using static System.Console;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace ConsoleApp3.Command
{
    class LoadFromFileCommand : AbstractCommand
    {
        private readonly List<Person> persons;

        public LoadFromFileCommand(List<Person> persons)
        {
            this.persons = persons;
        }

        public override string GetTitle()
        {
            return "Загрузить пользователей из файла";
        }

        public override void Run()
        {
            /*
             * Запросить имя файла для загрузки
             * Проверить, есть ли такой файл. Если нет, то просим повторить ввод
             * Открыть поток на чтение
             * Десериализация данных
             * Сохраняем 
             * 
             * */
            string fileName;
            bool fileExists;

            do
            {
                Write("Введите имя файла для загрузки данных (data.xml):");
                fileName = ReadLine();
                if (fileName == "")
                {
                    fileName = "data.xml";
                }
                if (!fileName.EndsWith(".xml"))
                {
                    fileName += ".xml";
                }
                fileExists = File.Exists(fileName);
                if (!fileExists)
                {
                    Write($"Файл {fileName} не существует.");
                }
            } while (!fileExists);
            XmlSerializer xmlSerializer = new XmlSerializer(persons.GetType());
            using (TextReader stream = new StreamReader(fileName))
            {
                List<Person> tmp = xmlSerializer.Deserialize(stream) as List<Person>;
                persons.Clear();
                persons.AddRange(tmp);
            }

            ReadKey();
        }
    }
}
