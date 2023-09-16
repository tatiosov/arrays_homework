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

            Console.WriteLine($"Задача 60: Вывод элементов трехмерного массива с их индексами в скобках"); // Выводим задачу на экран

            Console.WriteLine($"\nВведите размер массива X x Y x Z:"); // Запрашиваем у пользователя размеры массива
            int x = InputNumbers("Введите X: "); // Запрашиваем и сохраняем значение X
            int y = InputNumbers("Введите Y: "); // Запрашиваем и сохраняем значение Y
            int z = InputNumbers("Введите Z: "); // Запрашиваем и сохраняем значение Z
            Console.WriteLine("");

            int[,,] array3D = new int[x, y, z]; // Создаем трехмерный массив

            CreateArray(array3D); // Заполняем массив случайными значениями
            WriteArray(array3D); // Выводим массив на экран с индексами

            Console.ReadKey(); // Ждем, пока пользователь нажмет клавишу, чтобы консоль не закрылась сразу
        }

        static int InputNumbers(string input)
        {
            Console.Write(input); // Выводим приглашение для ввода числа
            int output = Convert.ToInt32(Console.ReadLine()); // Считываем введенное значение и конвертируем в int
            return output; // Возвращаем введенное число
        }

        static void WriteArray(int[,,] array3D)
        {
            for (int i = 0; i < array3D.GetLength(0); i++)
            {
                for (int j = 0; j < array3D.GetLength(1); j++)
                {
                    for (int k = 0; k < array3D.GetLength(2); k++)
                    {
                        Console.Write($"{array3D[i, j, k]} ({i}, {j}, {k}); "); // Выводим значение и его индексы
                    }
                    Console.WriteLine(); // Переходим на новую строку после каждого Y
                }
                Console.WriteLine(); // Переходим на новую строку после каждого X
            }
        }

        static void CreateArray(int[,,] array3D)
        {
            int[] temp = new int[array3D.GetLength(0) * array3D.GetLength(1) * array3D.GetLength(2)]; // Создаем временный массив для хранения уникальных случайных чисел
            int number;

            for (int i = 0; i < temp.GetLength(0); i++)
            {
                temp[i] = new Random().Next(10, 100); // Заполняем временный массив случайными уникальными числами
                number = temp[i];

                if (i >= 1)
                {
                    for (int j = 0; j < i; j++)
                    {
                        while (temp[i] == temp[j])
                        {
                            temp[i] = new Random().Next(10, 100); // Проверяем на уникальность чисел
                            j = 0;
                            number = temp[i];
                        }
                        number = temp[i];
                    }
                }
            }

            int count = 0;
            for (int x = 0; x < array3D.GetLength(0); x++)
            {
                for (int y = 0; y < array3D.GetLength(1); y++)
                {
                    for (int z = 0; z < array3D.GetLength(2); z++)
                    {
                        array3D[x, y, z] = temp[count]; // Заполняем трехмерный массив значениями из временного массива
                        count++;
                    }
                }
            }
        }
    }
}
