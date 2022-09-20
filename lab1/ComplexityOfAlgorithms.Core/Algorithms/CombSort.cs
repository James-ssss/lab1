using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Numerics;

namespace lab1.Algorithms
{
    public class CombSort : IExecutable
    {
        public void Execute()
        {
            var timer = new Stopwatch();
            List<string> milliSec = new();
            for (int j = 1; j <= 5; j++)
            {
                for (int k = 20; k < 30000; k +=25)
                {
                    int[] vector = Generation.GetNewVector(k, 1, 10000);
                    timer.Start();

                    /////////////////////
                    ulong gap = (ulong)vector.Length;
                    bool swapped = false;
                    while ((gap > 1) || swapped)
                    {
                        gap = (ulong)(gap / 1.2473309);
                        if (gap < 1) gap = 1;
                        ulong i = 0;
                        ulong m = gap;
                        swapped = false;
                        while (m < (ulong)vector.Length)
                        {
                            if (vector[i] > vector[m])
                            {
                                swapped = true;
                                int t = vector[i];
                                vector[i] = vector[m];
                                vector[m] = t;
                            }
                            i++;
                            m = i + gap;
                        }
                    }

                    ///////////////////////


                    timer.Stop();
                    milliSec.Add(timer.Elapsed.TotalMilliseconds.ToString());
                    timer.Reset();

                }
                
                File.WriteAllLines($"..//..//..//results/3/3_{j}_result.txt", milliSec); //3

                milliSec.Clear();
            }

        }

    }
}
