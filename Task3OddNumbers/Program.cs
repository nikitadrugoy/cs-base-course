using System;
using Utils;

namespace Task3OddNumbers
{
    /// <summary>
    /// Автор: Сидорин Никита
    /// Курс: Основы языка C#
    /// Урок: 2
    /// Задача: 3
    /// Условие: С клавиатуры вводятся числа, пока не будет введен 0.
    /// Подсчитать сумму всех нечетных положительных чисел.
    /// </summary>
    internal class Program
    {
        public static void Main(string[] args)
        {
            var oddNumbersCount = 0;
            int currentNumber;

            do
            {
                currentNumber = ConsoleHelper.PromptInt("Enter number (0 to exit)");

                if (IsOdd(currentNumber))
                {
                    oddNumbersCount++;
                } 
            } while (currentNumber != 0);
            
            Console.WriteLine($"Odd numbers count: {oddNumbersCount}");
        }

        private static bool IsOdd(int value)
        {
            return value % 2 != 0;
        }
    }
}