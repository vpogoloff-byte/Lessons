using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str;
            double a,b,c;

            Console.WriteLine("Напишите три числа для вычисления их суммы и произведения:");

            str = Console.ReadLine();

            a = double.Parse(str);

            str = Console.ReadLine();

            b = double.Parse(str);

            str = Console.ReadLine();

            c = double.Parse(str);

            double resultMultiplication = a * b * c;
            double resultSum = a + b + c;

            Console.WriteLine("Сумма = " + resultSum);
            Console.WriteLine("Произведение = " + resultMultiplication);
        }
    }
}
