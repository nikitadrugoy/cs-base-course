using System;
using Utils;

namespace Task5BodyMassIndex
{
    /// <summary>
    /// Автор: Сидорин Никита
    /// Курс: Основы языка C#
    /// Урок: 2
    /// Задача: 5
    /// Условие: а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает,
    /// нужно ли человеку похудеть, набрать вес или все в норме;
    /// б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.
    /// </summary>
    internal class Program
    {
        public static void Main(string[] args)
        {
            var weight = int.Parse(ConsoleHelper.Prompt("Enter your weight (kg)"));
            var height = int.Parse(ConsoleHelper.Prompt("Enter your height (sm)"));

            var bodyMassIndex = MassIndex(weight, height);
            var massExceeding = MassExceeding(weight, height);

            Console.WriteLine($"Your body mass index is {bodyMassIndex:F}.");

            if (massExceeding > 0)
            {
                Console.WriteLine($"You should gain {massExceeding:F} kg.");
            }
            else if (massExceeding > 0)
            {
                Console.WriteLine($"You should drop {Math.Abs(massExceeding):F} kg.");
            }
            else
            {
                Console.WriteLine("Congratulations! You are fine.");
            }
            
            ConsoleHelper.ExitByAnyKey();
        }

        private static double SmToMeters(double height)
        {
            return height / 100d;
        }

        private static double MassIndex(double weight, double height)
        {
            var heightMeters = SmToMeters(height);
            return weight / (heightMeters * heightMeters);
        }

        private static double MassExceeding(double weight, double height)
        {
            const double normalIndexMin = 18.50;
            const double normalIndexMax = 24.99;
            
            var currentIndex = MassIndex(weight, height);

            if (currentIndex >= normalIndexMin && currentIndex <= normalIndexMax)
            {
                return 0;
            }

            var targetIndex = currentIndex < normalIndexMin ? normalIndexMin : normalIndexMax;
            var heightMeters = SmToMeters(height);
            var normalWeight = targetIndex * heightMeters * heightMeters;

            return normalWeight - weight;
        }
    }
}