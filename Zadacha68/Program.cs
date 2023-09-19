using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine($"Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.");
            int m = GetUserInput("Введите m: ");
            int n = GetUserInput("Введите n: ");

            int ackermanFunction = CalculateAckerman(m, n);

            Console.Write($"Функция Аккермана = {ackermanFunction} ");

            // Ждем, пока пользователь нажмет клавишу, чтобы консоль не закрылась сразу
            Console.ReadKey();
        }

        // Рекурсивная функция для вычисления функции Аккермана.
        static int CalculateAckerman(int m, int n)
        {
            if (m == 0) return n + 1;
            else if (n == 0) return CalculateAckerman(m - 1, 1);
            else return CalculateAckerman(m - 1, CalculateAckerman(m, n - 1));
        }

        // Функция для получения целого числа от пользователя.
        static int GetUserInput(string input)
        {
            Console.Write(input);
            int output = Convert.ToInt32(Console.ReadLine());
            
            // Если введено отрицательное число, преобразуем его в положительное и выведем информацию о модификации.
            if (output < 0)
            {
                Console.WriteLine($"По заданию число не может быть отрицательным, получаем модуль заданного вами числа {output}");
                output = Math.Abs(output);
                Console.WriteLine($"Новое число: {output}");
            }
            return output;
        }
    }
}
