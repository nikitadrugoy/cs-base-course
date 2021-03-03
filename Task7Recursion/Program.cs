using System;
using Utils;

namespace Task7Recursion
{
    /// <summary>
    /// Автор: Сидорин Никита
    /// Курс: Основы языка C#
    /// Урок: 2
    /// Задача: 7
    /// Условие: a) Разработать рекурсивный метод, который выводит на экран числа от a до b (a меньше b);
    /// б) *Разработать рекурсивный метод, который считает сумму чисел от a до b.
    /// </summary>
    internal class Program
    {
        public static void Main(string[] args)
        {
            var a = ConsoleHelper.PromptInt("Enter first number");
            var b = ConsoleHelper.PromptInt("Enter second number");
            var sum = SumRecursive(a, b);
            
            Console.WriteLine($"Sum: {sum}");
            
            ConsoleHelper.ExitByAnyKey();
        }

        private static int SumRecursive(int a, int b)
        {
            var sum = a;
            
            if (a < b)
            {
                sum += SumRecursive(a + 1, b);
            }
            
            return sum;
        }
    }
}