﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1.Algorithms
{
    public class MatrixOperations
    {
        private static int[,] MultiplicationMatrix(int[,] firstMatrix, int[,] secondMatrix)
        {
            var resultMatrix = new int[firstMatrix.GetUpperBound(0)+1, secondMatrix.GetUpperBound(1)+1];

            for (int i = 0; i < firstMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < secondMatrix.GetLength(1); j++)
                {
                    for (int k = 0; k < secondMatrix.GetLength(0); k++)
                    {
                        resultMatrix[i, j] += firstMatrix[i, k] * secondMatrix[k, j];
                    }
                }
            }

            return resultMatrix;
        }
    }
}
