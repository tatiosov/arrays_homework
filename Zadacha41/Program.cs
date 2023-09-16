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
            // Выводим текстовое сообщение о задаче в консоль
            Console.WriteLine($"\nЗадача 41. Количество чисел больше нуля");
            Console.WriteLine($"\n\nВведите массив чисел через запятую, например: 123,452,183");

            // Считываем строку, которую ввел пользователь
            string input = Console.ReadLine();

            // Вызываем функцию GetNums, передавая в неё введенную строку
            int count = GetNums(input);

            // Выводим результат (количество четных чисел) на экран
            Console.WriteLine($"Количество чисел больше нуля в массиве: " + count.ToString());

            // Ждем, пока пользователь нажмет клавишу, чтобы консоль не закрылась сразу
            Console.ReadKey();
        }

        // Функция для расчета количества четных чисел в массиве
        static int GetNums(string input)
        {
            int result = 0;  // Переменная для хранения количества четных чисел
            string[] parts = input.Split(',');  // Разбиваем введенную строку на массив строк, используя ',' как разделитель
            int numsCount = 0;
            List<int> numbers = new List<int>();  // Создаем список для хранения чисел

            // Проходим по каждой строке в массиве parts
            for (int i = 0; i < parts.Length; i++)
            {
                // Пытаемся преобразовать строку в число
                if (int.TryParse(parts[i], out int number))
                {
                    numbers.Add(number);  // Если успешно, сохраняем число в список numbers
                    numsCount += 1;
                }
                else
                {
                    // В случае ошибки при парсинге выводим сообщение об ошибке
                    Console.WriteLine($"Не удалось преобразовать элемент с индексом {i}: {parts[i]}");
                    // Помещаем в список numbers значение 1 как запасной вариант
                    numbers.Add(1);
                }
            }

            // Проходим по каждому числу в списке numbers
            if (numsCount > 0)
            {
                foreach (int num in numbers)
                {
                    // Проверяем, является ли число больше нуля (положительным)
                    if (num > 0)
                    {
                        result++;  // Если число положительное, увеличиваем счетчик
                    }
                }
            }
            return result;  // Возвращаем количество положительных чисел
        }
    }
}
