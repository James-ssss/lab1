using System.Numerics;

namespace СomplexityOfAlgorithms.Algorithms;

public class SimpleExponentiation
{
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