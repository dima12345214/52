using System;

public class PalindromeChecker
{
    public static bool IsPalindrome(string str)
    {
        // 1. Подготовка строки: удаление пробелов и приведение к нижнему регистру
        string cleanedStr = str.Replace(" ", "").ToLower();

        // 2. Проверка: сравнение строки с её перевернутой версией
        //    Используем string.Length / 2, так как достаточно проверить половину строки
        for (int i = 0; i < cleanedStr.Length / 2; i++)
        {
            if (cleanedStr[i] != cleanedStr[cleanedStr.Length - 1 - i])
            {
                return false; // Если символы не совпадают, это не палиндром
            }
        }

        return true; // Если все символы совпали, это палиндром
    }

    public static void Main(string[] args)
    {
        // Примеры использования
        string str1 = "А роза упала на лапу Азора";
        string str2 = "hello";
        string str3 = "level";

        Console.WriteLine($"'{str1}' - палиндром? {IsPalindrome(str1)}");  // Вывод: True
        Console.WriteLine($"'{str2}' - палиндром? {IsPalindrome(str2)}");  // Вывод: False
        Console.WriteLine($"'{str3}' - палиндром? {IsPalindrome(str3)}");  // Вывод: True
    }
}

