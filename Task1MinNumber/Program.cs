using System;
using Utils;

namespace Task1MinNumber
{
    /// <summary>
    /// Автор: Сидорин Никита
    /// Курс: Основы языка C#
    /// Урок: 2
    /// Задача: 1
    /// Условие: Написать метод, возвращающий минимальное из трех чисел.
    /// </summary>
    internal class Program
    {
        public static void Main(string[] args)
        {
            var first = ConsoleHelper.PromptInt("Enter first number");
            var second = ConsoleHelper.PromptInt("Enter second number");
            var third = ConsoleHelper.PromptInt("Enter third number");
            
            var min = Min(first, second, third);
            
            Console.WriteLine($"Min number is {min}.");
            
            ConsoleHelper.ExitByAnyKey();
        }

        private static int Min(int first, int second, int third)
        {
            if (first <= second && first <= third)
            {
                return first;
            }

            return second <= third ? second : third;
        }
    }
}