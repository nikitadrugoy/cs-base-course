using System;

namespace Utils
{
    public static class ConsoleHelper
    {
        public static string Prompt(string message)
        {
            Console.Write($"{message}: ");
            
            return Console.ReadLine();
        }

        public static int PromptInt(string message)
        {
            while (true)
            {
                if (int.TryParse(Prompt(message), out var result))
                {
                    return result;
                }

                Console.WriteLine("Value is not a number.");
            }
        }

        public static void PrintInPosition(string message, int left, int top)
        {
            Console.SetCursorPosition(left, top);
            Console.WriteLine(message);
        }

        public static void ExitByAnyKey()
        {
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
            Environment.Exit(0);
        }
        
        public static void HideCursor()
        {
            Console.CursorVisible = false;
        }
        
        public static void ShowCursor()
        {
            Console.CursorVisible = true;
        }

        public static string PromptPassword(string message)
        {
            var password = string.Empty;
            ConsoleKey key;
         
            Console.Write($"{message}: ");
            
            do
            {
                var keyInfo = Console.ReadKey(true);
                key = keyInfo.Key;

                if (key == ConsoleKey.Backspace && password.Length > 0)
                {
                    password = password.Remove(password.Length - 1);
                    Console.Write("\b \b");
                }
                else if (!char.IsControl(keyInfo.KeyChar))
                {
                    password += keyInfo.KeyChar;
                    Console.Write("*");
                }
            } while (key != ConsoleKey.Enter);

            Console.WriteLine();
            
            return password;
        }
    }
}