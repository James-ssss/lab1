using System.Diagnostics;
using System.Numerics;

using lab1.Algorithms;
class Program
{ 
    static void Main()
    {
        int maxLength = 4000;
        StreamWriter f = new StreamWriter("..//..//..//results//III//knyshov.5txt");
        for (int i = 1; i <= maxLength; i += 20)
        {
            var v = VectorGeneration.GetNewVector(i, 1, 1000);
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            var m = InsertionSort.InsertSort(v);
            stopwatch.Stop();

            TimeSpan ts = stopwatch.Elapsed;
            f.WriteLine(stopwatch.Elapsed.TotalMilliseconds);
        }
        f.Close();
    }
}
