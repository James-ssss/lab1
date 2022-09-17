using System.Diagnostics;
using System.Numerics;

using lab1.Algorithms;
class Program
{ 
    static void Main()
    {
        int maxLength = 100000;
        StreamWriter f = new StreamWriter("..//..//..//results/III/QuickRecursiveSort_3.txt");
        for (int i = 1; i <= maxLength; i += 500)
        {
            var v = VectorGeneration.GetNewVector(i, 1, 1000);
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            var m = QuickRecursiveSort.QuickSort(v, 0, i - 499);
            stopwatch.Stop();

            TimeSpan ts = stopwatch.Elapsed;
            f.WriteLine(stopwatch.Elapsed.TotalMilliseconds);
        }
        f.Close();
    }
}
