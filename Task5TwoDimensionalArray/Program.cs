using System;
using ArraysLib;
using Utils;

namespace Task5TwoDimensionalArray
{
    /// <summary>
    /// Автор: Сидорин Никита
    /// Курс: Основы языка C#
    /// Урок: 4
    /// Задача: 5
    /// Условие: *а) Реализовать библиотеку с классом для работы с двумерным массивом.
    /// - Реализовать конструктор, заполняющий массив случайными числами,
    /// - метод, который возвращают сумму всех элементов массива,
    /// - метод, который возвращают сумму всех элементов массива больше заданного,
    /// - свойство, возвращающее минимальный элемент массива,
    /// - свойство, возвращающее максимальный элемент массива
    /// - метод, возвращающий номер максимального элемента массива (через параметры, используя модификатор ref или out).
    /// **б) Добавить конструктор и методы, которые загружают данные из файла и записывают данные в файл.
    /// **в) Обработать возможные исключительные ситуации при работе с файлами.
    /// </summary>
    internal class Program
    {
        public static void Main(string[] args)
        {
            // var filePath = @"C:\values.txt"; // Test exception
            var filePath = "values.txt";       // bin/debug
            
            TestSaving(filePath);
            Console.WriteLine();
            TestLoading(filePath);

            ConsoleHelper.ExitByAnyKey();
        }

        private static void TestSaving(string filePath)
        {
            var lengthX = ConsoleHelper.PromptInt("Enter X length");
            var lengthY = ConsoleHelper.PromptInt("Enter Y length");
            var array = new D2Array(lengthX, lengthY);
            var maxValue = array.MaxValue(out var maxValueIndex);
            var sumMinValue = 500;

            Console.WriteLine(array.ToString());
            Console.WriteLine();
            Console.WriteLine($"Min: {array.Min}");
            Console.WriteLine($"Max: {maxValue} (index is [{maxValueIndex.Item1}, {maxValueIndex.Item2}])");
            Console.WriteLine($"Sum: {array.Sum()}");
            Console.WriteLine($"Sum from {sumMinValue}: {array.Sum(sumMinValue)}");

            try
            {
                array.SaveToFile(filePath);
            }
            catch (UnauthorizedAccessException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Array2DLengthException e) // Custom exception
            {
                Console.WriteLine(e.Message);
            }
            
            Console.WriteLine($"Array saved to file \"{filePath}\"");
        }

        private static void TestLoading(string filePath)
        {
            var array = new D2Array(filePath);
            
            Console.WriteLine("File loaded.");
            Console.WriteLine(array.ToString());
        }
    }
}