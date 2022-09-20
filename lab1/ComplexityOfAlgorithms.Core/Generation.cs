using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace СomplexityOfAlgorithms.ComplexityOfAlgorithms.Core
{
    public static class Generation
    {
        /// <summary>
        /// Возвращает заполненый массив чисел. Нужно указать длину нужного массива и промежуток чисел, которые можно использовать. Например, от 1 до 100.
        /// </summary>
        /// <param name="length" >Длина массива (размерность вектора)</param>
        /// <param name="firstNum">Левая граница для диапазона чисел</param>
        /// <param name="secondNum">Правая граница для диапазона чисел</param>
        /// <returns></returns>
        public static int[] GetNewVector(int length, int firstNum, int secondNum)
        {
            var rnd = new Random();
            int[] vector = new int[length];
            for (int i = 0; i < length; i++)
            {
                vector[i] = rnd.Next(firstNum, secondNum);
            }

            return vector;
        }

        public static int[,] GetNewMatrix(int height, int length, int leftNum, int rightNum)
        {
            var array = new int[height, length];
            var rnd = new Random();
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    array[i, j] = rnd.Next(leftNum, rightNum);

                }

            }
            return array;
        }

    }
}
