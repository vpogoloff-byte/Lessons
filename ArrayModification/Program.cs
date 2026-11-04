using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayModification
{
    internal class Program
    {

        static int[] ResizeArray(int[] arr)
        {
            Console.WriteLine("На сколько элементов изменить массив (+n или -n)");
            int element = int.Parse(Console.ReadLine());
            int newSize = arr.Length + element;

            if (newSize < 0) 
            { 
                Console.WriteLine("Вы ввели отрицательный массив!");
                return arr;
            }

            int[] arr1 = new int [newSize];

            for ( int i = 0 ; i < arr.Length ; i++)
            {
                arr1 [i] = arr [i];
            }
            return arr1;
        }

        static int[] AddToStart(int [] arr)
        {
            Console.WriteLine("Какое число добавить в начало массива?");
            int index = int.Parse (Console.ReadLine());
            int[] arr1 = new int [arr.Length+1];

            arr1[0] = index;
            for ( int i = 0 ; i < arr.Length ;i++)
            {
                arr1[i + 1] = arr [i];
            }
            return arr1;
        }

        static void AddToEnd(ref int[] arr)
        {

        }

        static void AddAtIndex(ref int[] arr)
        {

        }

        static void RemoveFromStart(ref int[] arr)
        {

        }

        static void RemoveFromEnd(ref int[] arr)
        {

        }

        static void RemoveAtIndex(ref int[] arr)
        {

        }

        static void Main(string[] args)
        {

            int[] arr = { 4, 3, 6, 9 };
            int[] arr2 = new int [arr.Length];
            Console.WriteLine("Какой метод вы хотите вызвать? \n\n" +
                "1. Для изменения размера\n" +
                "2. Для добавления элементов в начало или конец по индексу\n" +
                "3. Для удаления первого или последнего элемента по индексу");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    {
                        arr2 = ResizeArray(arr);
                        break;
                    }
                case 2:
                    {
                        arr2 = AddToStart(arr);

                        break;
                    }
                case 3:
                    {

                        break;
                    }
                default:
                    {
                        Console.WriteLine("Неизвестная операция!");
                        break;
                    }
            }

            for (int i = 0; i < arr2.Length; i++)
            {
                Console.Write(arr2[i] + "  ");
            }
        }
    }
}
