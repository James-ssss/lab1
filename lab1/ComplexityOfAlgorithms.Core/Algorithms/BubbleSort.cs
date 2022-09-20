using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using СomplexityOfAlgorithms.ComplexityOfAlgorithms.ConsoleUI;
using СomplexityOfAlgorithms.ComplexityOfAlgorithms.Core;

namespace СomplexityOfAlgorithms.Algorithms
{
    public class BubbleSort : IExecutable
    {
        public void Execute()
        {
            ConsoleHelper.ClearScreen();
            Console.WriteLine("Вы выбрали сортировку пузырьком.");
            for (int i = 1; i <= 5; i++)
            {
                string path = $"..//..//..//results/5/5_{i}.txt";
                StreamWriter f = new StreamWriter(path);
                for (int j = 1; j <= 4000; j += 20)
                {
                    var v = Generation.GetNewVector(j, 1, 1000);
                    Stopwatch stopwatch = new Stopwatch();
                    stopwatch.Start();
                    BubbleSort.BubbSort(v);
                    stopwatch.Stop();

                    TimeSpan ts = stopwatch.Elapsed;
                    f.WriteLine(stopwatch.Elapsed.TotalMilliseconds);
                }
                f.Close();
            }
            ConsoleHelper.ClearScreen();
            Console.WriteLine("Файлы успешно созданы");
        }
        public static int[] BubbSort(int[] vector)
        {
            int temp;
            for (int i = 0; i < vector.Length; i++)
            {
                for (int j = i + 1; j < vector.Length; j++)
                {
                    if (vector[i] > vector[j])
                    {
                        temp = vector[i];
                        vector[i] = vector[j];
                        vector[j] = temp;
                    }
                }
            }

            return vector;

        }
    }
}

