using System.Diagnostics;
using ÑomplexityOfAlgorithms.ComplexityOfAlgorithms.ConsoleUI;
using ÑomplexityOfAlgorithms.ComplexityOfAlgorithms.Core;

namespace ÑomplexityOfAlgorithms.Algorithms;

public class InsertionSort
{
    public void Execute()
    {
        ConsoleHelper.ClearScreen();
        Console.WriteLine("Âû âûáğàëè ñîğòèğîâêó âñòàâêàìè.");
        for (int i = 1; i <= 5; i++)
        {
            string path = $"..//..//..//results/III/InsertionSort_{i}.txt";
            StreamWriter f = new StreamWriter(path);
            for (int j = 1; j <= 4000; j += 20)
            {
                var v = Generation.GetNewVector(j, 1, 1000);
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                InsertionSort.InsertSort(v);
                stopwatch.Stop();

                TimeSpan ts = stopwatch.Elapsed;
                f.WriteLine(stopwatch.Elapsed.TotalMilliseconds);
            }
            f.Close();
        }
        ConsoleHelper.ClearScreen();
        Console.WriteLine("Ôàéëû óñïåøíî ñîçäàíû");
    }
    public static void Swap(int[] array, int i, int j)
    {
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }
    public static int[] InsertSort(int[] vector)
    {
        int x;
        int j;
        for (int i = 1; i < vector.Length; i++)
        {
            x = vector[i];
            j = i;
            while (j > 0 && vector[j - 1] > x)
            {
                Swap(vector, j, j - 1);
                j -= 1;
            }
            vector[j] = x;
        }

        return vector;
    }
}