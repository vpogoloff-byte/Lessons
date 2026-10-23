using System;

namespace Lessons
{
    internal class ArrayBasics
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Сколько чисел вы хотите ввести в массив?");
            int size = int.Parse(Console.ReadLine());

            double[] arrNumber = new double[size];


            Console.WriteLine("Вводите числа:");

            for (int i = 0; i < size; i++)
            {
                arrNumber[i] = double.Parse(Console.ReadLine());
            }

            Console.WriteLine();

            double sum = 0;

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("Число номер " + i + ": " + arrNumber[i]);
                sum = sum + arrNumber[i];

            }

            Console.WriteLine("Сумма всех чисел массива: " + sum);
            Console.WriteLine("Среднее арифметическое: " + (sum / size));

        }
    }
}