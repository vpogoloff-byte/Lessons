using System;

namespace Lessons
{
    internal class EvenOddCounter
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Напишите диапазон, в котором будет подсчёт четных и нечетных целых чисел (Например: с 1 до 25):");

            int startNumber = int.Parse(Console.ReadLine());    // TODO: обработать исключения
            int endNumber = int.Parse(Console.ReadLine());
            int even = 0;
            int odd = 0;

            if (startNumber > endNumber)
            {
                Console.WriteLine("Неправильный ввод диапазона!");
                return;
            }

            while (startNumber <= endNumber)
            {
                if (startNumber % 2 == 0)
                {
                    even++;
                }
                else
                {
                    odd++;
                }

                startNumber++;
            }

            Console.WriteLine("Чётных чисел: " + even);
            Console.WriteLine("Не чётных чисел: " + odd);
        }
    }
}