using System;

namespace Lessons
{
    internal class CalculatorIfElse
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите два числа для выражения");

            double number1 = double.Parse(Console.ReadLine()); // TODO: обработать исключения
            double number2 = double.Parse(Console.ReadLine());

            Console.WriteLine("\n Выберите действие с числами: \n 1 - Сложение \n 2 - Вычитание\n 3 - Умножение\n 4 - Деление");
            int choice = int.Parse(Console.ReadLine());
            if(choice == 1)
            {
                Console.WriteLine(number1 + " + " + number2 + " = " + (number1 + number2));
            }

            else if (choice == 2)
            {
                Console.WriteLine(number1 + " - " + number2 + " = " + (number1 - number2));
            }

            else if (choice == 3)
            {
                Console.WriteLine(number1 + " * " + number2 + " = " + (number1 * number2));
            }

            else if(choice == 4)
            {
                if (number2 == 0)
                {
                    Console.WriteLine("На ноль делить нельзя!");
                    return;
                }
                Console.WriteLine(number1 + " / " + number2 + " = " + (number1 / number2));
            }
            else
            {
                Console.WriteLine("Такого действия нет!");
            }

        }
    }
}
