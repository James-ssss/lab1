using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace СomplexityOfAlgorithms.ComplexityOfAlgorithms.Core
{
    public class VectorOperations : IExecutable
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
        public void Execute()
        {

        }
        public void ExecuteSum()
        {
            var timer = new Stopwatch();
            long result = 0;
        

            List<string> milliSec = new();
            for (int j = 1; j <= 5; j++)
            {
                for (int i = 200; i < 10000; i+=25)
                {
                    int[] vector = Generation.GetNewVector(i, 1, 9);
                    timer.Start();
                    
                    result = VectorOperations.Sum(vector); //1.2
                    
                    timer.Stop();
                    milliSec.Add(timer.Elapsed.TotalMilliseconds.ToString());
                    timer.Reset();

                }     
                File.WriteAllLines($"..//..//..//results/1.2/1_2_{j}_result.txt", milliSec); //1.2
                milliSec.Clear();
            }
        }
        public void ExecuteMul()
        {
            var timer = new Stopwatch();
            long result = 0;
        

            List<string> milliSec = new();
            for (int j = 1; j <= 5; j++)
            {
                for (int i = 200; i < 10000; i+=25)
                {
                    int[] vector = Generation.GetNewVector(i, 1, 9);
                    timer.Start();
                    result = VectorOperations.Mul(vector); //1.3
                    timer.Stop();
                    milliSec.Add(timer.Elapsed.TotalMilliseconds.ToString());
                    timer.Reset();

                }
                File.WriteAllLines($"..//..//..//results/1.3/1_3_{j}_result.txt", milliSec); //1.3
            
                milliSec.Clear();
            }
        }
        public void ExecuteConst()
        {
            var timer = new Stopwatch();
            long result = 0;
        

            List<string> milliSec = new();
            for (int j = 1; j <= 5; j++)
            {
                for (int i = 200; i < 10000; i+=25)
                {
                    int[] vector = Generation.GetNewVector(i, 1, 9);
                    timer.Start();
                    VectorOperations.Const(); //1.1
                    timer.Stop();
                    milliSec.Add(timer.Elapsed.TotalMilliseconds.ToString());
                    timer.Reset();

                }
                File.WriteAllLines($"..//..//..//results/1.1/1_1_{j}_result.txt", milliSec); //1.1
                milliSec.Clear();
            }
        }


    }
}
