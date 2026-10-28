using System;

namespace Lessons
{
    internal class ArrayMinMax
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Введите 5 чисел для поиска наименьшего и наибольшего");
            int[] arr = new int[5];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            int max = arr[0], min = arr[0];

            for (int i = 0; i < arr.Length; i++)
            {
                if (max < arr[i])
                {
                    max = arr[i];
                }

                if (min > arr[i])
                {
                    min = arr[i];
                }
            }

            Console.WriteLine();

            Console.WriteLine("Минимальное число: " + min);
            Console.WriteLine("Максимальное число: " + max);

        }
    }
}