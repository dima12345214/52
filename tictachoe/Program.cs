using System;

namespace TicTacToe
{
    class Program
    {
        static char[] board = { '1', '2', '3', '4', '5', '6', '7', '8', '9' }; // Игровое поле
        static int player = 1; // Номер текущего игрока (1 или 2)
        static int choice; // Выбор ячейки для хода
        static int flag = 0; // Флаг для проверки выигрыша/ничьей

        static void Main(string[] args)
        {
            do
            {
                Console.Clear(); // Очищаем консоль для нового отображения поля
                Console.WriteLine("Player 1: X and Player 2: O");
                Console.WriteLine("\n");
                if (player % 2 == 0)
                {
                    Console.WriteLine("Player 2 Turn");
                }
                else
                {
                    Console.WriteLine("Player 1 Turn");
                }
                Console.WriteLine("\n");
                Board(); // Выводим игровое поле на экран

                choice = 0;
                bool validInput = false;

                while (!validInput)
                {
                    Console.Write("Enter number: ");
                    if (int.TryParse(Console.ReadLine(), out choice))
                    {
                        if (choice >= 1 && choice <= 9)
                        {
                            if (board[choice - 1] != 'X' && board[choice - 1] != 'O')
                            {
                                validInput = true;
                            }
                            else
                            {
                                Console.WriteLine("This cell is already occupied. Try again.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Please enter a number between 1 and 9.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a number.");
                    }
                }


                if (player % 2 == 0)
                {
                    board[choice - 1] = 'O';
                }
                else
                {
                    board[choice - 1] = 'X';
                }

                player++; // Переключаемся на следующего игрока
                flag = CheckWin(); // Проверяем, есть ли победитель или ничья
            } while (flag != 1 && flag != -1); // Продолжаем, пока нет победителя или ничьей

            Console.Clear();
            Board();

            if (flag == 1)
            {
                Console.WriteLine("Player {0} has won!", (player % 2) + 1);
            }
            else
            {
                Console.WriteLine("Draw!");
            }
            Console.ReadKey(); // Ожидаем нажатия клавиши перед завершением
        }

        // Метод для отрисовки игрового поля
        static void Board()
        {
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}   ", board[0], board[1], board[2]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}   ", board[3], board[4], board[5]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}   ", board[6], board[7], board[8]);
            Console.WriteLine("     |     |      ");
        }

        // Метод для проверки условия победы
        static int CheckWin()
        {
            // Проверка горизонталей
            if (board[0] == board[1] && board[1] == board[2])
            {
                return 1;
            }
            else if (board[3] == board[4] && board[4] == board[5])
            {
                return 1;
            }
            else if (board[6] == board[7] && board[7] == board[8])
            {
                return 1;
            }
            // Проверка вертикалей
            else if (board[0] == board[3] && board[3] == board[6])
            {
                return 1;
            }
            else if (board[1] == board[4] && board[4] == board[7])
            {
                return 1;
            }
            else if (board[2] == board[5] && board[5] == board[8])
            {
                return 1;
            }
            // Проверка диагоналей
            else if (board[0] == board[4] && board[4] == board[8])
            {
                return 1;
            }
            else if (board[2] == board[4] && board[4] == board[6])
            {
                return 1;
            }
            // Проверка на ничью
            else if (board[0] != '1' && board[1] != '2' && board[2] != '3' && board[3] != '4' && board[4] != '5' && board[5] != '6' && board[6] != '7' && board[7] != '8' && board[8] != '9')
            {
                return -1;
            }
            else
            {
                return 0; // Игра продолжается
            }
        }
    }
}
