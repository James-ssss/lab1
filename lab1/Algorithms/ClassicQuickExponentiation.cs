using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace lab1.Algorithms
{
    public class ClassicQuickExponentiation
    {
        public static (int Pow, int Count) Exponentiate(int value,int pow)
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
            return (pow,countSteps);
        }
    }
}
