using System;
using System.Linq;
using Utils;

namespace Task6GoodNumbers
{
    /// <summary>
    /// Автор: Сидорин Никита
    /// Курс: Основы языка C#
    /// Урок: 2
    /// Задача: 6
    /// Условие: Написать программу подсчета количества «Хороших» чисел в диапазоне от 1 до 1 000 000 000.
    /// Хорошим называется число, которое делится на сумму своих цифр.
    /// Реализовать подсчет времени выполнения программы, используя структуру DateTime.
    /// </summary>
    internal class Program
    {
        public static void Main(string[] args)
        {
            var maxValue = 1000000000;
            var goodNumberCount = 0;

            Console.WriteLine($"Counting good numbers of {maxValue}...");
            
            var dateTimeStart = DateTime.Now;
            
            for (var i = 1; i <= maxValue; i++)
            {
                if (IsGoodNumber(i))
                {
                    goodNumberCount++;
                }
            }

            var dateTimeFinish = DateTime.Now;
            var timeSpent = dateTimeFinish.Subtract(dateTimeStart).TotalMilliseconds / 1000;
            
            Console.WriteLine($"Good numbers count: {goodNumberCount}."); // 61574510
            Console.WriteLine($"Time spent: {timeSpent:F3} seconds.");    // 93,415 seconds (old: 183,852)
            ConsoleHelper.ExitByAnyKey();
        }

        private static bool IsGoodNumber(int value)
        {
            // Красиво, но очень медленно.
            // var digitSum = value.ToString().Sum(char.GetNumericValue);
            
            var digitSum = 0;
            var currentValue = value;

            while (currentValue != 0) {
                digitSum += currentValue % 10;
                currentValue /= 10;
            }

            return digitSum == 0 || value % digitSum == 0;
        }
    }
}