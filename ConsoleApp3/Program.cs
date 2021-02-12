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

namespace ConsoleApp3
{
    public class Program
    {
        static void Main(string[] args)
        {
            using (XmlTextWriter writer = new XmlTextWriter("persons.xml", Encoding.Default))
            {
                writer.Formatting = Formatting.Indented;
                writer.WriteStartDocument();
                writer.WriteStartElement("Persons");
                {
                    writer.WriteStartElement("Person");

                    writer.WriteAttributeString("Name", "Name 1");
                    writer.WriteElementString("Age", "30");

                    writer.WriteEndElement();
                }
                {
                    writer.WriteStartElement("Person");
                    writer.WriteAttributeString("Name", "Name 2");
                    writer.WriteElementString("Age", "35");

                    writer.WriteEndElement();
                }
                writer.WriteEndElement();
                writer.WriteEndDocument();
            }

            //ReadKey();
        }
    }
}
