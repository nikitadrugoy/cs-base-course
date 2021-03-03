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
            Console.WriteLine($"Time spent: {timeSpent:F3} seconds.");    // 183,852 seconds
            ConsoleHelper.ExitByAnyKey();
        }

        private static bool IsGoodNumber(int value)
        {
            // Красиво, но очень медленно.
            // var digitSum = value.ToString().Sum(char.GetNumericValue);
            
            double digitSum = 0;
            
            // TODO ToString() - узкое место по нагрузке, пока не нашел способ, как улучшить.
            foreach (var digitChar in value.ToString())
            {
                digitSum += char.GetNumericValue(digitChar);
            }

            return value % digitSum == 0;
        }
    }
}