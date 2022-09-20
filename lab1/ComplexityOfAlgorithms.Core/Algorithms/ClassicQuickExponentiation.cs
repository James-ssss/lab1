using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace СomplexityOfAlgorithms.Algorithms
{
    public class ClassicQuickExponentiation
    { /// <summary>
      /// Классический быстрый алгоритм возведения числа в степень.
      /// </summary>
      /// <param name="value">Значение, которое возводится в степень.</param>
      /// <param name="pow">Степень, в которую нужно возвести значение.</param>
      /// <returns>Возвращается первым степень, в которую возводится число. Вторым количество шагов, которое проходится алгоритмом./returns>
        public static (int Pow, int Count) Exponentiate(int value, int pow)
        {
            int countSteps = 3;
            int c = value;
            BigInteger result = 1;
            int k = pow;

            while (k != 0)
            {
                countSteps += 1;
                if (k % 2 == 0)
                {
                    c *= c;
                    k = k / 2;
                    countSteps += 3;
                }
                else
                {
                    result = result * c;
                    k = k - 1;
                    countSteps += 3;
                }
            }
            countSteps += 1;
            return (pow, countSteps);
        }
    }
}
