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
        for (int i = 0; i <= 15; i += 1)
        {
            if (i == 0)
            {
                continue;
            }
            else
            {
               result = SimpleExponentiation.PowFunc(2, i);
            }
            outputData.Add(result.Pow.ToString() + "\t" + result.Count.ToString());
        }
        File.WriteAllLines("..//..//..//results/8/8.1_result.txt", outputData);
        // var res = SimpleExponentiation.PowFunc(2, 1);
        // Console.WriteLine(res.Count + " " + res.Pow );
    }
}
