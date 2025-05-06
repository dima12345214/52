using System;

namespace MultiplicationInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal number1, number2;

            while (true) // Бесконечный цикл
            {
                Console.WriteLine("Введите первое число (от 0 до 10):");
                if (!decimal.TryParse(Console.ReadLine(), out number1))
                {
                    Console.WriteLine("Некорректный ввод. Пожалуйста, введите число.");
                    continue; // Переходим к следующей итерации цикла
                }

                Console.WriteLine("Введите второе число (от 0 до 10):");
                if (!decimal.TryParse(Console.ReadLine(), out number2))
                {
                    Console.WriteLine("Некорректный ввод. Пожалуйста, введите число.");
                    continue; // Переходим к следующей итерации цикла
                }

                if (number1 >= 0 && number1 <= 10 && number2 >= 0 && number2 <= 10)
                {
                    // Числа в допустимом диапазоне, выходим из цикла
                    break;
                }
                else
                {
                    Console.WriteLine("Введенные числа недопустимы. Пожалуйста, введите числа от 0 до 10.");
                }
            }

            // Вычисление и вывод результата умножения
            decimal result = number1 * number2;
            Console.WriteLine($"Результат умножения {number1} на {number2} равен {result}");
            Console.ReadKey();
        }
    }
}

