using System;

namespace JaggedArrayPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            int sum = 0;
            int[][] jagged = new int[3][];
            jagged[0] = new int[2];
            jagged[1] = new int[4];
            jagged[2] = new int[3];

            for (int i = 0; i < jagged.Length; i++)
            {
                for (int j = 0; j < jagged[i].Length; j++)
                {
                        jagged[i][j] = rnd.Next(10);
                }
            }

            for (int i = 0; i < jagged.Length; i++)
            {
                for (int j = 0; j < jagged[i].Length; j++)
                {
                    Console.Write(jagged[i][j] + "\t");
                    sum += jagged[i][j];
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            Console.WriteLine("Сумма всех элементов: " + sum);
        }
    }
}
