using System;

namespace YandexCodeRunTasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            long a, b;

            input = Console.ReadLine();

            string[] line = input.Split(' ');
            a = long.Parse(line[0]);
            b = long.Parse(line[1]);
            Console.WriteLine(a + b);
        }
    }
}
