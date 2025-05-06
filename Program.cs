using System;
using System.Collections.Generic;

namespace LostCity
{
    class Game
    {
        private int courage = 5;  // Пример: Параметр для отслеживания
        private int knowledge = 5; // Еще один параметр
        private List<int> choices = new List<int>(); // Сохраняем выборы игрока

        public void Run()
        {
            Console.WriteLine("Добро пожаловать в 'Затерянный Город'!");

            for (int i = 1; i <= 20; i++)
            {
                DisplayScene(i);
                int choice = GetPlayerChoice(i);
                choices.Add(choice); // Записываем выбор
                ApplyChoice(choice, i);

                Console.WriteLine("------------------------------------");
                Console.WriteLine($"Courage: {courage}, Knowledge: {knowledge}");  // Отображение текущего состояния
                Console.WriteLine("------------------------------------");
            }

            DetermineEnding();
        }

        private void DisplayScene(int iteration)
        {
            switch (iteration)
            {
                case 1:
                    Console.WriteLine("Вы стоите у входа в затерянный город. Перед вами - густые джунгли и темный провал пещеры.");
                    break;
                case 2:
                    Console.WriteLine("Вы углубились в джунгли. Слышите странные звуки. Видите развилку - идти по тропе или продираться сквозь заросли?");
                    break;
                // ... (Остальные сцены)
                default:
                    Console.WriteLine("Вы продолжаете исследовать руины...");
                    break;
            }
        }

        private int GetPlayerChoice(int iteration)
        {
            switch (iteration)
            {
                case 1:
                    Console.WriteLine("1. Войти в пещеру.");
                    Console.WriteLine("2. Прорубаться через джунгли.");
                    break;
                case 2:
                    Console.WriteLine("1. Идти по тропе.");
                    Console.WriteLine("2. Продираться через заросли.");
                    break;
                // ... (Остальные варианты)
                default:
                    Console.WriteLine("1. Продолжить идти прямо.");
                    Console.WriteLine("2. Осмотреть окрестности.");
                    break;
            }

            int choice;
            while (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Некорректный ввод. Введите число.");
            }
            return choice;
        }

        private void ApplyChoice(int choice, int iteration)
        {
            switch (iteration)
            {
                case 1:
                    if (choice == 1)
                    {
                        courage -= 1;
                        knowledge += 1;
                        Console.WriteLine("Вы выбрали пещеру. Внутри темно и сыро.");
                    }
                    else if (choice == 2)
                    {
                        courage += 1;
                        Console.WriteLine("Вы выбрали джунгли. Тяжело пробираться, но интересно.");
                    }
                    break;
                case 2:
                    if (choice == 1)
                    {
                        knowledge += 1;
                        Console.WriteLine("Тропа приводит к старому колодцу.");
                    }
                    else if (choice == 2)
                    {
                        courage += 2;
                        Console.WriteLine("Заросли оказались полны ядовитых растений!");
                        courage -= 1; // Пример негативного последствия
                    }
                    break;
                // ... (Остальные последствия)
            }
        }

        private void DetermineEnding()
        {
            Console.WriteLine("--------------------КОНЕЦ--------------------");

            if (courage > 8 && knowledge > 8)
            {
                Console.WriteLine("Концовка 1: Вы раскрыли секрет города и стали знаменитым археологом!");
            }
            else if (courage < 3)
            {
                Console.WriteLine("Концовка 2: Вы погибли в джунглях...");
            }
            else if (knowledge < 3)
            {
                Console.WriteLine("Концовка 3: Вы заблудились и не смогли найти выход.");
            }
            else if (choices.Contains(1) && choices.Contains(2) && choices.Contains(3))
            {
                Console.WriteLine("Концовка 4: Вы столкнулись с древним проклятием, но смогли избежать его.");
            }
            // ... (Остальные концовки)
            else
            {
                Console.WriteLine("Концовка 10: Ничего особенного не произошло. Вы просто ушли из города.");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            game.Run();
            Console.ReadKey();
        }
    }
}


