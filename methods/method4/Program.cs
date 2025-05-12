using System;
using System.Collections.Generic;
using System.Linq;

public class MaxElementFinder
{
    public static int FindMax(List<int> list)
    {
        if (list == null || list.Count == 0)
        {
            throw new ArgumentException("Список не должен быть пустым или null.");
        }

        int max = list[0];
        for (int i = 1; i < list.Count; i++)
        {
            if (list[i] > max)
            {
                max = list[i];
            }
        }
        return max;

        //Альтернативное LINQ решение:
        //return list.Max();
    }

    public static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Введите элементы списка через пробел (например, 1 2 3 4 5):");
        string input = Console.ReadLine();
        try
        {
            string[] numberStrings = input.Split(' ');
            foreach (string numStr in numberStrings)
            {
                numbers.Add(int.Parse(numStr));
            }

            int maxElement = FindMax(numbers);
            Console.WriteLine($"Максимальный элемент в списке: {maxElement}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Некорректный ввод. Пожалуйста, введите целые числа через пробел.");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}

