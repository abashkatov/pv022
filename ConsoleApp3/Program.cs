using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using static System.Console;

namespace ConsoleApp3
{
    public delegate string UpdateString(string str);

    public class Program
    {
        private static UpdateString updateString;
        static void Main(string[] args)
        {
            updateString?.Invoke("Hi");

            updateString += AddExclamationMark;
            updateString += AddQuestionMark;
            updateString += AddExclamationMark;
            updateString += AddPointMark;
            updateString += AddExclamationMark;
            updateString -= AddExclamationMark;

            WriteLine("Now call delegate");

            string result = updateString("Hi");

            WriteLine(result);

            //System.Delegate
            ReadKey();
        }
        static string AddExclamationMark(string str) {
            WriteLine(nameof(AddExclamationMark));
            return str + "!";
        }
        static string AddQuestionMark(string str) {
            WriteLine(nameof(AddQuestionMark));
            return str + "?";
        }
        static string AddPointMark(string str) {
            WriteLine(nameof(AddPointMark));
            return str + ".";
        }
    }
}
