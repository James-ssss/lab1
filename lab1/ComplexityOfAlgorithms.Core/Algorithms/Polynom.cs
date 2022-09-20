using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1.Algorithms
{
    public  class Polynom : IExecutable
    {
        double CalcP(int[] arrCoefficients, float x)
        {
            double res = 0;
            var rev = arrCoefficients.Reverse().ToArray();
            for (var i = 0; i < rev.Length; i++)
            {
                var coefficient = rev[i];
                res += coefficient * Math.Pow(x, i);
            }

            return res;
        }

        double CalcPGorner(int[] arrCoefficients, float x)
        {
            double res = arrCoefficients[0];
            for (int i = 1; i < arrCoefficients.Length; i++)
            {
                res = res * x + arrCoefficients[i];

            }
            return res;
        }
        public void Execute()
        {

        }

        public void ExecuteP()
        {
            var timer = new Stopwatch();
            List<string> milliSec = new();
            for (int j = 1; j <= 5; j++)
            {
                for (int k = 20; k < 100000; k += 50)
                {
                    int[] vector = Generation.GetNewVector(k, 1, 10000);
                    timer.Start();

                    /////////////////////
                    CalcP(vector, (float)1.5);

                    ///////////////////////


                    timer.Stop();
                    milliSec.Add(timer.Elapsed.TotalMilliseconds.ToString());
                    timer.Reset();

                }

                File.WriteAllLines($"..//..//..//results/1.4.1/1_4_1_{j}_result.txt", milliSec); //1.4.1

                milliSec.Clear();
            }
        }
        public void ExecutePGorner()
        {
            var timer = new Stopwatch();
            List<string> milliSec = new();
            for (int j = 1; j <= 5; j++)
            {
                for (int k = 20; k < 100000; k += 50)
                {
                    int[] vector = Generation.GetNewVector(k, 1, 10000);
                    timer.Start();

                    /////////////////////
                    CalcPGorner(vector, (float)1.5);

                    ///////////////////////


                    timer.Stop();
                    milliSec.Add(timer.Elapsed.TotalMilliseconds.ToString());
                    timer.Reset();

                }

                File.WriteAllLines($"..//..//..//results/1.4.2/1_4_2_{j}_result.txt", milliSec); //1.4.1

                milliSec.Clear();
            }
        }

    }
}
