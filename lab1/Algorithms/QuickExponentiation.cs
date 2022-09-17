﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace lab1.Algorithms
{
    public class QuickExponentiation
    { /// <summary>
      /// Алгоритм быстрого возведения в степень.
      /// </summary>
      /// <param name="value">Значение, которое возводится в степень.</param>
      /// <param name="pow">Степень, в которую нужно возвести значение.</param>
      /// <returns>Возвращается первым степень, в которую возводится число. Вторым количество шагов, которое проходится алгоритмом./returns>
        public static (int Pow, int Count) Exponentiate(int value, int pow)
        {
            int countSteps = 0;
            int c = value;
            int k = pow;
            BigInteger result;
            countSteps += 3;
            if (k % 2 == 1)
            {
                countSteps += 2;
                result = c;
            }
            else
            {
                countSteps += 2;
                result = 1;
            }
            while (k != 0)
            {
                k = k / 2;
                c *= c;
                countSteps += 3;
                if (k % 2 == 1)
                {
                    result = result * c;
                    countSteps += 2;
                }
            }
            countSteps += 1;
            return (pow, countSteps);
        }
    }
}
