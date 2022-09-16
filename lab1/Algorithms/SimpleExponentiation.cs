using System.Numerics;

namespace lab1.Algorithms;

public class SimpleExponentiation
{
    private static int countSteps = 0;
    /// <summary>
/// Простой алгоритм возведения в степень. 
/// </summary>
/// <param name="value">Значение, которое возводится в степень</param>
/// <param name="pow">Степень, в которую нужно возвести значение</param>
/// <returns></returns>
    public static (int Pow,int Count) PowFunc(ulong value, int pow)
    {    
        countSteps += 1;
        BigInteger result;
        countSteps += 1;
        result = value;
        for (int i = 1; i < pow; i++)
        {
            countSteps += 1;
            countSteps += 1;
            result *= value;
        }
        return (pow,countSteps);
    }
}