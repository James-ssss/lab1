﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using СomplexityOfAlgorithms.ComplexityOfAlgorithms.Core;

namespace СomplexityOfAlgorithms.Algorithms
{
    public class BubbleSort : IExecutable
    {
        public static int[] BubbSort(int[] vector)
        {
            int temp;
            for (int i = 0; i < vector.Length; i++)
            {
                for (int j = i + 1; j < vector.Length; j++)
                {
                    if (vector[i] > vector[j])
                    {
                        temp = vector[i];
                        vector[i] = vector[j];
                        vector[j] = temp;
                    }
                }
            }

            return vector;

        }
    }
}

