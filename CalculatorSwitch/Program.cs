using System;

namespace Lessons
{
    internal class CalculatorSwitch
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите два числа для выражения");

            double number1 = double.Parse(Console.ReadLine());
            double number2 = double.Parse(Console.ReadLine());

            Console.WriteLine("\n Выберите действие с числами: \n 1 - Сложение \n 2 - Вычитание\n 3 - Умножение\n 4 - Деление");
            int choise = int.Parse(Console.ReadLine());

            switch (choise)
            {
                case 1:
                    {
                        Console.WriteLine(number1 + " + " + number2 + " = " + (number1+number2));

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
                        Console.WriteLine(number1 + " / " + number2 + " = " + (number1 / number2));

                        break;
                    }
            }

        }
    }
}
