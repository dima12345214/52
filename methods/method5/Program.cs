using System;
using System.Collections.Generic;
using System.Linq;

public class DuplicateRemover
{
    public static List<T> RemoveDuplicates<T>(List<T> list)
    {
        // Использование HashSet для отслеживания уникальных элементов.
        // HashSet обеспечивает быструю проверку наличия элемента.
        HashSet<T> uniqueElements = new HashSet<T>();
        List<T> result = new List<T>();

        foreach (T element in list)
        {
            if (uniqueElements.Add(element)) // Add возвращает true, если элемент добавлен (т.е. уникален)
            {
                result.Add(element);
            }
        }
        return result;


        // Альтернативный вариант с использованием LINQ (более короткий)
        // return list.Distinct().ToList();
    }

    public static void Main(string[] args)
    {
        List<int> numbersWithDuplicates = new List<int> { 1, 2, 2, 3, 4, 4, 5, 5, 5 };
        List<int> uniqueNumbers = RemoveDuplicates(numbersWithDuplicates);

        Console.WriteLine("Список с дубликатами: " + string.Join(", ", numbersWithDuplicates)); // Вывод исходного списка
        Console.WriteLine("Список без дубликатов: " + string.Join(", ", uniqueNumbers)); // Вывод списка без дубликатов
    }
}
