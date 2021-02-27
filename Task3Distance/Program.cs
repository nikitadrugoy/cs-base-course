using System;
using Utils;

namespace Task3Distance
{
    /// <summary>
    /// Автор: Сидорин Никита
    /// Курс: Основы языка C#
    /// Урок: 1
    /// Задача: 3
    /// Условие:
    /// а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2, y2
    /// по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2).
    /// Вывести результат, используя спецификатор формата .2f (с двумя знаками после запятой);
    /// б) *Выполните предыдущее задание, оформив вычисления расстояния между точками в виде метода;
    /// </summary>
    internal class Program
    {
        public static void Main(string[] args)
        {
            var (x1, y1) = ReadPoint("Enter first point coords");
            var (x2, y2) = ReadPoint("Enter second point coords");
            var distance = Distance(x1, y1, x2, y2);
            
            Console.WriteLine($"Distance is {distance:F}");
            
            ConsoleHelper.ExitByAnyKey();
        }

        private static (int x, int y) ReadPoint(string message)
        {
            Console.WriteLine(message);
            
            var x = int.Parse(ConsoleHelper.Prompt("x"));
            var y = int.Parse(ConsoleHelper.Prompt("y"));
            
            return (x, y);
        }

        private static double Distance(int x1, int y1, int x2, int y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }
    }
}