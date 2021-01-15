using System;
using System.Text;
using static System.Console;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            string FIO = ReadLine();
            FIO = "Ivanov Ivan Ivanovich aaa aa";
            /*
             * 1 Ввод ФИО (одной строкой)
             * 2 Если пользователь ввёл неверные данные, то попросить повторить ввод
             *      Верные данные:
             *          - три слова
             *          - каждое слово более трёх символов
             *  3 Вывести текстовую строку вида: "Фамилия: <Фамилия>, Имя: <Имя>, Отчество: <Отчество>"
             * 
             * */

            int n = 100000;
            ////// StringBuilder
            StringBuilder stringBuilder = new StringBuilder();
            var from = DateTime.Now;
            for (int i = 0; i < n; i++)
            {
                stringBuilder.Append(i);
            }
            string total = stringBuilder.ToString();
            var span = from.Subtract(DateTime.Now);

            WriteLine(span.TotalMilliseconds);

            ////// string
            string str = "";
            from = DateTime.Now;
            for (int i = 0; i < n; i++)
            {
                str += i;
            }
            total = str;
            span = from.Subtract(DateTime.Now);

            WriteLine(span.TotalMilliseconds);


            ReadKey();
        }
    }
}
