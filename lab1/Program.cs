using System.Diagnostics;
class Program
{ 
    static void Main()
    {
        var timer = new Stopwatch();
        var rnd = new Random();
        long result = 0;
        Console.WriteLine("Введите длину вектора V");
        var N = int.Parse(Console.ReadLine());
        long[] vector = new long[N];
        for (int i = 0; i < N; i++)
        {
            vector[i] = rnd.Next(1, 20);
        }
        /*foreach (int i in vector)
            Console.Write($"{i} ");*/
        List<string> milliSec = new();
        for (int i = 0; i < 5; i++)
        {
            
            timer.Start();
            result = lab1.ActionsWithElements.Sum(vector);
            timer.Stop();
            milliSec.Add(timer.ElapsedTicks.ToString());
            timer.Reset();

        }
        milliSec.Add("результат вычисления: " + result.ToString());
        milliSec.Add("количество итераций: " + N.ToString());

        File.WriteAllLines("..//..//..//1_2_result.txt", milliSec);
        milliSec.Clear();

        for (int i = 0; i < 5; i++)
        {

            timer.Start();
            result = lab1.ActionsWithElements.Mul(vector);
            timer.Stop();
            milliSec.Add(timer.ElapsedTicks.ToString());
            timer.Reset();

        }
        milliSec.Add("результат вычисления: " + result.ToString());
        milliSec.Add("количество итераций: " + N.ToString());

        File.WriteAllLines("..//..//..//1_3_result.txt", milliSec);

        //Console.WriteLine(milliSec);
    }
}
