using System;
using Utils;

namespace Task1Questionnaire
{
    /// <summary>
    /// Автор: Сидорин Никита
    /// Курс: Основы языка C#
    /// Урок: 1
    /// Задача: 1
    /// Условие: Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес).
    /// В результате вся информация выводится в одну строчку.
    /// а) используя склеивание;
    /// б) используя форматированный вывод;
    /// в) *используя вывод со знаком $.
    /// </summary>
    internal class Program
    {
        public static void Main(string[] args)
        {
            var name = ConsoleHelper.Prompt("Enter your name");
            var surname = ConsoleHelper.Prompt("Enter your surname");
            var age = ConsoleHelper.Prompt("Enter your age");
            var height = ConsoleHelper.Prompt("Enter your height");
            var weight = ConsoleHelper.Prompt("Enter your weight");
            
            Console.WriteLine(
                name + " " + surname + 
                " is " + age + " years old, " + 
                height + "sm height and " + 
                weight + "kg weight."
            );
            
            Console.WriteLine(
                "{0} {1} is {2} years old, {3}sm height and {4}kg weight.", 
                name, surname, age, height, weight
            );
            
            Console.WriteLine($"{name} {surname} is {age} years old, {height}sm height and {weight}kg weight.");
            
            ConsoleHelper.ExitByAnyKey();
        }
    }
}