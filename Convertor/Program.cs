using System;

namespace Lessons
{
    internal class Convertor
    {
        static double InputNumber (string message)
        {
            double number;
            Console.WriteLine(message);

            while (!double.TryParse(Console.ReadLine(), out number))
            {

                Console.WriteLine("Ошибка повтори ввод: ");

            }

            return number;
        }
        static void Main(string[] args)
        {

            double dollarRate = 83.95;
            double euroRate = 93.92;

            double rub = InputNumber ("Введите количество рублей для конвертации: ");

            double dollar = Math.Round(rub / dollarRate, 2);
            double euro = Math.Round(rub / euroRate,2);

            Console.WriteLine("Ваша сумма в долларах: " + dollar);
            Console.WriteLine("Ваша сумма в евро: " + euro);

        }
    }
}