using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace СomplexityOfAlgorithms.ComplexityOfAlgorithms.Core
{
    public static class VectorOperations
    {
        /// <summary>
        /// Возвращает сумму элементов последовательности
        /// </summary>
        /// <param name="vector"></param>
        /// <returns></returns>
        public static long Sum(int[] vector)
        {
            long result = 0;
            foreach (var item in vector)
            {
                result += item;
            }
            return result;
        }

        /// <summary>
        /// Возвращает произведение элементов последовательности
        /// </summary>
        /// <param name="vector"></param>
        /// <returns></returns>
        public static long Mul(int[] vector)
        {
            long result = 1;
            foreach (var item in vector)
            {
                result *= item;
            }
            return result;
        }
        /// <summary>
        /// Печатает строку n раз
        /// </summary>
        public static void Const()
        {
            Console.WriteLine("tra ta ta");
        }

    }
}
