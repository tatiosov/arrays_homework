using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Очищаем консоль перед началом выполнения программы.
            Console.Clear();

            // Выводим описание задачи.
            Console.WriteLine($"Задача 64: Программа, которая выводит все натуральные числа в промежутке от N до 1.");

            // Запрашиваем у пользователя ввод натурального числа N.
            int n = InputNumbers("Введите n: ");

            // Начинаем вывод натуральных чисел от N до 1.
            int count = 2;
            PrintNumber(n, count);

            // Выводим число 1 в конце последовательности.
            Console.Write(1);

            // Ждем, пока пользователь нажмет клавишу, чтобы консоль не закрылась сразу.
            Console.ReadKey();
        }

        // Рекурсивная функция для вывода натуральных чисел от N до 1.
        static void PrintNumber(int n, int count)
        {
            // Если текущее число больше N, завершаем рекурсию.
            if (count > n) return;

            // Рекурсивный вызов функции для вывода следующего числа и запятой.
            PrintNumber(n, count + 1);

            // Вывод текущего числа и запятой (если оно не последнее).
            Console.Write(count);

            // Если это не последнее число, выводим запятую.
            if (count <= n) Console.Write(", ");
        }

        // Функция для ввода натуральных чисел с консоли.
        static int InputNumbers(string input)
        {
            Console.Write(input);
            int output = Convert.ToInt32(Console.ReadLine());
            return output;
        }
    }
}
