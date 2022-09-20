using System.Diagnostics;
using System.Numerics;

using lab1.Algorithms;
class Program
{ 
    static void Main()
    {
        /*var timer = new Stopwatch();
        long result = 0;
        

        List<string> milliSec = new();
        for (int j = 1; j <= 5; j++)
        {
            for (int i = 200; i < 10000; i+=25)
            {
                int[] vector = Generation.GetNewVector(i, 1, 9);
                timer.Start();
                //VectorOperations.Const(); //1.1
                //result = VectorOperations.Sum(vector); //1.2
                result = VectorOperations.Mul(vector); //1.3
                timer.Stop();
                milliSec.Add(timer.Elapsed.TotalMilliseconds.ToString());
                timer.Reset();

            }
            //File.WriteAllLines($"..//..//..//results/1.1/1_1_{j}_result.txt", milliSec); //1.1
            //File.WriteAllLines($"..//..//..//results/1.2/1_2_{j}_result.txt", milliSec); //1.2
            File.WriteAllLines($"..//..//..//results/1.3/1_3_{j}_result.txt", milliSec); //1.3
            
            milliSec.Clear();
        }*/

        //2
        /*var timer = new Stopwatch();
        List<string> milliSec = new();
        for (int z = 1; z <= 5; z++)
        {
            StreamWriter f = new StreamWriter($"..//..//..//results/2/2_1_{z}_result.txt", true);
            for (int i = 1; i <= 100; i+=5)
            {
                for (int j = 1; j <= 100; j+=5)
                {
                    int[,] A = Generation.GetNewMatrix(i, j, 1, 9);
                    int[,] B = Generation.GetNewMatrix(j, i, 1, 9);
                    timer.Start();
                    
                    var resultAB = MatrixOperations.MultiplicationMatrix(A, B);
                    
                    timer.Stop();
                    milliSec.Add(timer.Elapsed.TotalMilliseconds.ToString());
                    
                    timer.Stop();
                }
                f.WriteLine(String.Join(' ', milliSec));
                milliSec.Clear();
            }
            f.Close();
        }*/
        //var cs = new CombSort();
        //cs.Execute();
        var polynom = new Polynom();
        polynom.Execute();

    }
}
