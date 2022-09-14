using System.Diagnostics;
using System.Numerics;

using lab1.Algorithms;
class Program
{ 
    static void Main()
    {
        /*var timer = new Stopwatch();
        var vector = VectorGeneration.GetNewVector(100, 1, 9);
        List<string> milliSec = new();
        Console.WriteLine("Введите ранг матрицы: ");
        var N = int.Parse(Console.ReadLine());
        
       
        for (int i = 0; i < 5; i++)
        {
            
            timer.Start();
            // тута должен быть алгоритм умножения матриц
            timer.Stop();
            milliSec.Add(timer.ElapsedMilliseconds.ToString());
            timer.Reset();

        }
        File.WriteAllLines("..//..//..//2_result.txt", milliSec);*/

        var timer = new Stopwatch();
        long result = 0;
        

        List<string> milliSec = new();
        for (int j = 1; j <= 5; j++)
        {
            for (int i = 200; i < 10000; i+=25)
            {
                int[] vector = VectorGeneration.GetNewVector(i, 1, 9);
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
        }
       
    }
}
