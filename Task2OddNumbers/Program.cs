using System;
using Utils;

namespace Task2OddNumbers
{
    /// <summary>
    /// Автор: Сидорин Никита
    /// Курс: Основы языка C#
    /// Урок: 3
    /// Задача: 2
    /// Условие: а) С клавиатуры вводятся числа, пока не будет введен 0 (каждое число в новой строке). 
    /// Требуется подсчитать сумму всех нечетных положительных чисел. 
    /// Сами числа и сумму вывести на экран, используя tryParse;
    /// б) Добавить обработку исключительных ситуаций на то, что могут быть введены некорректные данные. 
    /// При возникновении ошибки вывести сообщение. Напишите соответствующую функцию;
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