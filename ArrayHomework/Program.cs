using System;

namespace Lessons
{
    internal class ArrayHomework
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задача про обратный вывод чисел: ");
            int size = 4;

            int[] arrNumber = new int[size];


            for (int i = 0; i < size; i++)
            {
                arrNumber[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();

            for (int i = arrNumber.Length - 1 ;i >= 0; i--)
            {
                Console.WriteLine(arrNumber[i]);
            }

            Console.WriteLine("Конец задания про вывод");

            Console.WriteLine();

            Console.WriteLine("Задание про сумму чётных чисел в массиве:");

            Console.WriteLine();

            int sum = 0;

            for (int i = 0;i < size;i++)
            {
                if (arrNumber[i] % 2 == 0)
                {
                    sum += arrNumber[i];
                }
            }

            Console.WriteLine("Сумма чётных чисел: " + sum);
        }
    }
}