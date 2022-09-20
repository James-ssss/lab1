using System.Diagnostics;
using System.Numerics;
using СomplexityOfAlgorithms.ComplexityOfAlgorithms.ConsoleUI;
using СomplexityOfAlgorithms.ComplexityOfAlgorithms.Core;

class Program
{ 
    static void Main()
    {
        Console.CursorVisible = false;
        MainMenu menu = new MainMenu();
        do
        {
            menu.Draw();

            ConsoleKeyInfo keyInfo = Console.ReadKey(true);
            if (keyInfo.Key == ConsoleKey.DownArrow)
            {
                menu.Next();
            }
            else if (keyInfo.Key == ConsoleKey.UpArrow)
            {
                menu.Prev();
            }
            else if (keyInfo.Key == ConsoleKey.Enter)
            {
                menu.Select();

                Console.WriteLine("Хотите продолжить? y/n");
                string answer = Console.ReadLine();
                if (answer == "n" || answer == "no")
                {
                    break;
                }
            }
        } while (true);
       
    }
}
