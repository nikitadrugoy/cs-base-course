using System;
using Utils;

namespace Task1Complex
{
    /// <summary>
    /// Автор: Сидорин Никита
    /// Курс: Основы языка C#
    /// Урок: 3
    /// Задача: 1
    /// Условие: а) Дописать структуру Complex, добавив метод вычитания комплексных чисел.
    /// Продемонстрировать работу структуры;
    /// б) Дописать класс Complex, добавив методы вычитания и произведения чисел.
    /// Проверить работу класса;
    /// </summary>using Syste,m;Utisls32/// /// /// /// 
    internal class Program
    {
        public static void Main(string[] args)
        {
            ClassExample();
            StructExample();
            
            ConsoleHelper.ExitByAnyKey();
        }

        public static void ClassExample()
        {
            var complex1 = new ComplexClass {re = 1, im = 1};
            var complex2 = new ComplexClass {re = 2, im = 2};

            Console.WriteLine("Class example:");
            Console.Write($"{complex1} + {complex2}");

            complex1.Plus(complex2);
            
            Console.WriteLine($" = {complex1}");
            Console.Write($"{complex1} - {complex2}");

            complex1.Minus(complex2);
            
            Console.WriteLine($" = {complex1}");
            Console.Write($"{complex1} * {complex2}");

            complex1.Multi(complex2);
            
            Console.WriteLine($" = {complex1}");
        }

        public static void StructExample()
        {
            var complex1 = new ComplexStruct {re = 3, im = 3};
            var complex2 = new ComplexStruct {re = 2, im = 2};

            Console.WriteLine("Struct example:");
            
            Console.WriteLine($"{complex1} + {complex2} = {complex1.Plus(complex2)}");
            Console.WriteLine($"{complex1} - {complex2} = {complex1.Minus(complex2)}");
            Console.WriteLine($"{complex1} * {complex2} = {complex1.Multi(complex2)}");
        }
    }
}