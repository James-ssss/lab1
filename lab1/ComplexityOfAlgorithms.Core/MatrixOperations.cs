using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace СomplexityOfAlgorithms.ComplexityOfAlgorithms.Core
{
    public class MatrixOperations : IExecutable
    {
        public static int[,] MultiplicationMatrix(int[,] firstMatrix, int[,] secondMatrix)
        {
            var resultMatrix = new int[firstMatrix.GetUpperBound(0) + 1, secondMatrix.GetUpperBound(1) + 1];

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
        public void Execute()
        {

        }
        public void ExecuteMultiplication()
        {
           var timer = new Stopwatch();
           List<string> milliSec = new();
           for (int z = 1; z <= 5; z++)
           {
               StreamWriter f = new StreamWriter($"..//..//..//results/2/2_1_{z}_result.txt", true);
               for (int i = 1; i <= 500; i+=25)
               { 
               
                   for (int j = 1; j <= 500; j+=25)
                   {
                       int[,] A = Generation.GetNewMatrix(i, j, 1, 9);
                       int[,] B = Generation.GetNewMatrix(j, i, 1, 9);
                       timer.Start();

                       var resultAB = MatrixOperations.MultiplicationMatrix(A, B);
                       milliSec.Add(timer.Elapsed.TotalMilliseconds.ToString());
                       timer.Reset();      
                   }
                   f.WriteLine(String.Join(' ', milliSec));
                   milliSec.Clear();
               }
               f.Close();
           }
        }
    }
}
