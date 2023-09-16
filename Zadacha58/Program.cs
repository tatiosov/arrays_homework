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
            Console.WriteLine($"Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.\n\nСразу зададим матрицу, которую можно перемножить, т.е. количество столбцов первой равно количеству строк второй");
            Console.WriteLine($"\nВведите размеры матриц и диапазон случайных значений:");

            // Запрашиваем и сохраняем значения от пользователя.
            int m = InputNumbers("Введите число строк 1-й матрицы: ");
            int n = InputNumbers("Введите число столбцов 1-й матрицы (и строк 2-й): ");
            int p = InputNumbers("Введите число столбцов 2-й матрицы: ");
            int range = InputNumbers("Введите диапазон случайных чисел: от 1 до ");

            int[,] firstMartrix = new int[m, n]; // Создаем первую матрицу.
            CreateArray(firstMartrix, range); // Заполняем её случайными числами.
            Console.WriteLine($"\nПервая матрица:");
            ShowArr(firstMartrix); // Выводим первую матрицу.

            int[,] secondMatrix = new int[n, p]; // Создаем вторую матрицу.
            CreateArray(secondMatrix, range); // Заполняем её случайными числами.
            Console.WriteLine($"\nВторая матрица:");
            ShowArr(secondMatrix); // Выводим вторую матрицу.

            int[,] resultMatrix = new int[m, p]; // Создаем матрицу для результата перемножения.

            MultiplyMatrix(firstMartrix, secondMatrix, resultMatrix); // Перемножаем две матрицы.
            Console.WriteLine($"\nПроизведение первой и второй матриц:");
            ShowArr(resultMatrix); // Выводим результат на экран.

            // Ждем, пока пользователь нажмет клавишу, чтобы консоль не закрылась сразу.
            Console.ReadKey();
        }

        static int GetLine(int[,] array) // Метод для нахождения строки с наименьшей суммой элементов.
        {
            int row = 0, min = int.MaxValue; // Инициализируем переменные для номера строки и минимальной суммы.

            for (int i = 0; i < array.GetLength(0); i++) // Перебираем строки матрицы.
            {
                int sum = 0; // Инициализируем переменную для суммы элементов строки.
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

        static void MultiplyMatrix(int[,] firstMatrix, int[,] secondMatrix, int[,] resultMatrix) // Метод для перемножения двух матриц.
        {
            for (int i = 0; i < resultMatrix.GetLength(0); i++) // Перебираем строки результирующей матрицы.
            {
                for (int j = 0; j < resultMatrix.GetLength(1); j++) // Перебираем столбцы результирующей матрицы.
                {
                    int sum = 0; // Инициализируем переменную для суммы элементов.
                    for (int k = 0; k < firstMatrix.GetLength(1); k++) // Перебираем элементы в строке и столбце.
                    {
                        sum += firstMatrix[i, k] * secondMatrix[k, j]; // Вычисляем сумму произведений элементов.
                    }
                    resultMatrix[i, j] = sum; // Записываем результат в результирующую матрицу.
                }
            }
        }

        static int InputNumbers(string input) // Метод для ввода чисел от пользователя.
        {
            Console.Write(input); // Выводим приглашение для ввода.
            int output = Convert.ToInt32(Console.ReadLine()); // Считываем введенное значение и преобразуем его в int.
            return output; // Возвращаем введенное значение.
        }

        static void CreateArray(int[,] array, int range) // Метод для заполнения матрицы случайными числами.
        {
            Random random = new Random(); // Создаем генератор случайных чисел.
            for (int i = 0; i < array.GetLength(0); i++) // Перебираем строки матрицы.
            {
                for (int j = 0; j < array.GetLength(1); j++) // Перебираем столбцы матрицы.
                {
                    array[i, j] = random.Next(1, range); // Заполняем элемент случайным числом.
                }
            }
        }

        static void ShowArr(int[,] array) // Метод для вывода матрицы на экран.
        {
            for (int i = 0; i < array.GetLength(0); i++) // Перебираем строки матрицы.
            {
                for (int j = 0; j < array.GetLength(1); j++) // Перебираем элементы в строке.
                {
                    Console.Write(array[i, j] + " "); // Выводим элемент с пробелом.
                }
                Console.WriteLine(); // Переходим на новую строку после вывода строки матрицы.
            }
        }
    }
}
