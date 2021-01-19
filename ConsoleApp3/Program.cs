﻿using System;
using System.Text;
using static System.Console;

namespace ConsoleApp3
{
    enum РабочиеДни { Понедельник, Вторник, Среда, Четверг, Пятница}
    class Program
    {
        static void Main(string[] args)
        {
            /**
             * Задание 1
             * 
             * Сделать перечисления с рабочими и выходными днями недели.
             * Написать программу, которая прнимиает день недели через аргументы командной строки и сообщает, 
             * существует ли такой день недели и, если существует, то рабочий или выходной.
             * Дополнительная сложность:
             * 1. Результат работы программы не должен зависеть от исходного регистра символов в аргументах 
             * командной строки.
             * 2. Если пользователь не указал день недели в аргументах командной строки, то запрашивать
             * у пользователя ввод дня недели.
             * 
             * Задание 2
             * 
             * Написать программу которая принимает от пользователя размеры массива N и M и создает массив 
             * соответствующего размера заполняя его случайными величинами от -100 до +100. 
             * 
             * Надо полученным массивом выполните следующие операции:
             * 1. Сжать массив, удалив из него все 0 и, заполнить освободившиеся справа элементы значениями –1
             * 2. Преобразовать массив так, чтобы сначала шли все отрицательные элементы, а потом положительные
             * (0 считать положительным)
             * 3. Написать программу, которая предлагает пользователю ввести число и считает, сколько раз это число
             * встречается в массиве.
             * 4. В двумерном массиве порядка M на N поменяйте местами заданные столбцы.
             * 
             * */

            ReadKey();
        }
    }
}
