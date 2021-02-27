using System;
using Utils;

namespace Task2BodyMassIndex
{
    /// <summary>
    /// Автор: Сидорин Никита
    /// Курс: Основы языка C#
    /// Урок: 1
    /// Задача: 2
    /// Условие: Ввести вес и рост человека.
    /// Рассчитать и вывести индекс массы тела (ИМТ) по формуле I=m/(h*h);
    /// где m — масса тела в килограммах, h — рост в метрах
    /// </summary>
    internal class Program
    {
        public static void Main(string[] args)
        {
            var height = int.Parse(ConsoleHelper.Prompt("Enter your height (sm)"));
            var weight = int.Parse(ConsoleHelper.Prompt("Enter your weight (kg)"));

            var heightMeters = height / 100d;
            var bodyMassIndex = weight / (heightMeters * heightMeters);
            
            Console.WriteLine($"Your body mass index is {bodyMassIndex:F1}.");
            
            ConsoleHelper.ExitByAnyKey();
        }
    }
}