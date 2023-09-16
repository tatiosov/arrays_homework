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
            Console.Clear(); // Очищаем консоль.

            // Выводим информационное сообщение.
            Console.WriteLine($"Задача 56: Строка в массиве с наименьшей суммой элементов строки");
            Console.WriteLine($"\nВведите размер массива m x n и диапазон случайных значений:");

            // Запрашиваем и сохраняем значения от пользователя.
            int m = InputNumbers("Введите m: ");
            int n = InputNumbers("Введите n: ");
            int range = InputNumbers("Введите диапазон: от 1 до ");
            int[,] array = new int[m, n]; // Создаем двумерный массив.

            CreateArray(array, range); // Заполняем массив случайными числами.
            ShowArr(array); // Выводим массив на экран.

            int row = GetLine(array); // Получаем номер строки с наименьшей суммой элементов.
            Console.WriteLine($"\nНомер строки с наименьшей суммой элементов: {row}");
            
            // Ждем, пока пользователь нажмет клавишу, чтобы консоль не закрылась сразу.
            Console.ReadKey();
        }

        static int GetLine(int[,] array) // Метод для нахождения строки с наименьшей суммой элементов.
        {
            int row = 0, min = int.MaxValue; // Инициализируем переменные для хранения номера строки и минимальной суммы.

            for (int i = 0; i < array.GetLength(0); i++) // Перебираем строки массива.
            {
                int sum = 0; // Инициализируем переменную для хранения суммы элементов строки.
                for (int j = 0; j < array.GetLength(1); j++) // Перебираем элементы в строке.
                {
                    sum += array[i, j]; // Добавляем значение элемента к сумме.
                }
                if (sum < min) { // Если текущая сумма меньше минимальной.
                    min = sum; // Обновляем минимальную сумму.
                    row = i; // Запоминаем номер строки.
                }
            }
            return row; // Возвращаем номер строки с наименьшей суммой элементов.
        }

        static int InputNumbers(string input) // Метод для ввода чисел от пользователя.
        {
            Console.Write(input); // Выводим приглашение для ввода.
            int output = Convert.ToInt32(Console.ReadLine()); // Считываем введенное значение и преобразуем его в int.
            return output; // Возвращаем введенное значение.
        }

        static void CreateArray(int[,] array, int range) // Метод для заполнения массива случайными числами.
        {
            Random random = new Random(); // Создаем генератор случайных чисел.
            for (int i = 0; i < array.GetLength(0); i++) // Перебираем строки массива.
            {
                for (int j = 0; j < array.GetLength(1); j++) // Перебираем элементы в строке.
                {
                    array[i, j] = random.Next(1, range); // Заполняем элемент случайным числом.
                }
            }
        }

        static void ShowArr(int[,] array) // Метод для вывода массива на экран.
        {
            for (int i = 0; i < array.GetLength(0); i++) // Перебираем строки массива.
            {
                for (int j = 0; j < array.GetLength(1); j++) // Перебираем элементы в строке.
                {
                    Console.Write(array[i, j] + " "); // Выводим элемент с пробелом.
                }
                Console.WriteLine(); // Переходим на новую строку после вывода строки массива.
            }
        }
    }
}
