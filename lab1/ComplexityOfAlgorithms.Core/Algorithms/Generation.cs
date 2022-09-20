using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1.Algorithms
{
    public static class VectorGeneration
    {
        /// <summary>
        /// Возвращает заполненый массив чисел. Нужно указать длину нужного массива и промежуток чисел, которые можно использовать. Например, от 1 до 100.
        /// </summary>
        /// <param name="length" ></param>
        /// <param name="firstNum"></param>
        /// <param name="secondNum"></param>
        /// <returns></returns>
        public static int[] GetNewVector(int length, int firstNum, int secondNum)
        {
            var rnd = new Random();
            int[] vector = new int[length];
            for (int i = 0; i < length; i++)
            {
                vector[i] = rnd.Next(firstNum,secondNum);
            }
            
            return vector;
        }


    }
}
