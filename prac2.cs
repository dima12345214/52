using System;

namespace BankDeposit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите сумму вклада:");
            decimal depositAmount = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Введите количество месяцев:");
            int months = Convert.ToInt32(Console.ReadLine());

            decimal finalAmount = depositAmount;
            int currentMonth = 0; // Инициализируем счетчик месяцев

            while (currentMonth < months)
            {
                finalAmount += finalAmount * 0.07m; // Начисляем 7%
                currentMonth++; // Увеличиваем счетчик месяцев
            }

            Console.WriteLine($"Конечная сумма вклада через {months} месяцев: {finalAmount:C}"); // :C форматирует вывод как валюту
            Console.ReadKey(); // Чтобы консоль не закрывалась сразу
        }
    }
}

