using System;

namespace PrintStringMethod
{
    internal class Program
    {
        static void PrintMessage()
        {
            Console.WriteLine("Вы вызвали функцию PrintMessage");
        }
        

        static void Main(string[] args)
        {
            Console.WriteLine("Хотите вызвать функцию? \n 1. Да!\t 2. Нет!");
            Console.WriteLine();
            int choice = int.Parse(Console.ReadLine());

            if (choice == 1) { PrintMessage(); }
            else { Console.WriteLine("Вы не ввели"); }
        }
    }
}
