using System;

public class PersonInfo
{
    public string FullName { get; set; }
    public int Age { get; set; }
    public double Height { get; set; } // Рост может быть дробным
    public double Weight { get; set; } // Вес может быть дробным

    public PersonInfo(string fullName, int age, double height, double weight)
    {
        FullName = fullName;
        Age = age;
        Height = height;
        Weight = weight;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Введите ФИО:");
        string fullName = Console.ReadLine();

        Console.WriteLine("Введите возраст:");
        int age = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите рост (в метрах):");
        double height = double.Parse(Console.ReadLine());

        Console.WriteLine("Введите вес (в килограммах):");
        double weight = double.Parse(Console.ReadLine());


        PersonInfo person = new PersonInfo(fullName, age, height, weight);

        // Способ 1:  Вывод с использованием свойств объекта
        Console.WriteLine("\nСпособ 1:");
        Console.WriteLine($"ФИО: {person.FullName}");
        Console.WriteLine($"Возраст: {person.Age}");
        Console.WriteLine($"Рост: {person.Height} м");
        Console.WriteLine($"Вес: {person.Weight} кг");


        // Способ 2: Вывод с использованием интерполяции строк
        Console.WriteLine("\nСпособ 2:");
        Console.WriteLine($"ФИО: {person.FullName}, Возраст: {person.Age}, Рост: {person.Height} м, Вес: {person.Weight} кг");


        // Способ 3: Вывод с использованием String.Format
        Console.WriteLine("\nСпособ 3:");
        Console.WriteLine(String.Format("ФИО: {0}, Возраст: {1}, Рост: {2} м, Вес: {3} кг", person.FullName, person.Age, person.Height, person.Weight));

        Console.ReadKey(); // Задержка для того чтобы увидеть вывод в консоли.

    }
}



