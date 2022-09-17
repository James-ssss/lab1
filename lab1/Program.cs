using System.Diagnostics;
using System.Numerics;

using lab1.Algorithms;
class Program
{ 
    static void Main()
    {
        List<string> outputData = new();
        outputData.Add(new string("Pow" + "\t" + "Count steps"));

        (int Pow, int Count) result = new();

        for (int i = 0; i <= 100; i += 5)
        {
            result = QuickExponentiation.Exponentiate(8, i);
            outputData.Add(result.Pow.ToString() + "\t" + result.Count.ToString());
        }
        File.WriteAllLines("..//..//..//results/8/8.3_result.txt", outputData);
    }
}
