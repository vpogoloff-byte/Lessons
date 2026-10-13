using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons
{
    internal class AverageOfTwo
    {
        static double InPutNumber(string message)
        {
            double number;
            Console.WriteLine(message);

            while (!double.TryParse(Console.ReadLine(), out number))
            {

                Console.WriteLine("Ошибка, повтори: ");
            }

            return number;
        }
        static void Main(string[] args)
        {

            Console.WriteLine("Напишите два числа для вычисления среднего арифметического:");

            double a = InPutNumber("Введи первое число:");

            double b = InPutNumber("Введи второе число:");

            double end = (a + b) / 2;

            Console.WriteLine("Среднее арифметическое = " + end);

        }
    }
}
