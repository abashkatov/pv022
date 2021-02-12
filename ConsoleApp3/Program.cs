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
            string 
                url = "cian.ru/spb/nevskiy/11/dfhhfghejfhsdhfshdkjfhsdfgsdfgsdfg",
                email1 = "df-g@dfh.ru",
                email2 = "df.g@dfh"
            ;

            string
                emailPattern = @"^\w+@\w+\.\w+$",
                urlPattern = @"^cian\.ru\/(\w+)\/(\w+)\/(\w+)\/"
            ;

            Regex 
                regexMail = new Regex(emailPattern),
                regexUrl = new Regex(urlPattern)
                ;
            WriteLine(email1 + " is match " + regexMail.IsMatch(email1));
            WriteLine(email2 + " is match " + regexMail.IsMatch(email2));

            var matches = regexUrl.Matches(url);
            foreach (Match match in matches) {
                foreach (Group group in match.Groups)
                {
                    WriteLine(group.Value);
                }
            }

            ReadKey();
        }
    }
}
