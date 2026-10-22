using System;


namespace Lessons
{
    internal class NestedLoopsTriangles
    {
        static void Main(string[] args)
        {

            int height = 5;

            for (int i = 0; i < height; i++) // Внешний цикл: отвечает за строки (сверху вниз)
            {

                for (int j = 0; j <= i; j++) // Внутренний цикл: отвечает за количество # в строке
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine();

            for (int i = 0; i < height; i++) 
            {

                for (int j = 0; j <= height - i - 1; j++) 
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine();

            for(int i = 0 ; i < height ; i++)
            {

                for(int j = 0 ; j < height-i-1; j++)
                {
                    Console.Write(" ");
                }

                for(int k = 0 ; k < i+1; k++)
                {
                    Console.Write("#");
                }

                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine();

            for (int i = 0; i < height; i++)
            {

                for (int j = 0; j < i; j++)
                {
                    Console.Write(" ");
                }

                for (int k = 0; k < height - i; k++)
                {
                    Console.Write("#");
                }

                Console.WriteLine();
            }
        }
    }
}
