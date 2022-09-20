using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using СomplexityOfAlgorithms.ComplexityOfAlgorithms.ConsoleUI;
using СomplexityOfAlgorithms.ComplexityOfAlgorithms.Core;

namespace СomplexityOfAlgorithms.Algorithms
{
    public class QuickExponentiation : IExecutable
    {
        public void Execute()
        {
            ConsoleHelper.ClearScreen();
            Console.WriteLine("Вы выбрали быстрый алгоритм возведения в степень.");
            List<string> outputData = new();
            outputData.Add(new string("Pow" + "\t" + "Count steps"));
            (int Pow, BigInteger Value) result = new();
            for (int i = 1; i <= 100; i += 5)
            {
                if (i == 11)
                {
                    i -= 1;
                    result = QuickExponentiation.Exponentiate(5, i);
                }
                else
                {
                    result = QuickExponentiation.Exponentiate(5, i);
                }
                outputData.Add(result.Pow + "\t" + result.Value);
            }
            File.WriteAllLines("..//..//..//results/8/8.3_result.txt", outputData);
            ConsoleHelper.ClearScreen();
            Console.WriteLine("Файлы успешно созданы");
        }
        /// <summary>
        /// Алгоритм быстрого возведения в степень.
        /// </summary>
        /// <param name="value">Значение, которое возводится в степень.</param>
        /// <param name="pow">Степень, в которую нужно возвести значение.</param>
        /// <returns>Возвращается первым степень, в которую возводится число. Вторым количество шагов, которое проходится алгоритмом./returns>
        public static (int Pow, int Count) Exponentiate(int value, int pow)
        {
            int countSteps = 0;
            int c = value;
            int k = pow;
            BigInteger result;
            countSteps += 3;
            if (k % 2 == 1)
            {
                countSteps += 2;
                result = c;
            }
            else
            {
                countSteps += 2;
                result = 1;
            }
            while (k != 0)
            {
                k = k / 2;
                c *= c;
                countSteps += 3;
                if (k % 2 == 1)
                {
                    result = result * c;
                    countSteps += 2;
                }
            }
            countSteps += 1;
            return (pow, countSteps);
        }
    }
}
