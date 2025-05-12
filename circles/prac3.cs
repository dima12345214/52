    using System;

    namespace MultiplicationTable
    {
        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Таблица умножения:");
                Console.WriteLine("-------------------");

                for (int i = 1; i <= 10; i++)
                {
                    for (int j = 1; j <= 10; j++)
                    {
                        Console.Write($"{i * j,4}"); // Выравнивание по 4 символа
                    }
                    Console.WriteLine(); // Переход на новую строку после каждой строки таблицы
                }

                Console.ReadKey(); // Чтобы консоль не закрывалась сразу
            }
        }
    }
    

