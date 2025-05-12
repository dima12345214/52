using System;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2, result = 0;
            string operation;

            Console.WriteLine("Простой калькулятор на C#");

            // Ввод данных
            Console.Write("Введите первое число: ");
            while (!double.TryParse(Console.ReadLine(), out num1))
            {
                Console.WriteLine("Ошибка! Введите число (например, 10, 3.14):");
                Console.Write("Введите первое число: ");
            }

            Console.Write("Введите второе число: ");
            while (!double.TryParse(Console.ReadLine(), out num2))
            {
                Console.WriteLine("Ошибка! Введите число (например, 10, 3.14):");
                Console.Write("Введите второе число: ");
            }

            Console.WriteLine("Выберите операцию:");
            Console.WriteLine("+ : Сложение");
            Console.WriteLine("- : Вычитание");
            Console.WriteLine("* : Умножение");
            Console.WriteLine("/ : Деление");
            Console.WriteLine("% : Остаток от деления");
            Console.Write("Введите символ операции: ");
            operation = Console.ReadLine();

            // Выполнение операции
            switch (operation)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    if (num2 == 0)
                    {
                        Console.WriteLine("Ошибка! Деление на ноль.");
                        return; // Выход из программы
                    }
                    result = num1 / num2;
                    break;
                case "%":
                    if (num2 == 0)
                    {
                        Console.WriteLine("Ошибка! Деление на ноль.");
                        return; // Выход из программы
                    }
                    result = num1 % num2;
                    break;
                default:
                    Console.WriteLine("Ошибка! Неверная операция.");
                    return; // Выход из программы
            }


            // Вывод результата
            Console.WriteLine("Результат: " + result);
        }
    }
}
