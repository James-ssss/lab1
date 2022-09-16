using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace lab1.Algorithms
{
    public class RecursiveExponentiation
    {
        public static int CountSteps = 0;
        /// <summary>
        /// Рекурсивный алгоритм возведения числа в степень.
        /// </summary>
        /// <param name="value">Значение, которое возводится в степень.</param>
        /// <param name="pow">Степень, в которую нужно возвести значение.</param>
        /// <returns>Возвращается первым степень, в которую возводится число. Вторым количество шагов, которое проходится алгоритмом./returns>
        public static (int pow, BigInteger value) Exponentiate(int value, int pow)
        {
            if (pow == 0)
            {
                CountSteps += 2;
                return (pow, 1);
            }
            if (pow > 0)
            {
                CountSteps += 5;
                return (pow, Exponentiate(value, pow - 1).value * value);
            }
            return Exponentiate(value, -pow);
        }
    }
}
