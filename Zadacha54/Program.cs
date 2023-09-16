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
            Console.WriteLine($"Задача 54: Упорядочивание элементов массива по убыванию каждой его строки");
            Console.WriteLine($"\nВведите размер массива m x n и диапазон случайных значений:");

            // Запрашиваем и сохраняем значения от пользователя.
            int m = InputNumbers("Введите m: ");
            int n = InputNumbers("Введите n: ");
            int range = InputNumbers("Введите диапазон: от 1 до ");
            int[,] array = new int[m, n]; // Создаем двумерный массив.

            CreateArray(array, range); // Заполняем массив случайными числами.
            ShowArr(array); // Выводим массив на экран.

            Console.WriteLine($"\nОтсортированный массив: ");
            SortLines(array); // Сортируем строки массива по убыванию.
            ShowArr(array); // Выводим отсортированный массив на экран.

            // Ждем, пока пользователь нажмет клавишу, чтобы консоль не закрылась сразу.
            Console.ReadKey();
        }

        static void SortLines(int[,] array) // Метод для сортировки строк массива.
        {
            for (int i = 0; i < array.GetLength(0); i++) // Перебираем строки массива.
            {
                for (int j = 0; j < array.GetLength(1); j++) // Перебираем элементы в строке.
                {
                    for (int k = 0; k < array.GetLength(1) - 1; k++) // Проходим по элементам строки для сортировки.
                    {
                        if (array[i, k] < array[i, k + 1]) // Если текущий элемент меньше следующего.
                        {
                            int temp = array[i, k + 1]; // Меняем местами элементы.
                            array[i, k + 1] = array[i, k];
                            array[i, k] = temp;
                        }
                    }
                }
            }
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
