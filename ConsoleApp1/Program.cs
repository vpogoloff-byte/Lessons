using System;

namespace Lessons
{
    internal class CalculatorSwitch
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите два числа для выражения");

            double number1 = double.Parse(Console.ReadLine()); // TODO: обработать исключения
            double number2 = double.Parse(Console.ReadLine());

            Console.WriteLine("\n Выберите действие с числами: \n 1 - Сложение \n 2 - Вычитание\n 3 - Умножение\n 4 - Деление");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    {
                        Console.WriteLine(number1 + " + " + number2 + " = " + (number1 + number2));

                        break;
                    }

                case 2:
                    {
                        Console.WriteLine(number1 + " - " + number2 + " = " + (number1 - number2));

                        break;
                    }

                case 3:
                    {
                        Console.WriteLine(number1 + " * " + number2 + " = " + (number1 * number2));

                        break;
                    }

                case 4:
                    {
                        if (number2 == 0)
                        {
                            Console.WriteLine("На ноль делить нельзя!");
                            break;
                        }
                        Console.WriteLine(number1 + " / " + number2 + " = " + (number1 / number2));

                        break;
                    }
                default:
                    Console.WriteLine("Такого действия нет!");
                    break;
            }

        }
    }
}
