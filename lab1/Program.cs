using System.Diagnostics;
using System.Numerics;

using lab1.Algorithms;
class Program
{ 
    static void Main()
    {
        List<string> outputData = new();
        outputData.Add(new string("Pow" + "\t" + "Count steps"));
       (string Pow, string Count) result = new();
        for (int i = 1; i <= 50; i += 10)
        {
            if (i == 11)
            {
                i -= 1;
               result = SimpleExponentiation.PowFunc(5, i);
            }
            else
            {
               result = SimpleExponentiation.PowFunc(5, i);
            }
            outputData.Add(result.Pow + "\t" + result.Count);
        }
        File.WriteAllLines("..//..//..//results/8/8.1_result.txt", outputData);  
    }
}
