using System.Diagnostics;
using System.Numerics;

using lab1.Algorithms;
class Program
{ 
    static void Main()
    {
        List<string> outputData = new();
        outputData.Add(new string("Pow" + "\t" + "Count steps"));

        (int Pow, BigInteger Value) result = new();

        for (int i = 0; i <= 100; i += 5)
        {
            result = RecursiveExponentiation.Exponentiate(2, i);
            outputData.Add(result.Pow.ToString() + "\t" + RecursiveExponentiation.CountSteps.ToString());
            RecursiveExponentiation.CountSteps = 0;
        }

       File.WriteAllLines("..//..//..//results/8/8.2_result.txt", outputData);

    }
}
