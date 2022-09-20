using System.Diagnostics;
using System.Numerics;

using lab1.Algorithms;
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

                timer.Stop();
                milliSec.Add(timer.Elapsed.TotalMilliseconds.ToString());
                timer.Reset();

            }
            //File.WriteAllLines($"..//..//..//results/1.1/1_1_{j}_result.txt", milliSec); //1.1
            //File.WriteAllLines($"..//..//..//results/1.2/1_2_{j}_result.txt", milliSec); //1.2
            File.WriteAllLines($"..//..//..//results/1.3/1_3_{j}_result.txt", milliSec); //1.3
            
            milliSec.Clear();
        }
       
    }
}
