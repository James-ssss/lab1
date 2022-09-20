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

        //2 Умножение матриц
        //var mult = new MatrixOperations();
        //mult.ExecuteMultiplication();


        //3 Сортировка расческой
        var cs = new CombSort();
        cs.Execute();


        //1.4.1
        //var polynom = new Polynom();
        //polynom.ExecuteP();


        //1.4.2
        //var polynom = new Polynom();
        //polynom.ExecutePGorner();


        //1.7 TimSort
        //var timSort = new TimSort();
        //timSort.Execute();

    }
}
