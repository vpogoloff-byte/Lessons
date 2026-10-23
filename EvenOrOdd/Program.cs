using System;

namespace Lessons
{
    internal class EvenOrOdd
    {
        static int InputNumber(string message)
        {
            int number;
            Console.WriteLine(message);

            while (!int.TryParse(Console.ReadLine(), out number))
            {

                Console.WriteLine("Ошибка, повтори: ");
            }

            return number;
        }
        static void Main(string[] args)
        {
            
            int number = InputNumber("Введите число для проверки на чётность: ");

            //if (number % 2 == 0)
            //{
            //    Console.WriteLine("Ваше число чётное!");
            //}
            //else
            //{
            //    Console.WriteLine("Ваше число нечётное!");
            //}
            Console.WriteLine(number % 2 == 0 ? "Ваше число чётное!" : "Ваше число нечётное!");

        }
    }
}