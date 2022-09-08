using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    public static class ActionsWithElements
    {
        /// <summary>
        /// Возвращает сумму элементов последовательности
        /// </summary>
        /// <param name="vector"></param>
        /// <returns></returns>
        public static long Sum(long[] vector)
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
        public static long Mul(long[] vector)
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
        public static void Const(int N)
        {
            for (var i = 0; i < N; i++)
                Console.WriteLine("tra ta ta");
        }
    }
}
