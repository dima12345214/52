using System;

public class FactorialCalculator
{
    public static long Factorial(int n)
    {
        if (n == 0)
        {
            return 1;
        }
        if (n < 0)
        {
            throw new ArgumentException("Факториал не определен для отрицательных чисел.");
        }

        long result = 1;
        for (int i = 1; i <= n; i++)
        {
            result *= i;
        }
        return result;
    }

    public static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Введите число для расчета факториала:");
            int number = int.Parse(Console.ReadLine());
            long factorial = Factorial(number);
            Console.WriteLine($"Факториал числа {number} равен {factorial}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Некорректный ввод. Пожалуйста, введите целое число.");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}

