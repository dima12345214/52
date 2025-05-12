using System;

public class Example
{
    public static void Main(string[] args)
    {
        int[][,] mas = {
            new int[,] {{1, 2}, {3, 4}},
            new int[,] {{4, 5}, {6, 7}},
            new int[,] {{7, 8}, {9, 10}},
            new int[,] {{10, 11}, {12, 13}}
        };

        Console.Write("{{"); // Открываем внешний массив

        for (int i = 0; i < mas.Length; i++)
        {
            Console.Write("{{"); // Открываем внутренний массив
            for (int j = 0; j < mas[i].GetLength(0); j++) // Перебираем строки
            {
                for (int k = 0; k < mas[i].GetLength(1); k++) // Перебираем столбцы
                {
                    Console.Write(mas[i][j, k]);
                    if (k < mas[i].GetLength(1) - 1)
                    {
                        Console.Write(", "); // Разделяем элементы запятой
                    }
                }
                if (j < mas[i].GetLength(0) - 1)
                {
                    Console.Write("}, {"); // Разделяем подмассивы
                }
            }
            Console.Write("}}"); // Закрываем внутренний массив
            if (i < mas.Length - 1)
            {
                Console.Write(", "); // Разделяем массивы запятой
            }
        }

        Console.Write("}}"); // Закрываем внешний массив
    }
}