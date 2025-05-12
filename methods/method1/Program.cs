    using System;
    using System.Collections.Generic;
    using System.Linq;

    namespace SumList
    {
        class Program
        {
            static void Main(string[] args)
            {
                // Пример использования
                List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
                int sum = SumNumbers(numbers);
                Console.WriteLine($"Сумма чисел в списке: {sum}");
            }

            // Метод для вычисления суммы чисел в списке
            public static int SumNumbers(List<int> numbers)
            {
                if (numbers == null || numbers.Count == 0)
                {
                    return 0; // Возвращаем 0 для пустого или null списка
                }
                return numbers.Sum(); //Используем LINQ для суммы
            }
        }
    }
