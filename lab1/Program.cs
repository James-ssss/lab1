using lab1.Algorithms;
using System.Diagnostics;
using System.Numerics;
using СomplexityOfAlgorithms.Algorithms;
using СomplexityOfAlgorithms.ComplexityOfAlgorithms.ConsoleUI;
using СomplexityOfAlgorithms.ComplexityOfAlgorithms.Core;

class Program
{
    const string BucketSort = "Блочная сортировка";
    const string SimpleExponentiation = "Простое возведение в степень";
    const string RecursiveExponentiation = "Рекурсивное возведение в степень";
    const string QuickExponentiation = "Быстрое возведение в степень";
    const string ClassicQuickExponentiation = "Классическое быстрое возведение в степень";
    const string CombSort = "Сортировка расческой";
    const string PlynomialCalculation = "Прямое (наивное) вычисление полинома";
    const string PolynomialCalculationByHorner = "Вычисление полинома методом Горнера";
    const string MatrixMultiplication = "Умножение матриц";
    const string BubbleSort = "Сортировка пузырьком";
    const string InsertionSort = "Сортировка вставками";
    const string QuickSort = "Быстрая сортировка";
    const string Exit = "Выход";
    static void Main(string[] args)
    {

        List<MenuItem> mainMenu = new List<MenuItem>
            {
                new MenuItem{Title = BucketSort},
                new MenuItem{Title = SimpleExponentiation},
                new MenuItem{Title = RecursiveExponentiation},
                new MenuItem{Title = QuickExponentiation},
                new MenuItem{Title = ClassicQuickExponentiation},
                new MenuItem{Title = CombSort},
                new MenuItem{Title = PlynomialCalculation},
                new MenuItem{Title = PolynomialCalculationByHorner},
                new MenuItem{Title = MatrixMultiplication},
                new MenuItem{Title = BubbleSort},
                new MenuItem{Title = InsertionSort},
                new MenuItem{Title = QuickSort},
                new MenuItem{Title = Exit},
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
                    switch (mainMenu[index].Title)
                    {
                        case BucketSort:
                            BucketSort b = new BucketSort();
                            b.Execute();
                            BaseMenu.ReturnToMainMenu(mainMenu, index);
                            break;
                        case SimpleExponentiation:
                            SimpleExponentiation s = new SimpleExponentiation();
                            s.Execute();
                            BaseMenu.ReturnToMainMenu(mainMenu, index);
                            break;
                        case RecursiveExponentiation:
                            RecursiveExponentiation r = new RecursiveExponentiation();
                            r.Execute();
                            BaseMenu.ReturnToMainMenu(mainMenu, index);
                            break;
                            break;
                        case QuickExponentiation:
                            QuickExponentiation q = new QuickExponentiation();
                            q.Execute();
                            BaseMenu.ReturnToMainMenu(mainMenu, index);
                            break;
                        case ClassicQuickExponentiation:
                            ClassicQuickExponentiation c = new ClassicQuickExponentiation();
                            c.Execute();
                            BaseMenu.ReturnToMainMenu(mainMenu, index);
                            break;
                        case CombSort:
                            CombSort cs = new CombSort();
                            cs.Execute();
                            BaseMenu.ReturnToMainMenu(mainMenu, index);
                            break;
                        case PlynomialCalculation:
                            Polynom pc = new Polynom();
                            pc.ExecuteP();
                            BaseMenu.ReturnToMainMenu(mainMenu, index);
                            break;
                        case PolynomialCalculationByHorner:
                            Polynom pcby = new Polynom();
                            pcby.ExecutePGorner();
                            BaseMenu.ReturnToMainMenu(mainMenu, index);
                            break;
                        case MatrixMultiplication:
                            MatrixOperations mo = new MatrixOperations();
                            mo.ExecuteMultiplication();
                            BaseMenu.ReturnToMainMenu(mainMenu, index);
                            break;
                        case BubbleSort:
                            BubbleSort bs = new BubbleSort();
                            bs.Execute();
                            BaseMenu.ReturnToMainMenu(mainMenu, index);
                            break;
                        case InsertionSort:
                            InsertionSort iss = new InsertionSort();
                            iss.Execute();
                            BaseMenu.ReturnToMainMenu(mainMenu, index);
                            break;
                        case QuickSort:
                            QuickSort qs = new QuickSort();
                            qs.Execute();
                            BaseMenu.ReturnToMainMenu(mainMenu, index);
                            break;
                        case Exit:
                            ConsoleHelper.ClearScreen();
                            Console.WriteLine("Работа завершена");
                            return;
                    }
                    break;
            }
        }
    }

    
}

