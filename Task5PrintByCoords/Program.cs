using System;
using Utils;

namespace Task5PrintByCoords
{
    /// <summary>
    /// Автор: Сидорин Никита
    /// Курс: Основы языка C#
    /// Урок: 1
    /// Задача: 5
    /// Условие:
    /// а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
    /// б) Сделать задание, только вывод организуйте в центре экрана
    /// в) *Сделать задание б с использованием собственных методов (например, Print(string ms, int x,int y)
    /// </summary>
    internal class Program
    {
        public static void Main(string[] args)
        {
            var name = ConsoleHelper.Prompt("Enter your name");
            var surname = ConsoleHelper.Prompt("Enter your surname");
            var city = ConsoleHelper.Prompt("Enter your city");

            PrintCenter($"Hello! I am {name} {surname} from {city}.");

            ConsoleHelper.HideCursor();
            Console.ReadKey();
        }
        
        private static void PrintCenter(string message)
        {
            var left = (Console.WindowWidth - message.Length) / 2;
            var top = Console.WindowHeight / 2;
            
            Console.Clear();
            ConsoleHelper.PrintInPosition(message, left, top);
        }
    }
}