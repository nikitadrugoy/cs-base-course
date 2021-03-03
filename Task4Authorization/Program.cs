using System;
using Utils;

namespace Task4Authorization
{
    /// <summary>
    /// Автор: Сидорин Никита
    /// Курс: Основы языка C#
    /// Урок: 2
    /// Задача: 4
    /// Условие: Реализовать метод проверки логина и пароля. На вход подается логин и пароль.
    /// На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains).
    /// Используя метод проверки логина и пароля, написать программу:
    /// пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает.
    /// С помощью цикла do while ограничить ввод пароля тремя попытками.
    /// </summary>
    internal class Program
    {
        public static void Main(string[] args)
        {
            var attemptCount = 3;

            do
            {
                if (Authorize())
                {
                    break;
                }
                
                attemptCount--;
                
                Console.WriteLine($"{attemptCount} attempts left.");
            } while (attemptCount > 0);

            if (attemptCount <= 0)
            {
                Console.WriteLine($"Authorization failed.");
                ConsoleHelper.ExitByAnyKey();
            }

            Console.WriteLine("Welcome!");
            ConsoleHelper.ExitByAnyKey();
        }

        private static bool Authorize()
        {
            const string login = "root";
            const string password = "GeekBrains";
            
            var enteredLogin = ConsoleHelper.Prompt("Enter login");
            var enteredPassword = ConsoleHelper.PromptPassword("Enter password");

            return enteredLogin == login && enteredPassword == password;
        }
    }
}