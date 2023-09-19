using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine($"Задача 66: Задайте значения M и N. Программа найдёт сумму натуральных элементов в промежутке от M до N");
            int m = GetUserInput("Введите m: ");
            int n = GetUserInput("Введите n: ");
            int temp = m;

            // Если m больше n, поменяем их значения местами.
            if (m > n)
            {
                m = n;
                n = temp;
            }

            CalculateAndPrintSum(m, n, temp = 0);

            // Ожидание нажатия клавиши пользователем перед закрытием консоли.
            Console.ReadKey();
        }

        // Функция для расчета и вывода суммы натуральных чисел от m до n.
        static void CalculateAndPrintSum(int m, int n, int summ)
        {
            summ = summ + n;
            
            // Если n меньше или равно m, выводим сумму элементов.
            if (n <= m)
            {
                Console.Write($"Сумма элементов = {summ} ");
                return;
            }

            // Рекурсивный вызов функции для расчета суммы с уменьшением n на 1.
            CalculateAndPrintSum(m, n - 1, summ);
        }

        // Функция для получения целого числа от пользователя.
        static int GetUserInput(string input)
        {
            Console.Write(input);
            int output = Convert.ToInt32(Console.ReadLine());
            return output;
        }
    }
}
