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

            for (int i = 0; i < months; i++)
            {
                finalAmount += finalAmount * 0.07m; // Начисляем 7%
            }

            Console.WriteLine($"Конечная сумма вклада через {months} месяцев: {finalAmount:C}"); // :C форматирует вывод как валюту
            Console.ReadKey(); // Чтобы консоль не закрывалась сразу
        }
    }
}

