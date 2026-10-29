using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int[,] arr = new int[3 , 4];
            int max = arr[0, 0];

            Random random = new Random();

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = random.Next(10);
                }
            }

            for (int i = 0;i < arr.GetLength(0); i++)
            {
                for(int j = 0;j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + "\t");
                    sum += arr[i, j];
                    if (max < arr[i, j])
                    {
                        max = arr[i, j];
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine("Максимальное число: " + max);

            Console.WriteLine("Сумма чисел массива: " + sum);

        }
    }
}
