using System;
using Utils;

namespace Task2NumberLength
{
    /// <summary>
    /// Автор: Сидорин Никита
    /// Курс: Основы языка C#
    /// Урок: 2
    /// Задача: 2
    /// Условие: Написать метод подсчета количества цифр числа.
    /// </summary>
    internal class Program
    {
        public static void Main(string[] args)
        {
            var number = ConsoleHelper.Prompt("Enter number");
            
            Console.WriteLine($"Number length is {number.Length}.");
            
            ConsoleHelper.ExitByAnyKey();
        }
    }
}