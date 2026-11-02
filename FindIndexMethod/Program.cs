using System;

namespace FindIndexMethod
{
    internal class Program
    {
        static int IndexArr(int[] arr, int num)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == num)
                {
                    return i;
                }
            }
            return -1;
        }
        static void Main(string[] args)
        {

            int [] arr = { 1, 4, 6, 1, 5, 8, 9, 3 };
            for (int i = 0; i < arr.Length; i++) { Console.Write(arr[i] + "\t"); }
            Console.WriteLine();
            Console.WriteLine("Индекс какого числа вы хотите найти?");

            int num = int.Parse(Console.ReadLine());

            int index = IndexArr(arr, num);

            Console.WriteLine(index == -1 ? "Такого числа нет в массиве!" : "Твоё число в массиве имеет индекс " + index);
        }
    }
}