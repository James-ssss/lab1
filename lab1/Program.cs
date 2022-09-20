using System.Diagnostics;
using System.Numerics;
using СomplexityOfAlgorithms.Algorithms;
using СomplexityOfAlgorithms.ComplexityOfAlgorithms.ConsoleUI;
using СomplexityOfAlgorithms.ComplexityOfAlgorithms.Core;

class Program
{
    static void Main(string[] args)
    {

        List<MenuItem> mainMenu = new List<MenuItem>
            {
                new MenuItem{Id =1, Text = "Вывести список людей"},
                new MenuItem{Id =9, Text = "Выход"},
            };

        int index = 0;
        while (true)
        {
            BaseMenu.DrawMenu(mainMenu, index, "Главное меню \n");
            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.DownArrow:
                    if (index < mainMenu.Count - 1)
                        index++;
                    else
                        index = 0;
                    break;
                case ConsoleKey.UpArrow:
                    if (index > 0)
                        index--;
                    else
                        index = mainMenu.Count - 1;
                    break;
                case ConsoleKey.Enter:
                    switch (mainMenu[index].Text)
                    {
                        case "Вывести список людей":
                            BucketSort b = new BucketSort();
                            b.Execute();
                            BaseMenu.ReturnToMainMenu(mainMenu, index);
                            break;
                        case "Выход":
                            ConsoleHelper.ClearScreen();
                            Console.WriteLine("Работа завершена");
                            return;
                    }
                    break;
            }
        }
    }

    
}

