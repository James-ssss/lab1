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
    public class QuickSort
    {
        public void Execute()
        {
            ConsoleHelper.ClearScreen();
            Console.WriteLine("Вы выбрали быструю сортировку.");
            for (int i = 1; i <= 5; i++)
            {
                string path = $"..//..//..//results/6/6_{i}.txt";
                StreamWriter f = new StreamWriter(path);
                for (int j = 1; j <= 100000; j += 500)
                {
                    var v = Generation.GetNewVector(j, 1, 1000);
                    Stopwatch stopwatch = new Stopwatch();
                    stopwatch.Start();
                    QuickSort.SortArray(v,0, j - 501);
                    stopwatch.Stop();

                    TimeSpan ts = stopwatch.Elapsed;
                    f.WriteLine(stopwatch.Elapsed.TotalMilliseconds);
                }
                f.Close();
            }
            ConsoleHelper.ClearScreen();
            Console.WriteLine("Файлы успешно созданы");
        }
        public static int[] SortArray(int[] array, int leftIndex, int rightIndex)
        {
            var i = leftIndex;
            var j = rightIndex;
            var pivot = array[leftIndex];
            while (i <= j)
            {
                while (array[i] < pivot)
                {
                    i++;
                }

                while (array[j] > pivot)
                {
                    j--;
                }

                if (i <= j)
                {
                    int temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                    i++;
                    j--;
                }
            }

            if (leftIndex < j)
                SortArray(array, leftIndex, j);
            if (i < rightIndex)
                SortArray(array, i, rightIndex);
            return array;
        }
    }
}
