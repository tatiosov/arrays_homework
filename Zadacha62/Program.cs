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
            Console.Clear(); // Очищаем консоль

            Console.WriteLine($"Задача 62: Заполнение массива 4 на 4 по спирали"); // Выводим задачу на экран

            int n = 4;
            int[,] sqareMatrix = new int[n, n]; // Создаем квадратную матрицу

            int temp = 1;
            int i = 0;
            int j = 0;

            while (temp <= sqareMatrix.GetLength(0) * sqareMatrix.GetLength(1))
            {
                sqareMatrix[i, j] = temp;
                temp++;

                // Двигаемся по спирали, изменяя индексы
                if (i <= j + 1 && i + j < sqareMatrix.GetLength(1) - 1)
                    j++;
                else if (i < j && i + j >= sqareMatrix.GetLength(0) - 1)
                    i++;
                else if (i >= j && i + j > sqareMatrix.GetLength(1) - 1)
                    j--;
                else
                    i--;
            }

            WriteArray(sqareMatrix); // Выводим массив на экран

            // Ждем, пока пользователь нажмет клавишу, чтобы консоль не закрылась сразу
            Console.ReadKey();
        }

        static void WriteArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] / 10 <= 0)
                        Console.Write($" {array[i, j]} "); // Выводим элемент с однозначным числом с дополнительным пробелом
                    else
                        Console.Write($"{array[i, j]} "); // Выводим элемент с двузначным числом

                }
                Console.WriteLine(); // Переходим на новую строку после каждой строки матрицы
            }
        }
    }
}
