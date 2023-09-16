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
            Console.WriteLine($"\nЗадача 43. Точка пересечения двух прямых");

            // Запрос у пользователя ввода коэффициентов прямых
            Console.WriteLine($"\n\nВведите коэффициент b1:");
            double b1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"\n\nВведите коэффициент b2:");
            double b2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"\n\nВведите коэффициент k1:");
            double k1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"\n\nВведите коэффициент k2:");
            double k2 = Convert.ToDouble(Console.ReadLine());

            // Рассчитываем координаты точки пересечения прямых
            double x = -(b1 - b2) / (k1 - k2);
            double y = k1 * x + b1;

            // Выводим результат (координаты точки пересечения) на экран
            Console.WriteLine($"Точка пересечения: ({x}; {y})");

            // Ждем, пока пользователь нажмет клавишу, чтобы консоль не закрылась сразу
            Console.ReadKey();
        }
    }
}
