using System.Diagnostics;
using System.Numerics;

using lab1.Algorithms;
class Program
{ 
    static void Main()
    {
        int maxLength = 1000000;
        StreamWriter f = new StreamWriter("..//..//..//results/III/QuickRecursiveSort_5.txt");
        for (int i = 1; i <= maxLength; i += 5000)
        {
            var v = VectorGeneration.GetNewVector(i, 1, 1000);
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            BucketSort.Sort(v);
            stopwatch.Stop();

            TimeSpan ts = stopwatch.Elapsed;
            f.WriteLine(stopwatch.Elapsed.TotalMilliseconds);
        }
        f.Close();
    }
}
