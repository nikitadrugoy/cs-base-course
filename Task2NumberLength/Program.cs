using System;
using Utils;

namespace Task2NumberLength
{
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