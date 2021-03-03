using System;
using Utils;

namespace Task1MinNumber
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var first = int.Parse(ConsoleHelper.Prompt("Enter first number"));
            var second = int.Parse(ConsoleHelper.Prompt("Enter second number"));
            var third = int.Parse(ConsoleHelper.Prompt("Enter third number"));
            
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