using System.Diagnostics;
using System.Numerics;
using MathNet.Numerics.LinearAlgebra;
class Program
{ 
    static void Main()
    {
        var timer = new Stopwatch();
        var rnd = new Random();
        List<string> milliSec = new();
        Console.WriteLine("Введите ранг матрицы: ");
        var N = int.Parse(Console.ReadLine());
        var A = Matrix<double>.Build;
        var B = Matrix<double>.Build;
        var a = A.Dense(N, N, (i, j) => rnd.Next(1, 100));
        var b = B.Dense(N, N, (i, j) => rnd.Next(1, 100));
        Matrix<double> resultMatrix = a;
        for (int i = 0; i < 5; i++)
        {
            
            timer.Start();
            resultMatrix = a.Multiply(b);
            timer.Stop();
            milliSec.Add(timer.ElapsedMilliseconds.ToString());
            timer.Reset();

        }
        File.WriteAllLines("..//..//..//2_result.txt", milliSec);
        Console.WriteLine(resultMatrix);
        /*var timer = new Stopwatch();
        var rnd = new Random();
        long result = 0;
        Console.WriteLine("Введите длину вектора V");
        var N = int.Parse(Console.ReadLine());
        long[] vector = new long[N];
        for (int i = 0; i < N; i++)
        {
            vector[i] = rnd.Next(1, 20);
        }
        
        List<string> milliSec = new();
        
        for (int i = 0; i < 5; i++)
        {

            timer.Start();
            lab1.ActionsWithElements.Const(N); //1.1
            //result = lab1.ActionsWithElements.Sum(vector); //1.2
            //result = lab1.ActionsWithElements.Mul(vector); //1.3
            timer.Stop();
            milliSec.Add(timer.ElapsedMilliseconds.ToString());
            timer.Reset();

        }
        milliSec.Add("количество итераций: " + N.ToString());

        File.WriteAllLines("..//..//..//1_1_result.txt", milliSec); //1.1
        //File.WriteAllLines("..//..//..//1_2_result.txt", milliSec); //1.2
        //File.WriteAllLines("..//..//..//1_3_result.txt", milliSec); //1.3
        milliSec.Clear(); */
    }
}
