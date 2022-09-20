using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using СomplexityOfAlgorithms.ComplexityOfAlgorithms.ConsoleUI;

namespace СomplexityOfAlgorithms.ComplexityOfAlgorithms.Core
{
    public class BaseMenu
    {
        public static void ReturnToMainMenu(List<MenuItem> items, int index)
        {
            Console.WriteLine("\n");
            string inputChar;
            do
            {
                Console.WriteLine("Введите b/back для возвращения в главное меню, либо любой другой символ для выхода из программы");
                inputChar = Console.ReadLine();
                var needInputChar = inputChar?.ToLower();
                if ((needInputChar == "b") || (needInputChar == "back"))
                    break;
                else
                    Environment.Exit(0);
            } while (true);

            ConsoleHelper.ClearScreen();

            DrawMenu(items, index, "Главное меню");
        }
        public static void DrawMenu(List<MenuItem> items, int index, string text)
        {
            ConsoleHelper.ClearScreen();
            Console.WriteLine(text);
            for (int i = 0; i < items.Count; i++)
            {
                if (i == index)
                {
                    Console.BackgroundColor = ConsoleColor.Gray;
                    Console.ForegroundColor = ConsoleColor.Black;
                }
                Console.WriteLine(items[i].Text);

                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.White;
            }
            Console.WriteLine();
        }
    }
}
