using System;
using Utils;

namespace Task4ValueExchange
{
    /// <summary>
    /// Автор: Сидорин Никита
    /// Курс: Основы языка C#
    /// Урок: 1
    /// Задача: 4
    /// Условие: Написать программу обмена значениями двух переменных.
    /// а) с использованием третьей переменной;
    /// б) *без использования третьей переменной.
    /// </summary>
    internal class Program
    {
        public static void Main(string[] args)
        {
            var first = ConsoleHelper.Prompt("Enter first value");
            var second = ConsoleHelper.Prompt("Enter second value");
            
            ExchangeWithThirdVariable(first, second);
            ExchangeWithoutThirdVariable(first, second);
            
            Console.WriteLine();
            ConsoleHelper.ExitByAnyKey();
        }

        private static void ExchangeWithThirdVariable(string first, string second)
        {
            var third = first;
            
            first = second;
            second = third;

            Console.WriteLine();
            Console.WriteLine("With third variable");
            Console.WriteLine($"First value: {first}");
            Console.WriteLine($"Second value: {second}");
        }
        
        private static void ExchangeWithoutThirdVariable(string first, string second)
        {
            (first, second) = (second, first);

            Console.WriteLine();
            Console.WriteLine("Without third variable");
            Console.WriteLine($"First value: {first}");
            Console.WriteLine($"Second value: {second}");
        }
    }
}