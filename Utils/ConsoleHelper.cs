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
        
        public static void PrintInPosition(string message, int left, int top)
        {
            Console.SetCursorPosition(left, top);
            Console.WriteLine(message);
        }

        public static void ExitByAnyKey()
        {
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
        
        public static void HideCursor()
        {
            Console.CursorVisible = false;
        }
        
        public static void ShowCursor()
        {
            Console.CursorVisible = true;
        }
    }
}