using System.Numerics;
using СomplexityOfAlgorithms.ComplexityOfAlgorithms.ConsoleUI;
using СomplexityOfAlgorithms.ComplexityOfAlgorithms.Core;

namespace СomplexityOfAlgorithms.Algorithms;

public class SimpleExponentiation : IExecutable
{
    public void Execute()
    {
        ConsoleHelper.ClearScreen();
        Console.WriteLine("Вы выбрали простой алгоритм возведения в степень.");
        List<string> outputData = new();
        outputData.Add(new string("Pow" + "\t" + "Count steps"));
        (int Pow, int Count) result = new();
        for (int i = 1; i <= 100; i += 5)
        {
            if (i == 11)
            {
                i -= 1;
                result = SimpleExponentiation.Exponentiate(5, i);
            }
            else
            {
                result = SimpleExponentiation.Exponentiate(5, i);
            }
            outputData.Add(result.Pow + "\t" + result.Count);
        }
        File.WriteAllLines("..//..//..//results/8/8.1_result.txt", outputData);
        ConsoleHelper.ClearScreen();
        Console.WriteLine("Файлы успешно созданы");
    }
    /// <summary>
    /// Простой алгоритм возведения в степень. 
    /// </summary>
    /// <param name="value">Значение, которое возводится в степень.</param>
    /// <param name="pow">Степень, в которую нужно возвести значение.</param>
    /// <returns>Возвращается первым степень, в которую возводится число. Вторым количество шагов, которое проходится алгоритмом./returns>
    public static (int Pow, int Count) Exponentiate(ulong value, int pow)
    {
        int countSteps = 0;
        BigInteger result;
        result = value;

        countSteps += 3;

        for (int i = 1; i < pow; i++)
        {
            countSteps += 2;
            result *= value;
        }

        return (pow, countSteps);
    }
}